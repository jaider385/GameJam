using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverIU : MonoBehaviour
{
    public void VolverAlMenu()
    {
        SceneManager.LoadScene(0);
    }
}
