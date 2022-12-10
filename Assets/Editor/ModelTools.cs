using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using Autohand;
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

    static Component[] components;

    [MenuItem("Tools/Component Copier")]
    public static void ComponentCopier()
    {
        Debug.Log("Method runs");

        GameObject[] selectedObjects = Selection.gameObjects;

        Debug.Log(selectedObjects[0]);
        Debug.Log(selectedObjects[1]);

        if (selectedObjects[0].GetComponent<Rigidbody>() != null)
        {
            Debug.Log("Rigidbody is not null");

            components = selectedObjects[0].GetComponents(typeof(Rigidbody));
            foreach (Component c in components)
            {
                Debug.Log(c);

                ComponentUtility.CopyComponent(c);
                ComponentUtility.PasteComponentAsNew(selectedObjects[1]);
            }

        }

        if (selectedObjects[0].GetComponent<Joint>() != null)
        {
            components = selectedObjects[0].GetComponents(typeof(Joint));
            foreach (Component c in components)
            {
                Debug.Log(c);

                ComponentUtility.CopyComponent(c);
                ComponentUtility.PasteComponentAsNew(selectedObjects[1]);
            }
        }
        if (selectedObjects[0].GetComponent<Collider>() != null)
        {
            components = selectedObjects[0].GetComponents(typeof(Collider));
            foreach (Component c in components)
            {
                Debug.Log(c);

                ComponentUtility.CopyComponent(c);
                ComponentUtility.PasteComponentAsNew(selectedObjects[1]);
            }
        }

        if (selectedObjects[0].GetComponent<Grabbable>() != null)
        {

            components = selectedObjects[0].GetComponents(typeof(Grabbable));
            foreach (Component c in components)
            {
                Debug.Log(c);

                ComponentUtility.CopyComponent(c);
                ComponentUtility.PasteComponentAsNew(selectedObjects[1]);
            }
        }

    }


    static Component[] copiedComponents;

    [MenuItem("Tools/Copy all components %&C")]
    static void Copy()
    {
        copiedComponents = Selection.activeGameObject.GetComponents<Component>();
    }

    [MenuItem("Tools/Paste all components %&P")]
    static void Paste()
    {
        foreach (var targetGameObject in Selection.gameObjects)
        {
            if (!targetGameObject || copiedComponents == null) continue;
            foreach (var copiedComponent in copiedComponents)
            {
                if (!copiedComponent) continue;
                UnityEditorInternal.ComponentUtility.CopyComponent(copiedComponent);
                UnityEditorInternal.ComponentUtility.PasteComponentAsNew(targetGameObject);
            }
        }
    }

}
