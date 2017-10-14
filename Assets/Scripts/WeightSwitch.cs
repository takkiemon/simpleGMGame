using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSwitch : MonoBehaviour {

    public Color colorStart = Color.red;
    public Color colorEnd = Color.green;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.transform.localScale.x >= 1.5)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
