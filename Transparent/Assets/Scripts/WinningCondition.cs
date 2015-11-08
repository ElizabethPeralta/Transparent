using UnityEngine;
using System.Collections;

public class WinningCondition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTrigggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            Application.LoadLevel("Player1Wins");

        }

        if (other.CompareTag("Player2"))
        {
            Application.LoadLevel("Player2Wins");

        }
        if (other.CompareTag("Player3"))
        {
            Application.LoadLevel("Player3Wins");

        }
    
    }
}
