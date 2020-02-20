using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    //Destructable Game Objects
    [SerializeField] private GameObject DestructableObject;

    //Particles of the destroyed object
    [SerializeField] private GameObject[] particles;

    //If the object is shot, it will be destroyed, and particles will emit from the former object
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            //Destroys the object
            Destroy(DestructableObject);

            //Sets particles active after object is destroyed
            for (int i = 0; i < 4; i++)
            {
                particles[i].SetActive(true);
                i++;
            }
        }
    }
}
