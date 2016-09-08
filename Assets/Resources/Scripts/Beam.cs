using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * RandomS, transform.localScale.z * RandomS);
	}

	float RandomS { get { return Random.Range(0.1f, 2f); } }
	
	// Update is called once per frame
	void Update () {
	
	}
}
