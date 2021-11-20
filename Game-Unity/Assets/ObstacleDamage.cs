using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{
    public int time = 10;

    CountdownGame countDownGame;

    void Start()
    {
        countDownGame = GameObject.FindObjectOfType(typeof(CountdownGame)) as CountdownGame;
    }


    private void OnCollisionEnter(Collision collision)
    {
        countDownGame.count -= time;
       // Destroy(this.gameObject);
    }

}
