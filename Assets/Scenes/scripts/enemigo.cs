




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
 
    public Transform jugador;  // Arrastra el GameObject del jugador aquí
    public float velocidadPersecucion = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Comprueba si el jugador (jugador) está definido
        if (jugador != null)
        {
            // Calcula la dirección hacia el jugador
            Vector3 direccion = (jugador.position - transform.position).normalized;

            // Aplica la velocidad de persecución al enemigo
            rb.velocity = direccion * velocidadPersecucion;
        }
    }
}

