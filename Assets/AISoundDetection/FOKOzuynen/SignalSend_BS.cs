using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.EventSystems;
 using UnityEngine.Events;
 using UnityEngine.UI;
namespace FOKOzuynen
{
	
	[AddComponentMenu("FOKOzuynen/Send Signal")]
	public class SignalSend_BS : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,ISerializationCallbackReceiver
{
	public bool doit;
	private float m_Timer = 0f;
	[SerializeField] private float m_WaitForSec = 0f ;
	private bool startMethod;
	[SerializeField] private string SignalText;
	[SerializeField] private bool saveSignal;
	
	[HideInInspector]public List<string> savedSignals;
	[HideInInspector]private int nrOfSignals;
	[Space(6)]
	[SerializeField]private bool deleteSignal;
	[HideInInspector]public int nrSignal;
	
	[HideInInspector]public GameObject m_ColliderObj;
	private Collider colliderTrigger;
	[HideInInspector]public string m_ColliderName = "nameOfObject";
	[HideInInspector] public Button clickButton;
	
	public enum eventType
	{
		PointerEnter, PointerExit,
		OnUpdate, 
		OnDisable, OnEnable,
		OnStart,
		ColliderEnter,ColliderExit,
		ColliderNameEnter,ColliderNameExit,
		OnTagEnter,OnTagExit,
		OnClick
	};
	[Space(5)]
	[HideInInspector]public eventType typeEvent;
	[HideInInspector][TagSelector] public string TagFilter = "";
	[HideInInspector]public bool callmethod;
	private OnDisableEvent m_OnDisableEvent;
	
	//   TRIGGERS  //////////////////////////////////////////////////
	
	void OnDisable()
	{
		if(typeEvent == eventType.OnDisable && Application.isPlaying )
		{
			callmethod = true;
			m_OnDisableEvent.m_SendSignal.Add(this);
		}
	}
	
	void OnEnable()
	{
		if(typeEvent == eventType.OnEnable && Application.isPlaying)
		{
			startMethod = true;
		}
		callmethod = false;
	}
	void Start()
	{
		
		if(clickButton != null && typeEvent == eventType.OnClick )clickButton.onClick.AddListener(delegate{startMethod=true;});
		
		if(typeEvent == eventType.OnStart && Application.isPlaying)
		{
			startMethod = true;
		}
		m_OnDisableEvent = FindObjectOfType<OnDisableEvent>();
	}
	
	void Update()
	{
		if(typeEvent == eventType.OnUpdate && Application.isPlaying)
		{
			SendSignal();
		}
		if(startMethod && Application.isPlaying)
		{
			TimeWait();
		}
	}
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
		if(typeEvent == eventType.ColliderExit || typeEvent == eventType.ColliderNameExit )
		{
			colliderTrigger = m_ColliderObj.GetComponent<Collider>();
		}
		
		if(typeEvent == eventType.ColliderExit && GetComponent<Collider>() == other)
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
	
	public void OnBeforeSerialize()
	{
		if( saveSignal )
		{
			SignalManager.SendToDatabase(SignalText);
			saveSignal = false;
		}
		if(deleteSignal)
		{
			SignalManager.DeleteThisSignal(savedSignals[nrSignal]);
			deleteSignal = false;
		}
	}
	public void OnAfterDeserialize(){}
	
	
	//  Method ///////////////////////////////////////////////
	void TimeWait()
	{
		m_Timer += Time.deltaTime;
		if(m_Timer>= m_WaitForSec)
		{
			SendSignal();
			if(m_Timer>= m_WaitForSec+0.2f)
			{
				m_Timer = 0;
				startMethod = false;
			}
		}
	}
	
	public void SendSignal()
    {
	    SignalManager.OnSignalSend(savedSignals[nrSignal]);
	    m_OnDisableEvent.m_SendSignal.Remove(this);
    }
}


}