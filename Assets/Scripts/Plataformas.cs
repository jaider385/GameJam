using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public float velocidad;
    public bool destinoActual = false;
    float distanciaIzquierda = 3f;
    private Vector3 posicionInicial;
    private void Start()
    {
        posicionInicial = transform.position;
    }

    private void Update()
    {
        Vector3 destino = destinoActual ? posicionInicial : posicionInicial + Vector3.left * distanciaIzquierda;
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
        if (Vector3.Distance(transform.position, destino) < 0.01f)
        {
            destinoActual = !destinoActual;
        }
    }
}
