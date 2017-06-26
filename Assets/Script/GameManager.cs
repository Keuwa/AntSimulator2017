using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using A


using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	private BoardManager boardScript;
	public List<Ant> Ants{get;set;}

	public void AddToAntList(Ant ant){
		Ants.Add (ant);

	}

	public void moveAll(){
		foreach (Ant ant in Ants) {
			ant.Move (1,1);
		}
	}

	void InitGame(){
		boardScript.SetupScene();
	}

	// Use this for initialization
	void Awake () {

		Ants = new List<Ant>();

		if (instance == null)
			instance = this;

		else if (instance != this)
			Destroy(gameObject);	

		DontDestroyOnLoad(gameObject);


		boardScript = GetComponent<BoardManager>();
		InitGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
