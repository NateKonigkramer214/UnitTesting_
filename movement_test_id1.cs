using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float timePlayed;
    public GameObject EndScreen;
    public AudioSource main_music;

    void Start()
    {
        Elements();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        EndScreen.SetActive(false);
        main_music.Play();
    }
    public float speed = 10.0f;
    void Update()
    {
        
        timePlayed += Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

    }

    private void Elements()
    {
        rb = GetComponent<Rigidbody>();
    }
}