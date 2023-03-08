using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;

    public static int bestscore = 0;

    void Start()
    {
        score = 0; // 게임 시작 시, score 초기화 
    }

    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}
