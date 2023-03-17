using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//FOKOzuynen


public class ZoneActivator : MonoBehaviour
{
   [SerializeField] private float perimeterDeactivator = 12f;
   [SerializeField] private float perimeterActivator = 9f;
     private Collider[] DeactivatePerimeter;
     private Collider[] ActivatePerimeter;
    
    void Update()
    {
        DeactivatePerimeter = Physics.OverlapSphere(transform.position, perimeterDeactivator);  
        
       foreach(var Obj in DeactivatePerimeter)
       {
        if( Obj.GetComponent<AIHearing>() && Obj.GetComponent<AIHearing>().zoneActivator)
           {
              Obj.gameObject.GetComponent<AIHearing>().enabled = false;
           }
          else if( Obj.GetComponent<Sound_Emitter>() && Obj.GetComponent<Sound_Emitter>().zoneActivator)
           {
              Obj.gameObject.GetComponent<Sound_Emitter>().enabled = false;
           }

       }
       ActivatePerimeter = Physics.OverlapSphere(transform.position, perimeterActivator); 
       foreach(var Obj in ActivatePerimeter)
       {
        if( Obj.GetComponent<AIHearing>() && Obj.GetComponent<AIHearing>().zoneActivator)
           {
              Obj.gameObject.GetComponent<AIHearing>().enabled = true;
           }
          else if( Obj.GetComponent<Sound_Emitter>() && Obj.GetComponent<Sound_Emitter>().zoneActivator)
           {
              Obj.gameObject.GetComponent<Sound_Emitter>().enabled = true;
           }
       }  
    }

 void OnDrawGizmosSelected()   // visual perimeter in scene of AI 
      {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, perimeterDeactivator );
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, perimeterActivator );
      }
}
