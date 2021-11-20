using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackCollision : MonoBehaviour
{
    // 3.5 seconds
    public float delay = 3.5f;
    public int quantityLife = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CarPlayer")
        {
            // Play music victory
            GetComponent<AudioSource>().Play();

            if (LifeDamage.damage.GetCurrentLife() != 0)
            {
                quantityLife = 20;
                LifeDamage.damage.DecreaseLife(quantityLife, collision);
            }
        }
    }
}
