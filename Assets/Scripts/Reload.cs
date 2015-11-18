//Alan Hsiao, Logic & Programming, Pool Audio Project, 11/18/15

using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	//attempt to create a restart button, pulled from madlibs game. Button does not show on screen...
	void OnGUI() {
		if (GUI.Button (new Rect (20, 50, 1000, 1000), "Reload"))
			Application.LoadLevel ("Main");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
