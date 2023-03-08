using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayGame()
    {
        // 버튼 클릭 소리
        GetComponent<AudioSource>().Play();

        BirdJump.isGameOver = false;

        SceneManager.LoadScene("PlayScene");
    }
}
