using UnityEngine;

public class items : MonoBehaviour
{
    public JuagdorItems player;
    [SerializeField] private AudioClip ItemSound;


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
        AudioSource.PlayClipAtPoint(ItemSound, transform.position);
        if (other.CompareTag("Player")) { Destroy(gameObject);}
        player = other.GetComponent<JuagdorItems>();    
        player.Agarrador();

    }




}
