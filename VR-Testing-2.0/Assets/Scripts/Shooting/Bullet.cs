using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject projectile;
    private float speed = 25f;
    public OVRGrabbable gun;

    public Transform currentGunPosition;

    void Start()
    {
    }

    //Shoots the bullet forward (is supposed to at least)
    void Update()
    {
        Fired();
        /*
        if (gun.isGrabbed && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            projectile.transform.position = Gun.CurrentPosition;

            // equals forward
            if(Gun.CurrentPosition == transform.forward)
            {
                GetComponent<Rigidbody>().velocity = projectile.transform.forward * speed;
            }
            else if(Gun.CurrentPosition == transform.right)
            {
                GetComponent<Rigidbody>().velocity = projectile.transform.right * speed;
            }

        }
        */
    }

    void Fired()
    {
        while(gun.isGrabbed && OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            GameObject instBullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidBody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidBody.AddForce(Vector3.forward * speed);
            break;
        }
    }
}
