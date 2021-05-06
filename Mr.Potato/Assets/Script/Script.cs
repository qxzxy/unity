using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D herobody;
  
    public float moveforce = 100;
    private float finput = 0.0f;
    public float maxSpeed = 5;
    public float jumpForce = 300;
    private bool bFaceRight = true;
    public float jumpvalue;
    private bool bGrounded=false;
    Transform mGroumdCheck;
    void Start()
    {
        herobody = GetComponent<Rigidbody2D>();
        mGroumdCheck = transform.Find("GroundCheck");
    }
    private void Awake()
    {
        herobody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        finput = Input.GetAxis("Horizontal");
        if (finput > 0 && !bFaceRight)
        {
            flip();
        }
        else if (finput < 0 && bFaceRight)
        {
            flip();
        }
        bGrounded=Physics2D.Linecast(transform.position, mGroumdCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            herobody.velocity = Vector2.up * jumpvalue;
        }*/
        //if
       // herobody.AddForce(Vector2.right * h * Moveforce);*/
    }
    private void FixedUpdate()
    {
        float finput = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        //控制移动
        if (herobody.velocity.x<maxSpeed)
        {
            rigidbody.AddForce(Vector2.right * finput * moveforce);
        }
        //限制最大速度
        if(Mathf.Abs(rigidbody.velocity.x)>maxSpeed)
        {
            rigidbody.velocity = new Vector2(Mathf.Sign(rigidbody.velocity.x * maxSpeed), rigidbody.velocity.y);
        }
        bool bJump = false;
        if (bGrounded)
        {
            bJump = Input.GetKeyDown(KeyCode.Space);
            Vector2 upForce = new Vector2(0, 1);
            if(bJump)
                herobody.AddForce(upForce * jumpForce);
        }

    }
    void flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        bFaceRight = !bFaceRight;
    }
   /* void TrackPlayer()
    {
        float 
    }*/
}
