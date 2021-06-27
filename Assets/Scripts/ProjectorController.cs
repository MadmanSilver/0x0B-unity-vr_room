using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

///<summary>Controlls the projector puzzle.</summary>
public class ProjectorController : MonoBehaviour
{
    // Number of items to put in place.
    public int items = 6;
    // Text on the monitor.
    public Text screen;
    // What to set the monitor's text to.
    public string text;
    // Event triggered when all items are in place.
    public UnityEvent onComplete;

    ///<summary>Decreases the number of items left to place.</summary>
    public void DecreaseCount() {
        // Decrease items and update the monitor.
        items--;
        screen.text = items + " " + text;

        // If all items placed, trigger complete event.
        if (items == 0) {
            onComplete.Invoke();
        }
    }
}
