using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTrail : MonoBehaviour {

    Pulsar pulsar;

    // Use this for initialization
    void Start () {
        pulsar = GameObject.FindGameObjectWithTag("Panel").GetComponent<Pulsar>();
    }
	
	// Update is called once per frame
	void Update () {
        if (pulsar.pulsado)
        {
            if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
            {
                Plane objPlane = new Plane(Camera.main.transform.forward *= 1, this.transform.position);

                Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                float rayDistance;

                if (objPlane.Raycast(mRay, out rayDistance))
                    this.transform.position = mRay.GetPoint(rayDistance);
            }
        }            
	}
}
