using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftsideMovement : MonoBehaviour
{
    public static float speed = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
