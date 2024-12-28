using UnityEngine;
using UnityEngine.PlayerLoop;

public class bird : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrenth = 5;
    public logicscript logic;
    bool BirdIsAlive = true;
    public AudioSource music;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
          if(transform.position.y < -3.4)
        {
            logic.GameOver();
            BirdIsAlive = false;
        }
        if(Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            myrigidbody.linearVelocity = Vector2.up * flapStrenth;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        BirdIsAlive = false;
    }
}
