using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Script to make an item grabbable. No longer used. Kept for reference.</summary>
public class CustomGrabbable : MonoBehaviour
{
    // Wether or not the item is in grabbing range.
    public bool inRange = false;

    ///<summary>Grabs the item with the hand.</summary>
    public void Grab(GameObject hand) {
        // Disables forces including gravity on the item.
        gameObject.GetComponent<Rigidbody>().isKinematic = true;

        // Moves the item to the hand.
        transform.position = hand.transform.position;

        // Parents the item to the hand.
        transform.parent = hand.transform;
    }

    ///<summary>Releases the held item.</summary>
    public void Release() {
        // Unparents the item from the hand.
        transform.parent = null;

        // Re-enables forces on the item.
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
