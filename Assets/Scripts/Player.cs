using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

public class Player : MonoBehaviour
{
    [SerializeField] private int vidas = 3;

    [SerializeField] InputActionAsset map;
    [SerializeField] float fuerzaSalto;
    [SerializeField] float velocidad;
    public bool tocandoSuelo;
    private Rigidbody rb;
    private Collider cl;
    private void Start()
    {
        cl = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float movimientoX = 0;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            {
                movimientoX = -1;
            }
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            {
                movimientoX = 1;
            }
            if (Keyboard.current.spaceKey.wasPressedThisFrame && tocandoSuelo)
            {
                Saltar();
            }
        }
        rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);
    }
    private void Saltar()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.y, fuerzaSalto);
        tocandoSuelo = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ladrillo"))
        {
            RestarVida();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(""))
        {
            SumarVida();
        }
    }
    void SumarVida()
    {
        vidas++;
        Debug.Log("suma 1 vida");
    }
    void RestarVida()
    {
        vidas--;
        if (vidas <= 0)
        {
            GameManager.Instance.Perdio();
            Debug.Log("Perdio 1 vida");

        }
    }
}