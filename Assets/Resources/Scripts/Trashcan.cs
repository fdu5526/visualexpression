using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Trashcan : Physics2DBody {

	SentimentalText sentimentalText;
	Text throwAwayPrompt;
	bool isAboutToTrash;

	// Use this for initialization
	protected override void Awake () {
		sentimentalText = FindObjectOfType<SentimentalText>();
		throwAwayPrompt = GameObject.Find("Canvas/ThrowAway").GetComponent<Text>();
		throwAwayPrompt.enabled = false;
		isAboutToTrash = false;
	}
	
	public bool IsInTrashcan { get { return isAboutToTrash; } }

	public void PlayTrashSound () {
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (sentimentalText.HasItem) {
			Vector3 m = Input.mousePosition;
			m.z = 1f;
			Vector2 mousePos = (Camera.main.ScreenToWorldPoint(m));
			isAboutToTrash = (-0.1f <= mousePos.x && mousePos.x <= 0.2f) &&
											 (0.3f <= mousePos.y && mousePos.y <= 0.9f);
		} else {
			isAboutToTrash = false;
		}
		throwAwayPrompt.enabled = isAboutToTrash;
	}
}
