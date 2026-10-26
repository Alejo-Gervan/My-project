using UnityEngine;

public class SpawnTest : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 startPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(objectToSpawn, startPosition, transform.rotation);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
