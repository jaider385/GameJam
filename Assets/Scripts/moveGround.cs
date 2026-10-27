using Unity.VisualScripting;
using UnityEngine;

public class moveGround : MonoBehaviour
{
   Vector3 destinoActual;
    public float velocidad;
    public GameObject puntoA;
    public GameObject puntoB;

    private void Start()
    {
        destinoActual = puntoA.transform.position;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destinoActual, velocidad * Time.deltaTime);
        if (Vector3.Distance(transform.position, destinoActual) < 0.1f)
        {
            if (destinoActual == puntoB.transform.position)
            {
                destinoActual = puntoA.transform.position;
            }
            else
            {
                destinoActual = puntoB.transform.position;
            }
        }
    }
}
