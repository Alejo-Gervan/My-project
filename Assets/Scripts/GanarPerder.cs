using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GanarPerder : MonoBehaviour
{
    public RecibirDamage recibirDamageScript;
    public static GanarPerder Instance { get; private set; }
    float puntaje;

    [Header("Victoria Settings")]

   
    public TextMeshProUGUI texto;
    public GameObject panelWin;

    public GameObject panelLose;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float puntaje = recibirDamageScript.Kills;
        panelWin.SetActive(false);
        panelLose.SetActive(false);
        texto.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        ganador();
    }
  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 0f;
            texto.enabled = true;
            texto.text = "PERDISTE";
            panelLose.SetActive(true);
            
        }
    }

    public void otravez()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void ganador()
    {
        if (puntaje >= 5.5)
        {
            Time.timeScale = 0f;
            texto.enabled = true;
            texto.text = "GANADOR";
            panelWin.SetActive(true);


        }
    }
    public void SumarKill()
    {
        puntaje += 1; // O el valor que quieras sumar
        Debug.Log("Puntaje total: " + puntaje);
    }
    void Awake()
    {
        // Configuramos el Singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
