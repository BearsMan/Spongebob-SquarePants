using System;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinCounter++; // Increment coin counter by 1 per every coin that is picked up by the player.
            UpdateCoinCounter();
            coinAudioSource.Play();
        }
    }
    private void UpdateCoinCounter()
    {
        if (coinCounter == 0)
        {
            coinAudioSource.Play(); // Stop playing after the final coin is collected.
        }
    }
}
