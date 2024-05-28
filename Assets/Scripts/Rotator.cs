using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 0;
    
    private void Update()
    {
        transform.Rotate(0,speed * Time.deltaTime,0,Space.Self);
    }
}
