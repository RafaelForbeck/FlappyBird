using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        switch (GameManager.instance.status)
        {
            case GameStatus.Start:
                break;
            case GameStatus.Play:
                PlayUpdate();
                break;
            case GameStatus.GameOver:
                break;
        }
    }
    void PlayUpdate()
    {
        transform.position += Vector3.left * Time.deltaTime * GameManager.instance.speed;

        if (transform.position.x < -2.5f)
        {
            // autodestruir
            Destroy(gameObject);
        }
    }
}
