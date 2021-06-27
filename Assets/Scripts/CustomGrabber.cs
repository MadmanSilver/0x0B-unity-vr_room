using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Adds grabbing functionality to a VR hand. No longer used. Kept for reference.</summary>
public class CustomGrabber : MonoBehaviour
{
    // Layer to check for grabbable items.
    public int grabbableLayer = 0;
    // Object needed to check for player input.
    public OVRInput.Controller controller;

    // Current focused grabbable item.
    private CustomGrabbable grabbable;
    // List of all in-range grabbables.
    private HashSet<Collider> grabbables = new HashSet<Collider>();
    // Whether or not the focused grabbable is grabbed.
    private CustomGrabbable grabbed = null;

    ///<summary>Runs every frame. Checks for input and grabs/releases if necessary.</summary>
    void Update() {
        // Grabs the closest in-range item when the button is pressed.
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controller)) {
            Collider closest = null;

            // Finds the closest grabbable object in range.
            foreach (Collider col in grabbables) {
                if (closest == null) {
                    closest = col;
                } else {
                    if (Vector3.Distance(transform.position, closest.transform.position) > Vector3.Distance(transform.position, col.transform.position)) {
                        closest = col;
                    }
                }
            }

            // Grabs the closest item.
            if (closest != null) {
                grabbed = closest.GetComponent<CustomGrabbable>();
                grabbed.Grab(gameObject);
            }
        }

        // Releases the grabbed item when the button is released.
        if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, controller) && grabbed != null) {
            grabbed.Release();
            grabbed = null;
        }
    }

    ///<summary>Runs when a grabbable item comes in range.</summary>
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == grabbableLayer) {
            grabbable = other.GetComponent<CustomGrabbable>();

            if (grabbable != null) {
                grabbable.inRange = true;
                grabbables.Add(other);
            }
        }
    }

    ///<summary>Runs when a grabbable item leaves range.</summary>
    void OnTriggerExit(Collider other) {
        if (other.gameObject.layer == grabbableLayer) {
            grabbable = other.GetComponent<CustomGrabbable>();

            if (grabbable != null) {
                grabbable.inRange = false;
                grabbables.Remove(other);
            }
        }
    }
}
