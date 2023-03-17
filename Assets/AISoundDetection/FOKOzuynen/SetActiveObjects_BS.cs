using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;
 
namespace FOKOzuynen
{
	[AddComponentMenu("FOKOzuynen/SetActiveObjects")]	
	
	public class SetActiveObjects_BS : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
	{
		private float m_Timer = 0f;
		[SerializeField] private float m_WaitForSec = 0f ;
		[HideInInspector]public List<string> savedSignals;
		private int nrOfSignals;
		[SerializeField] private bool SetState;
		[HideInInspector]public int nrSignal;
		
		[HideInInspector]public GameObject m_ColliderObj;
		private Collider colliderTrigger;
		[HideInInspector]public string m_ColliderName = "nameOfObject";
		[SerializeField]private GameObject[] SetActiveObj;
		[SerializeField]private Behaviour[] SetActiveCompomnent;
		public enum eventType
		{
			PointerEnter, PointerExit,
			OnUpdate, 
			OnDisable, OnEnable,
			OnStart,
			ColliderEnter,
			ColliderExit,
			ColliderNameEnter,
			ColliderNameExit,
			OnTagEnter,
			OnTagExit,
			OnSignalReceived
		};
		[Space(5)]
		[HideInInspector] public eventType typeEvent;
		[HideInInspector][TagSelector] public string TagFilter = "";
		[HideInInspector]public bool startMethod;
		[HideInInspector]public bool callmethod;
		//private OnDisableEvent m_OnDisableEvent;
		
		//   TRIGGERS  //////////////////////////////////////////////////
		
		public void OnPointerEnter(PointerEventData eventData) 
		{
			if(typeEvent == eventType.PointerEnter)
			{
				startMethod = true;
			}
		}
		public void OnPointerExit(PointerEventData eventData) 
		{
			if(typeEvent == eventType.PointerExit)
			{
				startMethod = true;
			}
		}
		private void OnTriggerEnter(Collider other)
		{
			if(typeEvent == eventType.ColliderEnter || typeEvent == eventType.ColliderNameEnter )
			{
				colliderTrigger = m_ColliderObj.GetComponent<Collider>();
			}
			if(typeEvent == eventType.ColliderEnter && colliderTrigger == other)
			{
				startMethod = true;
			}
			if(typeEvent == eventType.ColliderNameEnter && colliderTrigger.name == m_ColliderName)
			{
				startMethod = true;
			}
			if(typeEvent == eventType.OnTagEnter && other.tag == TagFilter)
			{
				startMethod = true;
			}
		}
		private void OnTriggerExit(Collider other)
		{
			if(typeEvent == eventType.ColliderExit || typeEvent == eventType.ColliderNameExit)
			{
				colliderTrigger = m_ColliderObj.GetComponent<Collider>();
			}
			if(typeEvent == eventType.ColliderExit && colliderTrigger == other)
			{
				startMethod = true;
			}
			if(typeEvent == eventType.ColliderNameExit && colliderTrigger.name == m_ColliderName)
			{
				startMethod = true;
			}
			if(typeEvent == eventType.OnTagExit && other.tag == TagFilter)
			{
				startMethod = true;
			}
		}
		void OnDisable()
		{
		   SignalManager.SignalCaptured -= OnSignalReceive;
			
			if(typeEvent == eventType.OnDisable && Application.isPlaying)
			{
				ActivateObjects();
			}
		}
	
		void OnEnable()
		{
			SignalManager.SignalCaptured += OnSignalReceive;
			
			if(typeEvent == eventType.OnEnable && Application.isPlaying)
			{
				startMethod = true;
			}
			
			callmethod = false;
		}
		
		void Start()
		{
			//m_OnDisableEvent = FindObjectOfType<OnDisableEvent>();
			if(typeEvent == eventType.OnStart && Application.isPlaying)
			{
				startMethod = true;
			}
		}
	
		void Update()
		{
			if(typeEvent == eventType.OnUpdate && Application.isPlaying)
			{
				TimeWait();
				ActivateObjects();
			}
			if(startMethod && Application.isPlaying )
			{
				TimeWait();
			}
		}
		
		private void OnSignalReceive(string signalReceive)
		{
			if(signalReceive == savedSignals[nrSignal] && typeEvent == eventType.OnSignalReceived)
			{
				startMethod = true;
			}
		}
	
		//  Method ///////////////////////////////////////////////
		public  void TimeWait()
		{
			m_Timer += Time.deltaTime;
			if(m_Timer>= m_WaitForSec)
			{
				ActivateObjects();
			   if(m_Timer>= m_WaitForSec+0.2f)
				{
					m_Timer = 0;
					startMethod = false;
				}
			}
			
		}
		
		public void ActivateObjects()
		{
		   if(m_Timer>= m_WaitForSec)
			{
				foreach(var component in SetActiveCompomnent)
				{
				  component.enabled = SetState;
				}
				foreach(GameObject gameObj in SetActiveObj)
				{
				 gameObj.SetActive ( SetState);
				}
				//m_OnDisableEvent.m_SetValuesReflect.Remove(this);
			}
		}
   
}


}