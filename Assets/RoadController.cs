using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    
    [SerializeField]
    float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 movement = new Vector3(0, -0.7f);
        transform.Translate(movement * speed * Time.deltaTime);
        if (transform.position.y < -18)
        {
        Vector3 pos = new Vector3(-0.5986f, 21, 2);
        transform.position = pos;
        }
    }
}
