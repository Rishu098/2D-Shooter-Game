using UnityEngine;
using System.Collections;
using UnityEngine .UI;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		disableAll ();
		if (PlayerPrefs.HasKey ("LevelClearedCount"))
			PlayerPrefs.SetInt ("LevelClearedCount", 0);

		int clearedLevel = PlayerPrefs.GetInt ("LevelClearedCount");
		for (int i = 0; i < clearedLevel; i++) {
			transform.GetChild (i).gameObject.GetComponent <Button> ().interactable = true;
		}}
	public void disableAll(){
		int levelButtonsCount = transform.childCount;
		for (int i = 0; i < levelButtonsCount; i++) {
			transform.GetChild (i).GetComponent <Button> ().interactable = false;
		}
	}
	
	public void 	playLevel(int Level){
		SceneManager.LoadScene (Level);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
