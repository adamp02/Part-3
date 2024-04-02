using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Pickup
{

    public int boostValue = 200;

    // Start is called before the first frame update
    void Start()
    {
        base.findPlayer();
    }




    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        playerObj.SendMessage("SpeedPickup", boostValue);
    }
}
