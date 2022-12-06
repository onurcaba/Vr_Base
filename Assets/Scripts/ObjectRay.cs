using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectRay : MonoBehaviour
{
    public float distance = 5f;
    public TextMeshProUGUI textMeshProUGUI;
    public TextMeshProUGUI textMeshProUGUI2;

    public GameObject go = null;

    public GameManager manager;

    RaycastHit hit;
    public bool checkItem;

    void Update()
    {
        
        Color color = Color.white;

        if (Physics.Raycast(transform.position, transform.forward, out hit, distance) && hit.collider.GetComponent<GameItem>() != null)
        {
            textMeshProUGUI.text = hit.collider.GetComponent<GameItem>().itemName;

            go = hit.collider.gameObject;
            Material mat = go.GetComponent<MeshRenderer>().material;
            mat.SetColor("_EmissionColor", new Color(0.3f, 0.3f, 0.3f));
            mat.EnableKeyword("_EMISSION");

            if (checkItem)
            {
                CheckItemInList();
            }
        }

        else
        {
            go.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
        }
    }

    public void CheckItemInList()
    {
        textMeshProUGUI2.text = "pressed";
        
        foreach (var item in manager.itemsToFind)
        {

            Debug.Log("Loop run");
            Debug.Log(hit.collider.GetComponent<GameItem>().gameItemType.ToString());

            if (item == hit.collider.GetComponent<GameItem>().gameItemType.ToString())
            {
                go = hit.collider.gameObject;
                Material mat = go.GetComponent<MeshRenderer>().material;
                mat.SetColor("_EmissionColor", Color.green);
                mat.EnableKeyword("_EMISSION");

            }
        }
    }

    public void checkItemTrue()
    {
        checkItem = true;

    }

    public void checkItemFalse()
    {
        checkItem = false;

    }
}
