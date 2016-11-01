 using UnityEngine;
 using System.Collections;
 using UnityEngine.EventSystems;

public class Rotate : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public float xDeg, yDeg;
    public float speed;
    public float friction;
    bool mouseDown; 

    // Update is called once per frame
    void Update()
    {
        if (mouseDown == true)
        {
            xDeg -= Input.GetAxis("Mouse X") * speed * friction;
            yDeg += Input.GetAxis("Mouse Y") * speed * friction;
            Quaternion fromRotation = transform.rotation;
            Quaternion toRotation = Quaternion.Euler(0, xDeg, 0);
            transform.rotation = Quaternion.Lerp(fromRotation, toRotation, Time.deltaTime * 5.0f);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mouseDown = true; 

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mouseDown = false;
    }
}
    
