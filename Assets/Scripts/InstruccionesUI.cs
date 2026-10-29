using UnityEngine;
using UnityEngine.SceneManagement;

public class InstruccionesUI : MonoBehaviour
{
    public void Jugar()
    {
        Debug.Log("Instrucciones Listas");
        SceneManager.LoadScene(2);
    }
}
