using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class RotateLerp : MonoBehaviour
{
    //public float rotationSpeed = 8;  //This will determine max rotation speed, you can adjust in the inspector

    public Camera cam;  //Drag the camera object here

    public bool mouseDown;
    float yDeg, xDeg;
    public int speed = 1;
    public float friction = 3;
    public float lerpSpeed = 10;
    public float angle = 0f;



    void Update()
    {
        //If you want to prevent rotation, just don't call this method
        //if (mouseDown == true) RotateObject(); else Debug.Log("Poop");
        //if (mouseDown == true) RotateTransform(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")); 
       // else RotateTransform(0f, 0f);

        //Debug.Log("xDeg = " + xDeg);
        //Debug.Log("yDeg = " + xDeg);
        Debug.Log("Angle = " + angle);



    }

   // void RotateTransform(float xNum, float yNum)
    //{
        //xDeg -= xNum * speed * friction;
        //yDeg -= yNum * speed * friction; 


        //Get mouse position
        //Vector3 mousePos = Input.mousePosition;

        //Adjust mouse z position
        //mousePos.z = cam.transform.position.y - transform.position.y;

        //Get a world position for the mouse
       // Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mousePos);

        //Quaternion fromRotation = transform.rotation;

        //angle = -Mathf.Atan2(transform.position.z - mouseWorldPos.z, transform.position.x - mouseWorldPos.x) * Mathf.Rad2Deg;
        //Quaternion newAngle = Quaternion.Euler(0, angle * xDeg, 0);
        //Quaternion toRotation = Quaternion.Euler(0, xDeg + yDeg, 0); 


        //Get the angle to rotate and rotate
         //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, angle, 0), Time.deltaTime * lerpSpeed);
    //}

    public void OnMouseUp()
    {

        //MAKE IT SO ON MOUSE UP IT LERPS FROM CURRENT ANGLE TO 0?
         
        mouseDown = true;
        Debug.Log("Down");
        //Get mouse position
        Vector3 mousePos = Input.mousePosition;

        //Adjust mouse z position
        mousePos.z = cam.transform.position.y - transform.position.y;

        //Get a world position for the mouse
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mousePos);

        //Quaternion fromRotation = transform.rotation;

        angle = -Mathf.Atan2(transform.position.z - mouseWorldPos.z, transform.position.x - mouseWorldPos.x) * Mathf.Rad2Deg;
        //Quaternion newAngle = Quaternion.Euler(0, angle * xDeg, 0);
        //Quaternion toRotation = Quaternion.Euler(0, xDeg + yDeg, 0); 


        //Get the angle to rotate and rotate
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, angle, 0), Time.deltaTime * lerpSpeed);
    }

    public void OnMouseDrag()
    {
        mouseDown = true;
        Debug.Log("Down");
                //Get mouse position
        Vector3 mousePos = Input.mousePosition;

        //Adjust mouse z position
        mousePos.z = cam.transform.position.y - transform.position.y;

        //Get a world position for the mouse
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mousePos);

        //Quaternion fromRotation = transform.rotation;

        angle = -Mathf.Atan2(transform.position.z - mouseWorldPos.z, transform.position.x - mouseWorldPos.x) * Mathf.Rad2Deg;
        //Quaternion newAngle = Quaternion.Euler(0, angle * xDeg, 0);
        //Quaternion toRotation = Quaternion.Euler(0, xDeg + yDeg, 0); 


        //Get the angle to rotate and rotate
         transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, angle, 0), Time.deltaTime * lerpSpeed);
    }


}