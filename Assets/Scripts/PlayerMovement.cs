using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	void Update() {
		Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Target.z = transform.position.z;

		transform.position = Vector3.MoveTowards(transform.position, Target, speed * Time.deltaTime / transform.localScale.x);
		transform.LookAt(Target);
	}
}