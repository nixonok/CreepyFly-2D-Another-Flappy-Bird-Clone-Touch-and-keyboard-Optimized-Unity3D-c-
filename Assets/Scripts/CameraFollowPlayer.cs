using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {

	Transform Player;
	public float CameraX=0f;

	void Start () {

		GameObject PlayerGameObj = GameObject.FindGameObjectWithTag ("Player");
		Player = PlayerGameObj.transform;
		CameraX = transform.position.x - Player.position.x;
	}
	

	void Update () {
	if( Player != null){
			Vector3 PositionObj = transform.position;
		PositionObj.x = Player.position.x + CameraX;
			transform.position = PositionObj;
		}
	}
}
