using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : MovingObject {

	// Use this for initialization
	protected override void Start () {
		GameManager.instance.AddToAntList (this);
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
}
