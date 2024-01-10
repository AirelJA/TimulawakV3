using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    private bool onGround = true;
    public bool gameOver = false;
    private float horizontalMovement;
    private GameObject focalPoint;
    public float speed = 5.0f;
    private float boundary = 13.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");

        
    }

    private void Update()
    {
        // Move the player based on the input

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            onGround = false;
        }

        if (transform.position.x > boundary)
            transform.position = new Vector3(boundary, 6.5f, 6.5f);

        if (transform.position.x < -boundary)
            transform.position = new Vector3(-boundary, 290.5f, 290.5f);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        if (horizontalMovement < 0f) // Check if moving to the left
        {
            // Rotate the player by 180 degrees around the Y-axis
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        else if (horizontalMovement > 0f)
        {
            // Reset rotation if moving to the right
            transform.eulerAngles = Vector3.zero;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * Mathf.Abs(horizontalMovement));
        

        /*if (horizontalMovement > 0f)
        {
            transform.eulerAngles = Vector3.zero;
        }
        else if (horizontalMovement < 0f)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        */
        //playerRb.AddForce(focalPoint.transform.forward * speed * forwardMovement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }

        /*else if (collision.gameObject.CompareTag("deathTrigger"))
        {
            gameOver = true;
            onGround = false;
        }*/
    }
}
