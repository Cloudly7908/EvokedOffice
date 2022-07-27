using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float pickUpRange = 5;
    public float moveForce = 250;
    public Transform holdParent;

    private GameObject heldOBj;
    void Update()
    {
       
        
     if (Input.GetKeyDown(KeyCode.F))
     {
            if (heldOBj == null)
            {

                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
                {
                    PickUpObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
     }

       

        if (heldOBj != null)
        {
            MoveObject();
        }
        
    }

    void MoveObject()
    {
        if (Vector3.Distance(heldOBj.transform.position, holdParent.position) > 0.1f)
        {
            Vector3 moveDistance = (holdParent.position - heldOBj.transform.position);
            heldOBj.GetComponent<Rigidbody>().AddForce(moveDistance * moveForce);
        }
    }

    void PickUpObject(GameObject pickObj)
    {
        if(pickObj.GetComponent<Rigidbody>())
        {
            Rigidbody objRig = pickObj.GetComponent<Rigidbody>();
            objRig.useGravity = false;
            objRig.drag = 10;

            objRig.transform.parent = holdParent;
            heldOBj = pickObj;
        }
    }

    void DropObject()
    {
        Rigidbody heldrig = heldOBj.GetComponent<Rigidbody>();
        heldrig.useGravity = true;
        heldrig.drag = 1;

        heldOBj.transform.parent = null;
        heldOBj = null;
    }
}
