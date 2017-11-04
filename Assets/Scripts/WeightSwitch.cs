using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSwitch : MonoBehaviour {

	public Color colorStart = new Color(0, 0, 0);
	public Color colorWrong = new Color(1, 0, 0);
    public Color colorRight = new Color(0, 1, 0);

    public float treshold;
    public float currentWeight;
    public bool activated;

    private void Start()
    {
        activated = false;
        currentWeight = 0;
    }

    private void OnTriggerStay(Collider other)
    {
        //currentWeight += other.transform.localScale.x;
        if (/*currentWeight*/ other.transform.localScale.x >= treshold)
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