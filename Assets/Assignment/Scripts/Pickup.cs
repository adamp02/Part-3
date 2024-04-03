using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject playerObj;

    void Start()
    {
        findPlayer();
    }

    public void findPlayer()
    {
        playerObj = GameObject.Find("Player");
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        playerObj.SendMessage("MsgTest");
        Destroy(this.gameObject);
    }

}
