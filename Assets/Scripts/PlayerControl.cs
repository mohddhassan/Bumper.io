using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody playerRB;
    private GameObject focalPoint;
    private int killCount = 0;
    private int killedEnemies = 0;
    

    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        
    }

    
    void Update()
    {
        
        float verticalInput = Input.GetAxis("Vertical");
        playerRB.AddForce(focalPoint.transform.forward * speed * verticalInput, ForceMode.VelocityChange);

        //killedEnemies = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyControl>().fallenEnemies;

        //if (killedEnemies == 1)
        //{
        //    Debug.Log("EnemyFallen");
        //}




    }

    

}
