using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ProjectorController : MonoBehaviour
{
    public int items = 6;
    public Text screen;
    public string text;
    public UnityEvent onComplete;

    public void DecreaseCount() {
        items--;
        screen.text = items + " " + text;

        if (items == 0) {
            onComplete.Invoke();
        }
    }
}
