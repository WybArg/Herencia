using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ClaseBase
{
    void Start()
    {
        Manager.OnStartMovement += StartMove;
    }


    void Update()
    {
        if (move) Move();
    }

    public void StartMove()
    {
        move = true;
    }


    private void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
