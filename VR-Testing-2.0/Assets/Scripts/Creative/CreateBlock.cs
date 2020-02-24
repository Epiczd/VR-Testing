using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBlock : MonoBehaviour
{
    //Activates the block menu
    [SerializeField] private GameObject blockMenu;

    //On Start, the block menu is disabled
    void Start()
    {
        blockMenu.SetActive(false);
    }

    //If the player presses B, they will open the block menu
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            blockMenu.SetActive(true);
        }
    }
}
