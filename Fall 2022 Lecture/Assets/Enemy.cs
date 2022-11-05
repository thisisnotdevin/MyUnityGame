using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public int health = 50;

    public GameObject deathEffect;
    public AudioSource audioPlayer;
    // Start is called before the first frame update

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0){
            
            Die();
        }
    }

    // Update is called once per frame
    void Die ()
    {
<<<<<<< HEAD
     ScoreScript.scoreValue += 10;
=======
>>>>>>> parent of 99024113 (added stuff)
     Instantiate(deathEffect, transform.position, Quaternion.identity);
     Destroy(gameObject);   
     audioPlayer.Play();
    }
}
