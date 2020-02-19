using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    private float time = 1f;

    public Light directionalLight;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(time);

        directionalLight.color -= (Color.grey / 2.0f) * Time.deltaTime;

        time -= Time.deltaTime;

        switch (time)
        {
            case 1f:
                {
                    directionalLight.color = Color.red;
                }
                break;
            case 0.75f:
                {
                    directionalLight.color = Color.blue;
                }
                break;
            case 0.5f:
                {
                    directionalLight.color = Color.yellow;
                }
                break;
            case 0.25f:
                {
                    directionalLight.color = Color.black;
                }
                break;
            case 0f:
                {
                    time = 1f;
                }
                break;
        }
    }
}
