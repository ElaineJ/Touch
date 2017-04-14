using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Linq;
using UnityEngine.SceneManagement;

public class StringFormation : MonoBehaviour
{

	public GameObject bubble=null;
	public List<string> characters=new List<string>();
	//StringBuilder builder = new StringBuilder();
	public string wordCheck;
	public List<GameObject> bubbles = new List<GameObject>();
	public GameObject[] hinges;
	public Text score = null;
	public int total = 0;
	static Dictionary<char, int> perLetterScore = new Dictionary<char, int>()
	{
		{'A', 1}, {'E', 1 }, {'I',1 }, {'O', 1 }, {'N', 1 }, {'R',1 }, {'T', 1 }, {'L', 1 }, {'S', 1 }, {'U', 1 }, {'D', 2 }, {'G',2 }, {'B', 3 }, {'C',3 }, {'M',3 }, {'P',3 }, {'F',4 },
		{'H',4 }, {'V',4 }, {'W',4 }, {'Y',4 }, {'K',5 }, {'J', 8 }, {'X',8 }, {'Q', 10 }, {'Z',10 }
	};



	public Button button;

	// Use this for initialization
	void Start()
	{
		//Button btn = button.GetComponent<Button>();
		button.onClick.AddListener(TaskOnClick);
		score.text = "0";



		//testing



	}

	// Update is called once per frame
	void Update()
	{

		//bubbles = GameObject.FindGameObjectsWithTag("selected");
		//Debug.Log(bubbles);
		hinges = FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach(GameObject dat in hinges)
		{
			stringAdder(dat);
		}
		bubbles.RemoveAll(item=>item==null);


	}



	public StringFormation(List<GameObject> bubbles, List<String> characters)
	{
		this.bubbles = bubbles;
		this.characters = characters;
		//this.builder = builder;
		//this.button = button;
	}
	void TaskOnClick()
	{
		for (int i = 0; i < bubbles.Count; i++)
		{
			DynamicText dynamic1 = bubbles.ElementAt(i).GetComponent<DynamicText>();
			//characters[i] = dynamic1.alphabet;
			//Debug.Log(characters[i]);
			characters.Add(dynamic1.alphabet);
			wordCheck = string.Join("",characters.ToArray());
			Debug.Log(characters[i]);



		}

		//string wordCheck = builder.ToString();
		Debug.Log("this is "+wordCheck);

		Debug.Log(checkWord(wordCheck));
		//string words = "ZEBRA";
		if (checkWord(wordCheck) == true)
		{
			char[] charactersScore = wordCheck.ToCharArray();

			foreach (char item in charactersScore)
			{
				total = total + perLetterScore[item];
			}
			score.text=total.ToString();
		}
		Debug.Log("Button clicked");
		//s1.characters.Clear();
		//Debug.Log(character);
		characters.Clear();
		for(int i = 0; i < bubbles.Count; i++)
		{
			

			//GameObject cube = GameObject.FindGameObjectWithTag("Floater");
			//transform.position = Random.insideUnitSphere * 5
			System.Random random=new System.Random();
			double rnX = random.NextDouble () * (5.0) - 2.5;
			double rnY = random.NextDouble () * (8.0) - 3.5;
			Vector2 trans = new Vector2 ((float)rnX, (float)rnY);
			Instantiate(bubble,trans,transform.rotation);
			Destroy(bubbles[i]);
			Debug.Log (SceneManager.GetActiveScene ().name);



		}
	}


	public static bool checkWord(string word)
	{
		//WORD MUST BE SENT IN ALL UPPERCASE

		if (word[0] == 'A')
			return wordInDict(word, "A.txt");
		else if (word[0] == 'B')
			return wordInDict(word, "B.txt");
		else if (word[0] == 'C')
			return wordInDict(word, "C.txt");
		else if (word[0] == 'D')
			return wordInDict(word, "D.txt");
		else if (word[0] == 'E')
			return wordInDict(word, "E.txt");
		else if (word[0] == 'F')
			return wordInDict(word, "F.txt");
		else if (word[0] == 'G')
			return wordInDict(word, "G.txt");
		else if (word[0] == 'H')
			return wordInDict(word, "H.txt");
		else if (word[0] == 'I')
			return wordInDict(word, "I.txt");
		else if (word[0] == 'J')
			return wordInDict(word, "J.txt");
		else if (word[0] == 'K')
			return wordInDict(word, "K.txt");
		else if (word[0] == 'L')
			return wordInDict(word, "L.txt");
		else if (word[0] == 'M')
			return wordInDict(word, "M.txt");
		else if
			(word[0] == 'N')
			return wordInDict(word, "N.txt");
		else if (word[0] == 'O')
			return wordInDict(word, "O.txt");
		else if (word[0] == 'P')
			return wordInDict(word, "P.txt");
		else if (word[0] == 'Q')
			return wordInDict(word, "Q.txt");
		else if (word[0] == 'R')
			return wordInDict(word, "R.txt");
		else if (word[0] == 'S')
			return wordInDict(word, "S.txt");
		else if (word[0] == 'T')
			return wordInDict(word, "T.txt");
		else if (word[0] == 'U')
			return wordInDict(word, "U.txt");
		else if (word[0] == 'V')
			return wordInDict(word, "V.txt");
		else if (word[0] == 'W')
			return wordInDict(word, "W.txt");
		else if (word[0] == 'X')
			return wordInDict(word, "X.txt");
		else if (word[0] == 'Y')
			return wordInDict(word, "Y.txt");
		else if (word[0] == 'Z')
			return wordInDict(word, "Z.txt");

		return false;
	}

	public static bool wordInDict(string word, string dic)
	{
		string directoryStr = @"Dictionary/";
		string path = Path.Combine(directoryStr, dic);
		//foreach (string line in File.ReadLines(path))
		//    if (word == line)
		//        return true;

		using (StreamReader sr = File.OpenText(dic))
		{
			string[] lines = File.ReadAllLines(dic);
			for (int x = 0; x < lines.Length - 1; x++)
			{
				if (word == lines[x])
				{
					sr.Close();
					return true;
				}
			}
		}

		return false;
	}


	public void stringAdder(GameObject obj)
	{
		if (obj.CompareTag ("0")) {
			if (!bubbles.Contains (obj)) {
				bubbles.Insert (0, obj);
			}
		} else if (obj.CompareTag ("1")) {
			if (!bubbles.Contains (obj)) {
				bubbles.Insert (1, obj);
			}
		} else if (obj.CompareTag ("2")) {
			if (!bubbles.Contains (obj)) {
				bubbles.Insert (2, obj);
			}
		} else if (obj.CompareTag ("3")) {
			if (!bubbles.Contains (obj)) {
				bubbles.Insert (3, obj);
			}
		} else if (obj.CompareTag ("4")) {
			if (!bubbles.Contains (obj)) {
				bubbles.Insert (4, obj);
			}
		} else if (obj.CompareTag ("5")) {
			if (!bubbles.Contains (obj)) {
				bubbles.Insert (5, obj);
			}
		} else if (obj.CompareTag ("Untagged")) {
			if (bubbles.Contains (obj)) {
				bubbles.Remove (obj);

			}
		} 

			

	}


}