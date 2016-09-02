using UnityEngine;
using System.Collections;

public class DeleteZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	void OnCollisionEnter (Collision coll) {
		Destroy(coll.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
