using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject enemyBall = null;
    public Texture[] texture;
    public bool isGameOver = false;
    
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        PlayerSizeTextureKill();

    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyBall = collision.gameObject;
        }
    }


    private void ChangeTexture()
    {
        int textureIndex = UnityEngine.Random.Range(0, texture.Length);
        GetComponent<Renderer>().material.mainTexture = texture[textureIndex];
    }


    private void PlayerSizeTextureKill()
    {
        if (isGameOver == false && enemyBall != null && gameObject != null)
        {
            if (enemyBall.transform.position.y < -2)
            {
                gameObject.transform.localScale += new Vector3(1, 1, 1);
                gameObject.GetComponent<Rigidbody>().mass += 1;
                ChangeTexture();
                Destroy(enemyBall);
            }


        }
        if (gameObject.transform.position.y < -2)
        {
            Destroy(gameObject);
            Debug.Log("player destroyed");
            isGameOver = true;
            Debug.Log(isGameOver);

        }
    }
}

