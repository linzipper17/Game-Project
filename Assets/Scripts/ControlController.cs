using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ControlController : MonoBehaviour
{
    public List<GameObject> buttonText = new List<GameObject>();
    public List<GameObject> players = new List<GameObject>();
    public ControlStorage controlStorage;
    private int _buttonIndex;
    private GameObject _player;
    private bool _sensingInput = false;

    private void Start()
    {
        for(int i = 0; i < 8; i++)
        {
            buttonText[i].GetComponent<TextMeshProUGUI>().text = controlStorage.controls[i];
        }
    }

    public void RebindControl(int buttonNumber)
    {
        _buttonIndex = buttonNumber;
        buttonText[buttonNumber].GetComponent<TextMeshProUGUI>().text = "Press a key";
        _sensingInput = true;
        while (_sensingInput == true)
        {
            foreach(KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(kcode))
                    Debug.Log("KeyCode down: " + kcode);
            }
        }
    }
    
}
