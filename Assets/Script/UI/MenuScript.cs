using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public void exitGame() {
		Application.Quit();
	}

	public void changeScene(string sceneName) {
		Application.LoadLevel(sceneName);
	}
}
