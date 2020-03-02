using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockMenu : MonoBehaviour
{
    //Activates the block menu
    [SerializeField] private GameObject blockMenu;

    //The Pointer
    [SerializeField] private GameObject pointer;

    //On Start, the block menu and pointer are disabled
    void Start()
    {
        blockMenu.SetActive(false);
        pointer.SetActive(false);
    }

    //If the player presses B, they will open the block menu
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            blockMenu.SetActive(true);
            pointer.SetActive(true);
        }
    }
}
