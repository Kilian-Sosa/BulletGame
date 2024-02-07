using UnityEngine;

public class BulletController : MonoBehaviour {

    void Start() {
        GameObject.Find("GameManager").GetComponent<GameManager>().shots++;
        GameObject.Find("GameManager").GetComponent<GameManager>().UpdateShots();
    }

    void Update() {
        
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
