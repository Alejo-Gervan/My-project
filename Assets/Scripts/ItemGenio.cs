using UnityEngine;

public class ItemGenio : MonoBehaviour
{
    public JuagdorItems player;
    [SerializeField] private AudioClip GenioSound;
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
        AudioSource.PlayClipAtPoint(GenioSound, transform.position);
        if (other.CompareTag("Player")) { Destroy(gameObject); }
        player = other.GetComponent<JuagdorItems>();
        player.AgarraGenio();

    }




}
