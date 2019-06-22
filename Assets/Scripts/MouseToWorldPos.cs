using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseToWorldPos : MonoBehaviour
{
    public Vector3 MousePosition;

    // Update is called once per frame
    void Update()
    {
        MousePosition = Input.mousePosition;
        MousePosition.z = Camera.main.GetComponent<Transform>().position.y;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
     //   Debug.Log(MousePosition);
    }
}
