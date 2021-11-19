using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownGame : MonoBehaviour
{
    public Text displayCountdown;

    public float count = 120.0f;

    void Update()
    {
        if (count > 0.0f)
        {
            count -= Time.deltaTime;
            displayCountdown.text = count.ToString("F2");
        }
        else
        {
            displayCountdown.text = "Time's up";
            SceneManager.LoadScene("GameOver");
        }
    }
}
