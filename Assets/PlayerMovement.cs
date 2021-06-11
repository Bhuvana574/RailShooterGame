using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
  
    public float ObjectSpeed;
    [SerializeField]
    Vector3 Objectdirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjectMovement(Objectdirection, ObjectSpeed) ;
       
    }
  private  void  ObjectMovement(Vector3 direction,float speed)
    {
        transform.Translate(Vector3.forward * ObjectSpeed);
    }
}
