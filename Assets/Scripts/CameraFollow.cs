using UnityEngine;


public class CameraFollow : MonoBehaviour
{

    private Transform m_Player; // Reference to the player's transform.


    private void Awake()
    {
        // Setting up the reference.
        m_Player = GameObject.FindGameObjectWithTag("Player").transform;
    }



    private void Update()
    {
        if (m_Player.position.y < -1.5f)
        {
            Vector3 newPosition = new Vector3(this.transform.position.x, -1.5f, this.transform.position.z);
            this.transform.position = newPosition;
        }

    }



}


