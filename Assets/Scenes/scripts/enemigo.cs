




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
 
    public Transform jugador;  // Arrastra el GameObject del jugador aqu�
    public float velocidadPersecucion = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Comprueba si el jugador (jugador) est� definido
        if (jugador != null)
        {
            // Calcula la direcci�n hacia el jugador
            Vector3 direccion = (jugador.position - transform.position).normalized;

            // Aplica la velocidad de persecuci�n al enemigo
            rb.velocity = direccion * velocidadPersecucion;
        }
    }
}

