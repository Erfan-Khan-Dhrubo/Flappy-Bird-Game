using UnityEngine;

public class middlePipe : MonoBehaviour
{
    public logicUpdater logic;
    
   public AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicUpdater>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.AddScore();
        source.Play();
    }
}
