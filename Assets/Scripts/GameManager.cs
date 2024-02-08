using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] Texture2D cursorTarget;
    [SerializeField] TextMeshProUGUI shotsText, killsText;
    public int shots = 0, kills = 0;
    bool canShoot = true;

    void Start() {
        Vector2 hotspot = new Vector2 (cursorTarget.width/2, cursorTarget.height/2);
        Cursor.SetCursor(cursorTarget, hotspot, CursorMode.Auto);

        UpdateShots();
        UpdateKills();
    }


    void Update() {
        if (Input.GetMouseButton(0)) {
            Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPos, Vector2.zero);

            if (hit.collider != null) {
                if (hit.collider.CompareTag("spikeball_item")) {
                    Debug.Log("¡¡BOLA CON PINCHOS!!");
                    DisableFire();
                    Destroy(hit.collider.gameObject);
                }
                if (hit.collider.CompareTag("sawblade_item")) {
                    Debug.Log("¡¡DISCO DE SIERRA!!");
                    DisableFire();
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    public void UpdateShots() {
        shotsText.text = $"Disparos: {shots}";
    }

    public void UpdateKills() {
        killsText.text = $"Muertes: {kills}";
    }

    public void DisableFire() { canShoot = false; }

    public void EnableFire() { canShoot = true; }

    public bool GetShootingStatus() { return canShoot; }
}
