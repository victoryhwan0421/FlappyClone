using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.Animations;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    GameObject Bird;

    [SerializeField]
    float JumpPower = 0.0f;

    
    public static bool isGameOver = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("is GameOver?:  " + isGameOver);
    }

    void Update()
    {
        if (Bird.transform.position.y <= 5.5)
        {
            if (Input.GetMouseButtonDown(0))
            {

                GetComponent<AudioSource>().Play();
                // Vector2.up = (0,1)
                rb.velocity = Vector2.up * JumpPower;
            }
        }
    }

    /// <summary>
    /// bird 가 충돌 시, 발생하는 코드 
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGameOver = true;
        Debug.Log("is GameOver?:  " + isGameOver);

        // best score 기록 
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }
        Invoke("LoadGameOverScene", 0.3f);


    }

    private void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
