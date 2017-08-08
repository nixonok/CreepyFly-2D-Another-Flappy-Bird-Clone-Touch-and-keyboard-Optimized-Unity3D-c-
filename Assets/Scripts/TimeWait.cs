using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeWait : MonoBehaviour {


	void Start () {
		StartCoroutine(TestCoroutine());

	}

	IEnumerator TestCoroutine(){

		yield return new WaitForSeconds(2);
				SceneManager.LoadScene("main");
		yield break;

	}

	void Update () {
	
	}
}
