
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;

//call gameover in original code when timer ends
public class endsequence : MonoBehaviour
{


	public Button restartText;
	private Scene scene;

	private bool gameover;
	private bool restart;
	Animator anim;
	public int timeLeft = 0;
	public Text countdownText = null;

	// Use this for initialization
	void Start()
	{
		timeLeft = 60;
		StartCoroutine("LoseTime");
		countdownText.text = "";
		scene = SceneManager.GetActiveScene();
	}
	void Awake()
	{
		anim=GetComponent<Animator>();

	}


	// Update is called once per frame
	void Update()
	{
		restartText.onClick.AddListener(TaskOnClick);
		countdownText.text = (timeLeft.ToString());

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
			anim.SetTrigger("GameOver");
		}

	}
	void TaskOnClick()
	{
		Debug.Log("You have clicked the restart!");
		SceneManager.LoadScene(scene.name);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);


	}
	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}
}