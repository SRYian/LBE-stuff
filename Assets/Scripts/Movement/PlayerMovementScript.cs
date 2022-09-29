using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Vector2 inputDirection;
    [SerializeField]private float speed=3.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        //Get component from the objects attached
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Move();
        
    }

    private void Move()
    {   
        //Decalre variable for capturing input(unity eventsystem)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //Debug.Log(horizontal + " " + vertical);
        //Make a full stop
        // if (horizontal==0 && vertical==0)
        // {
        //     rb.velocity = new Vector2(0,0);
        //     return;
        // }
        //Normalize input directions
        inputDirection = new Vector2(horizontal, vertical).normalized;
        //Set velocity
        rb.velocity = inputDirection * speed;
    }

}
