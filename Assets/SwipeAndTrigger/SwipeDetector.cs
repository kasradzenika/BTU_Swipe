using UnityEngine;
using UnityEngine.Events;

public class SwipeDetector : MonoBehaviour
{
    public SwipeEvent swipeEvent;

    private bool isSwiping = false;
    private Vector3 swipeStartPosition;
    private Vector3 swipeDelta;
	
	void Update ()
    {
        if (isSwiping)
        {
            if (Input.GetMouseButtonUp(0))
            {
                swipeDelta = Input.mousePosition - swipeStartPosition;

                if(Mathf.Abs(swipeDelta.x) > Mathf.Abs(swipeDelta.y))
                {
                    if (swipeDelta.x > 0f)
                        swipeEvent.Invoke("right");
                    else
                        swipeEvent.Invoke("left");
                }
                else
                {
                    if (swipeDelta.y > 0f)
                        swipeEvent.Invoke("up");
                    else
                        swipeEvent.Invoke("down");
                }

                isSwiping = false;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                swipeStartPosition = Input.mousePosition;
                isSwiping = true;
            }
        }
	}
}


[System.Serializable]
public class SwipeEvent : UnityEvent<string> { }