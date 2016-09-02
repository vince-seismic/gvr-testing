using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	
	void Update () {
		gameObject.transform.Rotate (1, 1, 0);
	}
}
