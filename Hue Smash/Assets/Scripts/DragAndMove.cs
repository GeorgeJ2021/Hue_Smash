using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndMove : MonoBehaviour  
{
    private Touch touch;
    public float speedModifier;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.01f;    
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rb.MovePosition(new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z));
                   /* transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z); */
            }
        }
    }
}
