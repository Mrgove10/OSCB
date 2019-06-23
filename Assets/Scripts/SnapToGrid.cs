using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{
    public GameObject ObjectToSnap;
    public Vector3 snapPosition;
    public Vector3 MousePosition;

    private void Start()
    {
        getMousePos();
        Instantiate(ObjectToSnap,MousePosition,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        getMousePos();
        snapPosition = new Vector3(Mathf.Round(MousePosition.x),Mathf.Round(0),Mathf.Round(MousePosition.z));
        ObjectToSnap.transform.position = snapPosition;
    }

    void getMousePos()
    {
        MousePosition = Input.mousePosition;
        MousePosition.z = Camera.main.GetComponent<Transform>().position.y;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
    }
}
