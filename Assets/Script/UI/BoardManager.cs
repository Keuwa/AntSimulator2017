using System.Collections;
using AntUI;
using System.Collections.Generic;
using AntSimulator2017Concrete.Simulation;
using AntSimulator2017Abstract.Simulation;
using AntSimulator2017Abstract;
using AntSimulator2017Concrete.item;

using UnityEngine;

public class BoardManager : MonoBehaviour {

	public int columns = 8; 										//Number of columns in our game board.
	public int rows = 8;

	public GameObject[] floorTiles;
	public GameObject[] collectableTiles;
	public GameObject[] treeTiles;
	public GameObject[] antTiles;
	public GameObject[] antHillTiles;




	private Transform boardHolder;


	private List <Vector3> gridPositions = new List <Vector3> ();
	private List <Vector3> collectablePositions = new List <Vector3> ();
	private List <Vector3> antPositions = new List <Vector3> ();


	public void AddAnt(Position position){
		var vector = new Vector3 (position.x, position.y);
		antPositions.Add (vector);
		LayoutOneObject (antTiles,vector);
	}

	void InitialiseList ()
	{
		var simulation = AntSimulation.Instance;
		gridPositions.Clear ();

		for(int x = 1; x < columns-1; x++)
		{
			for(int y = 1; y < rows-1; y++)
			{
				gridPositions.Add (new Vector3(x, y, 0f));
			}
		}

		for(int i = 0 ;i < simulation.Environnement.Map.areas.Length;i++){
			for (int j = 0; j < simulation.Environnement.Map.areas[i].Length; j++) {
				if(simulation.Environnement.Map.areas[i][j].Fruits.Count>0){
					collectablePositions.Add (new Vector3(i, j, 0f));
				}
			}
		}

		foreach (var hill in simulation.Environnement.HeadQuarters) {
			var vector = new Vector3 (hill.Position.x, hill.Position.y, 0f);
			LayoutOneObject (antHillTiles, vector);
		}

		foreach (AntSimulator2017Concrete.Character.Ant ant in simulation.Environnement.HeadQuarters[0].ObserverList) {
			antPositions.Add (new Vector3(ant.position.x, ant.position.y, 0f));
		}
	}

	void BoardSetup ()
	{
		boardHolder = new GameObject ("Board").transform;

		for(int x = -1; x < columns + 1; x++)
		{
			for(int y = -1; y < rows + 1; y++)
			{
				GameObject toInstantiate = floorTiles[Random.Range (0,floorTiles.Length)];

				if(x == -1 || x == columns || y == -1 || y == rows)
					toInstantiate = treeTiles [Random.Range (0, treeTiles.Length)];

				GameObject instance =
					Instantiate (toInstantiate, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;

				instance.transform.SetParent (boardHolder);
			}
		}
	}


	void LayoutOneObject(GameObject[]tileArray,Vector3 positions){
			GameObject tileChoice = tileArray[Random.Range (0, tileArray.Length)];

			Instantiate(tileChoice, positions, Quaternion.identity);
	}


	void LayoutObject(GameObject[]tileArray,List<Vector3> positions){
		for(int i = 0; i < positions.Count ; i++)
		{
			GameObject tileChoice = tileArray[Random.Range (0, tileArray.Length)];

			Instantiate(tileChoice, positions[i], Quaternion.identity);
		}
	}

	public void SetupScene ()
	{
		BoardSetup ();

		new AntSimulationFactory().createSimulation (rows, columns);
 		InitialiseList ();

		LayoutObject (collectableTiles,collectablePositions);
		LayoutObject (antTiles,antPositions);

	}

}
