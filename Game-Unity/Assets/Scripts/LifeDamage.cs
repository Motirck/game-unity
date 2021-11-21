using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeDamage : MonoBehaviour
{
    public int life = 100;
    public static LifeDamage damage;
    public Text LifeScore;

    void Awake()
    {
        damage = this;
    }

    public int GetCurrentLife()
    {
        return life;
    }

    public void DecreaseLife(int quantity, Collision other)
    {
        life -= quantity;
        print("Decrease Life, now life is: " + life);

        LifeScore.text = life.ToString();

        if (life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
