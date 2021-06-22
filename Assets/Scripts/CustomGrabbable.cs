using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrabbable : MonoBehaviour
{
    public bool inRange = false;

    public void Grab(GameObject hand) {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        transform.position = hand.transform.position;
        transform.parent = hand.transform;
    }

    public void Release() {
        transform.parent = null;
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
