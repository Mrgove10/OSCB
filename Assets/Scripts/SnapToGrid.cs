using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{
    public PlaceObject PlaceObjectScript;
    public Vector3 snapPosition;
    public Vector3 MousePosition;
    
    private GameObject myobj;
    private void Start()
    {
        getMousePos();
        myobj = Instantiate(PlaceObjectScript.ObjectToSnap,MousePosition,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        getMousePos();
        snapPosition = new Vector3(Mathf.Round(MousePosition.x),Mathf.Round(0),Mathf.Round(MousePosition.z));
        myobj.transform.position = snapPosition;
    }

    void getMousePos()
    {
        MousePosition = Input.mousePosition;
        MousePosition.z = Camera.main.GetComponent<Transform>().position.y;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
    }
}
