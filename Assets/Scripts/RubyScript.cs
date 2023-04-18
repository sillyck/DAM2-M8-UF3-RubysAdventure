using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyScript : MonoBehaviour
{
    // Start is called before the first frame update
    float velocitat = 6.0f;
    
    void Start()
    {
    }

    // Update is called once per frame
     void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector2 position = transform.position;
        position.x = position.x + velocitat * horizontal * Time.deltaTime;
        position.y = position.y + velocitat * vertical * Time.deltaTime;
        transform.position = position;
    }
}
