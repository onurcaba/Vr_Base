using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLockTrigger : MonoBehaviour
{
    public GameObject Door;
    public AudioSource doorAudio;
    bool startFLag;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");

        if (other.CompareTag("DoorLockMale"))
        Door.GetComponent<Rigidbody>().isKinematic = true;
        if (startFLag)
        {
            doorAudio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger exit");

        if (other.CompareTag("DoorLockMale"))
        Door.GetComponent<Rigidbody>().isKinematic = false;
        doorAudio.Play();
        startFLag = true;
    }

    
}
