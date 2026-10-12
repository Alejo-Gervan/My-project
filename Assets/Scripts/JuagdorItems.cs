using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class JuagdorItems : MonoBehaviour
{
    private bool yaGeino = false;
    private bool YaGane = false;
    [SerializeField] private AudioClip GenioSound;
    [SerializeField] private AudioClip GanoSound;

    public GameObject paredGenial;
    int todosItems = 0;
    int todosGenio = 0;
    public TextMeshProUGUI contador;
    public int ItemAgarro = 0;
    public int ItemGenio = 0;
    public GameObject panelwin;
    public GameObject textwin;
    public GameObject imagelwin;
    public Vector3 GenioCaja = new Vector3(-1 ,1,-34);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        todosItems += GameObject.FindGameObjectsWithTag("item").Length * 10;
        todosGenio += GameObject.FindGameObjectsWithTag("gen").Length ;
        panelwin.SetActive(false);
        textwin.SetActive(false);
        imagelwin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ganador();
        ganadorGenio();
    }
    public void Agarrador()
    {
        ItemAgarro += 10;
        contador.text = "Items:" + ItemAgarro + "/" + todosItems;
    }
    public void ganador()
    {
        if (ItemAgarro >= todosItems && !YaGane)
        {
            panelwin.SetActive(true);
            textwin.SetActive(true);
            imagelwin.SetActive(true);
            AudioSource.PlayClipAtPoint(GanoSound, transform.position);
            YaGane = true;
        }
    }

    public void ganadorGenio()
    {
        if (ItemGenio >= todosGenio && !yaGeino)
        {
            Destroy(paredGenial);
            AudioSource.PlayClipAtPoint(GenioSound, transform.position);
            yaGeino = true;

        }

    }

    public void AgarraGenio()
    {
        ItemGenio += 1;
    }

    





}
