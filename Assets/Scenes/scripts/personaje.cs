using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  personaje : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Captura la entrada del jugador
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);

        // Normaliza el vector para que el movimiento diagonal no sea más rápido
        movimiento.Normalize();

        // Aplica el movimiento al personaje
        rb.velocity = transform.TransformDirection(movimiento) * velocidadMovimiento;
    }
}




