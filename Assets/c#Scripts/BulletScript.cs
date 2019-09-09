using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    //public GameObject hero;
    private Vector2 targetVector;
    public int speed = 50;          // The speed our bullet travels
    public float lifetime = 10f;     // how long it lives before destroying itself
    public float damage = 10f;       // how much damage this projectile causes

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(gameObject);
        rigidBody = GetComponent<Rigidbody2D>();
        //targetVector = new Vector2(8.49f, -2.16f);
        
       // rigidBody.AddForce(targetVector.normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0f)
        {
            // we have ran out of life
            Destroy(gameObject);    // kill me
        }
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        hero.improveHealth(10);


    }*/

    //BulletTrigger


}
