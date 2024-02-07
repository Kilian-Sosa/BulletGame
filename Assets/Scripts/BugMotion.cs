using UnityEngine;

public class BugMotion : MonoBehaviour {
    [SerializeField] float bugSpeed = 5;
    [SerializeField] GameObject target;

    void Start() {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() {
        Vector2 direction = (target.transform.position - transform.position).normalized;
        transform.up = direction;
        GetComponent<Rigidbody2D>().velocity = direction * bugSpeed;
    }
}
