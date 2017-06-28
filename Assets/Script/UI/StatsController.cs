using System.Collections;
using System.Collections.Generic;
using AntSimulator2017Concrete.Simulation;
using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour {
 	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	public void Update () {
		AntSimulation simulation = AntSimulation.Instance as AntSimulation ;

		GameObject.Find ("Turn").GetComponent<Text> ().text = "Nombre de tours : " + simulation.NumberOfTurn;
		GameObject.Find ("Ants").GetComponent<Text> ().text = "Nombre de fourmis : " + simulation.Environnement.HeadQuarters [0].ObserverList.Count;
		GameObject.Find ("DeathThisTurn").GetComponent<Text> ().text = "Morts ce tour : " + simulation.NumberOfDeathThisTurn;
		GameObject.Find ("Death").GetComponent<Text> ().text = "Morts total : " + simulation.NumberOfDeathTotal;

	}

}
