using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//add in UI package in Unity Engine for Step 3.

public class Collectable : MonoBehaviour
{
    /*Ideas for this script:
  Step 1. find a model and then create a script for allowing the player to destroy the collectable when player collides with it.
  2. Let's make this more fun! Add sound. When the player collects the object, add an audio component - like maybe a chime when the object is collected to denote that it has indeed been collected.
  3. Now, add a counter to the UI to count each time you collect an item.
  4. Get creative and think of more way to make collectables exciting! Have fun creating! 
  

//Variables
  //Step 1. You don't need any variables for step 1.
  //Step 2. You will need to create variables for the audioClip and audioSource.
  //Step 3.  Set Up Your UI and add in Text Object for the Counter in Unity first then come back to this script to continue.
  //Step 3. (cont) add int Collectablecounter = 0 variable and a text collectableCounterText variable.

//Functions
  //Step 1. You will need a void onTriggerEnter(). Use a Tag to capture the player collider. Then use the Destroy(gameObject) method within the function. Attach this script to the pickup item.
  //Step 2. You need a Start() function for the audio.  inside the function, grab the audiosource variable and assign the audio Source component. Be sure to attach to current gameObject.
  The second line of code, use audioSource.clip and assign to the audioclip variable you created above.
  Last thing you must do for the audio clip to work, make sure it plays once the item is collected (or detroyed). Go to the Destroy() withing the onTriggerEnter() function and add the audioclip variable you created above.length (ex. Destroy(gameObject, collectSound.length))
  //Step 3. Talk to your instructor on what to do next following adding in the UI variables. Also, be sure to add in the UnityEngine.UI library at the top of this script.
  */
    public AudioClip krabbyPattySound;
    public AudioSource krabbyPattyEatingSound;
    // public float krabbyPattyEatingSpeed;
    public GameObject krabbyPatty;
    public TextMeshPro krabbyPattyEatingText;
    public int collectableCounter = 0;
    public TextMeshPro collectableCounterText;

    private void Start()
    {
        krabbyPattyEatingSound = gameObject.GetComponent<AudioSource>();
        krabbyPattyEatingSound.clip = krabbyPattySound;
        UpdateCollectableCounter();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectableCounter++; // Add it by 1 for each collectable that is picked up.
            UpdateCollectableCounter();
            krabbyPattyEatingSound.Play();
            Destroy (gameObject, krabbyPattySound.length);
        }
    }
    private void UpdateCollectableCounter()
    {
        if (collectableCounterText != null)
        {
           collectableCounterText.text = "Patties" + collectableCounter;
        }
    }
}
