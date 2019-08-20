using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public GameObject ObjectToSnap;
    public GameManager GameManager;
    public SnapToGrid SnappingScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var objsnp = ObjectToSnap;
            Instantiate(objsnp, SnappingScript.snapPosition, Quaternion.identity);
            GameManager.RemoveMoney(objsnp.GetComponent<Placeable>().cost);
            Debug.Log("Clicked");
        }


        if (Input.GetKey(KeyCode.Alpha0))//key 0
        {
            
        }
    }
}
