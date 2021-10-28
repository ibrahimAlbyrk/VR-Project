using System;
using UnityEngine;
using UnityEngine.XR;

public class HDMInfoManager : MonoBehaviour
{
    private void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            print("No Headset plugged");
        }
        else if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName == "Mock HDM" || XRSettings.loadedDeviceName == "MockHDMDisplay")
        {
            print("Using Mock HDM");
        }
        else
        {
            print($"We Have a headset: {XRSettings.loadedDeviceName}");
        }
    }
}
