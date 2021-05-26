using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add thiese to script with UI element
using UnityEngine.UI;
using TMPro;

public class Example : MonoBehaviour
{
    public string title;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = title;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
