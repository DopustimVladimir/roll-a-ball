using System;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed = 50f;
    public Text scoreText;
    public Text completeText;

    private Rigidbody rb;
    private float moveH;
    private float moveV;
    private Vector3 movement;
    private int score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        completeText.text = "";
        score = 0;
        SetScoreText();
    }

    void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");

        movement = new Vector3(moveH, 0.0f, moveV);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroyable"))
        {
            other.gameObject.SetActive(false);
            score+= 1;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
        if (score >= 8) {
            completeText.text = "Congratulations!";
        }
    }
}
