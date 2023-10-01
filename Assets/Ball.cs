using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    int PlayerScore = 0;
    int EnemyScore = 0;

    public TMP_Text EnemyScoreText;
    public TMP_Text PlayerScoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        /*if (collision.gameObject.name.Contains("Gates")){
            print("Goal!");

            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }*/

        if (collision.gameObject.name.Contains("Player Gates"))
        {
            print("Enemy Goal!");

            EnemyScore += 1;
            EnemyScoreText.text = EnemyScore.ToString();
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (collision.gameObject.name.Contains("Enemy Gates"))
        {
            print("Player Goal!");

            PlayerScore += 1;
            PlayerScoreText.text = PlayerScore.ToString();
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
