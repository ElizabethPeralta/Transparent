using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
	bool mPressed;
	// Use this for initialization
	void Start () {
		mPressed = false;
	}
	
	// Update is called once per frame
	void Update () {

		 if (Input.GetMouseButton(0)) {
			mPressed = true;
		}else{mPressed = false;}
	
	}

	void OnTriggerEnter(Collider other){
		
			if (other.gameObject.CompareTag("Player") && mPressed ){
			
					
				Destroy(other.gameObject);
			}
		
	}
	
	void OnTriggerStay(Collider other){
		
			if (other.gameObject.CompareTag("Player")  && mPressed){
			
					
				Destroy(other.gameObject);
			}
		
	}


}
