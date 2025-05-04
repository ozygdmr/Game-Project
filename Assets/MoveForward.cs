using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject capsule;
    void Start()
    {
        capsule = GameObject.Find("Capsule");
    }
    public int speed = 300;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.position += capsule.transform.forward * speed * Time.deltaTime;
        }
        
    }
}
