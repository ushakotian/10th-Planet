using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Application.LoadLevel("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restartgame()
    {
        // restart the loaded level.
        Application.LoadLevel("SampleScene");
    }
}
