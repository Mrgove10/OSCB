using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{
    public GameObject ObjectToSnap;

    public MouseToWorldPos Mousescript;

    public Vector3 snapPosition;

    // Update is called once per frame
    void Update()
    { 
        snapPosition = new Vector3(Mathf.Round(Mousescript.MousePosition.x),Mathf.Round(0),Mathf.Round(Mousescript.MousePosition.z));
        ObjectToSnap.transform.position = snapPosition;
    }
}
