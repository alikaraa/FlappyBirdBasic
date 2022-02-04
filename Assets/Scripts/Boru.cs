using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boru : MonoBehaviour
{
  //0.65 
  //-6.85
    [SerializeField]
    float hareketHizi;


    void Update(){
        if(transform.position.x < -6.85f){
            transform.position = new Vector3(-0.65f,transform.position.y,transform.position.z);
        }
        gameObject.transform.Translate(-hareketHizi * Time.deltaTime, 0, 0);
    }
}
