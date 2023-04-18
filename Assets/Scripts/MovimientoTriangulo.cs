using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTriangulo : MonoBehaviour
{

    public float movementSpeed = 0.1f;
    public float rotationSpeed = 2f;
    public KeyCode teclaAvanzar;
    public KeyCode teclaRetroceder;
    public KeyCode teclaGirarIzq;
    public KeyCode teclaGirarDer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       

        if (Input.GetKey(teclaAvanzar))
        {
            transform.Translate(0, movementSpeed, 0);
        }
        if (Input.GetKey(teclaRetroceder))
        {
            transform.Translate(0, -movementSpeed, 0);
        }
        if (Input.GetKey(teclaGirarIzq))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
        if (Input.GetKey(teclaGirarDer))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }

    }
}
