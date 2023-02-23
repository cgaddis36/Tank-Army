using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePropellorX : MonoBehaviour
{
    public float propellerSpeed = 500.0f;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.forward, propellerSpeed * verticalInput * Time.deltaTime + 10);
    }
}
