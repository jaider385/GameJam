using UnityEngine;

public class Cayendo : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] positionObjetos;
    public float intervalo = 2f;
    public float spawns = 2f;

    private void Update()
    {
        intervalo -= Time.deltaTime;

        if (intervalo <= 0)
        {
            for (int i = 0; i < spawns; i++)
            {
                Instantiate(prefab, RandomPointPos().position, Quaternion.identity);
            }
       
            intervalo = 2f;
        }

    }
    Transform RandomPointPos()
    {
        int index = Random.Range(0, positionObjetos.Length);
        return positionObjetos[index];
    }
}