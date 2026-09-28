using UnityEngine;

public class FisicasJugador : MonoBehaviour
{
    public Rigidbody rb;
    bool saltoPuedo = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Salto();
    }

    private void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && saltoPuedo) { rb.AddForce(0, 500, 0); saltoPuedo = false; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Piso") { saltoPuedo = true; }
    }


}
