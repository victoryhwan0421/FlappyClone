using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    [SerializeField]
    GameObject Pipe;

    [SerializeField]
    float timeDiff;

    [SerializeField]
    float Time_DestroyPipe = 0.0f;


    float timer = 0.0f;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime; // Time.deltaTime 이 계속 더해져 1이되면 1초
        if (timer > timeDiff)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = new Vector3(6, Random.Range(-2.8f, 3.2f), 0);
            timer = 0.0f;
            Destroy(newPipe, Time_DestroyPipe);
        }
    }
}
