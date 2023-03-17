using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//FOKOzuynen
namespace FOKOzuynen
{
[AddComponentMenu("FOKOzuynen/ListObjectsActivate")]
public class ListObjectsActivate :  MonoBehaviour
{
	
	 public string objToActivate;
	
	[SerializeField] private GameObject[] listObjectsBS;
	[SerializeField] private List< string > namesOfObjects ;
	 private bool objCanBeChange = true;
	 string objActivated;
	 private int  indexInList;
	public void StringToActivate(string setstring){objToActivate = setstring;}
	void Update()
	{
		indexInList = namesOfObjects.IndexOf(objToActivate);
		 
		if(objActivated != objToActivate)
		{
			objCanBeChange = true;
		}
		else objCanBeChange = false;
		ActivateDefault();
		ObjActivateIndex();
		
	}
	
	void ActivateDefault()
	{
		if(string.IsNullOrEmpty(objToActivate)) //this will make the object at index0 in list by default to be active when no other  input
		{
			foreach (var obj in listObjectsBS)
			{
				if(obj != null) obj.SetActive(false);
			}
			if(listObjectsBS[0] != null)
			{
				listObjectsBS[0].SetActive(true);
				indexInList = 0;
				objToActivate = namesOfObjects[0];
			}
			else 
			{
			    indexInList = 0;
			    objToActivate = namesOfObjects[0];
		
			}
		}
	}
	
	void ObjActivateIndex()
	{
		if(namesOfObjects.Contains(objToActivate)  // the main opearation of how obj to be handled
			&& !string.IsNullOrEmpty(objToActivate) 
			&& objCanBeChange )
		{
			
			for(int i=0;i<listObjectsBS.Length;i++)
			{
				if(listObjectsBS[i] == null)continue;
				else listObjectsBS[i].SetActive(false);
			}
			
			   listObjectsBS[indexInList].SetActive(true);
			   objActivated = namesOfObjects[indexInList];
			   if(listObjectsBS[indexInList])
			   {
				   objCanBeChange = false;
			   }
			
		}
	}
	
}
}

