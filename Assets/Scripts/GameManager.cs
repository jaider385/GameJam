using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Unity.VectorGraphics;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Cayendo spawn;
    public List<moveGround> plataformas;
    private void Awake()
    {
        Instance = this;
    }
    public void AumentoDificultad()
    {
        spawn.intervalo = -0.5f;

        foreach (var item in plataformas)
        {
            item.velocidad += Random.Range(0.1f, 0.3f);
        }

        Debug.Log("Se aumento la velocidad");
    }
    public void Perdio()
    {
        Debug.Log("se reinicia Escena");
        SceneManager.LoadScene(0);
    }
}
