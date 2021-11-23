using UnityEngine;

public class ValidateRunWasMadeClockwise : MonoBehaviour
{
    public bool checkRun1;
    public bool checkRun2;
    public bool checkRun3;
    public bool checkRun4;

    public static ValidateRunWasMadeClockwise validateRun;

    void Awake()
    {
        validateRun = this;
    }

    public bool CheckStates()
    {
        return (checkRun1 && checkRun2 && checkRun3 && checkRun4);
    }

    public void SetStatus(string tag)
    {
        switch (tag)
        {
            case "CheckRun1":
                checkRun1 = true;
                break;
            case "CheckRun2":
                checkRun2 = true;
                break;
            case "CheckRun3":
                checkRun3 = true;
                break;
            case "CheckRun4":
                checkRun4 = true;
                break;
        }
    }
}
