using UnityEngine;
using System.Collections;

public class BeamSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Random.seed = 5;
		/*for (int i = 0; i < 100; i++) {
			GameObject g = (GameObject)Instantiate(Resources.Load("Prefabs/Beam"));
			g.transform.position = new Vector3(RandomPosition, RandomPosition, RandomPosition);
		}*/
	}

	float RandomPosition { get { return Random.Range(-10f, 100f); } }
	
	// Update is called once per frame
	void Update () {
	
	}
}
