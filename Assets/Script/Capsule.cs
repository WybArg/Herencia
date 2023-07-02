using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : ClaseBase
{
    private float time;
    public float timeSineWave;

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
        time += Time.deltaTime;

        if (time < timeSineWave)
        {
            transform.Translate(new Vector3(0, 1, 1).normalized * speed * Time.deltaTime);
        }
        else if (time < timeSineWave * 2)
        {
            transform.Translate(new Vector3(0, -1, 1).normalized * speed * Time.deltaTime);
        }
        else
        {
            time = 0;
        }

    }

}
