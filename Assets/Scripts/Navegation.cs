using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.AI;

public class Navegation : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     agent = GetComponent<NavMeshAgent>();
     
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("UpdateTraget", 0f, 5f);
    }

    private void UpdateTraget()
    {
        agent.destination = target.position;
    }
}
