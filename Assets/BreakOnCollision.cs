using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOnCollision : MonoBehaviour
{
    public GameObject fracturedObj;
    public float offsetY;
    public float thrust = 1.0f;
  
    void OnCollisionEnter(Collision obj) {
        if(obj.impulse.y > 12f)
        {
            Debug.Log(obj.impulse.y);
            Debug.Log("Break the Object");
            fracturedObj = Instantiate(fracturedObj,new Vector3(transform.position.x,transform.position.y-offsetY,transform.position.z),transform.rotation);
            fracturedObj.GetComponentInChildren<Rigidbody>().AddForce(thrust, -thrust, -thrust, ForceMode.Impulse);

            Destroy(gameObject);
          
            
            

        }
        
    }
    
}
