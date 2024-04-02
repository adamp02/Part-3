using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{

    public int healthValue = 2;

    // Start is called before the first frame update
    void Start()
    {
        base.findPlayer();
    }




    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        playerObj.SendMessage("HealthPickup", healthValue);
    }
}
