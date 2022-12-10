using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class ObjectRay : MonoBehaviour
{
    public LayerMask gameItemLayer;

    public float distance = 2f;
    public TextMeshProUGUI textMeshProUGUI;
    public TextMeshProUGUI textMeshProUGUI2;

    public TextMeshProUGUI youWinText;

    public GameItem pointedGameItem = null;
    GameItem pointedGameItemCurrent = null;
    GameItem checkingGameItem = null;

    public GameManager manager;

    RaycastHit hit;
    public bool checkItem;

    public GameObject infoCanvas;

    public Transform infoCanvasPoint;
    public TextMeshProUGUI infoCanvasText;

    Color whitehighligtColor = new Color(0.3f, 0.3f, 0.3f);
    Color greenHighligtColor = new Color(0.0f, 0.3f, 0.0f);
    Color redHighligtColor = new Color(0.3f, 0.0f, 0.0f);
    Color defaultColor = Color.black;

    public UITimer timer;
    public int foundedItems;

    private void Start()
    {
        Invoke("ActivateAndPositionInfoCanvas", 2);
    }
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance, gameItemLayer) && checkingGameItem == null)
        {
            if (hit.collider.GetComponent<GameItem>() != null)
            {
                pointedGameItem = hit.collider.gameObject.GetComponent<GameItem>();

                if (pointedGameItemCurrent != pointedGameItem)
                {
                    if (pointedGameItemCurrent != null && pointedGameItemCurrent.GetComponent<Renderer>() != null)
                    {
                        UnhighlightGameItem(pointedGameItemCurrent);
                    }

                    HighLightGameItem(pointedGameItem, whitehighligtColor);

                    pointedGameItemCurrent = pointedGameItem;
                }
            }

            else if (hit.collider.GetComponent<GameItem>() == null)
            {
                if (pointedGameItemCurrent != null)
                {
                    UnhighlightGameItem(pointedGameItemCurrent);
                }
                pointedGameItemCurrent = null;
            }
        }


    }

    private void UnhighlightGameItem(GameItem _gameitem)
    {

        Material[] mats = _gameitem.GetComponent<MeshRenderer>().materials;

        foreach (var mat in mats)
        {
            mat.SetColor("_EmissionColor", Color.black);
        }
    }

    public void CheckItemInList()
    {
        checkingGameItem = pointedGameItem;

        ActivateAndPositionInfoCanvas();

        bool founded = false;

        foreach (var (item, i) in manager.itemsToFind.Select((value, i)=>(value,i)))
        {
            // Make Green Forunded GamItem in list
            if (item == checkingGameItem.GetComponent<GameItem>().gameItemType.ToString() && !founded)
            {
                HighLightGameItem(checkingGameItem, greenHighligtColor);

                founded = true;

                //manager.itemsToFindTextElement[index].color = Color.green;
                manager.CheckItemInList(i);

                // When this value reach 5 timer will stop and Game Finish
                foundedItems++;

                if (foundedItems == 5)
                {
                    timer.playing = false;
                }
            }
        }

        if (!founded)
        {
            HighLightGameItem(checkingGameItem, redHighligtColor);
        }

        StartCoroutine("UnhighlighCheckedGameItem");
    }

    private void ActivateAndPositionInfoCanvas()
    {
        infoCanvas.SetActive(true);
        infoCanvas.transform.position = infoCanvasPoint.position;
        infoCanvas.transform.rotation = Quaternion.Euler(infoCanvasPoint.localRotation.eulerAngles.x, infoCanvasPoint.rotation.eulerAngles.y, 0);

        if (pointedGameItem != null)
        {
            infoCanvasText.text = pointedGameItem.GetComponent<GameItem>().itemDescription;
        }
    }

    private void HighLightGameItem(GameItem _gameItem, Color _highLightColor)
    {

        if (_gameItem.GetComponent<Renderer>() != null)
        {
            Material[] mats = _gameItem.GetComponent<MeshRenderer>().materials;

            foreach (var mat in mats)
            {

                var currentEmissionColor = mat.GetColor("_EmissionColor");

                mat.SetColor("_EmissionColor", _highLightColor);
                mat.EnableKeyword("_EMISSION");
            }
        }

        else if (_gameItem.GetComponent<GameItem>().customMeshRenderer != null)
        {
            Material mat = _gameItem.GetComponent<GameItem>().customMeshRenderer.material;
            var currentEmissionColor = mat.GetColor("_EmissionColor");

            mat.SetColor("_EmissionColor", _highLightColor);
            mat.EnableKeyword("_EMISSION");
        }
        else
        {
            Debug.Log("No renderer in GameItem");
        }
    }

    IEnumerator UnhighlighCheckedGameItem()
    {
        yield return new WaitForSeconds(3);


        Material[] mats = checkingGameItem.GetComponent<MeshRenderer>().materials;

        foreach (var mat in mats)
        {
            mat.SetColor("_EmissionColor", defaultColor);
        }

        checkingGameItem = null;
    }
}