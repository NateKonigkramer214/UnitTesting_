/* Basic Unit Test Code for Movement */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Test]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    void Start() {
        Elements();
    }

    void Update() 
    {
        //Getting the input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Transforming the position of the player
        transform.position = transform.position + new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }

    private void Elements()
    {
        rb = GetComponent<Rigidbody>()
    }

}