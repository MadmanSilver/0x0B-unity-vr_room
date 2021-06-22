using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public float flashDuration = 3.0f;

    private Light[] lights;
    private bool flashing = false;
    private float delta;

    // Start is called before the first frame update
    void Start()
    {
        lights = Object.FindObjectsOfType<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flashing) {
            foreach (Light light in lights) {
                if (light.gameObject.tag == "Room Lights") {
                    delta = Time.deltaTime / flashDuration * 1;
                    if (light.intensity + delta < 0) {
                        light.intensity = 0;
                        flashDuration = -flashDuration;
                    } else if (light.intensity + delta > 1) {
                        light.intensity = 1;
                        flashDuration = -flashDuration;
                    } else {
                        light.intensity += delta;
                    }
                }
            }
        }
    }

    public void ActivateEmergency() {
        foreach (Light light in lights) {
            if (light.gameObject.tag == "Room Lights") {
                light.intensity = 0;
                light.color = Color.red;
            }
        }
        flashing = true;
    }

    public void StopEmergency() {
        foreach (Light light in lights) {
            if (light.gameObject.tag == "Room Lights") {
                light.intensity = 1;
                light.color = Color.white;
            }
        }
        flashing = false;
    }
}
