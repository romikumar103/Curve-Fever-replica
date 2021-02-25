using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float s_speed = 3f;
    public float rotationSpeed = 200f;
    float horizontal = 0f;

   

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * s_speed * Time.fixedDeltaTime,Space.Self);
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "killsPlayer")
        {
            s_speed = 0f;
            rotationSpeed = 0f;

            GameObject.FindObjectOfType<GameManager>().EndGame();
          
        }
    }
}
