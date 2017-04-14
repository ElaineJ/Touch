using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour {
	//public Scene scene;
	public Button button;

	// Use this for initialization
	void Start () {
		button.onClick.AddListener(TaskOnClick);
		//scene.name = "bubble on plane";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TaskOnClick(){
		SceneManager.LoadScene ("bubble on plane");
	}
}
