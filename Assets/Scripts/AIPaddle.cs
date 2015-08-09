using UnityEngine;
using System.Collections;

public class AIPaddle : MonoBehaviour {

	public Ball ball;
	public float clamp = 8f;


	private Vector3 aiPos = new Vector3 (13f, 0, 0);

	// Update is called once per frame
	void Update () 
	{
		aiPos = new Vector3 (13f, Mathf.Clamp (ball.transform.position.y, -clamp, clamp), 0);
		transform.position = aiPos;
	}
}
