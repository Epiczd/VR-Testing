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

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            projectile.transform.position = Gun.CurrentPosition;
            GetComponent<Rigidbody>().AddForce(-transform.forward * Time.smoothDeltaTime * speed);
        }
    }
}
