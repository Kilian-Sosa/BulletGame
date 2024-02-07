using UnityEngine;

public class TurretController : MonoBehaviour {
    [SerializeField] GameObject bulletPrefab, spawnPoint;

    void Start() {
        
    }


    void Update() {
        if (Input.GetMouseButtonDown(0)) Instantiate(bulletPrefab, spawnPoint.transform);
    }
}
