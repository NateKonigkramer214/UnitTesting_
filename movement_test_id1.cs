using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float timePlayed;
    void Start()
    {
        Elements();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }
    public float speed = 10.0f;
    void Update()
    {
        
        timePlayed += Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

        if(Input.GetAxis("Horizontal") == true){
            
        }
    }

    private void Elements()
    {
        rb = GetComponent<Rigidbody>();
    }
}
