using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Rigidbody2D rb;
    private float rad;
    public GameObject hero;
    private float shotDelayTime = 1.0f;
    private float fireForce = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetChild(0).gameObject.GetComponent<Rigidbody2D>(); // gun object
        transform.GetChild(0).gameObject.SetActive(true);
        AdjustAngle(new Vector3(0.0f, 0.0f, 0.0f));
        InvokeRepeating("StartShooting", 2.0f, shotDelayTime *  1.0f );
    }

    // Update is called once per frame
    void Update()
    {
        AdjustAngle(hero.transform.position);
        shotBullet();
    }

    private void StartShooting()
    {
        transform.GetComponent<Animator>().SetTrigger("shot");
        //shotBullet();
        //if (((IsInView(transform.parent.parent.GetChild(0).position)) | (IsInView(transform.position))))
        {
            //
        }
    }

    public void shotBullet()
    {
        //if (GlobalVariables.liveFlag)
        {
            
            float currRad = rad;
            if(rb!= null)
                rb.AddForce(new Vector2(-fireForce * Mathf.Cos(currRad), -fireForce * Mathf.Sin(currRad)), ForceMode2D.Impulse);

           // audio.PlayOneShot(GlobalVariables.shotAudio);
        }
    }

    private void AdjustAngle(Vector3 targetPosition)
    {
        Vector2 direction = targetPosition - transform.position;
        rad = Mathf.Atan(direction.y / direction.x);
        transform.parent.eulerAngles = new Vector3(0f, 0f, rad * Mathf.Rad2Deg);
    }

    private bool IsInView(Vector2 objPosition)
    {
        if ((objPosition.x >= Camera.main.transform.position.x - 6.5f)
            & (objPosition.x <= Camera.main.transform.position.x + 6.5f)
            & (objPosition.y > Camera.main.transform.position.y - 5.0f)
            & (objPosition.y <= Camera.main.transform.position.y + 5.0f))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
