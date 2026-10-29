using UnityEngine;

public class InGround : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Suelo") || other.gameObject.CompareTag("Ground"))
        {
            player.tocandoSuelo = true;
        }
    }
}
