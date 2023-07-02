using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : ClaseBase
{

    private int reverseY = 1;
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
        InvokeRepeating(nameof(MoveZigZag), 2, 2);
    }


    private void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveZigZag()
    {
        reverseY *= -1;
        this.transform.Rotate(0, 45 * reverseY, 0);
    }
}
