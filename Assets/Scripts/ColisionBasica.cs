using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBasica : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisión detectada con " + collision.gameObject.name);
    }
}
