using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeDamage : MonoBehaviour
{
    public int life = 100;
    public static LifeDamage damage;

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

        if (life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
