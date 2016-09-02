using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SentimentalText : MonoBehaviour {

	Text text;
	bool isStartText;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		isStartText = true;
	}


	public void SetText (string t) {
		text.text = t;
		isStartText = false;
	}

	public bool HasItem { get { return text.text.Length > 0 && !isStartText; } }
	
	// Update is called once per frame
	void Update () {
	
	}
}
