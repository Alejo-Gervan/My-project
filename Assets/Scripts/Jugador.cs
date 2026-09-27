using UnityEngine;

public class Jugador : MonoBehaviour
{
    
    public float Velocidad = 2;
    public float gravedad = -9.81f;
    public Vector3 startPosition;
    public CharacterController Control;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Arrancamos");
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // MovimientoBasicoSinColision();
        MovimientoBasicoConColision();
        if (Control.isGrounded == false) {Control.Move(new Vector3 (0, gravedad , 0) * Time.deltaTime);  }
        
    }

    private void MovimientoBasicoSinColision() //Al modificar el componente transform, el obejeta va a ese nuevo vector ignorando si ya hay otro objeto ahi, osea, ignora las colisiones
    {
        if (Input.GetKey(KeyCode.W)) { transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * Velocidad); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * Velocidad); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * Velocidad); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * Velocidad); }
    }

    private void MovimientoBasicoConColision() //Aca se modifica el componenete CharacterController, que este si detecta colisiones con otros objetos al movernos
    {
        if (Input.GetKey(KeyCode.W)) { Control.Move(new Vector3(1, 0, 0) * Time.deltaTime * Velocidad); }
        if (Input.GetKey(KeyCode.S)) { Control.Move(new Vector3(-1, 0, 0) * Time.deltaTime * Velocidad); }
        if (Input.GetKey(KeyCode.A)) { Control.Move(new Vector3(0, 0, 1) * Time.deltaTime * Velocidad); }
        if (Input.GetKey(KeyCode.D)) { Control.Move(new Vector3(0, 0, -1) * Time.deltaTime * Velocidad); }
    }



}
