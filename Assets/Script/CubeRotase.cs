
using UnityEngine;

public class CubeRotase : MonoBehaviour
{
    private Camera myCam;
    private Vector3 screenPos;
    private float angleObj;
    private Collider2D col;

    private void Awake() 
    {
        myCam = Camera.main;
    }

    private void Start()
    {
        col = this.GetComponent<Collider2D>();
    }

    private void Update()
    {
        Vector3 mousePos = myCam.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            if(col == Physics2D.OverlapPoint(mousePos))
            {
                screenPos = myCam.WorldToScreenPoint(transform.position);
                Vector3 vec3 = Input.mousePosition - screenPos;
                angleObj = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y, vec3.x)) * Mathf.Rad2Deg;
            }
        }

        if(Input.GetMouseButton(0))
        {
            if(col == Physics2D.OverlapPoint(mousePos))
            {
                Vector3 vec3 = Input.mousePosition - screenPos;
                float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, 0, angle + angleObj);
            }
        }
    }
}
