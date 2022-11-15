
using UnityEngine;

public class CubeRotase : MonoBehaviour
{
    [SerializeField] private Vector3 mousePosition;

    private void OnMouseDrag() 
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z= Camera.main.nearClipPlane + 4;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 ojbPos = new Vector3(mousePosition.x, mousePosition.y ); 
        transform.up = ojbPos;

    }
}
