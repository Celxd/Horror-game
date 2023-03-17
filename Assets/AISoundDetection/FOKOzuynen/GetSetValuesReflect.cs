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
	[AddComponentMenu("FOKOzuynen/GetSetValuesReflect")]	

public class GetSetValuesReflect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,ISerializationCallbackReceiver
{
	public enum saveValueType { m_Float, m_Integer, m_String, m_Bool };
	public saveValueType typeOfValue;
	[HideInInspector]public bool boolSaved;
	[HideInInspector]public int intValueIndexGet;
	[HideInInspector]public int intValueIndexSet;
	[HideInInspector]public string[] stringValueFieldGet; 
	[HideInInspector]public string[] stringValueGet; 
	[HideInInspector][SerializeField]public string[] stringValueSet; 
	[HideInInspector]public string[] stringCloneValueSet;
	[HideInInspector]public int intCloneValueIndexSet;
	 
	[HideInInspector]public float  floatSaved;
	[HideInInspector]public int  integerSaved;
	[HideInInspector]public string stringSaved;
	[Tooltip("Drag here the Script from where to get the Values to be save")]
	[SerializeField]public Component m_ComponentValueGet ;
	[Tooltip("Drag here the Script where to be set the Values saved")]
	[SerializeField]public Component m_ComponentValueSet ;
	[HideInInspector]public GameObject m_ColliderObj;
	[HideInInspector]public string m_ColliderName = "nameOfObject";
	private Collider colliderTrigger;
	[HideInInspector]public int nrSignal;
	[HideInInspector]public int nrSignalPrev;
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
	
	[HideInInspector]public bool savetheValue = false;
	[HideInInspector]public bool loadtheValue = false;
	
	[HideInInspector][SerializeField]public string uniqueID;
	private FieldInfo[] fieldStringInfoSet;
	[HideInInspector][SerializeField]private List<string> stringListSet;
	[HideInInspector][TagSelector] public string TagFilter = "";
	private string[] x;
	private object valueSavedTransObj;
	[HideInInspector]public bool callmethod;
	private OnDisableEvent m_OnDisableEvent;
	
	//   TRIGGERS  //////////////////////////////////////////////////
	public void OnBeforeSerialize()
	 {  ProcessValues();  }
	public void OnAfterDeserialize(){}
	
	void Start()
	{
		if(typeEvent == eventType.OnStart)ProcessValues();
		m_OnDisableEvent = FindObjectOfType<OnDisableEvent>();
	}
	
	void Update()
	{
		if(!Application.isPlaying)
		{
		   ProcessValues();
		}
		if(typeEvent == eventType.OnUpdate && Application.isPlaying)
		{
			ProcessValues();
		}
	}
	
