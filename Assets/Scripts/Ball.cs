using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float ballInitialVelocity = 600f;

	private bool ballInPlay = false;
	private Rigidbody rb;

	// Use this for initialization
	void Awake () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Jump") && ballInPlay == false)
		{
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(ballInitialVelocity*Mathf.Sign(Random.Range(-1f,1f)), ballInitialVelocity*Random.Range(-1f,1f), 0));

		}
	}
}
