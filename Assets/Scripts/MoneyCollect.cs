using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCollect : MonoBehaviour
{
    public static int moneyCount;
    private Text moneyCounter;

    // Start is called before the first frame update
    void Start()
    {
        moneyCounter = GetComponent<Text>();
        moneyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moneyCounter.text = "X " + moneyCount;
    }
}
