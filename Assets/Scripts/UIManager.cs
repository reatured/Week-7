using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textCount;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
        count = 0;
        textCount.text = " " + count;
    }

    // Update is called once per frame
    public void updateText()
    {
        count++;
        textCount.text = " " + count;

    }
}
