using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private GameObject Hero ;
    public Text distanceCovered;
    public Text fuelCanCollected;
   
    // Start is called before the first frame update
    void Start()
    {

        //Hero = gameObject.FindObjectOfType(Hero);
        distanceCovered.text = "" + HeroManager.distance;
        fuelCanCollected.text = "" + HeroManager.fuelCanCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void populateScore(int fuelCanCount, int distance) {
        distanceCovered.text = "" + distance;
        fuelCanCollected.text = "" + fuelCanCount;

    }*/


}
