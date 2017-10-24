using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSwitch : MonoBehaviour {

	public Color colorStart = Color(1f, 0f, 0f);
	public Color colorEnd = Color(0f, 1f, 0f);

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.transform.localScale.x >= 1.5)
        {
			GetComponent<Renderer>().material.color = colorEnd;
        }
    }
}
