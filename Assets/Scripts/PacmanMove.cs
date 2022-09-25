using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMove : MonoBehaviour
{
    public Transform[] CyclePosition;
    public float speed = 3f;
    private int index = 0;


    private void FixedUpdate()
    {
        if (transform.position != CyclePosition[index].position)
        {
            Vector2 temp = Vector2.MoveTowards(transform.position, CyclePosition[index].position, speed );
        
            GetComponent<Rigidbody2D>().MovePosition(temp);
        }
        else
        {
            index = (index + 1) % CyclePosition.Length;
        }
        
       // Vector2 direction = CyclePosition[index].position - transform.position;
    }
}
