using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpActivation : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        this.GetComponent<CapsuleCollider>().enabled = false;
    }

    // Update is called once per frame
}
