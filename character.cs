using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {
	Animator anim;
	bool isDead;
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine ("Example");

	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "ball") {
			isDead = true;
			anim.SetTrigger ("isDead");
			StartCoroutine ("Example");
			//Example ();
			//StartCoroutine (Example ());
			//yield WaitForSeconds (3);
			//GetComponent<Collider>().enabled = false;


		}
	}
	IEnumerator Example(){
		print (Time.time);
		yield return new WaitForSeconds (4);
		Destroy (this.gameObject);

		print (Time.time);
	}
}
