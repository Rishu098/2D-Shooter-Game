using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr : MonoBehaviour
{
    GameObject levelsign;
    int SceneIndex, levelPassed;
    // Start is called before the first frame update
   void Start()
    {
        levelsign = GameObject.Find("LevelNumber");

        SceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void loadNextLevel() {
     SceneManager.LoadScene(SceneIndex + 1);

    }
}
