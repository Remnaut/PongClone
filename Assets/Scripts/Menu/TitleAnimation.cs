using UnityEngine;
using System.Collections;

public class TitleAnimation : MonoBehaviour {
	
	public void PlayAnimation() {
		GetComponent<Animator>().SetBool("Play",true);
	}
}
