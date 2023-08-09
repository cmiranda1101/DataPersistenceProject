using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetText(string inputText)
    {
        DataManager.playerName = inputText;
        Debug.Log(DataManager.playerName);
    }
}
