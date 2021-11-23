using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    // 3.5 seconds
    public float delay = 3.5f;

    public void OnTriggerEnter(Collider other)
    {
        /* Before playing the victory song and redirecting the user to the "You win" screen, the timer
           is checked, as it is impossible to make the lap with 30 seconds, possibly the player tried
           to win the game by accelerating on the track in reverse to cross the finish line */
        if (CountdownGame.countdownGame.CurrentCountdown() <= 30.0f)
        {
            // Play music victory
            GetComponent<AudioSource>().Play();

            Invoke("DelayedInChangingScene", delay);
        }
    }

    void DelayedInChangingScene()
    {
        SceneManager.LoadScene("Winner");
    }
}
