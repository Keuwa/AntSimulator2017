using System.Collections;
using System.Collections.Generic;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.HQ;
using UnityEngine;


public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	private BoardManager boardScript;
	public List<AntUI.Ant> Ants{get;set;}
	IEnumerator enumerator;
	public GUI text;
	StatsController statsController;

	public void AddToAntList(AntUI.Ant ant){
		Ants.Add (ant);

	}

	public void OnClickArmagedon(){
		AntSimulator2017Concrete.Simulation.AntSimulation simulation = AntSimulator2017Concrete.Simulation.AntSimulation.Instance as AntSimulator2017Concrete.Simulation.AntSimulation;
		simulation.Environnement.Armagedon ();
		//Debug.Log ("hello : ");
	}

	public void OnClickAcidRain(){
		AntSimulator2017Concrete.Simulation.AntSimulation simulation = AntSimulator2017Concrete.Simulation.AntSimulation.Instance as AntSimulator2017Concrete.Simulation.AntSimulation;
		simulation.Environnement.AcidRain ();
		///Debug.Log ("helloAcid");

	}
	public void OnClickSimulate()
	{
		if (enumerator != null) {
			StopCoroutine (enumerator);
			enumerator = null;
		}
		else {
			enumerator = Simulate ();
			StartCoroutine (enumerator);
		}
	}
		
	IEnumerator Simulate(){
		AntSimulator2017Concrete.Simulation.AntSimulation simulation = AntSimulator2017Concrete.Simulation.AntSimulation.Instance as AntSimulator2017Concrete.Simulation.AntSimulation;
		int i = 0;

		this.statsController = new StatsController ();


		while(true){

			simulation.Simulate();
			statsController.Update ();
			Debug.Log ("Number of death  total : " + simulation.NumberOfDeathTotal + "\nNumber of death this turn : " + simulation.NumberOfDeathThisTurn + "\nNumber of Ant" + simulation.Environnement.HeadQuarters [0].ObserverList.Count);

			foreach (AntHill hill in simulation.Environnement.HeadQuarters) {
				for (i = 0; i < Ants.Count; i++) {
					var ant = (hill.ObserverList [i] as Ant);
					var position = ant.position; 

					Vector2 vector = new Vector2 (position.x, position.y);
					Ants[i].Move (vector);
				}
				for (; i < hill.ObserverList.Count; i++) {
					boardScript.AddAnt((hill.ObserverList[i] as Ant).position);
				}
			}
			Ant ant1 = (AntSimulator2017Concrete.Simulation.AntSimulation.Instance.Environnement.HeadQuarters[0] as AntHill).ObserverList[0] as Ant;
			//Debug.Log ("LP : " + ant1.lifePoint);
			yield return new WaitForSeconds(0.2f);
		}
	}

	void InitGame(){
		boardScript.SetupScene();
	}

	// Use this for initialization
	void Awake () {

		Ants = new List<AntUI.Ant>();

		if (instance == null)
			instance = this;

		else if (instance != this)
			Destroy(gameObject);	

		DontDestroyOnLoad(gameObject);


		boardScript = GetComponent<BoardManager>();
		statsController = GetComponent<StatsController>();
		InitGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
