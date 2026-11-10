using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnTest : MonoBehaviour
{



    [Header("Bala Settings")]
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
