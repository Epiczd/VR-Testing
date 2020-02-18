using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody projectile;
    private float speed = 25f;
    public OVRGrabbable gun;

    public Transform currentGunPosition;

    void Start()
    {
    }

    //Shoots the bullet forward (is supposed to at least)
    void Update()
    {
        if (gun.isGrabbed && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            projectile.transform.position = Gun.CurrentPosition;

            if(currentGunPosition.transform.position == gun.grabbedTransform.forward)
            {
                GetComponent<Rigidbody>().velocity = projectile.transform.forward * speed;
            }
            else if(currentGunPosition.transform.position == gun.grabbedTransform.right)
            {
                GetComponent<Rigidbody>().velocity = projectile.transform.right * speed;
            }

        }
    }
}
