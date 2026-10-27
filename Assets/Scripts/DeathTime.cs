using UnityEngine;

public class DeathTime : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 8f);
    }
}
