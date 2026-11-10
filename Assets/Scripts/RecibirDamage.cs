using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class RecibirDamage : MonoBehaviour
{

    [Header("healt Settings")]
    public float vida = 100;
    public float damage = 50;

    
    [Header("Canvas Settings")]
    public TextMeshProUGUI VidaVer;
    public Image Barra;

    [Header("Animation Settings")]
    public Animator enemigo;
    public NavMeshAgent navegador;
    [Header("Victoria Settings")]

   
    public float Kills = 0;
    
    float contar = 6;


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
            VidaVer.text = vida.ToString();
            if (vida <= 0) 
            {
                
                StartCoroutine(MorirMal());
                Kills += 1;
                


            }
            //Aca como quiero solo la variable me pide el .tostring para hacerlo una palabra.
            //Pero si quisieramos poner una palabra mas la variable EJ: "Vida: " + vida; esta seria la manera correcta, ya que en cadenas no pide el .tostring en int/flooat
        }
    }

    private IEnumerator MorirMal() 
    
    {
        enemigo.SetBool("Vivo", false);
        VidaVer.text = "0";
        navegador.isStopped = true;
        yield return new WaitForSeconds(5f);
        GanarPerder.Instance.SumarKill();
        Destroy(gameObject);
    }

   


}
