using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    public GameManager manager;
    public Transform explotion;
    public Transform ballinpaddle;
    public bool inplay;
    public Rigidbody2D rb;
    public Transform powerup;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.gameoverd)
        {
            return;//it will return//nothing will not work in update method

        }
        if (!inplay)
        {
          transform.position=ballinpaddle.position;
        }
        if(Input.GetKeyDown(KeyCode.Space)&&!inplay) {
            inplay = true;
            rb.AddForce(Vector2.up * 400);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("outtracker"))
        {
            rb.velocity = Vector2.zero;
            inplay = false;
            manager.updatelifes(-1);//whyen plyer collided with with outtracker collider life will be decresed by -1
        }
    }
   private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("brike"))
        {
            brikescript breakscript = collision.gameObject.GetComponent<brikescript>();
            if (breakscript.breakhit > 1)
            {
                breakscript.breacker();
            }
            else
            {
                //green ball script

                int randomchance = Random.Range(1, 101);
                if (randomchance < 25)
                {
                    Instantiate(powerup, collision.transform.position, collision.transform.rotation);
                }
                Transform m = Instantiate(explotion, collision.transform.position, collision.transform.rotation);
                Destroy(m.gameObject, 2.5f);

                manager.scoreupdater(breakscript.point);
                manager.ubdatednumberofbriks();
                Destroy(collision.gameObject);
            }
        }
    }
}
