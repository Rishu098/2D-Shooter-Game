using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Weapon : MonoBehaviour {
	public GameObject prefab;
	public GameObject dialog;
    //  public GameObject dialog1;
    public Text win_lose;

	private LineRenderer lr;
	public GameObject aim;
    public int lifes;
    public Text Lifescount;

	// Use this for initialization
	void Start () {
        Lifescount.text = lifes.ToString();
		lr = GetComponent<LineRenderer> ();
		lr.SetPosition (0, transform.position);
		dialog .SetActive (false);
       // dialog1.SetActive(false);
      // if (PlayerPrefs.HasKey  ("LevelCleared")) {
		//} else
			//PlayerPrefs.SetInt ("LevelCleared",0);
		//if (PlayerPrefs.HasKey ("LevelClearedCount")) {
		//}
		//else 
//PlayerPrefs.SetInt ("LevelClearedCount", 0);


		//StartCoroutine (Example ());
	}

	// Update is called once per frame
	void Update () {
		//StartCoroutine ("Example");
		lr.SetPosition (1,aim.transform.position);
		var mouse = Input.mousePosition;
		var screenPoint = Camera.main.WorldToScreenPoint(transform .transform.localPosition);
		var offset = new Vector2 (mouse.x - screenPoint.x, mouse.y - screenPoint.y);
		var angle = Mathf.Atan2 (offset.y, offset.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler (0, 0, angle);
		if (Input.GetMouseButtonUp (0)) {
			Fire ();
		}
		if(GameObject.FindGameObjectsWithTag("Enemy").Length <1){
            //print ("you win");
            //PlayerPrefs.SetInt ("LevelCleared", SceneManager.GetActiveScene ().buildIndex);
            StartCoroutine("Example");
            win_lose.text = "Level Complete";
            win_lose.color = Color.green;


           // StartCoroutine("Example");
                
            //Example();

        }
        else if(lifes==0 && (GameObject.FindGameObjectsWithTag("Enemy").Length > 0)){
            StartCoroutine("Example");

            win_lose.text = "Level Fail";
            win_lose.color = Color.red;
           // StartCoroutine("Example");


        }
       // StartCoroutine("Example");
    }
	void Fire(){
        lifes--;
        Lifescount.text = lifes.ToString();
		var dir = (Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position).normalized;
		GameObject g = (GameObject )Instantiate (prefab, transform.position, Quaternion.identity);
		Destroy (g, 3.5f);
		g.GetComponent <Rigidbody2D> ().gravityScale = 0;
		g.GetComponent <Rigidbody2D>().AddForce(dir*2000);
	}
	IEnumerator Example(){
		//print (Time.time);
		yield return new WaitForSeconds (8.1f);
		dialog .SetActive (true);

		///print (Time.time);
	}
	//public void LevelCleared(){
	//	int previousBuildIndex = PlayerPrefs .GetInt ("LevelCleared");
	//int currentBuildIndex = SceneManager.GetActiveScene ().buildIndex;
		//int previousLevelCount = PlayerPrefs .GetInt ("LevelClearedCount");
	//	if (currentBuildIndex > previousBuildIndex) {
			//PlayerPrefs.SetInt ("LevelCleared", SceneManager.GetActiveScene ().buildIndex);
			//PlayerPrefs.SetInt ("LevelClearedCount", previousLevelCount + 1);
		//	print ("Level Cleared Count" +PlayerPrefs.GetInt ("LevelClearedCount"));
		//}
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	//}


}
