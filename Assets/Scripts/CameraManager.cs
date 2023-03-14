using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class CameraManager
{
    static List<CinemachineVirtualCamera> vcams = new List<CinemachineVirtualCamera>();
    public static CinemachineVirtualCamera active = null;

    public static bool IsActiveCamera(CinemachineVirtualCamera vcam)
    {
        return active == vcam;
    }

    public static void SwitchCamera(CinemachineVirtualCamera vcam)
    {
        vcam.Priority = 11;
        active = vcam;

        foreach (CinemachineVirtualCamera v in vcams)
        {
            if (v != vcam && v.Priority != 0)
            {
                v.Priority = 0;
            }
        }
    }

    public static void Register(CinemachineVirtualCamera vcam)
    {
        vcams.Add(vcam);
    }

    public static void Unregister(CinemachineVirtualCamera vcam)
    {
        vcams.Remove(vcam);
    }
}
