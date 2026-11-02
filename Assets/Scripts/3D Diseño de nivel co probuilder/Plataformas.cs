using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float velocidad = 3f;

    private Transform objetivoActual;

    void Start()
    {
        // La plataforma comienza moviéndose hacia el punto B
        objetivoActual = puntoB;
    }

    void Update()
    {
        // Mueve la plataforma hacia el objetivo actual a una velocidad constante
        transform.position = Vector3.MoveTowards(transform.position, objetivoActual.position, velocidad * Time.deltaTime);

        // Comprueba si la plataforma está muy cerca del objetivo (a menos de 0.1 unidades)
        if (Vector3.Distance(transform.position, objetivoActual.position) < 0.1f)
        {
            // Alterna el objetivo entre el punto A y el punto B
            if (objetivoActual == puntoB)
            {
                objetivoActual = puntoA;
            }
            else
            {
                objetivoActual = puntoB;
            }
        }
    }
}