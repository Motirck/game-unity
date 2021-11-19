using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    // 3.5 seconds
    public float delay = 3.5f;

    public void OnTriggerEnter(Collider other)
    {
        // Play music victory
        GetComponent<AudioSource>().Play();

        Invoke("DelayedInChangingScene", delay);
    }

    void DelayedInChangingScene()
    {
        SceneManager.LoadScene("Winner");
    }
}
