using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //The Bullet
    public GameObject projectile;
    //Speed the bullet moves
    private float speed = 25f;
    //The Gun
    public OVRGrabbable gun;

    //GunShot Sound Effect
    [SerializeField] private AudioSource gunShot;

    //Checks for the guns current position
    public Transform currentGunPosition;

    //Shoots the bullet forward (is supposed to at least)
    void Update()
    {
        Fired();
    }

    void Fired()
    {
        while(gun.isGrabbed && OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            gunShot.Play();
            GameObject instBullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidBody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidBody.AddForce(Vector3.forward * speed);
            break;
        }
    }
}
