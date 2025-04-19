using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float timeBetweenSpawns = 3;
    public float heightOffset = 15;

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
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation); // ?
    }
    
    
}
