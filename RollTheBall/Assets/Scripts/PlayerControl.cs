using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    public float movementSpeed = 10.0f;
    public  UnityEngine.UI.Text t;
    public UnityEngine.UI.Text w;

    private Rigidbody rb;
    private Vector3 movement;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        t.text = "Objects Collected: "+ count.ToString();
        w.gameObject.SetActive(false);
        //Debug.Log(count);
    }

    void Update()
    {
        if (count==8)
        {
            w.gameObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * movementSpeed);
    }
     
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            t.text = "Objects Collected: " + count.ToString();
            //Debug.Log(count);
        }
    }


}
