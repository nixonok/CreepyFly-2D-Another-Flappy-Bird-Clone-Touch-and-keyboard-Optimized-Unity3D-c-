using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int NumberOfBG = 10;
	float MaxUp = 1.92f;
	float MaxDown = 0.2f;

	void Start(){
				GameObject[] Abstrackls = GameObject.FindGameObjectsWithTag ("Obstrackl");
				foreach (GameObject Obstrackl in Abstrackls) {
						Vector3 pos = Obstrackl.transform.position;
						pos.y = Random.Range (MaxUp, MaxDown);
						Obstrackl.transform.position = pos;

				}
		}
	void OnTriggerEnter2D ( Collider2D Collider ) {

		float widthOfBGObj = ((BoxCollider2D)Collider).size.x;
		Vector3 BGposition = Collider.transform.position;
		BGposition.x += widthOfBGObj * NumberOfBG - (widthOfBGObj/2f + 2.5f);
		Collider.transform.position = BGposition;

		if (Collider.tag == "Obstrackl") {
			BGposition.y = Random.Range( MaxUp , MaxDown );
			}
		Collider.transform.position = BGposition;
	}

}
