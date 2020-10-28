using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D m_ribidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_ribidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        m_ribidbody.velocity = Vector2.left;
    }
}
