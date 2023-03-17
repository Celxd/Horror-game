using System.Collections;
using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 using UnityEngine.Events;
 using System;
using UnityEditor;

namespace FOKOzuynen
{
	
[AddComponentMenu("FOKOzuynen/Change Position")]	
	public class ChangePosition_BS : MonoBehaviour,  IPointerEnterHandler, IPointerExitHandler
	{
	private float m_Timer = 0f;
	[SerializeField] private float m_WaitForSec = 0f ;
	
	[HideInInspector]public GameObject m_ColliderObj;
	[HideInInspector]public string m_ColliderName = "nameOfObject";
	[SerializeField] public Transform m_TargetObj;
	private Collider colliderTrigger;
	Vector3 startPositionSelf;	
	Vector3 startPositionWorld;	
	    
	[SerializeField] private Vector3 m_TargetPosition ;
		
	private enum typeOfTransform 
	{
		Set, Add, Substract
	};
	[SerializeField] private typeOfTransform  transformType ;
	
	private enum transformSpace
	{
		Self, World
	};
	[SerializeField] private transformSpace space; 
	[SerializeField] private float m_Duration = 0.5f;
	[ReadOnlyInspector] [SerializeField] private float elapsedTime;
	private float percentageComplete;
	private bool transformComplete = false;
	private bool startMethod = false;
	
	[HideInInspector]public int nrSignal;
	private int nrOfSignals;
	[HideInInspector]public List<string> loadSignalsList;
	public enum eventType
	{
		PointerEnter, PointerExit,
		OnUpdate, 
		OnDisable, OnEnable,
		OnStart,
		ColliderEnter, ColliderExit,
		ColliderNameEnter, ColliderNameExit,
		OnTagEnter, OnTagExit,
		OnSignalReceived
	};
	[Space(5)]
	public eventType typeEvent;
	[HideInInspector][TagSelector] public string TagFilter = "";
		private int TimerDisable;
		[HideInInspector]public bool callmethod;
		[HideInInspector]public OnDisableEvent m_OnDisableEvent;
	//  Trigers   ////////////////////////////////////////////////////////////////
  
		void OnDisable()
		{  
			SignalManager.SignalCaptured -= OnSignalReceive;
			if(typeEvent == eventType.OnDisable && Application.isPlaying)
			{
				callmethod = true;
				m_OnDisableEvent.m_ChangePosition.Add(this);
			}
		}
		void OnEnable()
		{
			SignalManager.SignalCaptured += OnSignalReceive;
			if(space == transformSpace.Self && m_TargetObj != null) startPositionSelf = m_TargetObj.localPosition;
			if(space == transformSpace.World && m_TargetObj != null) startPositionWorld = m_TargetObj.position;
			if(typeEvent == eventType.OnEnable && m_TargetObj != null && Application.isPlaying) startMethod = true;
			callmethod = false;
		
		}
		void Start()
		{
			m_OnDisableEvent = FindObjectOfType<OnDisableEvent>();
			if(space == transformSpace.Self && m_TargetObj != null) startPositionSelf = m_TargetObj.localPosition;
			if(space == transformSpace.World && m_TargetObj != null) startPositionWorld = m_TargetObj.position;
			if(typeEvent == eventType.OnStart && m_TargetObj != null)startMethod = true;
		}
	
		void Update()
		{
		   if((typeEvent == eventType.OnUpdate || startMethod == true) 
				&& m_TargetObj != null && Application.isPlaying)
			{
				TimeWait();
				TransformProcess();
			}
		}
	private void OnTriggerEnter(Collider other)
	{
		if(typeEvent == eventType.ColliderEnter || typeEvent == eventType.ColliderNameEnter )
		{
			colliderTrigger = m_ColliderObj.GetComponent<Collider>();
		}
		if(typeEvent == eventType.ColliderEnter && colliderTrigger == other)startMethod = true;
		if(typeEvent == eventType.ColliderNameEnter && colliderTrigger.name == m_ColliderName)startMethod = true;
		if(typeEvent == eventType.OnTagEnter && other.tag == TagFilter)startMethod = true;
	}
	private void OnTriggerExit(Collider other)
	{
		if(typeEvent == eventType.ColliderNameExit || typeEvent == eventType.ColliderNameExit )
		{
			colliderTrigger = m_ColliderObj.GetComponent<Collider>();
		}
		if(typeEvent == eventType.ColliderExit && colliderTrigger == other)startMethod = true;
		if(typeEvent == eventType.ColliderNameExit && colliderTrigger.name == m_ColliderName)startMethod = true;
		if(typeEvent == eventType.OnTagExit && other.tag == TagFilter)startMethod = true;
	}
	
	
	public void OnPointerEnter(PointerEventData eventData) 
	{
		if(typeEvent == eventType.PointerEnter)startMethod = true;
	}
	public void OnPointerExit(PointerEventData eventData) 
	{
		if(typeEvent == eventType.PointerExit)startMethod = true ;
	}
		
	private void OnSignalReceive(string signalReceive)
	{
		if(signalReceive == loadSignalsList[nrSignal] && typeEvent == eventType.OnSignalReceived)
		{
			startMethod = true;
		}
	}
	
	//    Method   ///////////////////////////////////////////////////////////////////
	void TimeWait()
	{
		m_Timer += Time.deltaTime;
	}
	
	public void TransformProcess()
	{
		if (transformComplete) transformComplete = false;
		if(!transformComplete && m_Timer>= m_WaitForSec
			|| !transformComplete && typeEvent == eventType.OnDisable )
		{
			TimeProcessing();
			
			switch (space)
			{
			case transformSpace.Self:   // this is for Self Space transform
			   switch (transformType)
				{ 
				case typeOfTransform.Set:
				  m_TargetObj.localPosition = Vector3.Lerp(startPositionSelf, m_TargetPosition, percentageComplete);
				  break;
				case typeOfTransform.Add:
			     m_TargetObj.localPosition = Vector3.Lerp(startPositionSelf,startPositionSelf + m_TargetPosition,percentageComplete);
				  break;
				case typeOfTransform.Substract:
			     m_TargetObj.localPosition = Vector3.Lerp(startPositionSelf,startPositionSelf - m_TargetPosition,percentageComplete);
				  break;
				}
				break;
				
			case transformSpace.World:   // this is for World Space transform
			   switch (transformType)
				{
				case typeOfTransform.Set:
					m_TargetObj.position = Vector3.Lerp(startPositionWorld,m_TargetPosition,percentageComplete);
					break;
				case typeOfTransform.Add:
			      m_TargetObj.localPosition = Vector3.Lerp(startPositionWorld,startPositionSelf + m_TargetPosition,percentageComplete);
					break;
				case typeOfTransform.Substract:
			      m_TargetObj.localPosition = Vector3.Lerp(startPositionWorld,startPositionSelf - m_TargetPosition,percentageComplete);
					break;
				}
				break;
			} 
			
	}
	}
	
	void TimeProcessing()
	{
		 elapsedTime += Time.deltaTime;
		 percentageComplete = elapsedTime / m_Duration;
		
		if(elapsedTime >= m_Duration )
		{
			elapsedTime = 0;
			transformComplete = true;
			m_Timer =0;
			startMethod = false;
			m_OnDisableEvent.m_ChangePosition.Remove(this);
			
		}
		}
}


}
			
		

	



















