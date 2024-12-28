using UnityEngine;

public class pipeSpwan : MonoBehaviour
{
    public float deadZone = -10;
    public float MoveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ( Vector3.left * MoveSpeed ) * Time.deltaTime;
        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
