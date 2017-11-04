using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftScript : MonoBehaviour {

    private Vector3 Target;
    public float speed;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.transform.localScale.x >= 1.5)
        {
            Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Target.z = transform.position.z;

            transform.position = other.transform.position;
            transform.LookAt(Target);
        }
    }
}
