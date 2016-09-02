using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SentimentalText : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}


	public void SetText (string t) {
		text.text = t;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
