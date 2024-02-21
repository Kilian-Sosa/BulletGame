using UnityEngine;

public class SpikedballMotion : MonoBehaviour {
    [SerializeField] float rotationForce = 30f;
    [SerializeField] GameObject forcePointRef;

    void Update() {
        forcePointRef.GetComponent<Rigidbody2D>().velocity = forcePointRef.transform.right * rotationForce;
    }
}
