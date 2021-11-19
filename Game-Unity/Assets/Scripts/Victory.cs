using UnityEngine;

public class Victory : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        // Play music victory
        GetComponent<AudioSource>().Play();
    }
}
