using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public GameObject gameCamera;
    public GameObject player;

    float minDistance = 20;
    float maxDistance = 50;
    Vector3 startRelativePosition;

    // Start is called before the first frame update
    void Start()
    {
        startRelativePosition = player.transform.position - gameCamera.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float scalar = (player.transform.position - gameCamera.transform.position).magnitude;
        print(scalar);
        float func = -1*((scalar - 30)*(scalar - 10))/110 + 1;
        func = 1/Mathf.Clamp(func, 0.2f, 1);
        print(func);
        Vector3 newCamPos = player.transform.position - startRelativePosition * func * Time.deltaTime;
        this.transform.position = newCamPos;
    }
}
