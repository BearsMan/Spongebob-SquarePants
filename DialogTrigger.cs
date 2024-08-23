using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
            dialogPanel.SetActive(true);
            if (currentNPC.CompareTag("SpongeBob SquarePants"))
            {
                spongeBobText.gameObject.SetActive(true);
            }
            if (currentNPC.CompareTag("Squidward"))
            {
                squidwardText.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpongeBob SquarePants"))
        {
            spongeBobText.gameObject.SetActive(true);
        }
    }
}
