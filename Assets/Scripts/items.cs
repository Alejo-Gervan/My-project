using UnityEngine;

public class items : MonoBehaviour
{
    public Jugador player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { Destroy(gameObject);}
        player = other.GetComponent<Jugador>();
        player.Agarrador();

    }

}
