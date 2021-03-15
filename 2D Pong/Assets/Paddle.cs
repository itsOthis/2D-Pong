using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Init(bool isRightPaddle) {

        Vector2 pos = Vector2.zero;

        if (isRightPaddle) {
            // Place paddle on right side of screen
            pos = new Vector2(GameManager.topRight.x, 0);
        }
        else {
            // Place paddle on left side of screen
            pos = new Vector2(GameManager.bottomLeft.x, 0);
        }

        // Update this paddle's position
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
