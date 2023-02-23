using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Camera mainCamera;
    public Camera driversCamera;
    private Vector3 offset = new Vector3(-1.5f, 7.5f, -9.7f);
    private Vector3 driversOffset = new Vector3(0.0f, 4.2f, 1.034f);
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void LateUpdate()
    {   
        mainCamera.transform.position = player.transform.position + offset;
        driversCamera.transform.position = player.transform.position + driversOffset;
        if(Input.GetKeyDown(switchKey)) {
          mainCamera.enabled = !mainCamera.enabled;
          driversCamera.enabled = !driversCamera.enabled;
        }
    
    }
}
