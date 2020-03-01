using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Pulsar : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool pulsado = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }
}
