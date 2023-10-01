using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Gates")){
            print("Goal!");

            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (collision.gameObject.name.Contains("Player Gates"))
        {

        }

        if (collision.gameObject.name.Contains("Enemy Gates"))
        {

        }
    }
}
