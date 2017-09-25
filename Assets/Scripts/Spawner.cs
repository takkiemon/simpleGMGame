using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject Food;
	public float speed;

	void Start() {
		InvokeRepeating("Generate", 0, speed);
	}

	void Generate() {
		int x = Random.Range(0, Camera.main.pixelWidth);
		int y = Random.Range(0, Camera.main.pixelHeight);

		Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
		Target.z = 0;

		Instantiate(Food, Target, Quaternion.identity);
	}
}
