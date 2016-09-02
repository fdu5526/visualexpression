using UnityEngine;
using System.Collections;

public class BoxObject : Physics2DBody {

	bool isDragged;
	float initZ;

	// Use this for initialization
	protected override void Awake () {
		base.Awake();
		initZ = transform.position.z;
	}

	void OnMouseDown () {
		isDragged = true;
	}

	void OnMouseUp() {
		isDragged = false;
	}


	// Update is called once per frame
	void Update () {
	if (isDragged) {
			Vector3 m = Input.mousePosition;
			m.z = 1f;
			Vector2 mousePos = (Vector2)(Camera.main.ScreenToWorldPoint(m));
			Vector3 newPos = new Vector3(mousePos.x, mousePos.y, initZ);
			transform.position = newPos;
	}
		
	}
}
