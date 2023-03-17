using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
//FOKOzuynen


public class Mic_Emitter : MonoBehaviour
{
	
	[SerializeField] private AudioMixerGroup micMixerEmitter;
	[SerializeField] private Dropdown m_DropDown;
	
	private AudioSource playerMic;
	public string selectedDevice; 
	
	[SerializeField]
	private int sampleblock = 300;
	[SerializeField]
	[Range(0.0f,1.0f)]  
	private float volume = 0.33f;
	[SerializeField]
	[Range(0.0f,10.0f)] 
	private float amp = 0.2f; // this will amplify the distance of sound
	
	[SerializeField]
	[Range(0.0f,1000.0f)]
	private float micSoundDensity = 400.0f;
	[SerializeField]
	[ReadOnlyInspector]  
	public float micSoundLevel ;
	[SerializeField] private LayerMask layerToCollideWith;
	[SerializeField] private bool enableSoundVisualization = true;
	 private float refreshTimer = 15.0f;
	 private float refreshTime;
	private bool micSelected = false;
	
	
	//////////////////////////////////////////////////////////////////	
	void Start()
	{
		ParticleSystemBuild();
		MicManager();
	}
	
	void Update()
	{
		MicSounds();
		MicSourceRefresh();
	}
	
	
	////////////////////////////////////////////////////////////////////////
	
	
	void MicSourceRefresh()
	{
		refreshTime -= Time.deltaTime;
			
		if(refreshTime <= 0 )
		{
			playerMic.Stop();//Stops the audio
			refreshTime = refreshTimer;
			gameObject.SetActive(false);
			gameObject.SetActive(true);
			StartMicrophone ();
		 }
	}
	
	void MicManager() 
	{
		playerMic = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
		
		playerMic.playOnAwake = false;
		playerMic.outputAudioMixerGroup = micMixerEmitter;
		
		if(!micSelected && selectedDevice != null)
		{
		  for (int i = 0; i < Microphone.devices.Length; ++i)
		  {
			  StartMicrophone();
				
			  if(!m_DropDown.options.Contains(new Dropdown.OptionData() {text = Microphone.devices[i]}))
			  {
				  m_DropDown.options.Add(new Dropdown.OptionData() {text = Microphone.devices[i]});
			  }
		  }
			DropDownMicSelected(m_DropDown);
			micSelected = true;
			m_DropDown.onValueChanged.AddListener(delegate {DropDownMicSelected(m_DropDown);});
		}
	}
	
	void DropDownMicSelected(Dropdown m_DropDown)
	{
		int index = m_DropDown.value;
		selectedDevice = m_DropDown.options[index].text;
	}
	
	public void StartMicrophone () 
	{
		playerMic.clip = Microphone.Start(selectedDevice,true, 30, 44100);
		playerMic.PlayDelayed (0.3f);
		playerMic.Play(); 
	}
	
	void MicSounds()
	{
		GetComponent<ParticleSystem>().Stop();
		if(micSelected)
		{
			//we get the volume audio 
			playerMic.volume = (volume);
			// we monitorize blocks of sounds and based on that we know if we have a impulse
			float[] sample = new float[sampleblock];
			playerMic.GetOutputData(sample, 0);
        
			//we process the blocks of sounds 
			float packagedData = .5f;
			for (int x = 0; x < sample.Length; x++)
			{ 
				packagedData += System.Math.Abs(sample[x]);
			}
        
			micSoundLevel =  packagedData * amp; // setting a scale to be easy interpreted from the AI hearing on a scale from 0 to 1;
			
			if(micSoundLevel >= 1 )
			{
				//here the sound wave particle travel distance in realtime
				var particleMains = gameObject. GetComponent<ParticleSystem>().main;
				particleMains.startLifetime= micSoundLevel;
				GetComponent<ParticleSystem>().Play();
				
			}
		}
	}
	
	
	void ParticleSystemBuild()
	{
		//adding a Particle System and set it up.
		ParticleSystem particleSystem = gameObject.AddComponent(typeof(ParticleSystem)) as ParticleSystem;
		
		particleSystem.Stop();
		
		var particleMain = particleSystem.main;
		particleMain.duration = 2f;
		particleMain.startSize = 0.2f;
		particleMain.startSpeed = 15f;
          
		var emission = particleSystem.emission;
		emission.rateOverTime = micSoundDensity;

		var shape = particleSystem.shape;
		shape.enabled = true;
		shape.shapeType = ParticleSystemShapeType.Sphere;

		var collision = particleSystem.collision;
		collision.enabled = true;
		collision.bounce = 10f;
		collision.collidesWith = layerToCollideWith;
		collision.type = ParticleSystemCollisionType.World;
		collision.sendCollisionMessages = true;

		var renderer = particleSystem.GetComponent<ParticleSystemRenderer>();
		renderer.enabled = enableSoundVisualization;
          
		particleSystem.Play();
		
	}
	
}

