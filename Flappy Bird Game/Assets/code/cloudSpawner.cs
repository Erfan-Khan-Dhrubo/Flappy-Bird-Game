using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float timeBetweenSpawns = 5;
    public float heightOffset = 15;

    private float _timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn(); 
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
            Spawn();
            _timer = 0;
        }
    }

    void Spawn()
    {
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation); // ?
    }
}
