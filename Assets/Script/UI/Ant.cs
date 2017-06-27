using System.Collections;
using System.Collections.Generic;
using AntSimulator2017Concrete;
using UnityEngine;

namespace AntUI{
	public class Ant : MovingObject {
		AntSimulator2017Concrete.Character.Ant ant{ get; set;}

		// Use this for initialization
		protected override void Start () {
			GameManager.instance.AddToAntList (this);
			base.Start ();
		}

		// Update is called once per frame
		void Update () {

		}

	}
}
