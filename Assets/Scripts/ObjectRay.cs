using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectRay : MonoBehaviour
{
    public float distance = 2f;
    public TextMeshProUGUI textMeshProUGUI;
    public TextMeshProUGUI textMeshProUGUI2;

    public TextMeshProUGUI youWinText;

    public GameObject go = null;
    GameObject goCurrent = null;

    public GameManager manager;

    RaycastHit hit;
    public bool checkItem;

    public GameObject infoCanvas;
    public TextMeshProUGUI infoCanvasText;


    void Update()
    {
        Color color = Color.white;

        if (Physics.Raycast(transform.position, transform.forward, out hit, distance) && hit.collider.GetComponent<GameItem>() != null)
        {
            go = hit.collider.gameObject;


            if (goCurrent != go)
            {

                if (goCurrent != null)
                {
                    goCurrent.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                }

                Debug.Log("Game Objects are different");

                //textMeshProUGUI.text = hit.collider.GetComponent<GameItem>().itemName;

                Material mat = go.GetComponent<MeshRenderer>().material;
                var currentEmissionColor = mat.GetColor("_EmissionColor");
                //mat.SetColor("_EmissionColor", currentEmissionColor + new Color(0.2f, 0.2f, 0.2f));
                mat.SetColor("_EmissionColor", new Color(0.2f, 0.2f, 0.2f));
                mat.EnableKeyword("_EMISSION");

                //if (checkItem)
                //{
                //    CheckItemInList();
                //}
                goCurrent = go;
            }
        }

        else if (Physics.Raycast(transform.position, transform.forward, out hit, distance) && hit.collider.GetComponent<GameItem>() == null)
        {
            goCurrent.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            goCurrent = null;
        }


        //else goCurrent.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);

    }

    public void CheckItemInList()
    {
        infoCanvas.SetActive(true);
        infoCanvas.transform.position = goCurrent.GetComponent<MeshRenderer>().bounds.center + new Vector3(0, goCurrent.GetComponent<MeshRenderer>().bounds.extents.y/2,0);
        infoCanvas.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);

        infoCanvasText.text = goCurrent.GetComponent<GameItem>().itemDescription;


        Debug.Log("Checking Item List");
        bool founded = false;
        foreach (var item in manager.itemsToFind)
        {
            if (item == goCurrent.GetComponent<GameItem>().gameItemType.ToString() && !founded)
            {
                Material mat = goCurrent.GetComponent<MeshRenderer>().material;
                mat.SetColor("_EmissionColor", Color.green);
                mat.EnableKeyword("_EMISSION");
                founded = true;
            }
        }

        if (!founded)
        {
            Material mat = goCurrent.GetComponent<MeshRenderer>().material;
            mat.SetColor("_EmissionColor", Color.red);
            mat.EnableKeyword("_EMISSION");
        }
    }

}