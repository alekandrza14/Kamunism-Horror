using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fristPersonControler : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject[] g;
    public GameObject infoGrab;
    public static int money;
    public Text moneyCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyCounter.text = "Тевро : " + money;
        Ray r = new Ray(transform.position,Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(r,out hit))
        {
            if (hit.distance <= 1.5f && Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up*(50 * Time.deltaTime), ForceMode.Impulse);
            }
        }
        Ray r2 = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit2;
        if (Physics.Raycast(r2, out hit2))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {



                if (GrabPoint.grabedObj == null)
                {
                    if (hit2.collider != null)
                    {
                        GrabPoint.grabedObj = hit2.collider.gameObject;
                    }
                }
                else
                {
                    GrabPoint.grabedObj = null;
                }
            }
            if (hit2.collider.GetComponent<Rigidbody>())
            {
                infoGrab.SetActive(true);
            }
            else
            {
                infoGrab.SetActive(false);
            }
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {


                g[0].transform.Rotate(0, Input.GetAxisRaw("Mouse X") * (150f * Time.fixedDeltaTime), 0);
                g[1].transform.Rotate(-Input.GetAxisRaw("Mouse Y") * (150f * Time.fixedDeltaTime), 0, 0);
           
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Cursor.lockState = CursorLockMode.None;
        }
       if((rb.linearVelocity.x+ rb.linearVelocity.z) <= 1) rb.MovePosition( ((transform.right * Input.GetAxisRaw("Horizontal")+ transform.forward * Input.GetAxisRaw("Vertical"))/6)+transform.position);
      
    }
}
