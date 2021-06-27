using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Controlls the lights in the facility.</summary>
public class LightController : MonoBehaviour
{
    // The duration of the fade in and out.
    public float flashDuration = 3.0f;

    // List of all the lights in the facility.
    private Light[] lights;
    // If the lights are flashing.
    private bool flashing = false;
    // Change in brightness between frames.
    private float delta;

    ///<summary>Runs upon scene load. Grabs all the lights in the facility.</summary>
    void Start()
    {
        lights = Object.FindObjectsOfType<Light>();
    }

    ///<summary>Runs every frame. Fades lights in and out if flashing.</summary>
    void Update()
    {
        if (flashing) {
            // Cycles through all lights with tag "Room Lights".
            foreach (Light light in lights) {
                if (light.gameObject.tag == "Room Lights") {
                    // Calculates change in brightness as a function of time.
                    delta = Time.deltaTime / flashDuration * 1;

                    // Stops intensity at 0 or 1 then flips between fading in and out, respectively.
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

    ///<summary>Starts the emergency lights.</summary>
    public void ActivateEmergency() {
        // Turns all lights with tag "Room Lights" off and red.
        foreach (Light light in lights) {
            if (light.gameObject.tag == "Room Lights") {
                light.intensity = 0;
                light.color = Color.red;
            }
        }

        // Starts the lights flashing.
        flashing = true;
    }

    ///<summary>Stops the emergency lights.</summary>
    public void StopEmergency() {
        // Turns all lights with tag "Room Lights" on and white.
        foreach (Light light in lights) {
            if (light.gameObject.tag == "Room Lights") {
                light.intensity = 1;
                light.color = Color.white;
            }
        }

        // Stops the lights flashing.
        flashing = false;
    }
}
