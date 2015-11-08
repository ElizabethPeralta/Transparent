﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	
	
	public int health = 100;
    public int currentHealth;
    public Slider healthSlider;

    public bool isDead;
    public bool damaged;


	 void Awake()
    {
        
        currentHealth = health;
    }
	
	void Start () {
		
	
	
	}
	
	
	void Update () {
		Debug.Log(health);
	}
	
	
	//void OnTriggerEnter(Collider other){
	//	if (other.CompareTag("Glass"))
	//	{
	//		health -= 1;
			
	//	}
	//}

    public void TakeDamage(int ammount)
    {
        damaged = true;
        currentHealth -= ammount;
        healthSlider.value = currentHealth;

        if(currentHealth <= 0 && isDead)
        {
            Death();
        }
    }

    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;

        Application.LoadLevel("gameOverScreen");
    }
}
