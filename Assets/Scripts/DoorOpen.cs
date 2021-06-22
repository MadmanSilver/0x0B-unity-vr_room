using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;

    void Start() {
        anim = gameObject.GetComponent<Animator>();
    }
    
    public void openSesame() {
        anim.SetBool("character_nearby", true);
    }
}
