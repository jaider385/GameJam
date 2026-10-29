using UnityEngine;

public class ladrilloComportamiento : MonoBehaviour
{
    private bool yaGolpeo = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            gameObject.tag = "Untagged";
        }
        else if (collision.gameObject.CompareTag("Player") && !yaGolpeo)
        {
            yaGolpeo = true;
            gameObject.tag = "Untagged";
        }
    }
}
