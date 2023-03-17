using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
 using UnityEngine.Events;
using UnityEditor;
using UnityEngine.UI;
namespace FOKOzuynen
{
	[AddComponentMenu("FOKOzuynen/Change Scale")]
	
public class ChangeScale_BS : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	private float m_Timer = 0f;
	[SerializeField] private float m_WaitForSec = 0f ;
	
	[HideInInspector]public string m_ColliderName = "nameOfObject";
	[HideInInspector]public GameObject m_ColliderObj;
	[SerializeField] private Transform gameObj;
	private Collider colliderTrigger;
	Vector3 startScale;	
	[SerializeField] private Vector3 m_TargetScale ;
	private bool startMethod = false;	
	private enum typeOfTransform 
	{
		Set, 
		Add,
		Substract
	};
	[SerializeField] private typeOfTransform  transformType ;
	
	[SerializeField] private float m_Duration = 0.5f;
	[ReadOnlyInspector] [SerializeField] private float elapsedTime;
	private float percentageComplete;
	private bool transformComplete = false;
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
		OnSignalReceived,
		OnClick
	};
	[Space(5)]
	public eventType typeEvent;
	[HideInInspector][TagSelector] public string TagFilter = "";
	[HideInInspector]public bool callmethod;
	private OnDisableEvent m_OnDisableEvent;
	[HideInInspector] public Button clickButton;
	
	//   Trigers  ////////////////////////////////////////////////////////////////
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
	void OnEnable()
	{
		SignalManager.SignalCaptured += OnSignalReceive;
		if(gameObj != null)startScale = gameObj.localScale;
		if(typeEvent == eventType.OnEnable && Application.isPlaying) startMethod = true;
		callmethod = false;
	}
	void OnDisable()
	{
		SignalManager.SignalCaptured -= OnSignalReceive;
		if(typeEvent == eventType.OnDisable && Application.isPlaying)
		{
			callmethod = true;
			m_OnDisableEvent.m_ChangeScale.Add(this);
		}
	}
	void Start()
	{
		if(clickButton != null && typeEvent == eventType.OnClick )clickButton.onClick.AddListener(delegate{startMethod=true;});
		
		m_OnDisableEvent = FindObjectOfType<OnDisableEvent>();
		if(typeEvent == eventType.OnStart && gameObj != null)
		{
			startScale = gameObj.localScale;
			startMethod = true;
		}
	}
	
	void Update()
	{
		
		if((typeEvent == eventType.OnUpdate || startMethod == true) 
			&& gameObj != null && Application.isPlaying)
		{
			startScale = gameObj.localScale;
			TimeWait();
			TransformProcess();
		}
	
	}
	private void OnSignalReceive(string signalReceive)
	{
		if(signalReceive == loadSignalsList[nrSignal] && typeEvent == eventType.OnSignalReceived)
		{
			startMethod = true;
		}
	}
	//  Method /////////////////////////////////////////////////////////////
	public void TransformProcess()
	{
		
		if (transformComplete) transformComplete = false;
		if(!transformComplete && m_Timer>= m_WaitForSec 
		     || !transformComplete && typeEvent == eventType.OnDisable)
		{
			TimeProcessing();
			
			switch (transformType)
				{ 
				case typeOfTransform.Set:
				   gameObj.localScale = Vector3.Lerp(startScale, m_TargetScale, percentageComplete);
				   break;
				case typeOfTransform.Add:
			      gameObj.transform.localScale = Vector3.Lerp(startScale,startScale + m_TargetScale,percentageComplete);
					break;
				case typeOfTransform.Substract:
			      gameObj.transform.localScale = Vector3.Lerp(startScale,startScale - m_TargetScale,percentageComplete);
					break;
				}
		}
	}
	void TimeWait()
	{
		m_Timer += Time.deltaTime;
	}
	
	public void TimeProcessing()
	{
		elapsedTime += Time.deltaTime;
		percentageComplete = elapsedTime / m_Duration;
		
		if(elapsedTime >= m_Duration )
		{
			elapsedTime = 0;
			transformComplete = true;
			m_Timer =0;
			startMethod = false;
			m_OnDisableEvent.m_ChangeScale.Remove(this);
		}
	}
}

	

}	

			
		

	



















