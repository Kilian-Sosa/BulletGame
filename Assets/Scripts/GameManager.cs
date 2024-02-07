using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] Texture2D cursorTarget;

    void Start() {
        Vector2 hotspot = new Vector2 (cursorTarget.width/2, cursorTarget.height/2);
        Cursor.SetCursor(cursorTarget, hotspot, CursorMode.Auto);
    }


    void Update() {
        
    }
}
