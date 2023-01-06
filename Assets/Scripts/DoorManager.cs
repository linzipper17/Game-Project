using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public List<GameObject> interactables =  new List<GameObject>();
    public List<GameObject> doors = new List<GameObject>();

    private int _interactableAmount = 0;


    private void Start()
    {
        _interactableAmount = interactables.Count;
    }

    private void Update()
    {
        if (_interactableAmount == 1)
        {
            if(interactables[0].GetComponent<Interactables>().interactableDown == true)
            {
                doors[0].SetActive(false);
            }
            else
            {
                doors[0].SetActive(true);
            }   
        } else if (_interactableAmount == 2)
        {
            if(interactables[0].GetComponent<Interactables>().interactableDown == true && interactables[1].GetComponent<Interactables>().interactableDown == true)
            {
                doors[0].SetActive(false);
            }
            else
            {
                doors[0].SetActive(true);
            }    
        }
        
    }
}
