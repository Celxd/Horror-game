using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

namespace FOKOzuynen
{
[ExecuteAlways]
[CustomEditor (typeof(ChangeScale_BS),true)]
public class EditorChangeScale : Editor
{
	private GUIStyle m_yellow;
	string[] savedgetSignals;
	bool refresh ;
	[SerializeField]public ScriptableSignal m_ScriptableSignal;
	
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		
		ChangeScale_BS script =  (ChangeScale_BS)target ;
		script.loadSignalsList = m_ScriptableSignal.SignalDatabase;
		
		m_yellow = new GUIStyle(EditorStyles.label);
		m_yellow.normal.textColor = Color.yellow;
			
		if(script.typeEvent == ChangeScale_BS.eventType.ColliderEnter
			|| script.typeEvent ==  ChangeScale_BS.eventType.ColliderExit 
			|| script.typeEvent ==  ChangeScale_BS.eventType.ColliderNameEnter
			|| script.typeEvent ==  ChangeScale_BS.eventType.ColliderNameExit
			|| script.typeEvent == ChangeScale_BS.eventType.OnTagEnter 
			|| script.typeEvent == ChangeScale_BS.eventType.OnTagExit)
		{
			EditorGUILayout.LabelField("Add a Collider with Is Trigger = active",m_yellow);
		}
		if(script.typeEvent != ChangeScale_BS.eventType.OnSignalReceived)
		{refresh = true;}
		
		if(script.typeEvent == ChangeScale_BS.eventType.OnSignalReceived)
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
			
		if(script.typeEvent == ChangeScale_BS.eventType.ColliderNameEnter)
		{
			script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
		}
		else if(script.typeEvent == ChangeScale_BS.eventType.ColliderNameExit)
		{
			script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
		}
		else if(script.typeEvent == ChangeScale_BS.eventType.OnClick)
		{
			script.clickButton =  EditorGUILayout.ObjectField ("This Button",script.clickButton,typeof (Button), true)as Button;
		}
		else if(script.typeEvent == ChangeScale_BS.eventType.ColliderEnter)
		{
			script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
		}
		else if(script.typeEvent == ChangeScale_BS.eventType.ColliderExit)
		{
			script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
		}
		else if(script.typeEvent == ChangeScale_BS.eventType.OnTagEnter)
		{
			script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
		}
		else if(script.typeEvent == ChangeScale_BS.eventType.OnTagExit)
		{
			script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
		}
		
	}
}
}
