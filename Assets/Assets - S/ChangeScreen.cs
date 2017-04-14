using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScreen : MonoBehaviour {

	public void ChangetoScene(int sceneToChangeTo){
		SceneManager.LoadScene (sceneToChangeTo);
	}
}
