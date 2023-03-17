using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace FOKOzuynen
{
	//  Editor  //////////////////////////////////////////////
[ExecuteInEditMode]
[CustomEditor (typeof(SetValuesReflect),true)]
	public class EditorSetValueReflect : Editor
{
	private GUIStyle m_yellow;
	string[] savedgetSignals;
	bool refresh ;
	[SerializeField]public ScriptableSignal m_ScriptableSignal;
	
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI(); // this is need to see the main script for not creating other drawers and not making more fields public
		
		SetValuesReflect script =  (SetValuesReflect)target ;
		script.loadSignalsList = m_ScriptableSignal.SignalDatabase;
		
		if(script.typeEvent != SetValuesReflect.eventType.OnSignalReceived)
		{refresh = true;}
		
		if(script.typeEvent == SetValuesReflect.eventType.OnSignalReceived)
		{
			if(refresh)  // trick to refresh the Popup of signals  <<<<<<<<<<<<<<<<<<<<<<<<<<
		 {
				script.enabled = false;
				script.enabled = true;
				refresh = false;
		 }
			
			savedgetSignals = m_ScriptableSignal.SignalDatabase.ToArray();
			script.nrSignal = EditorGUILayout.Popup("Active Signal",script.nrSignal,savedgetSignals );
			
		
		}
		
		m_yellow = new GUIStyle(EditorStyles.label);
		m_yellow.normal.textColor = Color.yellow;
			
		if(script.typeEvent == SetValuesReflect.eventType.ColliderEnter
			|| script.typeEvent ==  SetValuesReflect.eventType.ColliderExit 
			|| script.typeEvent == SetValuesReflect.eventType.ColliderNameEnter
			|| script.typeEvent == SetValuesReflect.eventType.ColliderNameExit
			|| script.typeEvent == SetValuesReflect.eventType.OnTagEnter 
			|| script.typeEvent == SetValuesReflect.eventType.OnTagExit)
		{
			EditorGUILayout.LabelField("Add a Collider with Is Trigger = active",m_yellow);
		}
		
		if(script.typeEvent == SetValuesReflect.eventType.ColliderEnter)
		{
			script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
		}
		if(script.typeEvent == SetValuesReflect.eventType.ColliderNameEnter)
		{
			script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
		}
		if(script.typeEvent == SetValuesReflect.eventType.ColliderNameExit)
		{
			script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
		}
		if(script.typeEvent == SetValuesReflect.eventType.OnTagEnter)
		{
			script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
		}
		if(script.typeEvent == SetValuesReflect.eventType.OnTagExit)
		{
			script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
		}
		
		if(script.m_ComponentValueSet != null)
		{
			
			if(script.typeOfValue == SetValuesReflect.saveValueType.m_String)
			{
				script.SetThisString = EditorGUILayout.TextField("Set This String",script.SetThisString);
				script.intValueIndexSet = EditorGUILayout.Popup("Set String",script.intValueIndexSet,script.stringValueSet);
			}
			if(script.typeOfValue == SetValuesReflect.saveValueType.m_Bool)
			{
				script.SetThisBool = EditorGUILayout.Toggle("Set This Bool",script.SetThisBool);
				script.intValueIndexSet = EditorGUILayout.Popup("Set Bool",script.intValueIndexSet,script.stringValueSet);
			}
			if(script.typeOfValue == SetValuesReflect.saveValueType.m_Float)
			{
				script.SetThisFloat = EditorGUILayout.FloatField("Set This Float",script.SetThisFloat);
				script.intValueIndexSet = EditorGUILayout.Popup("Set Float",script.intValueIndexSet,script.stringValueSet);
			}
			if(script.typeOfValue == SetValuesReflect.saveValueType.m_Integer)
			{
				script.SetThisInteger = EditorGUILayout.IntField("Set This Integer",script.SetThisInteger);
				script.intValueIndexSet = EditorGUILayout.Popup("Set Integer",script.intValueIndexSet,script.stringValueSet);
			}
		}	
	}
	
}	
}
