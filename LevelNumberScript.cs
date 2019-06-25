using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumberScript : MonoBehaviour
{
    // Start is called before the first frame update
    int SceneIndex;
    Text text;

        void Start()
    {
        text = GetComponent<Text>();
        SceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Level " + SceneIndex;
    }
}
