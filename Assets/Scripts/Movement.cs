using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // get input from player
    // apply movement to sprite

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");  // A & D or Arrow Left & Right
        float vertical = Input.GetAxisRaw("Vertical");      // W & S or Arrow Up & Down

        Vector3 direction = new Vector2(horizontal, vertical);

        transform.position += direction * speed * Time.deltaTime;
    }
}
