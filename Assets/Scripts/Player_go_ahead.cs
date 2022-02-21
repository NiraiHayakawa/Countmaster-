using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_go_ahead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = this.transform.forward;
        float horizontal = Input.GetAxis("Horizontal");
       if(horizontal != 0 ){
            direction += this.transform.right * horizontal;
        }
        // if ( Input.GetKey(KeyCode.A) ) {
        //     Debug.Log("OnPress");
        //     direction += this.transform.right * -1;
        // }
        Debug.Log("Direction:"+direction);
        this.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Force);
    }
}
