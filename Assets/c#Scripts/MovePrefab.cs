using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrefab : MonoBehaviour
{
    public GameObject prefabToMove;
    public GameObject currentPrefab;
    public bool isFirstTrigger;
    
    private float incrementX = 50.47f;

    public bool IsFirstTrigger { get => isFirstTrigger; set => isFirstTrigger = value; }

    //  private bool isTriggerAdded = false;
    // Start is called before the first frame update
    void Start()
    {
        //IsFirstTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsFirstTrigger)
        {
            IsFirstTrigger = false;
        }
        else
        {
            Vector2 temp = new Vector2(currentPrefab.transform.position.x + incrementX, currentPrefab.transform.position.y);
            //  Vector2 temp = new Vector2(81.71f,0.27f);
            prefabToMove.transform.position = temp;
        }
       
        
    }


}
