using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;

[RequireComponent(typeof(SphereCollider))]
///<summary>Defines a point in space for an item to be able to attach.</summary>
public class SnapPoint : MonoBehaviour
{
    // Item that can snap to this spot.
    public Collider snappable;
    // If item is snapped.
    public GameObject snapped = null;
    // Event to trigger upon item snapping.
    public UnityEvent onSnap;

    ///<summary>Snaps the item if it comes in range.</summary>
    void OnTriggerEnter(Collider other) {
        if (other == snappable) {
            // Triggers snap event.
            if (snapped == null) {
                onSnap.Invoke();
            }

            // Snaps the item to the point.
            snapped = other.gameObject;
            snapped.GetComponent<Rigidbody>().isKinematic = true;
            snapped.transform.position = transform.position;
            snapped.transform.rotation = transform.rotation;
            snapped.transform.parent = transform;
        }
    }
}
