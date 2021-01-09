using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveController : MonoBehaviour
{
    float x;
    float y;
    public Vector2 vector_stop;
    Rigidbody2D rigid;
    Animator anim;
    public float speed;
    private bool playermoving;
    playerMoveController move;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Awake()
    {
        move = this;
    }

    // Update is called once per frame
    void Update()
    {
        playermoving = false;
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

    
        if(x > 0.5f || x < -0.5f)
        {
            playermoving = true;
            vector_stop = new Vector2(x, 0f);
        }
        if(y > 0.5f || y < -0.5f)
        {
            playermoving = true;
            vector_stop = new Vector2(0f, y);
            
        }
        rigid.velocity = new Vector2(x * speed, y * speed);
        anim.SetFloat("x", x);
        anim.SetFloat("y", y);
        anim.SetBool("moving", playermoving);
        anim.SetFloat("vector_x", vector_stop.x);
        anim.SetFloat("vector_y", vector_stop.y);

    }
}
