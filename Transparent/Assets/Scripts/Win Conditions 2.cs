using UnityEngine;
using System.Collections;

public class WinConditions2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	void OnCollisionEnter (Hit: Collision){


 if(Hit.gameObject.tag == "Player"){
  Application.loadLevel("LichHunt proto1");  

   }
  }
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
