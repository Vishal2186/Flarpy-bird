using UnityEngine;

public class PipeSpwan : MonoBehaviour
{
    public GameObject pipe;
    public float SpwanRate;
    private float timer = 0;
    public float Height = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if( timer < SpwanRate )
        {
            timer += Time.deltaTime; 
        }
        else
        {
            SpwanPipe();
            timer = 0;
        }
    }
    void SpwanPipe()
    {
        float lowest = transform.position.y - Height;
        float highest = transform.position.y + Height;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowest,highest),0),transform.rotation);
    }
}

