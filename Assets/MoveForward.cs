using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Start()
    {
        
        myrigid = this.GetComponent<Rigidbody>();
        myrigid.maxLinearVelocity = angular;
        
    }
    public int speed;
    public Rigidbody myrigid;
    public float playerheight;
    private RaycastHit hit;
    public float angular;
    public float damp;
    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(this.transform.position, Vector3.down, out hit,2f*0.5f+0.2f);
        if (Input.GetKey(KeyCode.W) && hit.collider.CompareTag("Ground")) {
            myrigid.linearVelocity += transform.forward * speed * Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.Space)&& hit.collider.CompareTag("Ground"))
        {
            myrigid.AddForce(Vector3.up,ForceMode.Impulse);

        }
        if (Input.GetKey(KeyCode.A) && hit.collider.CompareTag("Ground"))
        {
            
            myrigid.linearVelocity -= transform.right  * speed * Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.S) && hit.collider.CompareTag("Ground"))
        {
            myrigid.linearVelocity -= transform.forward * speed * Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.D) && hit.collider.CompareTag("Ground"))
        {
            myrigid.linearVelocity += transform.right * speed * Time.deltaTime;
            
        }
        
        if(hit.collider.CompareTag("Ground"))
        {
            myrigid.linearDamping = damp;
        }
    }
}
