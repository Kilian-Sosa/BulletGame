using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] Texture2D cursorTarget;
    [SerializeField] TextMeshProUGUI shotsText, killsText;
    public int shots = 0, kills = 0;

    void Start() {
        Vector2 hotspot = new Vector2 (cursorTarget.width/2, cursorTarget.height/2);
        Cursor.SetCursor(cursorTarget, hotspot, CursorMode.Auto);

        UpdateShots();
        UpdateKills();
    }


    void Update() {
        
    }

    public void UpdateShots() {
        shotsText.text = $"Disparos: {shots}";
    }

    public void UpdateKills() {
        killsText.text = $"Muertes: {kills}";
    }
}
