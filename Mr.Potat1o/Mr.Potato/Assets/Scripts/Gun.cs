using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rocket;
    public float fSpeed = 10;
    private PlayerControl playerCtrl;
    private Animator anim;//动画
    void Start()
    {
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }
    private void Awake()
    {
        anim = transform.root.gameObject.GetComponent<Animator>();
        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Mouse0))

        if (Input.GetButtonDown("Fire1"))
        {

            if (playerCtrl.bFaceRight)
            {
                Rigidbody2D rockectInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;//Euler旋转
                rockectInstance.velocity = new Vector2(fSpeed, 0);
            }
            else
            {
                Rigidbody2D rockectInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 180))) as Rigidbody2D;
                rockectInstance.velocity = new Vector2(-fSpeed, 0);
            }

        }
    }
}
