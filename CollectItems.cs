using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public AudioClip coinAudio;
    public AudioSource coinAudioSource;
    public float coinCollectSpeed = 1.0f;
    public GameObject coinObject;
    public int coinCounter = 0; // Add 1 per each coin that the player collects.
    public TextMeshPro coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinAudioSource = gameObject.GetComponent<AudioSource>();
        coinAudioSource.clip = coinAudio;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin Sound"); // Test coin sound.
            coinAudioSource.Play();
            Destroy (gameObject, coinAudio.length); // Will remove a delay when collecting the item.
        }
    }
}
