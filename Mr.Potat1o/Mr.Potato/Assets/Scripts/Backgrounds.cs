using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgrounds : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] backGrounds;
    public float fparallax = 0.4f;//整体
    public float layerFraction = 5f;
    public float fSmooth = 5f;
    Transform cam;
    Vector3 previousCamPos;
    public void Awake()
    {
        cam = Camera.main.transform;
    }
    private void Start()
    {
        previousCamPos = cam.position;
    }

    // Update is called once per frame
    void Update()
    {
        float fParallaxX = (previousCamPos.x - cam.position.x) * fparallax;//相反移动
        for(int i = 0; i < backGrounds.Length; i++)
        {
            float fNewX = backGrounds[i].position.x + fParallaxX * (i * layerFraction+ 1);
            Vector3 newPos = new Vector3(fNewX, backGrounds[i].position.y, backGrounds[i].position.y);
            backGrounds[i].position = Vector3.Lerp(backGrounds[i].position, newPos,fSmooth*Time.deltaTime);
        }
        previousCamPos = cam.position;
    }
}
