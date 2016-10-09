using UnityEngine;
using System.Collections;

public class DemoText : MonoBehaviour {
	public TextMesh textmesh;
	public string txtFile = "story";
	string txtContents;

	void Start() {
		char[] delims = {' '};
	
		TextAsset txtAssets = (TextAsset)Resources.Load(txtFile);
		txtContents = txtAssets.text;

		string[] words = txtContents.Split(delims);

		textmesh.text = "Hogwarts";
		textmesh.color = Color.blue; 
	}
}

