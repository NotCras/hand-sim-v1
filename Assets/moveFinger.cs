using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class moveFinger : MonoBehaviour
{
    [Header("General")]
    [Tooltip("in m/s")][SerializeField] private float speed = 10f;
    
    [Header("Control-based parameters")]
    [SerializeField] private float controlFactor = 10f;

    private float finger_throw;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finger_throw = CrossPlatformInputManager.GetAxis("Horizontal");
        
        
    }
}
