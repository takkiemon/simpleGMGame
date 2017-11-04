using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSwitch : MonoBehaviour {

	public Color colorStart = new Color(0, 0, 0);
	public Color colorWrong = new Color(1, 0, 0);
    public Color colorRight = new Color(0, 1, 0);

    public float treshold;

    private void OnTriggerStay(Collider other)
    {
        if (/*other.tag == "Player" && */other.transform.localScale.x >= treshold)
        {
            GetComponent<Renderer>().material.color = colorRight;
        }
        else
        {
            GetComponent<Renderer>().material.color = colorWrong;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = colorStart;
    }
}