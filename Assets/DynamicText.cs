using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicText : MonoBehaviour {
	//int count;
	// public GameObject exampleOne;
	// public GameObject exampleTwo;
	static List<char> availAlphabets = new List<char>();
	static Dictionary<char, int> charFreq = new Dictionary<char, int>()
	{
		{'A', 9}, {'E', 12 }, {'I',9 }, {'O', 8 }, {'N', 6 }, {'R',6 }, {'T', 6 }, {'L', 4 }, {'S', 4 }, {'U', 4 }, {'D', 4 }, {'G',3 }, {'B', 2 }, {'C',2 }, {'M',2 }, {'P',2 }, {'F',2 },
		{'H',2 }, {'V',2 }, {'W',2 }, {'Y',2 }, {'K',1 }, {'J', 1 }, {'X',1 }, {'Q', 1 }, {'Z',1 }
	};

	public string alphabet;
	[SerializeField]
	private TextMesh dynamic =null;
	// Use this for initialization
	void Start () {
		foreach (KeyValuePair<char, int> entry in charFreq)
		{
			for (int i = 0; i < entry.Value; i++)
			{
				availAlphabets.Add(entry.Key);
			}
		}
		System.Random rnd = new System.Random();
		int rndInt = rnd.Next(1, availAlphabets.Count);
		char rndAlphabet = availAlphabets[rndInt];
		availAlphabets.RemoveAt(rndInt);
		alphabet= rndAlphabet.ToString();
		dynamic.text=alphabet;
	}

	// Update is called once per frame
	void Update () {
	}

}