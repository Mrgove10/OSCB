using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMouvement : MonoBehaviour
{

    public float mDelta = 15.0f; // Pixels. The width border at the edge in which the movement work
    [Range(1f,50f)]
    public float mSpeed = 7.0f; // Scale. Speed of the movement
    
    // Update is called once per frame
    void Update()
    {
        
        if ( Input.mousePosition.x >= Screen.width - mDelta ) // Check if on the right edge
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.right;
            Debug.Log("going right");
        }
        
        if ( Input.mousePosition.x <= mDelta ) // Check if on the left edge
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.left;
            Debug.Log("going left");
        }
        
        if ( Input.mousePosition.y >= Screen.height - mDelta ) // Check if on the up edge
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.forward;
            Debug.Log("going up");
        }
        
        if ( Input.mousePosition.y <=  mDelta ) // Check if on the down edge
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.back;
            Debug.Log("going down");
        }
        
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // zooming in
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.down;
        }
        
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // zooming out
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.up;
        }
    }
}