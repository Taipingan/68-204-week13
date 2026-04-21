using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float move;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(move * moveSpeed, rb2d.linearVelocityY);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocityX, rb2d.linearVelocityY));
            Debug.Log("Jump");
        }
    }
}
