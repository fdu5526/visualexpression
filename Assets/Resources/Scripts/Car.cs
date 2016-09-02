using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

	[SerializeField]
	bool isGoingAway;

	// Use this for initialization
	void Start () {
		Transform b = transform.Find("Body");
		Renderer rend = b.GetComponent<Renderer>();
		Color c = ColorHSV.GetRandomColor(Random.Range(0.0f, 360f),
																			Random.Range(0.3f, 0.8f),
																			Random.Range(0.3f, 0.8f));
		rend.material.SetColor("_Color", c);
	}

	public void SetIsAway (bool isGoingAway) {
		this.isGoingAway = isGoingAway;
		transform.eulerAngles = new Vector3(-90f, 0f, isGoingAway ? -90f : 90f);
	}

	float RandomSpeed { get { return Random.Range(4f, 8f); } }
	
	// Update is called once per frame
	void FixedUpdate () {
		float z = isGoingAway ? RandomSpeed : -RandomSpeed;
		GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, z);
	}
}
