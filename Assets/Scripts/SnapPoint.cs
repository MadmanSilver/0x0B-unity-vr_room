using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;

[RequireComponent(typeof(SphereCollider))]
public class SnapPoint : MonoBehaviour
{
    public Collider snappable;
    public GameObject snapped = null;
    public UnityEvent onSnap;

    void OnTriggerEnter(Collider other) {
        if (other == snappable) {
            if (snapped == null) {
                onSnap.Invoke();
            }
            snapped = other.gameObject;
            snapped.GetComponent<Rigidbody>().isKinematic = true;
            snapped.transform.position = transform.position;
            snapped.transform.rotation = transform.rotation;
            snapped.transform.parent = transform;
        }
    }
}
