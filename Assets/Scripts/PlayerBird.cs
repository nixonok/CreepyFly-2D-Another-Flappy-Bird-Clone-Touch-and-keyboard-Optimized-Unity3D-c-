using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerBird : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 Gravity;
	public Vector3 PushSpeed;
	public float MaxPushSpeed = 5f;
	public float JumpSpeed = 1f;
	bool tapped = false;
	bool dead = false;
	Animator animator;
	float AfterDeathWait;
	public GUIText restart;
	public GUIText GameOver;
		public bool start = true;

	void Start () {
		GameOver.text = "Tap To Start";
		restart.text = "";
		Time.timeScale = 0.0f;
		animator = transform.GetComponentInChildren<Animator> ();
	}
	

	void Update () {
		if (dead) {
			GetComponent<Rigidbody2D>().gravityScale = -4;
			AfterDeathWait -= Time.deltaTime;
			if(AfterDeathWait<=0){
				GameOver.text = "GameOver";
				restart.text = "Tap To ReStart";
				if (Input.GetMouseButtonDown(0)){
										SceneManager.LoadScene ("main");
				}

			}
				}
		else{
		if (Input.GetMouseButtonDown(0)){
								GameOver.text = "";

			Time.timeScale = 1.0f;
			tapped = true;
		}
		}
		}

	void FixedUpdate () {
		velocity.x = JumpSpeed;
		velocity += Gravity * Time.deltaTime;
		if (dead) {
			GetComponent<Rigidbody2D>().gravityScale = 4;
						return;
				}
		if (tapped == true) {
			tapped = false;
			animator.SetTrigger("Tapped");
			if(velocity.y<0){
				velocity.y = 0;
			}

			velocity += PushSpeed;
		}
		velocity = Vector3.ClampMagnitude ( velocity , MaxPushSpeed);
		transform.position += velocity * Time.deltaTime; 
		float Angle = 0;
		if (velocity.y > 0) {
			Angle = Mathf.Lerp( 0 , 0 , 0 );
				}
		else {
			Angle = Mathf.Lerp( 0 , -30 , -velocity.y/MaxPushSpeed );
		}

		transform.rotation = Quaternion.Euler ( 0 , 0 , Angle );
	}

	void OnCollisionEnter2D (Collision2D collision){
		animator.SetTrigger("Dead");
		dead = true;
		AfterDeathWait = 0.5f;
		}


}
