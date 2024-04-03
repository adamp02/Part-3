using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMove : MonoBehaviour
{

    //player stats
    public float speed = 5f;
    public int health = 5;
    public int hunger = 5;

    public int maxHealth = 10;
    public int maxHunger = 10;

    // gui stuff
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI hungerText;

    Vector2 playerPos;
    Rigidbody2D playerRB;

    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();

        setupPlayer();
    }

    public void setupPlayer()
    {
        health = PlayerManager.playerStartingHealth;
        hunger = PlayerManager.playerStartingHunger;
        speed = PlayerManager.playerStartingSpeed;

        healthText.SetText("Health: " + health + " / " + maxHealth);
        hungerText.SetText("Hunger: " + hunger + " / " + maxHunger);
    }

    private void Update()
    {
        playerPos.x = Input.GetAxis("Horizontal");
        playerPos.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown("x"))
        {
            GetPosition(this.transform);
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void FixedUpdate()
    {
        playerRB.AddForce(playerPos * speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("The player hit something!");
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


    public static void GetPosition(Transform t)
    {
        Debug.Log("The player's current position is " + t.position + ".");
    }

}
