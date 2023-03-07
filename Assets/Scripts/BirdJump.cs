using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    GameObject Bird;

    [SerializeField]
    float JumpPower = 0.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        if (Bird.transform.position.y <= 5.5)
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Vector2.up = (0,1)
                rb.velocity = Vector2.up * JumpPower;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
