using UnityEngine;
using System.Collections;


public class LoadTxt : MonoBehaviour {
	
	public string txtFile = "story";
	string txtContents;

	// Use this for initialization
	void Start () {
		TextAsset txtAssets = (TextAsset)Resources.Load(txtFile);
		txtContents = txtAssets.text;
	}
		


	void OnGUI() {
		GUILayout.Label(txtContents);
		//GUILayout.Label(new Plane(), txtContents);
		//Plane plane = new Plane(Vector3(0.31, .6, -.92), Vector3(65, 45, 0)); 
		//Projector proj = new Projector();
		//proj.
		//GUILayout.Box(new Plane(, txtContents);
		//Rect rect = new Rect(100, 100, 100, 100);
		//Plane p = new Plane();

		//GUILayout.
	}

	// Update is called once per frame
//	void Update () {
	
//	}

}