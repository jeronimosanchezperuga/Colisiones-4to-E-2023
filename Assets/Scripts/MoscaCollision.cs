using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoscaCollision : MonoBehaviour
{
    public Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ventilador")
        {
            //Destroy(gameObject);
            transform.position = initialPosition;
        }else if (collision.gameObject.name == "Target")
        {
            Destroy(collision.gameObject);
        }
    }

}
