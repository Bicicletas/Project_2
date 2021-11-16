using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private float horizontalInput;
    //private float verticalInput;
    public float speed = 10f;
    public float xRange = 16f;
    public float menosxRange = -16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        
        if (transform.position.x < menosxRange)
        {
            transform.position = new Vector3(menosxRange, transform.position.y, transform.position.z);

        }

    }



}