using UnityEngine;

public class IncreaseTime : MonoBehaviour
{
    public float time = 10f;
    public float currentSpeed;
    public float eixoX;
    public float eixoY;
    public float eixoZ;
    CountdownGame countDownGame;

    // Start is called before the first frame update
    void Start()
    {
        countDownGame = GameObject.FindObjectOfType(typeof(CountdownGame)) as CountdownGame;
        currentSpeed = 35f;
        eixoX = 0;
        eixoY = 5;
        eixoZ = 0;
    }

    void Update()
    {
        transform.Rotate(new Vector3(eixoX, eixoY, eixoZ) * currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        countDownGame.count += time;
        CarControler.carController.PlaySongCollectedSphereTime();
        Destroy(this.gameObject);
    }
}
