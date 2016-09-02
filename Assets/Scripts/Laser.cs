using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	private LineRenderer line;

	void Start () {
		line = gameObject.GetComponent<LineRenderer> ();
		line.enabled = false;
	}

	void Update () {
		if (GvrController.TouchDown == true) {
			//shoot laser
			StopCoroutine("FireLaser");
			StartCoroutine ("FireLaser");
		}
	}

	IEnumerator FireLaser () {
		line.enabled = true;
		while (GvrController.IsTouching == true) {
			Ray ray = new Ray (transform.position, transform.forward);

			line.SetPosition (0, ray.origin);
			line.SetPosition (1, ray.GetPoint (100));

			yield return null;
		}

		line.enabled = false;
	}
}
