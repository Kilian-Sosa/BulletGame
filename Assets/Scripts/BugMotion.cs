using UnityEngine;

public class BugMotion : MonoBehaviour {
    [SerializeField] float bugSpeed = 5;
    [SerializeField] GameObject target;
    [SerializeField] float detectionDistance = 0.5f, offsetDistance = 0.2f;
    Rigidbody2D rb;
    Animator animator;

    void Start() {
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update() {
        Vector2 direction = (target.transform.position - transform.position).normalized;
        transform.up = direction;

        if (!IsDetectingPlayer()) rb.velocity = direction * bugSpeed;
        else {
            SetAnimation("attacking");
            rb.velocity = Vector2.zero;
        }
    }

    public void SetAnimation(string name) {
        AnimatorControllerParameter[] parametros = animator.parameters;
        foreach (var item in parametros) animator.SetBool(item.name, false);
        animator.SetBool(name, true);
    }

    bool IsDetectingPlayer() {
        Vector2 direction = ((Vector2)target.transform.position - (Vector2)transform.position).normalized;

        Vector2 endPoint = (Vector2)transform.position + direction * detectionDistance;

        Debug.DrawLine((Vector2) transform.position + direction * offsetDistance, endPoint, Color.black);

        RaycastHit2D raycastHit2D = Physics2D.Raycast((Vector2)transform.position + direction * offsetDistance, direction, detectionDistance - offsetDistance);

        return raycastHit2D.collider != null && raycastHit2D.collider.CompareTag("Player");
    }


    void OnTriggerEnter2D(Collider2D collision) {
        Destroy(gameObject);
    }

    void OnDestroy() {
        GameObject.Find("GameManager").GetComponent<GameManager>().kills++;
        GameObject.Find("GameManager").GetComponent<GameManager>().UpdateKills();
    }
}
