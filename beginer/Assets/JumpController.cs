using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
public class JumpController : MonoBehaviour
{
    // Start is called before the first frame update

    private float jumpPower = 3f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);    
        
    }
    }
    // private void OnCollisionEnter2D(Collision2D order)
    // {
    //     // if(order.gameObject.tag == "map")
    //     // {
            
    //     // }
    //     }
    // }
}
