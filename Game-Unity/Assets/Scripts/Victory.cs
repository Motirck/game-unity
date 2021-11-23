using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    // 3.5 seconds
    public float delay = 3.5f;
    public bool crossedFinishLine = false;
    public static Victory victory;

    void Awake()
    {
        victory = this;
    }

    public void OnTriggerEnter(Collider other)
    {
        // Checks if the car's turn was made in a clockwise direction on the track.
        if (ValidateRunWasMadeClockwise.validateRun.CheckStates())
        {
            // Play music victory
            GetComponent<AudioSource>().Play();

            crossedFinishLine = true;

            Invoke("DelayedInChangingScene", delay);
        }
    }

    void DelayedInChangingScene()
    {
        SceneManager.LoadScene("Winner");
    }

    public bool CrossedFinishLine()
    {
        return crossedFinishLine;
    }
}
