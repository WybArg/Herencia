using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ClaseBase
{
    void Start()
    {
        Manager.OnStartMovement += StartMoveHandler;
    }


    void Update()
    {
        if (move) Move();
    }

    public void StartMoveHandler()
    {
        move = true;
    }


    private void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
