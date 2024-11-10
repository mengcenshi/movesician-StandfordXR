using UnityEngine;

public class PlayOnCubeCollision : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the cube
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with another cube by ensuring the other object has this script
        if (collision.gameObject.GetComponent<PlayOnCubeCollision>() != null)
        {
            // Play the unique audio for this cube if it's not already playing
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Stop the audio when the cubes stop touching
        if (collision.gameObject.GetComponent<PlayOnCubeCollision>() != null)
        {
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
