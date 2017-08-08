using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	    public int Score=0;
	    public int BestScore=0;
		public Animator anim;


	public void AddScore(){
				Score++;
				anim.SetTrigger ("scored");
				if (Score > BestScore) {
						BestScore = Score;
			PlayerPrefs.SetInt ("BestScore", BestScore);
				}
		}

	void Start(){
		Score=0;
		BestScore = PlayerPrefs.GetInt ("BestScore", 0);
		}

	void OnDestroy(){

		}

	void Update (){
			GetComponent<GUIText>().text = ("Score: "+Score+"          Best: "+BestScore);
		
	}


}
