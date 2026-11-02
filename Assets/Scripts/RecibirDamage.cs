using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecibirDamage : MonoBehaviour
{

    [Header("healt Settings")]
    public float vida = 100;
    public float damage = 50;
    [Header("Canvas Settings")]
    public TextMeshProUGUI VidaVer;
    public Image Barra;

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
            Barra.fillAmount = vida / 100f;
            if (vida <= 0) 
            { 
                Destroy(gameObject);
                
            
            
            }
            VidaVer.text = vida.ToString(); //Aca como quiero solo la variable me pide el .tostring para hacerlo una palabra.
            //Pero si quisieramos poner una palabra mas la variable EJ: "Vida: " + vida; esta seria la manera correcta, ya que en cadenas no pide el .tostring en int/flooat
        }



    }



}
