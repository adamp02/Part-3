using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigidbody;

    //player stats
    public float speed = 5f;
    public int health = 5;
    public int hunger = 5;

    public int maxHealth = 10;
    public int maxHunger = 10;

    // gui stuff
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI hungerText;

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

        if (hunger > maxHunger)
        {
            hunger = maxHunger;
        }

        hungerText.SetText("Hunger: " + hunger + " / " + maxHunger);
    }

    public void HealthPickup(int healthValue)
    {
        Debug.Log("You got a medkit!");
        health += healthValue;

        if (health > maxHealth)
        {
            health = maxHealth;
        }

        healthText.SetText("Health: " + health + " / " + maxHealth);
    }

    public void SpeedPickup(int speedIncrease)
    {
        Debug.Log("You got a speedboost! Speed increased by " + speedIncrease + ".");
        speed += speedIncrease;
    }

}
