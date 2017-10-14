using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Eat : MonoBehaviour {

	public string tagtag; //named tagtag instead of tag to avoid any confusions with existing tag in Unity library
	public Text Score;
	public float increase; //the amount of growing after eating a Food

	int score = 0;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == tagtag) {
			transform.localScale += new Vector3(increase, increase, increase);
			Destroy(other.gameObject);

			score += 10;
			Score.text = "SCORE: " + score;
		}
	}
}
