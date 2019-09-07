using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrefab : MonoBehaviour
{
    public GameObject prefabToMove;
    public GameObject currentPrefab;
    public bool isFirstPrefab;
    public GameObject fuelCanAnim;
    
    private float incrementX = 50.47f;

    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isFirstPrefab)
        {
            isFirstPrefab = false;
        }
        else
        {
            Vector2 temp = new Vector2(currentPrefab.transform.position.x + incrementX, currentPrefab.transform.position.y);
            //  Vector2 temp = new Vector2(81.71f,0.27f);
            prefabToMove.transform.position = temp;
            fuelCanAnim.SetActive(true);
        }
       
        
    }


}
