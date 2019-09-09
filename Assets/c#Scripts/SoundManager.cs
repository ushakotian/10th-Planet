using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip LazerGunFire, PowerUpSound, characterJump, DieSound, LazerBeamSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        PowerUpSound = Resources.Load<AudioClip>("healthPickup");
        characterJump = Resources.Load<AudioClip>("Player-jump1");
        LazerBeamSound = Resources.Load<AudioClip>("ROBOTIC Short Burst 01 Zoom (stereo)");
		// DieSound = Resources.Load<AudioClip>("die");
		//LazerGunFire = Resources.Load<AudioClip>("gunFire");

        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playClip(string clip) {

        switch (clip) {

            case "jump":
                audioSrc.PlayOneShot(characterJump);
                break;

            case "powerUp":
                audioSrc.PlayOneShot(PowerUpSound);
                break;

            case "lazerBeam":
                audioSrc.PlayOneShot(LazerBeamSound);
                break;

            /*
            case "die":
                audioSrc.PlayOneShot(DieSound);
                break;

			case "gunFire":
				audioSrc.PlayOneShot(LazerGunFire);
				break;*/
        }

    }

}
