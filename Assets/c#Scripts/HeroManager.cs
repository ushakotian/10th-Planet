using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroManager : MonoBehaviour
{
    private Animator anim;
	public Text healthText;
    private Rigidbody2D rigidBody;
    public float verticalForce;
    public float horizontalForce;
    private Transform trans;
    private bool onGround;
    private int health;
    private const int MAX_HEALTH = 100;
         

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.freezeRotation = true;
        trans = GetComponent<Transform>();
        onGround = false;
        health = 100;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor") {
            if (health == 0)
            {
                anim.SetInteger("transition", 4);
            }
            else
            {
                anim.SetInteger("transition", 1);
                onGround = true;
            }
        }
        else if(collision.gameObject.name == "BulletTrigger") {
            Debug.Log("Bullet Trigger | Collider Object = " + collision.gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up") && onGround) {
            anim.SetInteger("transition", 3);
            SoundManager.playClip("jump");
            rigidBody.AddForce(new Vector2(0, verticalForce), ForceMode2D.Impulse);
            onGround = false;
        }
        if (Input.GetKey("right"))
        {
            anim.SetInteger("transition", 2);
            trans.localScale = new Vector2(1, 1);
            Vector2 currentPosition = trans.position;
            currentPosition.x = currentPosition.x + 0.2f;
            trans.position = currentPosition;
        }
        if (Input.GetKey("left"))
        {
            anim.SetInteger("transition", 2);
            trans.localScale = new Vector2(-1,1);            
            Vector2 currentPosition = trans.position;
            currentPosition.x = currentPosition.x - 0.2f;
            trans.position = currentPosition;
            
        }
        if(onGround)
            anim.SetInteger("transition", 2);
        if (health == 0)
        {
            anim.SetInteger("transition", 4); // player is dead
            Invoke("Restartgame", 0.5f);
            //Place player in the start

        }
    }

    // when the life goes to zero the hero is brought back to default position
    private void Restartgame()
    {
        // restart the loaded level.
        Application.LoadLevel("SampleScene");
    }

    //for lazer
    /*
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "lazerParent"
            || collision.gameObject.name == "lazerChild")
        {
            if (health >= 10)
            {
                SoundManager.playClip("lazerBeam");
                health =  health - 10;
                anim.SetInteger("transition", 4); // player is dead

            }
			healthText.text = "LIFE : " + health;
            Debug.Log("Fuel health is = " + health + " | Collider Object = " + collision.gameObject.name);

        }

    }*/

    public void improveHealth(int healthAdd) {
        if (health < 100)
            health += healthAdd;
        else
            health = 100;
        Debug.Log("Fuel health is = " + health );
    }

    //laser
    
    private void OnTriggerStay2D(Collider2D collision) {

        if ((collision.gameObject.name == "LazerParent") || (collision.gameObject.name == "LazerChild"))
        {
            //if (collision.gameObject.name == "LazerParent")
            {
                if (health >= 10)
                {
                    SoundManager.playClip("lazerBeam");
                    health = health - 10;


                    if (health == 0)
                        anim.SetInteger("transition", 4); // player is dead

                }
                healthText.text = "LIFE : " + health;
                Debug.Log("Fuel health is = " + health + " | Collider Object = " + collision.gameObject.name);

            }
        }

    }


}
