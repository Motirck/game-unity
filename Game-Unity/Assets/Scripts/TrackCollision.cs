using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackCollision : MonoBehaviour
{
    // 3.5 seconds
    public float delay = 3.5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CarPlayer")
        {
            // Play music victory
            GetComponent<AudioSource>().Play();
        }

        //// Disabling Renderer and SphereCollider to stop activating OnTrigger
        //    //// and making the object disappear from the screen
        //    //GetComponent<Renderer>().enabled = false;
        //    //GetComponent<BoxCollider>().enabled = false;

        //    //// Destroy object in 5 seconds
        //    //Destroy(gameObject, 5);

        //    //Invoke("DelayedInChangingScene", delay);
    }

    void DelayedInChangingScene()
    {
       //SceneManager.LoadScene("GameOver");
    }
}
