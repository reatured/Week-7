using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBehavior : MonoBehaviour
{
    public Animator anim;
    public UIManager ui;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("isOpen", true);
            ui.updateText();
            Destroy(this.GetComponent<ChestBehavior>());
        }
    }


    public void chestEvt()
    {

        Debug.Log("The Chest has Opened");
    }
}
