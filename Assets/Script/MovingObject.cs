using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingObject : MonoBehaviour {

	private Rigidbody2D rb2D;
	public float moveTime = 0.1f;
	private float inverseMoveTime;

	// Use this for initialization
	protected virtual void Start () {
		rb2D = GetComponent <Rigidbody2D> ();

		inverseMoveTime = 1f / moveTime;
	}
	
	public void Move (int xDir, int yDir)
	{

		Vector2 start = transform.position;

		Vector2 end = start + new Vector2 (xDir, yDir);

		StartCoroutine (SmoothMovement (end));
	}

	protected IEnumerator SmoothMovement (Vector3 end)
	{
		float sqrRemainingDistance = (transform.position - end).sqrMagnitude;

		while(sqrRemainingDistance > float.Epsilon)
		{
			Vector3 newPostion = Vector3.MoveTowards(rb2D.position, end, inverseMoveTime * Time.deltaTime);

			rb2D.MovePosition (newPostion);

			sqrRemainingDistance = (transform.position - end).sqrMagnitude;

			yield return null;
		}
	}
}
