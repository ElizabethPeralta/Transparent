using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
	
	public float health;
	
	
	void Start () {
		
		health = 20f;
		
	
	}
	
	
	void Update () {
		Debug.Log(health);
	}
	
	
	void OnTriggerEnter(Collider other){
		if (other.CompareTag("Glass"))
		{
			health -= 1f;
			
		}
	}
}
