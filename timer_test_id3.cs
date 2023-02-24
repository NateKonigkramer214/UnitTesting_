using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 10.0f;
    private float timePlayed;

    public LayerMask groundLayer;
    private bool canJump = true;
    public Text timeText;
    private float timer = 0f;

    void Start()
    {
        Elements();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }
    void Update()
    { 
        timePlayed += Time.deltaTime;
        timer += Time.deltaTime;

        // Format the time as minutes and seconds
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = Mathf.Floor(timer % 60).ToString("00");

        // Update the text component with the formatted time
        timeText.text = string.Format("{0}:{1}", minutes, seconds);
    }
}      
       
       
       
       
       
       
       
       
       
       
       
       
       
       
       
