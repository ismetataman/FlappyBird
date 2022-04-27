using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public float velocity = 1f;
    private Rigidbody2D rb2D;
    public bool isDead;
    public Score score;
    public GameObject deathScreen; 

    void Start()
    {
        Time.timeScale =1;
        rb2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
           //Havada sicratma
           rb2D.velocity = Vector2.up * velocity;
       }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name == "ScoreArea")
        {
            score.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {   
        if(other.gameObject.tag == "obstacle")
        {
            isDead = true;
            Time.timeScale = 0;
            deathScreen.SetActive(true);
        }
        
    }
}
