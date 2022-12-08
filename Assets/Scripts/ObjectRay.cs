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

    Color whitehighligtColor = new Color(0.2f, 0.2f, 0.2f);
    Color greenHighligtColor = new Color(0.0f, 0.2f, 0.0f);
    Color redHighligtColor = new Color(0.2f, 0.0f, 0.0f);
    Color defaultColor = Color.black;


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
                mat.SetColor("_EmissionColor", whitehighligtColor);
                mat.EnableKeyword("_EMISSION");

                goCurrent = go;
            }
        }

        else if (Physics.Raycast(transform.position, transform.forward, out hit, distance) && hit.collider.GetComponent<GameItem>() == null)
        {
            if (goCurrent != null)
            {

                goCurrent.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", defaultColor);
            }
            goCurrent = null;
        }

    }

    public void CheckItemInList()
    {
        infoCanvas.SetActive(true);
        infoCanvas.transform.position = goCurrent.GetComponent<MeshRenderer>().bounds.center + new Vector3(0, goCurrent.GetComponent<MeshRenderer>().bounds.extents.y / 2, 0);
        infoCanvas.transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);

        infoCanvasText.text = goCurrent.GetComponent<GameItem>().itemDescription;


        Debug.Log("Checking Item List");
        bool founded = false;


        int index = 0;

        foreach (var item in manager.itemsToFind)
        {
            if (item == goCurrent.GetComponent<GameItem>().gameItemType.ToString() && !founded)
            {
                Material mat = goCurrent.GetComponent<MeshRenderer>().material;
                mat.SetColor("_EmissionColor", greenHighligtColor);
                mat.EnableKeyword("_EMISSION");
                founded = true;

                manager.itemsToFindTextElement[index].color = Color.green;
                //manager.itemsToFind.Remove(item);

                if (manager.itemsToFind.Count == 0)
                {
                    youWinText.text = "You Win";
                }
            }
            index++;
        }

        if (!founded)
        {
            Material mat = goCurrent.GetComponent<MeshRenderer>().material;
            mat.SetColor("_EmissionColor", redHighligtColor);
            mat.EnableKeyword("_EMISSION");
        }
    }

}