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
        // Check if on the right edge
        if ( Input.mousePosition.x >= Screen.width - mDelta )
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.right;
            Debug.Log("going right");
        }
        
        // Check if on the left edge
        if ( Input.mousePosition.x <= mDelta )
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.left;
            Debug.Log("going left");
        }
        
        // Check if on the up edge
        if ( Input.mousePosition.y >= Screen.height - mDelta )
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.forward;
            Debug.Log("going up");
        }
        
        // Check if on the down edge
        if ( Input.mousePosition.y <=  mDelta )
        {
            Camera.main.transform.position += Time.deltaTime * mSpeed * Vector3.back;
            Debug.Log("going down");
        }
    }
}