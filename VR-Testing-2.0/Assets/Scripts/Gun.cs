using System.Collections;
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
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            gunFired = true;
            gun.Play();
            bullet.SetActive(true);
            
        }

        if(gunFired == true)
        {
            UpdateMovement();
            Debug.Log("Fired");
        }
    }

    // When the player fires the gun, this moves the bullet forward
    void UpdateMovement()
    {
        Vector3 MovementDirection = Vector3.forward;
        bullet.transform.Translate(MovementDirection * Time.deltaTime);
    }
}
