using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour {

	public Text scoreText;
	public static GM instance = null;

	private int playerScore = 0;
	private int aiScore = 0;
	// Use this for initialization
	void Awake () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

	}
	
	// Update is called once per frame
	public void PlayerScore()
	{
		playerScore++;
		scoreText.text = "Score\n" + playerScore + "  |  " + aiScore;
	}

	public void AiScore()
	{
		aiScore++;
		scoreText.text = "Score\n" + playerScore + "  |  " + aiScore;
	}
}
