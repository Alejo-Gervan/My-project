using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecibirDamage : MonoBehaviour
{

    public float vida = 100;
    public float damage = 50;
    public TextMeshProUGUI VidaVer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Projectil"))
       {
            Destroy(collision.gameObject);
            vida -= damage;
            if (vida <= 0) 
            { 
                Destroy(gameObject);
                
            
            
            }
            VidaVer.text = vida.ToString();

        }



    }



}
