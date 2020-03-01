using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Idiomas : MonoBehaviour {

    public string version = "1.0.";

    public Text texto;
    public Text by;

    public Text empezar;
    public Text salir;
    public Text de;

    public Text magic;

    int entrar;

    void Start()
    {
        if (Application.systemLanguage.ToString() == "Spanish")
            entrar = 0;
        else
            entrar = 1;

        if (entrar == 0)
        {
            texto.text = "Dependiendo de en qué orientación se levante el móvil,\nmostrará un número o otro.\n\nSolo tendrás que pedir al espectador que piense un número,\ndibujar cualquier cosa.\nPara después pulsar el boton (invisible)\nseñalizado en rojo, colocar el móvil boca abajo\ny se mostrara el numero elegido.";
            by.text = "Versión " + version + " de la aplicación.\nPara cualquier consulta,\nmejora o información contactar con: mipanco@gmail.com.";
            empezar.text = "Magia";
            salir.text = "Salir";
            de.text = "De";
            magic.text = "Más Trucos:";
            entrar = 1;
        }
        else
        {
            texto.text = "Depending on the orientation of the cell phone,\nit will show a number or another.\n\nYou only have to ask the viewer to think a number,\ndraw anything.\nThen press the (invisible)\nbutton indicated in red, place the phone face down\nand the number will be displayed.";
            by.text = "App Version " + version + ".\nFor any suggestion or comment,\nplease don´t hesitate to contact us: mipandco@gmail.com.";
            empezar.text = "Magic";
            salir.text = "Exit";
            de.text = "By";
            magic.text = "More Tricks:";
            entrar = 0;
        }
    }
}
