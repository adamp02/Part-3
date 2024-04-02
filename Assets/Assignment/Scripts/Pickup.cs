using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public GameObject playerObj;


    // Start is called before the first frame update
    void Start()
    {

        findPlayer();

    }

    public void findPlayer()
    {
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        playerObj.SendMessage("MsgTest");
        Destroy(this.gameObject);
    }

}