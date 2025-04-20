using UnityEngine;

public class bird : MonoBehaviour
{

    public Rigidbody2D birdRigidbody2D;
    public float jumpForce = 20;

    public logicUpdater logic;
    private bool _birdIsAlive = true;
    
    private float _upperDeadZone = 25;
    private float _lowerDeadZone = -22;
    
    //public AudioSource gameOverAudio;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicUpdater>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _birdIsAlive)
        {
            birdRigidbody2D.linearVelocity = Vector2.up * jumpForce;
            // vector.up means (0,1)
        }

        if (transform.position.y > _upperDeadZone || transform.position.y < _lowerDeadZone)
        {

            logic.GameOver();
            _birdIsAlive = false;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        _birdIsAlive = false;
    }
    
    
}
