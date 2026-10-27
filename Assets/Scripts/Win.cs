using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.SetActive(false);
            player.transform.position = new Vector2(-1, 2);
            player.SetActive(true);
            GameManager.Instance.AumentoDificultad();
            Debug.Log("Win");
        }
    }
}
