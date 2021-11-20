using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereTime : MonoBehaviour
{
    public float time = 10f;
    CountdownGame countDownGame;

    // Start is called before the first frame update
    void Start()
    {
        countDownGame = GameObject.FindObjectOfType(typeof(CountdownGame)) as CountdownGame;
    }

    private void OnTriggerEnter(Collider other)
    {
       countDownGame.count += time;
        Destroy(this.gameObject);
    }
}
