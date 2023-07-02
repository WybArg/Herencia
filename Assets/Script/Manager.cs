using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public delegate void DelStartMovementHandler();
    public static event DelStartMovementHandler OnStartMovement;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnStartMovement?.Invoke();
        }  
    }

}
