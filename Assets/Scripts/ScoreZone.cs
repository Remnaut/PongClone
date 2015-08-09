using UnityEngine;
using System.Collections;


public class ScoreZone : MonoBehaviour {

	public Ball ball;

	void OnTriggerEnter(Collider other)
	{
		ball.Reset ();
	}
}
