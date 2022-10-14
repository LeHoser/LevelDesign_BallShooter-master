using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionDown = new Vector3(0, -1 * moveSpeed * Time.deltaTime, 0);
        Vector3 directionUp = new Vector3(0,1 * moveSpeed * Time.deltaTime, 0);

        if(transform.position.y >= 6.67f)
        {
            transform.Translate(directionDown);
        }
        else if(transform.position.y <= 2.21f)
        {
            transform.Translate(directionUp);
        }
    }
}
