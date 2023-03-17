using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace FOKOzuynen
{
	//  Editor  //////////////////////////////////////////////
	[ExecuteInEditMode]
	[CustomEditor (typeof(SetActiveObjects_BS),true)]

	public class EditorActivateObjects : Editor
	{
		private GUIStyle m_yellow;
		string[] savedgetSignals;
		bool refresh ;
		[SerializeField]public ScriptableSignal m_ScriptableSignal;
		
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI(); // this is need to see the main script for not creating other drawers and not making more fields public
			
			SetActiveObjects_BS script =  (SetActiveObjects_BS)target ;
			script.savedSignals = m_ScriptableSignal.SignalDatabase;
			
			m_yellow = new GUIStyle(EditorStyles.label);
			m_yellow.normal.textColor = Color.yellow;
			
			if(script.typeEvent == SetActiveObjects_BS.eventType.ColliderEnter
				|| script.typeEvent ==  SetActiveObjects_BS.eventType.ColliderExit 
				|| script.typeEvent ==  SetActiveObjects_BS.eventType.ColliderNameEnter
				|| script.typeEvent ==  SetActiveObjects_BS.eventType.ColliderNameExit
				|| script.typeEvent == SetActiveObjects_BS.eventType.OnTagEnter 
				|| script.typeEvent == SetActiveObjects_BS.eventType.OnTagExit)
			{
				EditorGUILayout.LabelField("Add a Collider with Is Trigger = active",m_yellow);
			}
			if(script.typeEvent != SetActiveObjects_BS.eventType.OnSignalReceived)
			{refresh = true;}
		
			script.typeEvent = (SetActiveObjects_BS.eventType)EditorGUILayout.EnumPopup("Type Event",script.typeEvent);
		
			if(script.typeEvent == SetActiveObjects_BS.eventType.OnSignalReceived)
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
			
			if(script.typeEvent == SetActiveObjects_BS.eventType.ColliderNameExit)
			{
				script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
			}
			else if(script.typeEvent == SetActiveObjects_BS.eventType.ColliderNameEnter)
			{
				script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
			}
			else if(script.typeEvent == SetActiveObjects_BS.eventType.ColliderEnter)
			{
				script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
			}
			else if(script.typeEvent == SetActiveObjects_BS.eventType.ColliderExit)
			{
				script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
			}
			else if(script.typeEvent == SetActiveObjects_BS.eventType.OnTagEnter)
			{
				script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
			}
			else if(script.typeEvent == SetActiveObjects_BS.eventType.OnTagExit)
			{
				script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
			}
		}
	}	
	}