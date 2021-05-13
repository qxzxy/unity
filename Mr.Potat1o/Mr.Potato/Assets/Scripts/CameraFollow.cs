using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTran; //主角的Transform
    public float MaxDistanceX = 2;
    public float MaxDistanceY = 2;
    public float xSpeed = 4;
    public float ySpeed = 4;
    public Vector2 maxXandY;
    public Vector2 minXandY=new Vector2(-8,-8);
    public bool NeedMoveX()
    {
        bool bMove = false;
        if (Mathf.Abs(transform.position.x - playerTran.position.x) > MaxDistanceX)
            bMove = true;
        else
            bMove = false;
        return bMove;
    }
    /*public bool NeedMoveY()
    {
        bool 
    }*/
    public  void TrackPlayer()//0.02s
    {
        float newX = transform.position.x;
        if (NeedMoveX())
        {
            newX = Mathf.Lerp(transform.position.x, playerTran.position.x, xSpeed * Time.deltaTime);
        }
        newX = Mathf.Clamp(newX, minXandY.x, maxXandY.x);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
    private void FixedUpdate()
    {
        TrackPlayer();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        //public Transform playerTran;
        //playerTran = GameObject.Find("Hero").transform;
        playerTran = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()//每帧刷新
    {
        
    }
}
