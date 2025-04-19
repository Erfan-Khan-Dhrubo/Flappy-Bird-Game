using UnityEngine;

public class bird : MonoBehaviour
{

    public Rigidbody2D birdRigidbody2D;
    public float jumpForce = 20;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidbody2D.linearVelocity = Vector2.up * jumpForce;
            // vector.up means (0,1)
        }
    }
}
