using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    public float speed = 5.0f;
    public int fallenEnemies;
    private bool isOnGround = false;
    public int ifRanThisTimes = 0;
    
    
    
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        
        
    }

    
    void Update()
    {
        if(player.gameObject != null)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
        
        
        //FallenEnemy();
        
    }



    //private void FallenEnemy()
    //{
        
    //    if (transform.position.y < -1)
    //    {
    //        Destroy(gameObject);
    //        fallenEnemies++;
    //        Debug.Log(fallenEnemies);
         
    //    }

        

    //}



}
