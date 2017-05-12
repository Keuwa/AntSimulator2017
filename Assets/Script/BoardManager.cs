using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	public int columns = 8; 										//Number of columns in our game board.
	public int rows = 8;

	public GameObject[] floorTiles;
	public GameObject[] collectableTiles;
	public GameObject[] treeTiles;
	public GameObject[] antTiles;



	private Transform boardHolder;


	private List <Vector3> gridPositions = new List <Vector3> ();
	private List <Vector3> collectablePositions = new List <Vector3> ();
	private List <Vector3> antPositions = new List <Vector3> ();




	void InitialiseList ()
	{
		gridPositions.Clear ();

		for(int x = 1; x < columns-1; x++)
		{
			for(int y = 1; y < rows-1; y++)
			{
				gridPositions.Add (new Vector3(x, y, 0f));
			}
		}

		collectablePositions.Add (new Vector3(0f, 0f, 0f));
		collectablePositions.Add (new Vector3(2f, 2f, 0f));
		collectablePositions.Add (new Vector3(4f, 4f, 0f));

		antPositions.Add (new Vector3(5f, 5f, 0f));
		antPositions.Add (new Vector3(6f, 6f, 0f));



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

		InitialiseList ();

		LayoutObject (collectableTiles,collectablePositions);
		LayoutObject (antTiles,antPositions);

	}

}
