using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountdownGame : MonoBehaviour
{
    public static CountdownGame countdownGame;
    public Text displayCountdown;

    public float count = 120.0f;
    public int countSong = 0;

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
        else
        {
            displayCountdown.text = "Time's up";
            SceneManager.LoadScene("GameOver");
        }
    }

    public void PlaySongCountdown()
    {
        print("Entrou no 10");
        GetComponent<AudioSource>().Play();
    }
}