	public void OnPointerEnter(PointerEventData eventData) 
	{
		if(typeEvent == eventType.PointerEnter)
		{
			ProcessValues();
		}
	}
	public void OnPointerExit(PointerEventData eventData) 
	{
		if(typeEvent == eventType.PointerExit)
		{
			ProcessValues();
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if(typeEvent == eventType.ColliderExit || typeEvent == eventType.ColliderNameExit)
		{
			colliderTrigger = m_ColliderObj.GetComponent<Collider>();
		}
		
		if(typeEvent == eventType.ColliderEnter && GetComponent<Collider>() == other)
		{
			ProcessValues();
		}
		if(typeEvent == eventType.ColliderNameEnter && colliderTrigger.name == m_ColliderName)
		{
			ProcessValues();
		}
		if(typeEvent == eventType.OnTagEnter && other.tag == TagFilter)
		{
			ProcessValues();
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
			ProcessValues();
		}
		if(typeEvent == eventType.ColliderNameExit && colliderTrigger.name == m_ColliderName)
		{
			ProcessValues();
		}
		if(typeEvent == eventType.OnTagExit && other.tag == TagFilter)
		{
			ProcessValues();
		}
	}
	void OnEnable()
	{
		
		SignalManager.SignalCaptured += OnSignalReceive;
		if(typeEvent == eventType.OnEnable && Application.isPlaying)
		{
			ProcessValues();
		}
		callmethod = false;
	}
	void OnDisable()
	{
		SignalManager.SignalCaptured -= OnSignalReceive;
		if(typeEvent == eventType.OnDisable && Application.isPlaying)
		{
			callmethod = true;
			m_OnDisableEvent.m_GetSetValuesReflect.Add(this);
		}	
		
	}
	private void OnSignalReceive(string signalReceive)
	{
		if(signalReceive == loadSignalsList[nrSignal] && typeEvent == eventType.OnSignalReceived)
		{
			ProcessValues();
		}
	}
	
	//   Methods  //////////////////////////////////////////////////////////
	
	public void ProcessValues()
	{
		if(m_ComponentValueGet != null)
		{
			FieldInfo[] fieldInfos = m_ComponentValueGet.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
			
			//set the array size equals to the one of the fields - dynamic to avoid errors of outside of array size
			stringValueGet = new string[fieldInfos.Length];
			stringValueFieldGet = new string[fieldInfos.Length];
			//we get only the fields that are strings and avoid the array strings then list them in a array with the name of the field and the value for our dropdown that will be created  later
			for(int i= 0; i<fieldInfos.Length ;i++)
			{
				if(typeOfValue == saveValueType.m_String && fieldInfos[i].FieldType == typeof(System.String)) 
				{
					stringValueGet[i] = fieldInfos[i].Name + "=" +fieldInfos[i].GetValue(m_ComponentValueGet)  ;
					if(fieldInfos[i].GetValue(m_ComponentValueGet) == null)
					{stringValueFieldGet[i] = "";}
					else stringValueFieldGet[i]= fieldInfos[i].GetValue(m_ComponentValueGet).ToString();
				}
				else if(typeOfValue == saveValueType.m_Integer && fieldInfos[i].FieldType == typeof(System.Int32)) 
				{
					stringValueGet[i] = fieldInfos[i].Name + "=" +fieldInfos[i].GetValue(m_ComponentValueGet).ToString()  ;
					stringValueFieldGet[i]= fieldInfos[i].GetValue(m_ComponentValueGet).ToString();
				}
				else if(typeOfValue == saveValueType.m_Float &&  fieldInfos[i].FieldType == typeof(System.Single))
				{
					stringValueGet[i] = fieldInfos[i].Name + "=" +fieldInfos[i].GetValue(m_ComponentValueGet).ToString()  ;
					stringValueFieldGet[i]= fieldInfos[i].GetValue(m_ComponentValueGet).ToString();
				}
				else if(typeOfValue == saveValueType.m_Bool &&  fieldInfos[i].FieldType == typeof(System.Boolean))
				{
					stringValueGet[i] = fieldInfos[i].Name + "=" +fieldInfos[i].GetValue(m_ComponentValueGet).ToString()  ;
					stringValueFieldGet[i]= fieldInfos[i].GetValue(m_ComponentValueGet).ToString();
				}
			}
			
			//convert array to list clean empty spaces and convert back to array	
			List<string> stringList = new List<string>(stringValueGet);
			stringList .RemoveAll(x => x == null);
			stringValueGet = stringList.ToArray();
			
			List<string> stringLista = new List<string>(stringValueFieldGet);
			stringLista .RemoveAll(i => i == null);
			stringValueFieldGet = stringLista.ToArray();
			
			//get the field name from which need to extract the value bellow in fieldInfoSetB by getting the name only the first part from our list with split
			
			if(stringValueGet.Length != 0)
			{
				x = stringValueGet[intValueIndexGet].Split('=');
			}
			
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
				//get the float value field from the Component we choosed and set to be save
				FieldInfo fieldInfoSetB = m_ComponentValueGet.GetType().GetField(x[0], BindingFlags.NonPublic | BindingFlags.Public| BindingFlags.Instance);
					
				valueSavedTransObj = fieldInfoSetB.GetValue(m_ComponentValueGet);
				// we assign to the desired Component Field
					fieldStringInfoSet[intCloneValueIndexSet].SetValue(m_ComponentValueSet, valueSavedTransObj);
					m_OnDisableEvent.m_GetSetValuesReflect.Remove(this);
				}
			}
		}
	}

}


}
