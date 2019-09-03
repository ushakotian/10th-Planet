using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCan : MonoBehaviour
{
   // public GameObject fuelCan;
    public HeroManager hero;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        hero.improveHealth(10);
       

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
