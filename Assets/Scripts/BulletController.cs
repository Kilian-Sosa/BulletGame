using UnityEngine;

public class BulletController : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
