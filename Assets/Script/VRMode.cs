using System;
using TMPro;
using UnityEngine;

public class VRMode : MonoBehaviour
{
    private bool gyroMode = false;
    
    [SerializeField] private GyroLook gyroScript;
    [SerializeField] private DragLook mouseScript;
    [SerializeField] private TextMeshProUGUI modeText;

    public void ChangeMode()
    {
        if (gyroMode)
        {
            gyroScript.StopGyro();
            mouseScript.enabled = true;
            modeText.text = "Change Gyro Mode";
        }
        else
        {
            gyroScript.StartGyro();
            mouseScript.enabled = false;
            modeText.text = "Change Touch Mode";
        }
        gyroMode = !gyroMode;
    }
}
