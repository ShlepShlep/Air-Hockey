using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        if (mousePos.x > 0) mousePos.x = 0; //Limit player position to 0

        //transform.position = mousePos;
        GetComponent<Rigidbody2D>().MovePosition(mousePos);
    }
}
