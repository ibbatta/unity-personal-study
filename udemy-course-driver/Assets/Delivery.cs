using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] float timeToDestroyObj = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    bool hasPackageOn = false; 

    SpriteRenderer spriteCarRenderer;

    void Start() {
      spriteCarRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
      Debug.Log("Ouch!");
    }

     void OnTriggerEnter2D(Collider2D other) 
    {
      Color32 triggeredElementColor = other.GetComponent<SpriteRenderer>().color;

      if(other.tag == "Package" && !hasPackageOn){
        Debug.Log("---------------- Package obtained");
        hasPackageOn = true;
        spriteCarRenderer.color = triggeredElementColor;
        Destroy(other.gameObject, timeToDestroyObj);
      }

      if(other.tag == "Customer" && hasPackageOn){
        Debug.Log("---------------- Package delivered");
        spriteCarRenderer.color = triggeredElementColor;
        hasPackageOn = false;
      }

    }

}
