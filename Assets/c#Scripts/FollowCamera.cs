using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject heroCopy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float heroPostion  = heroCopy.transform.position.x;
        if (heroPostion > gameObject.transform.position.x) {
            gameObject.transform.position = new Vector2(heroPostion, -1.85f);
        }
    }
}
