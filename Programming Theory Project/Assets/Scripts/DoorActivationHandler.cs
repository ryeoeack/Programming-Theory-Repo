using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActivationHandler : Door
{
    [SerializeField] Door motherDoor;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                motherDoor.Open();
            }
        }
    }
}
