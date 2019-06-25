using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    Button[] LevelButtons;

    private void Awake()
    {
        int ReachLevel = PlayerPrefs.GetInt("ReachLevel", 1);
        LevelButtons = new Button[transform.childCount];

        for (int i = 0; i < LevelButtons.Length-1; i++)
        {
            LevelButtons[i] = transform.GetChild(i).GetComponent<Button>();
           // LevelButtons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
           if (i + 1 > ReachLevel)
            {
                LevelButtons[i].interactable = false;
            }
        }
    }
    public void PlayLevel(int Level)
    {
        SceneManager.LoadScene(Level);
    }
    public void resetPlayerP()
    {
        for (int i = 1; i < LevelButtons.Length-1; i++)
        {
            LevelButtons[i].interactable = false;
        }
        PlayerPrefs.DeleteAll();
    }
}