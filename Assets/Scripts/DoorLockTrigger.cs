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
        if (startFLag)
        {
            Debug.Log("trigger enter");

            if (other.CompareTag("DoorLockMale"))
            {
                Door.GetComponent<Rigidbody>().isKinematic = true;
                doorAudio.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger exit");

        if (other.CompareTag("DoorLockMale"))
        {
            Door.GetComponent<Rigidbody>().isKinematic = false;

            doorAudio.Play();
            startFLag = true;
        }
    }


}
