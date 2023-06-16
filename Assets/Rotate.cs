using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private bool ShouldRotate = false;
    [SerializeField] private float Angle = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ShouldRotate)
        {
            transform.Rotate(new Vector3(0, Angle, 0));
        }
    }
}
