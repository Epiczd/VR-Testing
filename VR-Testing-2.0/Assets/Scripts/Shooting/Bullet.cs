using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody projectile;
    private float speed = 25f;

    void Start()
    {
    }

    //Shoots the bullet forward (is supposed to at least)
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            projectile.transform.position = Gun.CurrentPosition;
            GetComponent<Rigidbody>().AddForce(transform.eulerAngles * speed);

        }
    }
}
