using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button playButton;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(TaskOnClik);
    }


    void TaskOnClik()
    {
        SceneManager.LoadScene(sceneName);
    }
 
}
