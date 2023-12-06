using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BikeController : MonoBehaviour
{
    [SerializeField]
    float speed = 5.5f;
    
     [SerializeField]
    int healthMax = 3;
    int healthCurrent;
    

    // Start is called before the first frame update
    void Start()
    {
        healthCurrent = healthMax;
    }
    

    // Update is called once per frame
    void Update()
    {
        //Vroom
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movementX = new Vector2(moveX, 0);
        Vector2 movementY = new Vector2(0, moveY);

        Vector2 movement = movementX + movementY;

        transform.Translate(movement * speed * Time.deltaTime);

        if (Mathf.Abs(transform.position.x) > 11)
        {
            transform.Translate(-movementX * speed * Time.deltaTime);
        }

        if (Mathf.Abs(transform.position.y) > 4.5)
        {
            transform.Translate(-movementY * speed * Time.deltaTime);
        }   
    }
    
         //Destroying objects

       void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            healthCurrent--;
            if (healthCurrent == 0)
            {
             Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            
        }
    }
}