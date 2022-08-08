using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Log : MonoBehaviour
{
    public static Log Instace {
        get
        {
            return instace;
        }
    }

    private static Log instace;

    public Text textgo;
    // Start is called before the first frame update
    void Awake()
    {
        instace = this;
    }
    // Start is called before the first frame update
    public void log(string text)
    {
        textgo.text = textgo.text + text + "\n";
    }
}
