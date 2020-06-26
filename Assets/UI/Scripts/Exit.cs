using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(TaskOnClik);
    }


    void TaskOnClik()
    {
        Application.Quit();
    }
}

