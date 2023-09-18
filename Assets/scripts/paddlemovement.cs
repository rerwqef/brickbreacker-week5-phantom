using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemovement : MonoBehaviour
{
    public float leftedge;
    public float rightedge;

    public float speed;
    public GameManager manager;

   

    // Update is called once per frame
    void Update()
    {
        if (manager.gameoverd) {
            return;
        }
        float m = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * m * Time.deltaTime * speed);
        if (transform.position.x < leftedge)
        {
            transform.position = new Vector2(leftedge, transform.position.y);
        }
        if (transform.position.x > rightedge)
        {
            transform.position = new Vector2(rightedge, transform.position.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("extralife")){
            manager.updatelifes(1);//life onnu increament aavum//
            Destroy(collision.gameObject);
        }
       
    }
}
