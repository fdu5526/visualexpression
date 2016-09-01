using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

	Timer spawnTimer;
	Car mostRecentCar;

	[SerializeField]
	bool isGoingAway;


	// Use this for initialization
	void Awake () {
		spawnTimer = new Timer(RandomSpawnTime);
	}



	float RandomSpawnTime { get { return Random.Range(6f, 10f); } }


	
	// Update is called once per frame

	void FixedUpdate () {
		if (spawnTimer.IsOffCooldown) {
			spawnTimer.Reset();
			spawnTimer.CooldownTime = RandomSpawnTime;
			float d = 100f;
			if (mostRecentCar != null) {
				d = Vector3.Distance(mostRecentCar.transform.position, transform.position);
			}

			if (d > 3f) {
				GameObject g = (GameObject)Instantiate(Resources.Load("Prefabs/Car"));
				g.transform.position = transform.position;
				mostRecentCar = g.GetComponent<Car>();
				mostRecentCar.SetIsAway(this.isGoingAway);
			}
		}
		
	}
}
