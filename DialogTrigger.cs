using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public GameObject dialogPanel;
    public GameObject currentNPC;
    public TextMeshProUGUI spongeBobText;
    public TextMeshProUGUI squidwardText;
    public TextMeshProUGUI patrickStarText; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogPanel.SetActive(false);
        spongeBobText.gameObject.SetActive(false);
        squidwardText.gameObject.SetActive(false);
        patrickStarText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Set each dialog panel to the correct NPC model.

            dialogPanel.SetActive(true);
            if (currentNPC.CompareTag("SpongeBob SquarePants"))
            {
                spongeBobText.gameObject.SetActive(true); // Set this to false in the Unity editor if you do not want the text to appear.
            }
            if (currentNPC.CompareTag("Squidward"))
            {
                squidwardText.gameObject.SetActive(true); // Set this to false in the Unity editor if you do not want the text to appear.
            }
            if (currentNPC.CompareTag("Patrick Star"))
            {
                patrickStarText.gameObject.SetActive(true); // Set this to false in the Unity editor if you do not want the text to appear.
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // Set each compare tag to the correct model dialog.

        if (other.CompareTag("SpongeBob SquarePants"))
        {
            spongeBobText.gameObject.SetActive(true);
        }
        if (other.CompareTag("Squidward Tentacles"))
        {
            squidwardText.gameObject.SetActive(true);
        }
        if (other.CompareTag("Patrick Star"))
        {
            patrickStarText.gameObject.SetActive(true);
        }
    }
}
