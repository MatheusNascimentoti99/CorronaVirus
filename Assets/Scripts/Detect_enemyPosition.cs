using UnityEngine;

public class Detect_enemyPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.position.y > GetComponentInParent<EnemyController>().transform.position.y) // Se o inimigo está na frente ou não
        {
            collision.gameObject.GetComponent<Renderer>().sortingOrder = -1;
            Debug.Log("Back");
        }
        else
        {
            collision.gameObject.GetComponent<Renderer>().sortingOrder = 1;
            Debug.Log("front");
        }
    }
}
