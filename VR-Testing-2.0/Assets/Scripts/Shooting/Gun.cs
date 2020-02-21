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
    }
}
