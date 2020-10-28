using System;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D m_rigidbody;
    public float MaxVelocidade = 10;
    public float moveForce;
    public float curve;

    private float walk = 5;
    private float axis;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        m_rigidbody = GetComponent<Rigidbody2D>();


    }

    void FixedUpdate()
    {

        MoveForwards();
        Curve();

    }

    private void Curve()
    {
        axis = Input.GetAxis("Vertical") * Time.deltaTime;
        Vector2 aux = new Vector2(transform.position.x, transform.position.y + axis * curve * Time.deltaTime);
        transform.position = aux;
    }

    private void MoveForwards()
    {
        animator.SetFloat("Speed", m_rigidbody.velocity.x);
        m_rigidbody.AddForce(Vector2.right * Time.deltaTime * moveForce * (m_rigidbody.velocity.x < walk ? moveForce : moveForce / (m_rigidbody.velocity.x / 2)));
        if (m_rigidbody.velocity.x > MaxVelocidade)
        {

            m_rigidbody.velocity = new Vector2(Math.Sign(m_rigidbody.velocity.x) * MaxVelocidade, m_rigidbody.velocity.y);

        }
    }


    // Update is called once per frame
    void Update()
    {
    }

}
