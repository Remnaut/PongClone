using UnityEngine;
using System.Collections;

public class PlayerPaddleController : MonoBehaviour {

	public float paddleSpeed = 1f;
	public float clamp = 8f;


	private Vector3 playerPos = new Vector3 (-13f, 0, 0);

	// Update is called once per frame
	void Update () 
	{
		float yPos = transform.position.y + Input.GetAxis ("Vertical") * paddleSpeed;
		playerPos = new Vector3 (-13f, Mathf.Clamp (yPos, -clamp, clamp), 0);
		transform.position = playerPos;
	}
}
