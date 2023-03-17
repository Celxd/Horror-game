using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
namespace FOKOzuynen
{
//  Editor  //////////////////////////////////////////////
	[ExecuteInEditMode]
	[CustomEditor (typeof(SignalSend_BS),true)]
 
	public class EditorSendSignal : Editor
	{
		private GUIStyle m_yellow; 
		string[] savedgetSignals;
		
		[SerializeField]public ScriptableSignal m_ScriptableSignal;
		
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI(); // this is need to see the main script for not creating other drawers and not making more fields public
			SignalSend_BS script =  (SignalSend_BS)target ;
			
			m_yellow = new GUIStyle(EditorStyles.label);
			m_yellow.normal.textColor = Color.yellow;
			
			script.savedSignals = m_ScriptableSignal.SignalDatabase;
			
			if(script.typeEvent == SignalSend_BS.eventType.ColliderEnter
				|| script.typeEvent ==  SignalSend_BS.eventType.ColliderExit 
				|| script.typeEvent ==  SignalSend_BS.eventType.ColliderNameEnter
				|| script.typeEvent ==  SignalSend_BS.eventType.ColliderNameExit
				|| script.typeEvent == SignalSend_BS.eventType.OnTagEnter 
				|| script.typeEvent == SignalSend_BS.eventType.OnTagExit)
			{
				EditorGUILayout.LabelField("Add a Collider with Is Trigger = active",m_yellow);
			}
			
			
			savedgetSignals = script.savedSignals.ToArray();
			script.nrSignal = EditorGUILayout.Popup("Active Signal",script.nrSignal,savedgetSignals );
			script.typeEvent = (SignalSend_BS.eventType)EditorGUILayout.EnumPopup("Type Event",script.typeEvent);
			if(script.typeEvent == SignalSend_BS.eventType.ColliderNameEnter)
			{
				script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
			}
			else if(script.typeEvent == SignalSend_BS.eventType.OnClick)
			{
				script.clickButton =  EditorGUILayout.ObjectField ("This Button",script.clickButton,typeof (Button), true)as Button;
			}
			else if(script.typeEvent == SignalSend_BS.eventType.ColliderNameExit)
			{
				script.m_ColliderName = EditorGUILayout.TextField("Collider Name",script.m_ColliderName);
			}
			else if(script.typeEvent == SignalSend_BS.eventType.ColliderEnter)
			{
				script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
			}
			else if(script.typeEvent == SignalSend_BS.eventType.ColliderExit)
			{
				script.m_ColliderObj = EditorGUILayout.ObjectField("ColliderObj",script.m_ColliderObj,typeof (GameObject), true) as GameObject;
			}
			else if(script.typeEvent == SignalSend_BS.eventType.OnTagEnter)
			{
				script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
			}
			else if(script.typeEvent == SignalSend_BS.eventType.OnTagExit)
			{
				script.TagFilter = EditorGUILayout.TagField("Select Tag",script.TagFilter);
			}
		}
	}	
	
}
