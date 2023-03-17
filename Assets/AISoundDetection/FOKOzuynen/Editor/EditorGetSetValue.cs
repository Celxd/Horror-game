using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace FOKOzuynen
{
[ExecuteInEditMode]
[CustomEditor (typeof(GetSetValuesReflect),true)]
public class EditorGetSetValue : Editor
{
	private string fieldGet;
	private string fieldSet;
	string[] savedgetSignals;
	bool refresh ;
	private GUIStyle m_yellow;
	[SerializeField]public ScriptableSignal m_ScriptableSignal;
	
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI(); // this is need to see the main script for not creating other drawers and not making more fields public
		
		GetSetValuesReflect script =  (GetSetValuesReflect)target ;
		script.loadSignalsList = m_ScriptableSignal.SignalDatabase;
		
		if(script.typeEvent != GetSetValuesReflect.eventType.OnSignalReceived)
		{refresh = true;}
		
		if(script.typeEvent == GetSetValuesReflect.eventType.OnSignalReceived)
		{
			savedgetSignals = m_ScriptableSignal.SignalDatabase.ToArray();
			script.nrSignal = EditorGUILayout.Popup("Active Signal",script.nrSignal,savedgetSignals );
			
			if(refresh)  // trick to refresh the Popup of signals  <<<<<<<<<<<<<<<<<<<<<<<<<<
			{
				script.enabled = false;
				script.enabled = true;
				refresh = false;
			}
		}
		
		m_yellow = new GUIStyle(EditorStyles.label);
		m_yellow.normal.textColor = Color.yellow;
			
		if(script.typeEvent == GetSetValuesReflect.eventType.ColliderEnter
			|| script.typeEvent ==  GetSetValuesReflect.eventType.ColliderExit 
			|| script.typeEvent == GetSetValuesReflect.eventType.ColliderNameEnter
			|| script.typeEvent == GetSetValuesReflect.eventType.ColliderNameExit
			|| script.typeEvent == GetSetValuesReflect.eventType.OnTagEnter 
			|| script.typeEvent == GetSetValuesReflect.eventType.OnTagExit)
		{
			EditorGUILayout.LabelField("Add a Collider with Is Trigger = active",m_yellow);
		}
		
		
		if(script.typeEvent == GetSetValuesReflect.eventType.ColliderEnter)
		{
			script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
		}
		else if(script.typeEvent == GetSetValuesReflect.eventType.ColliderExit)
		{
			script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
		}
		else if(script.typeEvent == GetSetValuesReflect.eventType.ColliderNameEnter)
		{
			script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
		}
		else if(script.typeEvent == GetSetValuesReflect.eventType.ColliderNameExit)
		{
			script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
		}
		else if(script.typeEvent == GetSetValuesReflect.eventType.OnTagEnter)
		{
			script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
		}
		else if(script.typeEvent == GetSetValuesReflect.eventType.OnTagExit)
		{
			script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
		}
		
		if(script.typeOfValue == GetSetValuesReflect.saveValueType.m_Bool && script.m_ComponentValueGet != null)
		{
			fieldGet = "Get Bool";
			fieldSet = "Set Bool";
		}
		if(script.typeOfValue == GetSetValuesReflect.saveValueType.m_Float && script.m_ComponentValueGet != null)
		{
			fieldGet = "Get Float";
			fieldSet = "Set Float";
		}
		if(script.typeOfValue == GetSetValuesReflect.saveValueType.m_Integer && script.m_ComponentValueGet != null)
		{
			fieldGet = "Get Integer";
			fieldSet = "Set Integer";
		}
		if(script.typeOfValue == GetSetValuesReflect.saveValueType.m_String && script.m_ComponentValueGet != null)
		{
			fieldGet = "Get String";
			fieldSet = "Set String";
		}
		if(script.m_ComponentValueGet != null)
		{
			//create the dropdown Get
			GUILayout.BeginHorizontal();	
			GUIContent comGet = new	GUIContent(fieldGet);
			script.intValueIndexGet = EditorGUILayout.Popup(comGet,script.intValueIndexGet,script.stringValueGet);
			GUILayout.EndHorizontal();
			
			//create the dropdown Set
			GUILayout.BeginHorizontal();	
			GUIContent comSet = new	GUIContent(fieldSet);
			script.intValueIndexSet = EditorGUILayout.Popup(comSet,script.intValueIndexSet,script.stringValueSet);
			GUILayout.EndHorizontal();
		}	
	}
	
}	
}

