using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImovement : MonoBehaviour
{
   
    [Tooltip("drag here object that contain AIHearing Script")]
    [SerializeField]
    private GameObject AIHearing;

    private bool soundDetectedGo;
    private Transform targetGo;
    [SerializeField]
    private bool chaseTarget = true; 
    NavMeshAgent navMeshAgent;
     
    void Start()
    {
       navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       soundDetectedGo = AIHearing.GetComponent<AIHearing>().soundDetected;
       targetGo = AIHearing.GetComponent<AIHearing>().targetObj;
       
         if ( soundDetectedGo && chaseTarget) 
         {                                
	         if(targetGo != null) 
	         {
		         transform.LookAt(targetGo.GetComponent<Transform>().position);  // AI will look at target
			     navMeshAgent.SetDestination(targetGo.GetComponent<Transform>().position); //Ai will go to the position of sound
	         }
			}
        
		}
      
}

