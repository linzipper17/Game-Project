using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public bool isLever = false;
    public bool interactableDown = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        interactableDown = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (isLever)
        {
            interactableDown = true;
        }
        else
        {
            interactableDown = false;
        }
    }
}
