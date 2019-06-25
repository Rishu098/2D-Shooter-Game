using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoNextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoNextLevel1() {
        int CurrentLevel = PlayerPrefs.GetInt("ReachLevel", 1);
        PlayerPrefs.SetInt("ReachLevel", CurrentLevel + 1);
        SceneManager.LoadScene(CurrentLevel + 1);
    }
}
