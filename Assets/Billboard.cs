using UnityEngine;

[ExecuteAlways]
public class Billboard : MonoBehaviour
{
    private Camera cam;
    
    void LateUpdate()
    {
        if (!cam)
        {
            cam = Camera.main;
            return;
        }
        
        transform.LookAt(cam.transform);
    }
}
