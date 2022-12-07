using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<GameItem> allGameItems = new List<GameItem>();
    List<GameItem> selectedGameItems = new List<GameItem>();

    public int findingItemCount;

    // Start is called before the first frame update
    void Start()
    {
        allGameItems.AddRange(GameObject.FindObjectsOfType<GameItem>());

        for (int i = 0; i < findingItemCount; i++)
        {
            int index = Random.Range(0, allGameItems.Count);

            selectedGameItems.Add(allGameItems[index]);
            allGameItems.RemoveAt(index);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
