using UnityEngine;

public class middlePipe : MonoBehaviour
{
    public logicUpdater logic;
    public bird bird;
    
   public AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicUpdater>();
       bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<bird>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!bird.isDead)
        {
            logic.AddScore();
            source.Play();
        }
        
    }
}
