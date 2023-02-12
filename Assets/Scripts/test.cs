using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public GameObject player;
    public float speed = 40;
    public float tilt = 40;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tiltVector = new Vector3(0,0,0);

        if(Input.GetKey("w")){
            tiltVector = tiltVector + new Vector3(-1,0,0);
        } 
        if(Input.GetKey("s")){
            tiltVector = tiltVector + new Vector3(1,0,0);
        } 
        if(Input.GetKey("d")){
            tiltVector = tiltVector + new Vector3(0,0,-1);
        } 
        if(Input.GetKey("a")){
            tiltVector = tiltVector + new Vector3(0,0,1);
        } 
        player.transform.position += (player.transform.forward * speed) * Time.deltaTime;
        player.transform.Rotate((tiltVector) * tilt * Time.deltaTime);
    }
}
