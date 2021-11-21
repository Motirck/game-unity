using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{
    // 3.5 seconds
    public float delay = 3.5f;
    public int quantityLife = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CarPlayer")
        {
            // Play music crash
            GetComponent<AudioSource>().Play();

            if (LifeDamage.damage.GetCurrentLife() != 0)
            {
                quantityLife = 10;
                LifeDamage.damage.DecreaseLife(quantityLife, collision);
            }
        }
    }
}
