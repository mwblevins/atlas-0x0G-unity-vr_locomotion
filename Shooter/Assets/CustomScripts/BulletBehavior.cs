using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject colide;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0]; // Get the first contact point
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal); // Calculate rotation to align with surface normal

        Instantiate(colide, contact.point, rotation); // Instantiate collision flash at the point of collision
        Destroy(gameObject); // Destroy the bullet
    }
}
