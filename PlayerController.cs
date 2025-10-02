using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of player movement
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started - PlayerController attached.");
    }

    // Update is called once per frame
    void Update()
    {
        // Get player input from keyboard (WASD/Arrow Keys)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the player with frame-rate independence
        transform.Translate(movement * speed * Time.deltaTime);

        // Debug output (prints player position each frame)
        Debug.Log("Player Position: " + transform.position);
    }
}
