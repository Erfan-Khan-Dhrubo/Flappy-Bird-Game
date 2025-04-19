using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float timeBetweenSpawns = 2;

    private float _timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       spawn(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < timeBetweenSpawns)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            spawn();
            _timer = 0;
        }
    }

    void spawn()
    {
        Instantiate(pipe, transform.position, transform.rotation); // ?
    }
    
    
}
