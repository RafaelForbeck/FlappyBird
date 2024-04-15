using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameManager.instance.status)
        {
            case GameStatus.Start:
                PlayUpadate();
                break;
            case GameStatus.Play:
                PlayUpadate();
                break;
            case GameStatus.GameOver:
                break;
            default:
                break;
        }
    }

    private void PlayUpadate()
    {
        transform.position += Vector3.left * GameManager.instance.speed * Time.deltaTime;

        if (transform.position.x < -0.04f)
        {
            transform.position += Vector3.right * 0.24f;
        }
    }
}
