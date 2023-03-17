using UnityEngine;
using UnityEngine.Audio;
using System;
//FOKOzuynen


public class Sound_Emitter : MonoBehaviour
{
	[Tooltip("Drag here the AudioSource that emitt sound")]
    [SerializeField]
    private AudioSource[] objectEmitterSource;
    
    private AudioSource objectEmitter;
    [SerializeField] private AudioMixerGroup mixerEmitter;
    
    private bool clipPlay ;
    [Tooltip("Volume that control the pasive sound for to control the real sound check the AudioSource Volume control")]
    [SerializeField]
    [Range(0.0f,1.0f)]  
     private float volume = 0.15f; // here we set the volume level of our object how loud have to be
    
    [Tooltip ("Distance of sound")]
    [SerializeField]
    [Range(0.0f,10.0f)] 
     private float amp = 0.5f; // this will amplify the distance of sound
    private float ampScale = 15f; 

    [SerializeField]
    [ReadOnlyInspector]  
    public float soundLevel ;
    [SerializeField]
    [Range(0.0f,1000.0f)]
	private float soundDensity = 300.0f;
	[SerializeField]
	[ReadOnlyInspector] 
	public float soundLevelScale = 10f;

    private int sampleblock = 100;
    [SerializeField] private LayerMask layerToCollideWith;
    [SerializeField] private bool enableSoundVisualization = true;  // this will hide sound hits
	private bool refreshParticle = true;
	private ParticleSystem m_particleSystem;
    [SerializeField] public bool zoneActivator;
	
    void Awake()
    {
         if(refreshParticle)
       {
        base.gameObject.SetActive(false);
        base.gameObject.SetActive(true);
        refreshParticle = false;
       }
    }
    
	void OnEnable()
	{
		 // here we set the emitter that will clone the main sound source otherwise lowering the volum while playing the game neither the AI will hear sound and that will result in cheating
         objectEmitter = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
        this.objectEmitter.hideFlags = HideFlags.HideInInspector; // here we hide the clone of the AudioSource , this AudioSource will emulate at max sound volume and can't be changed else players cant cheat by turning game saound off
        for(int i=0;i<objectEmitterSource.Length;i++)
        {
          if(objectEmitterSource[i]==null )Debug.Log("AudioSource field in Sound Emitter is empty");
          else  objectEmitter.clip = objectEmitterSource[i].clip;
        }
        
        objectEmitter.playOnAwake = true;
        objectEmitter.outputAudioMixerGroup = mixerEmitter;
       
         //adding a Particle System and set it up.
        if(gameObject.GetComponent<ParticleSystem>() == null)
        {
           m_particleSystem = gameObject.AddComponent(typeof(ParticleSystem)) as ParticleSystem;
        }
        else m_particleSystem = gameObject.GetComponent<ParticleSystem>();
        m_particleSystem.Stop();
          var particleMain = m_particleSystem.main;
          particleMain.duration = 2f;
          particleMain.startSize = 0.2f;
          particleMain.startSpeed = 15f;
          
          var emission = m_particleSystem.emission;
          emission.rateOverTime = soundDensity;

          var shape = m_particleSystem.shape;
          shape.enabled = true;
          shape.shapeType = ParticleSystemShapeType.Sphere;

          var collision = m_particleSystem.collision;
          collision.enabled = true;
          collision.bounce = 10f;
          collision.collidesWith = layerToCollideWith;
          collision.type = ParticleSystemCollisionType.World;
          collision.sendCollisionMessages = true;

          var renderer = m_particleSystem.GetComponent<ParticleSystemRenderer>();
          renderer.enabled = enableSoundVisualization;
          
         m_particleSystem.Play();
        
       SoundAnalyzer();
       
    }
    void Start()
    {
        if(zoneActivator)
        {
          gameObject.GetComponent<Sound_Emitter>().enabled = false;
          
        }
    }
	
       void Update()
    {
	   SoundAnalyzer();
        
	}
    
    
	
    void SoundAnalyzer()
	{
		// we sync the Audio Source with the clone audio source to play at same time
		for(int i=0;i<objectEmitterSource.Length;i++)
        {
            if(objectEmitterSource[i]==null )Debug.Log("AudioSource field in Sound Emitter is empty");
           else if(objectEmitterSource[i].isPlaying && !clipPlay && !objectEmitter.isPlaying ) 
           {
            clipPlay = true;
           }
        }
		if(clipPlay)
		     {
			    objectEmitter.Play();
                clipPlay = false;
		     }
		
		//we get the volume audio 
		objectEmitter.volume = (volume);
		// we monitorize blocks of sounds and based on that we know if we have a impulse
		float[] sample = new float[sampleblock];
		objectEmitter.GetOutputData(sample, 0);
        
		//we process the blocks of sounds 
		float packagedData = .5f;
		for (int x = 0; x < sample.Length; x++)
		{ 
			packagedData += System.Math.Abs(sample[x]);
		}
        
		soundLevelScale =  packagedData * (amp/ampScale); // setting a scale to be easy interpreted from the AI hearing on a scale from 0 to 1;
		soundLevel = soundLevelScale * 10;
		if(soundLevel <= 0.33 ) // 0.33 is minimum silence (yeah even silence have a sound)
		{
			gameObject.GetComponent<ParticleSystem>().Stop();
		}
		
		if(soundLevel >= 0.33 )
		{
			//here the sound wave particle travel distance in realtime
			var particleMains = gameObject. GetComponent<ParticleSystem>().main;
            particleMains.startLifetime = this.soundLevelScale;
			gameObject.GetComponent<ParticleSystem>().Play();
		}
        
	}
}

