using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public new string name;
    public int damage;
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public string getName()
    {
        return name;
    }
    public void setName(string nm)
    {
        name = nm;
    }
    void Awake()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        if (currentHealth > 0)
        {
            if (Input.GetKeyDown("1"))
            {
                TakeDamage(10);
            }
            if (Input.GetKeyDown("2"))
            {
                TakeDamage(20);
            }
            if (Input.GetKeyDown("3"))
            {
                TakeDamage(30);
            }
            if (Input.GetKeyDown("4"))
            {
                TakeDamage(40);
            }
            if (Input.GetKeyDown("5"))
            {
                TakeDamage(50);
            }
        }
        if (Time.timeScale == 0)
            {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Time.timeScale = 1;
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void TakeDamage(int damage)
    {
        name = "Player";
        currentHealth -= damage;
        if (currentHealth > 0)
        {
            Debug.Log(name + " takes " + damage + " points of damage.\nYou have " + currentHealth + " points of health.");
        }
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Debug.Log("Oh, " + name + " just die.\nYou should be more careful next time!");
        Time.timeScale = 0;
        print("Press 'P' key to reload the game...");
    }

}
