using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FOKOzuynen
{
	[AddComponentMenu("FOKOzuynen/On Disable Event")]	
public class OnDisableEvent : MonoBehaviour
{
	
	[Header("This is meant to be only one instance per scene and always active")]
	
	public List<ChangePosition_BS> m_ChangePosition;
	public List<ChangeScale_BS> m_ChangeScale;
	public List<SetValuesReflect> m_SetValuesReflect;
	public List<SetActiveObjects_BS> m_SetActiveObjs;
	public List<GetSetValuesReflect> m_GetSetValuesReflect;
	public List<SignalSend_BS> m_SendSignal;

	void OnDisable()
	{
			Debug.Log("Script OnDisableEvent  have to stay on a active GameObject");
	}
	void Update()
    {
	    /////Change Position
	    if(m_ChangePosition != null && m_ChangePosition.Count >0)
	    {
		    for(int i=0;i<m_ChangePosition.Count;i++)
		    {
			    if( m_ChangePosition[i].callmethod == true)
		       {
				     m_ChangePosition[i].TransformProcess();
			    }
			}
	    }
	    //////Change Scale
	    if(m_ChangeScale != null && m_ChangeScale.Count >0)
	    {
		    for(int i=0;i<m_ChangeScale.Count;i++)
		    {
			    if( m_ChangeScale[i].callmethod == true)
			    {
				    m_ChangeScale[i].TransformProcess(); 
			    }
		    }
	    }
	    //////Get Set Values Reflect
	    if(m_GetSetValuesReflect != null && m_GetSetValuesReflect.Count >0)
	    {
		    for(int i=0;i<m_GetSetValuesReflect.Count;i++)
		    {
			    if( m_GetSetValuesReflect[i].callmethod == true)
			    {
				    m_GetSetValuesReflect[i].ProcessValues(); 
			    }
		    }
	    }
	    ///////Set Active Objects
	    if(m_SetActiveObjs != null && m_SetActiveObjs.Count >0)
	    {
		    for(int i=0;i<m_SetActiveObjs.Count;i++)
		    {
			    if( m_SetActiveObjs[i].callmethod == true)
			    {
				    m_SetActiveObjs[i].ActivateObjects(); 
			    }
		    }
	    }
	    ///////Set Values Reflect
	    if(m_SetValuesReflect != null && m_SetValuesReflect.Count >0)
	    {
		    for(int i=0;i<m_SetValuesReflect.Count;i++)
		    {
			    if( m_SetValuesReflect[i].callmethod == true)
			    {
				    m_SetValuesReflect[i].ProcessValues(); 
			    }
		    }
	    }
	    //////On Signal Send
	    if(m_SendSignal != null && m_SendSignal.Count >0)
	    {
		    for(int i=0;i<m_SendSignal.Count;i++)
		    {
			    if( m_SendSignal[i].callmethod == true)
			    {
				    m_SendSignal[i].SendSignal(); 
			    }
		    }
	    }
        
    }
}
}
