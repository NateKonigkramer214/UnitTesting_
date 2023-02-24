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
    public LayerMask End;
    private bool canJump = true;

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

        // Check if the player is on the ground
        RaycastHit hit;
        bool isGrounded = Physics.Raycast(transform.position, -transform.up, out hit, 1f, groundLayer);

        // Allow the player to jump if they are on the ground and can currently jump
        if (Input.GetButtonDown("Jump") && canJump /*&& isGrounded*/)
        {
            rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
            canJump = false;
            Invoke("Jump", 1f);
        }
    }

    private void Elements()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fall"))
        {
            //Invoke("restart", 3f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Reset the ability to jump if the player lands on the ground
        if (collision.gameObject.layer == groundLayer)
        {
            canJump = true;
        }
    }

    private void Jump()
    {
        canJump = true;
    }

}