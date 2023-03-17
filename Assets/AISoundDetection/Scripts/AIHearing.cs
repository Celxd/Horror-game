using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;
//FOKOzuynen


public class AIHearing : MonoBehaviour
{
  public bool soundDetected  = false;  ///////this is the main Bool that should trigger any actions //////
	
	[SerializeField] private float perimeterAlert; 
	[TagSelector] public string TagFilter = "";
     
	[SerializeField] private float soundDetectAroundCorner = 1.0f;
	[SerializeField] private float distanceHearingAroundCorner = 3.0f;
  [ReadOnlyInspector][SerializeField]private float distanceToObj = 0.0f;
	[ReadOnlyInspector][SerializeField] private float emitterLevelLive;
	[SerializeField] private float highSoundLevel =30f;
	
   [SerializeField] private float timeAlert = 5.0f;
   [ReadOnlyInspector][SerializeField] private float alertTime;
    
   [ReadOnlyInspector] public Transform targetObj ; //////// this is the Main target so the AI will focus on this///////
	 private Collider[] soundTargetObj; //all objects detected in perimeter
   private bool targetDetected = false;
   private float soundEmitterLevel;
	 private float micSoundEmitterLevel;
	
	private bool directSoundHit  = false;
    
  private NavMeshPath path;
  private NavMeshAgent NavAgent;
  private GameObject hitTag;
  [Tooltip("To be use with ZoneActivator on Player read Documentation")]
	[SerializeField] public bool zoneActivator;
  
	
    void Start()
    {
        NavAgent = gameObject.GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        if(zoneActivator)
        {
          gameObject.GetComponent<AIHearing>().enabled = false;
        }
	 }

    void Update()
    {
      PerimeterScan();
	    if(targetDetected)
	    {
        ActiveHearing();
	    	TimeAlert();
	    }
	}
  
	
 public void PerimeterScan()  // this will check for objects how far can be listen and around corners
    {
      soundTargetObj = Physics.OverlapSphere(transform.position, perimeterAlert); 

      foreach(var hit in soundTargetObj)
        {
          if(hit.CompareTag(TagFilter.ToString()))
	        {
            hitTag =hit.gameObject;
	        	targetDetected = true;
	          if(emitterLevelLive >= highSoundLevel ) soundDetected = true; //this is used for detecting high sounds like big bangs that happens in perimeter
	        }
          else targetDetected = false;
          
	      }
    }
	void ActiveHearing()
	{
        if(hitTag != null && hitTag.GetComponentInChildren<Mic_Emitter>() )
	        {
	        	micSoundEmitterLevel = hitTag.GetComponentInChildren<Mic_Emitter>().micSoundLevel.CompareTo(soundDetectAroundCorner);
	        }
        
         if(hitTag != null &&hitTag.GetComponent<Sound_Emitter>())
           {
             soundEmitterLevel = hitTag.GetComponent<Sound_Emitter>().soundLevel.CompareTo(soundDetectAroundCorner)  ;
	          emitterLevelLive = hitTag.GetComponent<Sound_Emitter>().soundLevel;
           }
	       else if(hitTag != null && !hitTag.GetComponent<Sound_Emitter>())
          {
            var compSoundEmitterMain = hitTag.GetComponent<Sound_Emitter>();
           compSoundEmitterMain = hitTag.GetComponentInChildren(typeof(Sound_Emitter),true) as Sound_Emitter;
           soundEmitterLevel = compSoundEmitterMain.soundLevel.CompareTo(soundDetectAroundCorner);
          }
         
         if((soundEmitterLevel == 1 || micSoundEmitterLevel >= 1) && !directSoundHit)  //here we calculate the distance around corners for object that emitt sounds
              {
                  targetObj = hitTag.transform;
                  NavMesh.CalculatePath(transform.position, targetObj.position, NavAgent.areaMask, path);
                  distanceToObj = Vector3.Distance(transform.position, path.corners[0]);
                  if(path.corners.Length>2)
                  {
                     for(int c = 1;c < path.corners.Length; c++)
                    {
                      Debug.DrawLine(path.corners[c-1], path.corners[c], Color.red);
                      distanceToObj += Vector3.Distance(path.corners[c-1], path.corners[c]);
                    }
                    
                     if(distanceToObj < distanceHearingAroundCorner)
                    {
                       soundDetected = true;
                       Debug.Log("I can hear you near around the corner");  // delete this line for not having console blown
                    }
                  }
              }
       }
    
	public void TimeAlert()
    {
       if(soundDetected)
       {
           alertTime -= Time.deltaTime;
           if(alertTime <= 0)
           {
            targetDetected = false;
            alertTime = timeAlert;
            soundDetected = false; 
            targetObj = null;
            for(int i = 0; i< soundTargetObj.Length;i++)
            {
            	soundTargetObj[i]= null;
            }
            directSoundHit=false;
           }
       }
    }

       void OnParticleCollision(GameObject other)   // this is on direct sound collision
       { 
          if(other.tag == TagFilter.ToString() ) // && soundTargetObj.Length >=1 )
          {
            targetDetected =true;
          	directSoundHit = true;
            soundDetected = true;
            Debug.Log("I can hear YOU!!!");
            
           if(alertTime == timeAlert)
           {
	           targetObj = other.transform;
	         }
          }
          
       }
       
       void OnDrawGizmosSelected()   // visual perimeter in scene of AI 
      {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, perimeterAlert );
      }
}  
     


