using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public GameObject spawn1;
    public GameObject spawn2;


    private void FixedUpdate()
    {
        if(player1.transform.position.y < -10 || player2.transform.position.y < -10)
        {
            Die();
        }
    }

    public void Die()
    {
        player1.transform.position = spawn1.transform.position;
        player2.transform.position = spawn2.transform.position;
    }

        
        
}
