using UnityEngine;

public class CheckRunWasMadeClockwise : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        ValidateRunWasMadeClockwise.validateRun.SetStatus(gameObject.tag);
    }
}
