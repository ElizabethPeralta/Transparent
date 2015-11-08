using UnityEngine;
using System.Collections;


public class GlassDestroy : MonoBehaviour
{

    public int attackDamage = 10;
    public GameObject player/*,player2, player3*/;
    PlayerHealth playerHealth/*1, playerHealth2, playerHealth3*/;

    void Awake()
    {
        //player = GameObject.FindGameObjectsWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        //playerHealth2 = player2.GetComponent<PlayerHealth>();
        //playerHealth3 = player3.GetComponent<PlayerHealth>();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Lich"))
    //    {
    //        Attack();
    //        Destroy(this.gameObject);
    //    }
    //}

    void Attack()
    {

        if (playerHealth.currentHealth > 0)
        {

            playerHealth.TakeDamage(attackDamage);
        }

        //if (playerHealth2.currentHealth > 0)
        //{

        //    playerHealth2.TakeDamage(attackDamage);
        //}

        //if (playerHealth3.currentHealth > 0)
        //{

        //    playerHealth3.TakeDamage(attackDamage);
        //}
    }
}
