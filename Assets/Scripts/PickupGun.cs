using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGun : MonoBehaviour
{
    public GameObject focusedObject;

    public GameObject pickupSlot;

    public float interactDistance;

    public bool holding;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (holding)
        {
            return;


        }

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        Ray ray = new Ray(transform.position, fwd);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.CompareTag("PickUp"))
            {
                focusedObject = hit.collider.gameObject;
            }
        }
        else
        {
            focusedObject = null;
        }

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("PickUp"))
    //    {
    //        other.gameObject.GetComponent<CapsuleCollider>().enabled = true;

    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("PickUp"))
    //    {
    //        other.gameObject.GetComponent<CapsuleCollider>().enabled = false;
    //    }
    //}

    public void OnPickUp()
    {
        Debug.Log("e pressed");
        if (holding)
        {
            //drop the gun
            focusedObject.transform.parent = null;
            focusedObject.GetComponent<Rigidbody>().isKinematic = false;
            focusedObject.GetComponent<CapsuleCollider>().enabled = true;
            holding = false;
        }
        else
        {
            //pick up the gun
            focusedObject.transform.parent = pickupSlot.transform;
            focusedObject.transform.position = pickupSlot.transform.position;
            focusedObject.transform.rotation = pickupSlot.transform.rotation;
            focusedObject.GetComponent<Rigidbody>().isKinematic = true;
            focusedObject.GetComponent<CapsuleCollider>().enabled = false;
            holding = true;
        }

    }

}
