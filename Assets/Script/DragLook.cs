using UnityEngine;

public class DragLook : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector2 lastPos;
    private bool isInputActive = false;

    void Update()
    {
        // Handle touch input for mobile devices
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Began)
            {
                lastPos = touch.position;
                isInputActive = true;
            }
            
            if (touch.phase == TouchPhase.Moved && isInputActive)
            {
                Vector2 delta = touch.position - lastPos;
                transform.Rotate(Vector3.up, -delta.x * speed, Space.World);
                transform.Rotate(Vector3.right, delta.y * speed, Space.Self);
                lastPos = touch.position;
            }
            
            if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isInputActive = false;
            }
        }
        // Handle mouse input 
        else if (Input.GetMouseButtonDown(0))
        {
            lastPos = Input.mousePosition;
            isInputActive = true;
        }
        else if (Input.GetMouseButton(0) && isInputActive)
        {
            Vector2 delta = (Vector2)Input.mousePosition - lastPos;
            transform.Rotate(Vector3.up, -delta.x * speed, Space.World);
            transform.Rotate(Vector3.right, delta.y * speed, Space.Self);
            lastPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isInputActive = false;
        }
    }
}