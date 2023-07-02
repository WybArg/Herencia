using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : ClaseBase
{
    public float delayStartTeleport;
    public float timeIntervalTeleport;

    void Start()
    {
        Manager.OnStartMovement += StartMoveHandler;
    }

    public void StartMoveHandler()
    {
        InvokeRepeating(nameof(Move), delayStartTeleport, timeIntervalTeleport);
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
