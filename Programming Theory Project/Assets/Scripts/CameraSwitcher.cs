using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public int index;
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.CompareTag("Player"))
        {
            CameraManager.instance.SwitchCamera(index);
        }
    }
}
