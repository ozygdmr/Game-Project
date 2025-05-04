using UnityEngine;

public class rotatecam : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }
    public int SensX = 300;
    float mousex=0;
    // Update is called once per frame
    void Update()
    {

        mousex += Input.GetAxisRaw("Mouse X") * SensX * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, mousex, 0);
    }
}
