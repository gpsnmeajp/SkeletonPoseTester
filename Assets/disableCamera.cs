using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.XR.XRSettings.showDeviceView = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
