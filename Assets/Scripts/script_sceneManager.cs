using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_sceneManager : MonoBehaviour {

public void LoadScene(string sceneName) {

	Debug.Log ("The Scene loading is: " + sceneName);
	SceneManager.LoadScene(sceneName);
	}


public void QuitGame (){

	Debug.Log ("The Game is trying to Quit");
	Application.Quit();
}

}
