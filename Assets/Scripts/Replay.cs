using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayGame()
    {
        // ��ư Ŭ�� �Ҹ�
        GetComponent<AudioSource>().Play();

        BirdJump.isGameOver = false;

        SceneManager.LoadScene("PlayScene");
    }
}
