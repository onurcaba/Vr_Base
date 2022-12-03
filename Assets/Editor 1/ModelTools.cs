using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ModelTools : MonoBehaviour
{
    [MenuItem("Tools/Model Tools")]
    public static void disableReceiveShadows()
    {
        GameObject[] selectedObjectsAndChildren = Selection.gameObjects;

        foreach (var item in selectedObjectsAndChildren)
        {
            try
            {
                item.GetComponentInChildren<MeshRenderer>().material.SetFloat("_ReceiveShadows", 0f);

            }
            catch (System.Exception)
            {

                Debug.Log("No MeshRenderer");
            }
        }
    }
}
