using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public Button level2, level3;
    int LevelPassed;
    // Start is called before the first frame update
    void Start()
    {
        LevelPassed = PlayerPrefs.GetInt("LevelPassed");
        level2.interactable = false;
        level3.interactable = false;

        switch (LevelPassed) {
            case 1:
                level2.interactable = true;
                break;
            case 2:
                level2.interactable = true;
                level3.interactable = true;
                break;

        }
    }
    public void levelToLoad(int level) {
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
