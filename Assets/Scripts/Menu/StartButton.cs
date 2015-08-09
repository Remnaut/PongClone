using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	public void OnClick()
	{
		Invoke ("LoadGameLevel", 1.75f);
	}

	void LoadGameLevel()
	{
		Application.LoadLevel ("Game");
	}
	
}
