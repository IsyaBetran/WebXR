using UnityEngine;
using SK.GyroscopeWebGL;

public class GyroLook : MonoBehaviour
{
    [SerializeField] private GameObject cameraObject;
    [SerializeField] private float smoothingFactor = 0.15f; // Lower = smoother, reduces drift visibility
    [SerializeField] private float driftDeadzoneThreshold = 0.01f; // Ignore very small rotations
    
    private Quaternion targetRotation;
    private Quaternion currentRotation = Quaternion.identity;
    private bool isInitialized = false;

    void OnDestroy()
    {
        SK_DeviceSensor.StopGyroscopeListener();
    }

    public void StartGyro()
    {
        try
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        catch (System.Exception ex)
        {
            Debug.LogWarning("Screen orientation lock not supported: " + ex.Message);
        }

        SK_DeviceSensor.StartGyroscopeListener(OnGyroscopeReading);
    }

    public void StopGyro()
    {
        SK_DeviceSensor.StopGyroscopeListener();
    }

    private void OnGyroscopeReading(GyroscopeData reading)
    {
        if (!isInitialized)
        {
            targetRotation = reading.UnityRotation;
            currentRotation = reading.UnityRotation;
            isInitialized = true;
            return;
        }

        targetRotation = reading.UnityRotation;
        
        // For drift reduction
        float rotationDelta = Quaternion.Angle(currentRotation, targetRotation);
        if (rotationDelta < driftDeadzoneThreshold)
        {
            return; 
        }

        currentRotation = Quaternion.Lerp(currentRotation, targetRotation, smoothingFactor);
        cameraObject.transform.rotation = currentRotation;
    }
}
