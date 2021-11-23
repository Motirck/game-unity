using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountdownGame : MonoBehaviour
{
    public static CountdownGame countdownGame;
    public Text displayCountdown;

    public float count = 60.0f;
    public int countSong = 0;

    void Awake()
    {
        countdownGame = this;
    }

    void Update()
    {
        if (count <= 11.5f && countSong == 0)
        {
            countSong++;
            PlaySongCountdown();
        }
        if (count > 0.0f)
        {
            count -= Time.deltaTime;
            displayCountdown.text = count.ToString("F2");
        }
        else if (!Victory.victory.CrossedFinishLine())
        {
            displayCountdown.text = "Time's up";
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            displayCountdown.text = "0.00";
        }
    }

    public float CurrentCountdown()
    {
        return count;
    }

    public void IncreaseCountdown(float time)
    {
        count += time;
        countSong = 0;
        GetComponent<AudioSource>().Stop();
    }

    public void PlaySongCountdown()
    {
        GetComponent<AudioSource>().Play();
    }
}
