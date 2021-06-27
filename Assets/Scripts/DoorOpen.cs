using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Controlls the door opening animation.</summary>
public class DoorOpen : MonoBehaviour
{
    private Animator anim;

    ///<summary>Runs on scene load.</summary>
    void Start() {
        anim = gameObject.GetComponent<Animator>();
    }
    
    ///<summary>Runs the door open animation.</summary>
    public void openSesame() {
        anim.SetBool("character_nearby", true);
    }
}
