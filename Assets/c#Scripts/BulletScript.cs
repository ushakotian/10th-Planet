using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    //public GameObject hero;
    private Vector2 targetVector;
    public int speed = 50;          // The speed our bullet travels
    public float lifetime = 10f;     // how long it lives before destroying itself
    public float damage = 10f;
    private Vector2 bulletDefaultPosition;
    public GameObject hero;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
       
        //Instantiate(gameObject);
        // rigidBody = GetComponent<Rigidbody2D>();
        //targetVector = new Vector2(8.49f, -2.16f);

        // rigidBody.AddForce(targetVector.normalized * speed);
    }



    //public float interval;



    IEnumerator FlashHero()
    {
        // if (hero.activeSelf)

        // else
        hero.SetActive(false);
        healthText.text = " " + HeroManager.health;
        yield return new WaitForSeconds(0.5f);
        hero.SetActive(true);
    }

    void FlashHero1()
    {
        if (hero.activeSelf)
            hero.SetActive(false);
        else
            hero.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        bulletDefaultPosition = transform.localPosition;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Hero")
        {
            transform.localPosition = bulletDefaultPosition;
            HeroManager.health = HeroManager.health - 10;
            healthText.text = " " + HeroManager.health;
            // StartCoroutine(FlashHero());
            //InvokeRepeating("FlashHero1", 0, 0.1f);
            
        }
        gameObject.SetActive(false);
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        hero.improveHealth(10);


    }*/

    //BulletTrigger


}
