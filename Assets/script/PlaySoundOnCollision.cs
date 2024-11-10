using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    // Add an AudioSource component and assign it in the inspector
    public AudioSource collisionSound;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "Collidable" or any other identifier you set
        if (collisionSound != null && collision.gameObject.tag == "Collidable")
        {
            collisionSound.Play();
        }
    }
}
