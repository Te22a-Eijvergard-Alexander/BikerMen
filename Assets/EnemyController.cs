using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    float speed = 3f;



    void Start()
    {
        float x = Random.Range(-10f, 10f);
        Vector2 pos = new Vector2(x, 11);
        transform.position = pos;

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 movement = new Vector2(0, -0.7f);
        transform.Translate(movement * speed * Time.deltaTime);
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
