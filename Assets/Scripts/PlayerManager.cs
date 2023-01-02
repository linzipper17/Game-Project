using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    #region Variables
    
    [Header("Movement")]
    public float moveSpeed;
    
    public float acceleration;
    public float deceleration;
    public float frictionAmount;
    
    public float velPower;

    [Header("Jump")]
    public float jumpForce;

    public float fallGravityMultiplier;

    public float jumpCutMultiplier;

    [Header("Dash")] 
    public float dashForce;
    public float dashTime;
    
    public float horMult;

    public float vertMult;
    
    [Header("Checks")]
    public Vector2 checkRadius;
    
    [Header("Timer")] 
    public float coyoteTime;
    
    #endregion
}
