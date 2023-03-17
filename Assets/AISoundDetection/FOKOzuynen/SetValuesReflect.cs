using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using	UnityEditor;
using System.Reflection;
using UnityEngine.EventSystems;
 using UnityEngine.Events;
//FOKOzuynen
namespace FOKOzuynen
{
	[AddComponentMenu("FOKOzuynen/SetValuesReflect")]	
	
public class SetValuesReflect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,ISerializationCallbackReceiver
{
	private float m_Timer = 0f;
	[SerializeField] private float m_WaitForSec = 0f ;
	public enum saveValueType { m_Float, m_Integer, m_String, m_Bool };
	public saveValueType typeOfValue;
	[HideInInspector]public bool boolSaved;
	[HideInInspector]public int intValueIndexSet;
	[HideInInspector][SerializeField]public string[] stringValueSet; 
	[HideInInspector]public string[] stringCloneValueSet;
	[HideInInspector]public int intCloneValueIndexSet;
	[HideInInspector]public string valueToSave;  
	[HideInInspector]public float  floatSaved;
	[HideInInspector]public int  integerSaved;
	[HideInInspector]public string stringSaved;
	
	[HideInInspector]public float  SetThisFloat;
	[HideInInspector]public int  SetThisInteger;
	[HideInInspector]public string SetThisString;
	[HideInInspector]public bool SetThisBool;
	
	[Tooltip("Drag here the Script where to be set the Values saved")]
	[SerializeField]public Component m_ComponentValueSet ;
	[HideInInspector]public GameObject m_ColliderObj;
	[HideInInspector]public string m_ColliderName = "nameOfObject";
	private Collider colliderTrigger;
	[HideInInspector]public int nrSignal;
	//[HideInInspector]public int nrSignalPrev;
	[HideInInspector]public int nrOfSignals;
	[HideInInspector]public List<string> loadSignalsList;
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
	public eventType typeEvent;
	
	[Space(5)]
	[Header("This save option is to be used as optional for personal use")]
	[HideInInspector]public bool savetheValue = false;
	[HideInInspector]public bool loadtheValue = false;
	
	[HideInInspector][SerializeField]public string uniqueID;
	private FieldInfo[] fieldStringInfoSet;
	string valueSavedField;
	[HideInInspector][SerializeField]private List<string> stringListSet;
	[HideInInspector][TagSelector] public string TagFilter = "";
	private bool startMethod;
	[HideInInspector]public bool callmethod;
	private OnDisableEvent m_OnDisableEvent;
	
	//   TRIGGERS  //////////////////////////////////////////////////
	public void OnBeforeSerialize()
	{  if(!Application.isPlaying) ProcessValues();  }
	public void OnAfterDeserialize(){}
	
	void OnEnable()
	{
		SignalManager.SignalCaptured += OnSignalReceive;
		
		if(typeEvent == eventType.OnEnable && Application.isPlaying)
		{
			startMethod = true;
		}
		callmethod = false;
	}
	void OnDisable()
	{
		SignalManager.SignalCaptured -= OnSignalReceive;
		if(typeEvent == eventType.OnDisable && Application.isPlaying)
		{
			callmethod = true;
			m_OnDisableEvent.m_SetValuesReflect.Add(this);
		}	
	}
	void Start()
	{
		m_OnDisableEvent = FindObjectOfType<OnDisableEvent>();
		if(typeEvent == eventType.OnStart)startMethod = true;
	}
	void Update()
	{
		if(typeEvent == eventType.OnUpdate && Application.isPlaying)
		{
			TimeWait();
		}
		if(startMethod && Application.isPlaying )
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
		if(typeEvent == eventType.ColliderEnter && GetComponent<Collider>() == other)
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
		if(typeEvent == eventType.ColliderNameExit && colliderTrigger.name== m_ColliderName)
		{
			startMethod = true;
		}
		if(typeEvent == eventType.OnTagExit && other.tag == TagFilter)
		{
			startMethod = true;
		}
	}
	
