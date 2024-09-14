using TMPro;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public GameObject dialogPanel;
    public GameObject currentNPC;
    public TextMeshProUGUI spongeBobText;
    public TextMeshProUGUI squidwardText;
    public TextMeshProUGUI patrickStarText;
    public TextMeshProUGUI garyTheSnailText;
    public TextMeshProUGUI sandyCheeksText;
    public TextMeshProUGUI mrKrabsText;
    public TextMeshProUGUI pearlText;
    public TextMeshProUGUI planktonText;
    public TextMeshProUGUI karenTheComputerWifeText;
    public TextMeshProUGUI mrsPuffText;
    public TextMeshProUGUI larryTheLobsterText;
    public TextMeshProUGUI fishAText;
    public TextMeshProUGUI fishBText;
    public TextMeshProUGUI fishCText;
    public TextMeshProUGUI fishDText;
    public TextMeshProUGUI fishEText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Creates the start of each dialog text per character.

        dialogPanel.SetActive(false);
        spongeBobText.gameObject.SetActive(false);
        squidwardText.gameObject.SetActive(false);
        // patrickStarText.gameObject.SetActive(false);
        // garyTheSnailText.gameObject.SetActive(false);
        // sandyCheeksText.gameObject.SetActive(false);
        // mrKrabsText.gameObject.SetActive(false);
        // pearlText.gameObject.SetActive(false);
        // planktonText.gameObject.SetActive(false);
        // karenTheComputerWifeText.gameObject.SetActive(false);
        // mrsPuffText.gameObject.SetActive(false);
        // larryTheLobsterText.gameObject.SetActive(false);
        // fishAText.gameObject.SetActive(false);
        // fishBText.gameObject.SetActive(false);
        // fishCText.gameObject.SetActive(false);
        // fishDText.gameObject.SetActive(false);
        // fishEText.gameObject.SetActive(false);
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
    // README! This code and other game projects will now be done as a hobby because I may no longer be taking game design classes and other class types.

    // PLEASE DO NOT ATTEMPT TO CODE THIS GAME OR ANY OTHER GAME PROJECTS, UNLESS YOU ARE DOING IT FOR FUN!
}
