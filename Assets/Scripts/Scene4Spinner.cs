using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Spinner : MonoBehaviour
{
    public int rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1 * rotateSpeed * Time.deltaTime, 0);
    }
}
