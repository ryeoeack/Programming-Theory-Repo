using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    Camera[] Cameras;
    protected int currentCamera;
    public static CameraManager instance;
    private void Start()
    {
        instance = this;
        currentCamera = 0;
    }
    public void SwitchCamera(int index)
    {
        Cameras[currentCamera].gameObject.SetActive(false);
        Cameras[index].gameObject.SetActive(true);
        currentCamera = index;
    }
}
