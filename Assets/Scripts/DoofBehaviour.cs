using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoofBehaviour : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		/*rb = transform.GetComponent<Rigidbody>();
		Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Target.z = transform.position.z;*/

		//transform.position = Vector3.MoveTowards(transform.position, Target, speed * Time.deltaTime / transform.localScale.x);
		/*rb.angularVelocity = Vector3.MoveTowards(transform.position, Target, speed * Time.deltaTime / transform.localScale.x);*/
	}
}
