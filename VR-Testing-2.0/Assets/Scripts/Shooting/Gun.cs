﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;
using UnityEngine.Audio;

public class Gun : MonoBehaviour
{
    //Determines if the gun is fired
    private bool gunFired;

    //The Bullet being fired
    public GameObject bullet;

    //The Sound Effect of the gun
    public AudioSource gun;

    //Starting Position of the gun
    public static Vector3 CurrentPosition;

    [SerializeField] protected OVRGrabbable gunOVR;

    //OnStart, the bullet is disabled
    void Start()
    {
        bullet.SetActive(false);
    }

    /* If the player pressed the right index trigger, they will fire the gun.
     * When the gun is fired, the bullet will move, and the sound effect will play
     */
    void Update()
    {
        if (gunOVR.isGrabbed)
        {
            bullet.SetActive(true);
        }

        CurrentPosition = this.transform.position;
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            gunFired = true;
            gun.Play();
        }

        /*
        if(GunCheck.gunActive == true)
        {
            bullet.SetActive(true);
        }
        else
        {
            bullet.SetActive(false);
        }
        */

        if(gunFired == true)
        {
            /*
            UpdateMovement();
            */
            Debug.Log("Fired");
        }
    }

    /*
    // When the player fires the gun, this moves the bullet forward
    void UpdateMovement()
    {
        Vector3 MovementDirection = Vector3.forward;
        bullet.transform.Translate(MovementDirection * Time.deltaTime);
    }
    */
}
