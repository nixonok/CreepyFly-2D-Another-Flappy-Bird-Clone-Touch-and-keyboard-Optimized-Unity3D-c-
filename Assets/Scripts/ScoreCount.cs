using UnityEngine;
using System.Collections;

public class ScoreCount : MonoBehaviour {

		public ScoreCounter _ScoreCounter;

	void OnTriggerEnter2D (Collider2D collider){
		if (collider.tag == "Player") {

						_ScoreCounter.AddScore();
		

		}
	}


}