	private void OnSignalReceive(string signalReceive)
	{
		if(signalReceive == loadSignalsList[nrSignal] && typeEvent == eventType.OnSignalReceived)
		{
			startMethod = true;
		}
	}
	
	//   Methods  //////////////////////////////////////////////////////////
	void TimeWait()
	{
		m_Timer += Time.deltaTime;
		if(m_Timer>= m_WaitForSec)
		{
			ProcessValues();
			
			if(m_Timer>= m_WaitForSec+0.2f)
			{
				m_Timer = 0;
				startMethod = false;
			}
		}
	}
	
	public void ProcessValues()
	{
		
			if(m_ComponentValueSet != null)
			{
				//get all fields from the component we need to set the value to
				fieldStringInfoSet = m_ComponentValueSet.GetType().GetFields( BindingFlags.NonPublic | BindingFlags.Public| BindingFlags.Instance);
				
				stringValueSet = new string[fieldStringInfoSet.Length];
				stringCloneValueSet = new string[fieldStringInfoSet.Length];
				for(int i= 0; i<fieldStringInfoSet.Length ;i++)
				{
					if(typeOfValue == saveValueType.m_String && fieldStringInfoSet[i].FieldType == typeof(System.String))
					{
						stringValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet) ;
						//we create a clone as above only that this array will not get other transforms
						stringCloneValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet);
					}
					else if(typeOfValue == saveValueType.m_Integer && fieldStringInfoSet[i].FieldType == typeof(System.Int32))
					{
						stringValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet).ToString()  ;
						//we create a clone as above only that this array will not get other transforms
						stringCloneValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet).ToString()  ;
					}
					else if(typeOfValue == saveValueType.m_Float && fieldStringInfoSet[i].FieldType == typeof(System.Single))
					{
						stringValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet).ToString()  ;
						//we create a clone as above only that this array will not get other transforms
						stringCloneValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet).ToString()  ;
					}
					else if(typeOfValue == saveValueType.m_Bool && fieldStringInfoSet[i].FieldType == typeof(System.Boolean))
					{
						stringValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet).ToString()  ;
						//we create a clone as above only that this array will not get other transforms
						stringCloneValueSet[i] = fieldStringInfoSet[i].Name +"=" +fieldStringInfoSet[i].GetValue(m_ComponentValueSet).ToString()  ;
					}
				}
			
				//convert array to list clean empty spaces and convert back to array	
				stringListSet = new List<string>(stringValueSet);
				stringListSet .RemoveAll(x => x == null);
				stringValueSet = stringListSet.ToArray();
			
				//we compare the choosed value from dropdown and get the index since the clone have the real index of the script field row
				for(int i=0; i< stringCloneValueSet.Length; i++)
				{
					if(stringValueSet.Length != 0)
					{
					  if(stringCloneValueSet[i] ==  stringValueSet[intValueIndexSet] )
					  {
						intCloneValueIndexSet = i;
					   }
					}
				}
				if(Application.isPlaying)
	         {
		        //get the value from the saved string
					if(typeOfValue == saveValueType.m_String)valueSavedField = "SetThisString";
		        else if(typeOfValue == saveValueType.m_Integer)valueSavedField = "SetThisInteger";
		        else if(typeOfValue == saveValueType.m_Float)valueSavedField = "SetThisFloat";
		        else if(typeOfValue == saveValueType.m_Bool)valueSavedField = "SetThisBool";
					
		        FieldInfo fieldInfoSetSaved = GetType().GetField(valueSavedField, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
		        object valueSavedTransObj = fieldInfoSetSaved.GetValue(this);
					
				
		        // we assign to the desired Component Field
		        fieldStringInfoSet[intCloneValueIndexSet].SetValue(m_ComponentValueSet, valueSavedTransObj);
					m_OnDisableEvent.m_SetValuesReflect.Remove(this);
	         }
			}
	}
}


}
