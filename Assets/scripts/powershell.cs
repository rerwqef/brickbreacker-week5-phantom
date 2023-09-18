using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powershell : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

  
    void Update()
    {
        transform.Translate(new Vector2(0f, -1f)*Time.deltaTime*speed);
        if (transform.position.y < -5.5)
        {
            Destroy(gameObject);       //after this greeen ball willbe destroyed elswe balll will goes downwords inn every frame ,it will affect fps.
        }
    }
}
