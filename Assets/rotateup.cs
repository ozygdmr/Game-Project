using System;
using System.Text.RegularExpressions;
using UnityEngine;

public class rotateup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject capsule;
    
    void Start()
    {
        
    }
    public int SensY = 300;
    float rotX = 0.0f;
    // Update is called once per frame
    void Update()
    {


        
        rotX -= Input.GetAxisRaw("Mouse Y") * SensY * Time.deltaTime;
        rotX = Mathf.Clamp(rotX, -90.0f, 90.0f);
        transform.rotation = Quaternion.Euler(rotX, transform.eulerAngles.y, 0.0f);
    }
}
