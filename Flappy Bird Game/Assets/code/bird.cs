using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class bird : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text highscore;
    public GameObject highscoreText;

    public Rigidbody2D birdRigidbody2D;
    public float jumpForce = 20;

    public logicUpdater logic;
    private bool _birdIsAlive = true;

    private bool BirdIsAlive
    {
        get => _birdIsAlive;
        set
        {
            _birdIsAlive = value;
            if (!_birdIsAlive)
            {
                gameOverSound.Play();  
            }
            
        }
        
        
    }
    
    [FormerlySerializedAs("_isDead")] public bool isDead = false;

    public AudioSource gameOverSound;
    
    private float _upperDeadZone = 25;
    private float _lowerDeadZone = -22;
    
    //public AudioSource gameOverAudio;
    void Start()
    {  
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicUpdater>();
        highscore.text = "High Score: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            birdRigidbody2D.linearVelocity = Vector2.up * jumpForce;
            // vector.up means (0,1)
        }

        if (!isDead)
        {
            if (transform.position.y > _upperDeadZone || transform.position.y < _lowerDeadZone)
            {

                logic.GameOver();
                BirdIsAlive = false;
                isDead = true;
            }
        }

        

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //gameOverSound.Play();
        logic.GameOver();
        if (!isDead)
        {
            BirdIsAlive = false;
            isDead = true;
            
            int scoreValue = int.Parse(score.text);
            if (scoreValue > PlayerPrefs.GetInt("Highscore", 0))
            {
                PlayerPrefs.SetInt("Highscore", scoreValue);
                highscore.text = "High Score: " + scoreValue.ToString();
                highscoreText.SetActive(true);
            
            }
            
            
        }

        
        
       

        
    }
    
    
}
