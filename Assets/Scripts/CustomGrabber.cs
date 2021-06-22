using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrabber : MonoBehaviour
{
    public int grabbableLayer = 0;
    public OVRInput.Controller controller;

    private CustomGrabbable grabbable;
    private HashSet<Collider> grabbables = new HashSet<Collider>();
    private CustomGrabbable grabbed = null;

    void Update() {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controller)) {
            Collider closest = null;
            foreach (Collider col in grabbables) {
                if (closest == null) {
                    closest = col;
                } else {
                    if (Vector3.Distance(transform.position, closest.transform.position) > Vector3.Distance(transform.position, col.transform.position)) {
                        closest = col;
                    }
                }
            }

            if (closest != null) {
                grabbed = closest.GetComponent<CustomGrabbable>();
                grabbed.Grab(gameObject);
            }
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, controller) && grabbed != null) {
            grabbed.Release();
            grabbed = null;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == grabbableLayer) {
            grabbable = other.GetComponent<CustomGrabbable>();

            if (grabbable != null) {
                grabbable.inRange = true;
                grabbables.Add(other);
            }
        }
    }

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
