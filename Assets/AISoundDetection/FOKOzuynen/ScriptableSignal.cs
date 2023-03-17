using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace FOKOzuynen
{
[ExecuteAlways]
[CreateAssetMenu(fileName = "ScriptableSignalObj", menuName= "ScriptableSignal")]
public class ScriptableSignal: ScriptableObject
{
	public List<string> SignalDatabase;
	
	private int  ListLenght;
	void OnEnable()
	{
		
		if(!Directory.Exists ("SaveSignals"))
		{  Directory.CreateDirectory ("SaveSignals");  }
		
		if( File.Exists("SaveSignals"+"/"+"SavedSignals"))
		{
		 using FileStream fileStreamLoad = File.Open("SaveSignals"+"/"+"SavedSignals", FileMode.Open);
		 using BinaryReader binaryReaderLoad = new(fileStreamLoad);
			ListLenght = binaryReaderLoad.ReadInt32();
			SignalDatabase = new List<string>(new string[ListLenght]);
		for(int j=0; j< SignalDatabase.Count; j++)
		{
			SignalDatabase[j] = binaryReaderLoad.ReadString();
		}
			binaryReaderLoad.Close();
		}
		SignalManager.SignalToDatabase += OnSignalReceive;
		SignalManager.SignalToDelete += ToDelete;
	}
	
	void OnDisable()
	{
		SignalManager.SignalToDatabase -= OnSignalReceive;
		SignalManager.SignalToDelete -= ToDelete;
	}
	
	void OnSignalReceive(string signalToSave)
	{
		
		for (int i=0; i< SignalDatabase.Count; i++)
		{
			if(SignalDatabase.Contains(signalToSave))break;
			
			if(!SignalDatabase.Contains(signalToSave) )
			{
				SignalDatabase.Add(signalToSave);
			}
		}
		
		File. Delete("SaveSignals"+"/"+"SavedSignals"); 
		using FileStream fileStreamSaveBinary = File.Open("SaveSignals"+"/"+"SavedSignals", FileMode. Create); 
		using BinaryWriter binaryWriterSave = new(fileStreamSaveBinary); 
		ListLenght = SignalDatabase.Count;
		binaryWriterSave.Write(ListLenght);
		fileStreamSaveBinary.Flush();
		for(int j=0; j< SignalDatabase.Count; j++)
		{
			binaryWriterSave.Write(SignalDatabase[j].ToString());
			fileStreamSaveBinary.Flush();
		}
		
		fileStreamSaveBinary.Close();
	}
	
	void ToDelete(string signalDelete)
	{
		if(SignalDatabase.Contains(signalDelete))
		{
			SignalDatabase.Remove(signalDelete);
		}
		File. Delete("SaveSignals"+"/"+"SavedSignals"); 
		using FileStream fileStreamSaveBinary = File.Open("SaveSignals"+"/"+"SavedSignals", FileMode. Create); 
		using BinaryWriter binaryWriterSave = new(fileStreamSaveBinary); 
		ListLenght = SignalDatabase.Count;
		binaryWriterSave.Write(ListLenght);
		fileStreamSaveBinary.Flush();
		for(int j=0; j< SignalDatabase.Count; j++)
		{
			binaryWriterSave.Write(SignalDatabase[j].ToString());
			fileStreamSaveBinary.Flush();
		}
		
		fileStreamSaveBinary.Close();
		
	}
   
}
}