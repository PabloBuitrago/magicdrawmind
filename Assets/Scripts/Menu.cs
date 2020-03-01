using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Menu : MonoBehaviour {

    string URLmonstrar = "https://play.google.com/store/apps/developer?id=Mipandco";

    public GameObject panel;
    public GameObject panel2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Si presionan el boton ESC.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Salir();
        }
    }

    public void Magia()
    {
        SceneManager.LoadScene("Scene");
    }

    public void Salir()
    {
        if (panel.activeSelf == false && panel2.activeSelf == false)
        {
            #if UNITY_EDITOR
                EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
        else
        {
            panel.SetActive(false);
            panel2.SetActive(false);
        }
    }

    public void MagicCardsDeck()
    {
        Application.OpenURL(URLmonstrar);
    }

    public void Monstrar(bool pulsar)
    {
        if (pulsar)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    public void Monstrar2(bool pulsar)
    {
        if (pulsar)
        {
            panel2.SetActive(true);
        }
        else
        {
            panel2.SetActive(false);
        }
    }
}
