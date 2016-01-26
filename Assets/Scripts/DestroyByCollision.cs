using UnityEngine;
using System.Collections;

public class DestroyByCollision : MonoBehaviour {
	public GameObject explosion;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary") {
			return;
		}
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
