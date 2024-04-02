using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigidbody;

    //player stats
    public float speed = 5f;
    public int health = 5;
    public int hunger = 5;


    Vector2 direction;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {

        rigidbody.AddForce(direction * speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("The player hit something!");
    }

    public void MsgTest()
    {

        Debug.Log("Message received!");
    }

    public void FoodPickup(int foodValue)
    {
        Debug.Log("You ate some food!");
        hunger += foodValue;
    }

    public void HealthPickup(int healthValue)
    {
        Debug.Log("You got a medkit!");
        health += healthValue;
    }

    public void SpeedPickup(int speedIncrease)
    {
        Debug.Log("You got a speedboost! Speed increased by " + speedIncrease + ".");
        speed += speedIncrease;
    }

}
