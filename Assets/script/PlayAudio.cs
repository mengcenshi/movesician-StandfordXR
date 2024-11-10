using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Use this script to play audio when an object is collided with by the Player
// Create a trigger box (Cube) and check "Is Trigger"
// Attach this script to trigger box
// Create an Empty Game Object, call it "AudioSource_01"
// Make sure "Play on Awake" IS TICKED
// Add an Audio Source component to AudioSource_01
// Drag the audio file you want to play to the Audio Clip field
// In Hierarchy select the trigger box
// Locate the PlayAudio script component
// Drag the AudioSource_01 to the "Audio To Play" field in the script
// Test. Hit Play and collide into the trigger

public class PlayAudio : MonoBehaviour
{
    public GameObject AudioToPlay;
    void Start()
    {
        AudioToPlay.SetActive(false);

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
            AudioToPlay.SetActive(true);
    }
}
