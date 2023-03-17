using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using System;
namespace FOKOzuynen
{
	public static class SignalManager 
{
	
	  
	#region Actions

	public static event Action<string> SignalCaptured;
	public static event Action<string> SignalToDatabase;
	public static event Action <string> SignalToDelete;
	#endregion

	public static void OnSignalSend(string signalText) => SignalCaptured?.Invoke(signalText);
	public static void SendToDatabase(string signalText) => SignalToDatabase?.Invoke(signalText);
	public static void DeleteThisSignal(string signalText) => SignalToDelete?.Invoke(signalText);
}

}