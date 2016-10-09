using UnityEngine;
using System.Collections;

public class DemoText : MonoBehaviour {
	public TextMesh textmesh;
	public string txtFile = "story";
	string txtContents;

	void Start() {
		char[] delims = {' '};
		//textmesh.text = "Hello World";
		TextAsset txtAssets = (TextAsset)Resources.Load(txtFile);
		txtContents = txtAssets.text;

		string[] words = txtContents.Split(delims);

		textmesh.text = "Hogwarts";
		textmesh.color = Color.blue; //new Color(0, 0, 0);
		//textmesh.text = (s  + "/n") foreach s in words;

		/*for (int i = 0; i < words.Length; i++) {
			textmesh.text = words [2] + "\n";
		}
		*/


	    /*for (int i = 0; i < txtContents.Length; i++) {
			txtSplit = txtContents.Split[0]
		}
		textmesh.text = txtContents;
	   */
	}
}
	/*void Update {

	}
	*/