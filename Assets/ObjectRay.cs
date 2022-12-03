using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectRay : MonoBehaviour
{
    public float distance = 10f;
    public TextMeshProUGUI textMeshProUGUI;

    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {
            textMeshProUGUI.text = hit.collider.gameObject.name;
            Debug.DrawRay(transform.position, transform.forward * distance, Color.red);
        }

    }
}
