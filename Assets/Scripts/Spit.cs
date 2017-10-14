using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spit : MonoBehaviour {

	//public string tagtag; //named tagtag instead of tag to avoid any confusions with existing tag in Unity library
	//public Text Score;
	public float decrease; //the amount of shrinking after spitting a Doof
	public GameObject Doof;

	//int score = 0;

	void Update() {
		if (Input.GetMouseButtonDown(0) && transform.localScale.z > 1) {
			transform.localScale -= new Vector3(decrease, decrease, decrease);
			Instantiate(Doof, transform.position, transform.rotation);
			//score += 10;
			//Score.text = "SCORE: " + score;
		}
	}
}
