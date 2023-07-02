using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public delegate void DelStartMovement();
    public static event DelStartMovement OnStartMovement;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnStartMovement?.Invoke();
        }  
    }

}
