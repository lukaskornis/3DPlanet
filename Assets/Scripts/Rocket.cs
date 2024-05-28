using UnityEngine;

// trails (both engines have trails and glowing cube engine material, extra wing trails)
// rocket shoots cube rockets from both holes in alternating pattern

public class Rocket : MonoBehaviour
{
    public float speed;
    public float rotateSpeed = 90;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        var inputX = Input.GetAxisRaw("Horizontal");
        var inputY = Input.GetAxisRaw("Vertical");
        transform.rotation *= Quaternion.AngleAxis(inputX * rotateSpeed * Time.deltaTime,Vector3.up);
        transform.rotation *= Quaternion.AngleAxis(-inputY * rotateSpeed * Time.deltaTime,Vector3.right);
    }
}
