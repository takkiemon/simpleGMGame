using UnityEngine;
using System.Collections;

public class Eat : MonoBehaviour {

	public string tagtag; //named tagtag instead of tag to avoid any confusions with existing tag in Unity library
	public float increase;

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == tagtag) {
			transform.localScale += new Vector3(increase, increase, increase);
			Destroy(other.gameObject);
		}
	}
}
