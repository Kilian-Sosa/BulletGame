using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] Texture2D cursorTarget;
    [SerializeField] TextMeshProUGUI shotsText;
    public int shots = 0;

    void Start() {
        Vector2 hotspot = new Vector2 (cursorTarget.width/2, cursorTarget.height/2);
        Cursor.SetCursor(cursorTarget, hotspot, CursorMode.Auto);

        UpdateShots();
    }


    void Update() {
        
    }

    public void UpdateShots() {
        shotsText.text = $"Disparos: {shots}";
}
