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

	public void Reset()
	{
		if (transform.position.x < 0) {
			GM.instance.PlayerScore ();
		} else if (transform.position.x > 0) {
			GM.instance.AiScore ();
		}
		ballInPlay = false;
		rb.velocity = new Vector3 (0f, 0f, 0f);
		transform.position = new Vector3 (0f, 0f, 0f);

	}
}
