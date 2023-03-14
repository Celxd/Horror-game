using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] float gravityMultiplier = 2f;
    [SerializeField] float speed = 5f;
    [SerializeField] float sensitivity = .5f;
    [SerializeField] CinemachineVirtualCamera cam;
    [SerializeField] CinemachineVirtualCamera cam_sprint;
    [SerializeField] CinemachineVirtualCamera cam_zoom;
    [SerializeField] float headBobSpeed = 0.5f;
    [SerializeField] float headBobAmount = 0.25f;
    [SerializeField] float maxStamina = 100f;
    [SerializeField] float staminaRegenRate = 10f;
    [SerializeField] float staminaDepletionRate = 20f;

    public Vector2 turn;
    private Rigidbody rb;
    private CinemachineBasicMultiChannelPerlin noise;
    private float t;
    private float currentStamina;
    private bool regenStamina;
    private bool canRun;
    private CinemachineVirtualCamera activeCam;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        currentStamina = maxStamina;
        regenStamina = false;
        canRun = true;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        CameraManager.Register(cam);
        CameraManager.Register(cam_sprint);
        CameraManager.Register(cam_zoom);

        CameraManager.SwitchCamera(cam);
    }

    // Update is called once per frame
    void Update()
    {
        activeCam = CameraManager.active;
        noise = activeCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        Vector3 moveVelocity = moveDirection * speed;

        rb.AddForce(Physics.gravity * gravityMultiplier, ForceMode.Acceleration);

        if (Input.GetKey(KeyCode.LeftShift) && canRun == true)
        {
            rb.velocity = transform.TransformDirection(moveVelocity * 1.5f);
            currentStamina -= staminaDepletionRate * Time.deltaTime;
            regenStamina = true;

            if (CameraManager.IsActiveCamera(cam_sprint) != true)
                CameraManager.SwitchCamera(cam_sprint);
        }
        else
        {
            
            
            if (regenStamina)
                currentStamina += staminaRegenRate * Time.deltaTime;

            if(Input.GetMouseButton(1))
            {
                rb.velocity = transform.TransformDirection(moveVelocity / 1.5f);
                if (CameraManager.IsActiveCamera(cam_zoom) != true)
                    CameraManager.SwitchCamera(cam_zoom);
            }
            
            else
            {
                rb.velocity = transform.TransformDirection(moveVelocity);
                if (CameraManager.IsActiveCamera(cam) != true)
                    CameraManager.SwitchCamera(cam);
            }
        }
        
        if (currentStamina >= maxStamina)
        {
            regenStamina = false;
            canRun = true;
        }
        
        else if (currentStamina <= 0)
        {
            currentStamina = 0;
            regenStamina = true;
            canRun = false;
        }

        currentStamina = Mathf.Clamp(currentStamina, 0f, maxStamina);
        
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        turn.y = Mathf.Clamp(turn.y, -90, 90);
        transform.eulerAngles = new Vector3(0, turn.x, 0);
        activeCam.transform.localEulerAngles = new Vector3(-turn.y, 0, 0);
        
        float velocity = Mathf.Clamp01(Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z));
        if (velocity > 0)
        {
            noise.m_AmplitudeGain = velocity * headBobAmount * speed;
            noise.m_FrequencyGain = velocity * headBobSpeed * speed;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                noise.m_AmplitudeGain *= 1.5f;
                noise.m_FrequencyGain *= 1.5f;
            }
        }
        else
        {
            noise.m_AmplitudeGain = headBobAmount;
            noise.m_FrequencyGain = headBobSpeed;
        }
    }

    private void OnDestroy()
    {
        CameraManager.Unregister(cam);
        CameraManager.Unregister(cam_sprint);
        CameraManager.Unregister(cam_zoom);
    }
}
