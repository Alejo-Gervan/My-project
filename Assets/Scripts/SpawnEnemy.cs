using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject spawnPrefab;
    public Vector2 spawnPosition0;
    

    public float delay = 2f;
    public float tiempoRepeticion = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CrearObstaculo", delay, tiempoRepeticion);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CrearObstaculo()
    {
        Instantiate(spawnPrefab, spawnPosition0, Quaternion.identity);
    }
}
