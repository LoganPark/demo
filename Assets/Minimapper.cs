using UnityEngine;
using System.Collections;

public class Minimapper : MonoBehaviour {

	public Texture MinimapRenderTexture;
	
	void OnGUI () {
	
		GUILayout.BeginArea(new Rect(Screen.width * 0.8f, 0, Screen.width * 0.2f, Screen.width * 0.2f));
			GUILayout.Box( MinimapRenderTexture );
		GUILayout.EndArea();
	}
}
