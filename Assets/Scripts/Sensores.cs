using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sensores : MonoBehaviour {

    public Text muestra;

    public GameObject derechaObject;
    public GameObject izquierdaObject;
    public GameObject arribaObject;
    public GameObject abajoObject;

    public GameObject boton;

    public GameObject pref;

    GameObject pintura;

    float x, y, z;

    bool entrar = false;

    bool derecha = false, izquierda = false, arriba = false , abajo = false;

	// Use this for initialization
	void Start () {
        pintura = Instantiate(pref);
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

        muestra.text = Input.acceleration.x.ToString() + " - " + Input.acceleration.y.ToString() + " - " + Input.acceleration.z.ToString();

        x = Input.acceleration.x;
        y = Input.acceleration.y;
        z = Input.acceleration.z;

        if (entrar && (derecha | izquierda | abajo | arriba))
        {
            entrar = false;

            boton.SetActive(true);

            Limpiar();

            if (derecha)
                derechaObject.SetActive(true);
            else if (izquierda)
                izquierdaObject.SetActive(true);
            else if (abajo)
                abajoObject.SetActive(true);
            else if (arriba)
                arribaObject.SetActive(true);

        }
            

        if (entrar)
        {
            if (x < -0.5)
                izquierda = true;
            else if (x > 0.5)
                derecha = true;
            else if (y > 0.5)
                abajo = true;
            else if (y < -0.5)
                arriba = true;
        }
    }

    public void Limpiar()
    {
        Destroy(pintura);
        pintura = Instantiate(pref);

        derechaObject.SetActive(false);
        izquierdaObject.SetActive(false);
        abajoObject.SetActive(false);
        arribaObject.SetActive(false);
    }

    public void Reset()
    {
        entrar = false;

        derecha = false;
        izquierda = false;
        arriba = false;
        abajo = false;

        boton.SetActive(false);

        derechaObject.SetActive(false);
        izquierdaObject.SetActive(false);
        abajoObject.SetActive(false);
        arribaObject.SetActive(false);

        Invoke("Empezar", 3);
    }

    void Empezar()
    {
        entrar = true;
    }
}
