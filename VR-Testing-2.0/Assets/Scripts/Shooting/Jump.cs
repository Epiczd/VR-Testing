using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Jumped();
    }

    //If the player presses the A button, they jump.
    void Jumped()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 8f, 0f), ForceMode.Impulse);
        }

        
    }
}
