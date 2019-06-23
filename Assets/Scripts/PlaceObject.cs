using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public GameObject ObjectToSnap;
    
    public SnapToGrid SnappingScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var objsnp = ObjectToSnap;
           // objsnp.GetComponent<Renderer>().material.color = Random.ColorHSV();
            Instantiate(objsnp, SnappingScript.snapPosition, Quaternion.identity);
            Debug.Log("Clicked");
        }
    }
}
