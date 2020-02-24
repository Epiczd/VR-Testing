using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBlock : MonoBehaviour
{
    //Blocks created by the player
    [SerializeField] private GameObject block;

    [SerializeField] private Button createButton;

    //OnStart, the block is disabled
    void Start()
    {
        block.SetActive(false);
        createButton.onClick.AddListener(OnClick);
    }

    /* When the player clicks the create block button,
     * it will ask how many blocks they want to create (future feature).
     * The game will then instantiate the amount of blocks requested from the player
     */
    public void Update(float numOfBlocks)
    {
        OnClick();
        for (int i = 0; i < numOfBlocks; i++)
        {
            GameObject blockCreate = Instantiate(block, transform.position, Quaternion.identity) as GameObject;
            i++;
        }
    }

    //When the button is clicked, it sets the block active
    void OnClick()
    {
        block.SetActive(true);
    }
}
