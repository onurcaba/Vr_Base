using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI firstItemText1;
    public TextMeshProUGUI firstItemText2;
    public TextMeshProUGUI firstItemText3;
    public TextMeshProUGUI firstItemText4;
    public TextMeshProUGUI firstItemText5;

    public enum GameItemType //GameItemTypeList
    {
        BesMmCiftKatmanliCelikDisKabuk,
        COVeCO2Scrubber,
        Klima,
        AkrilikPencere,
        AkuDestegi,
        IlkYardimKiti,
        YanginTupu,
        BankTipiKoltuk,
        ReflectifYazilar,
        HavaGecirmeyenKapiKapak,
        KimyasalTuvalet,
        OksijenDestegi,
        KisiselKurtarmaCihazi
    }

    public GameItemType gameItemType;


    public List<string> allGameItemTypes = new List<string>();

    public List<string> itemsToFind = new List<string>();

    public int findingItemCount;


    void Start()
    {
        // Callecting all types of items.
        allGameItemTypes = System.Enum.GetValues(typeof(GameItemType)).Cast<GameItemType>().Select(v => v.ToString()).ToList();

        for (int i = 0; i < findingItemCount; i++)
        {
            // Adding Types of Items to find.
            var gameItemType1 = allGameItemTypes[Random.Range(0, allGameItemTypes.Count)];
            itemsToFind.Add(gameItemType1);
            allGameItemTypes.Remove(gameItemType1);
        }

        firstItemText1.text = itemsToFind[0].ToString();
        firstItemText2.text = itemsToFind[1].ToString();
        firstItemText3.text = itemsToFind[2].ToString();
        firstItemText4.text = itemsToFind[3].ToString();
        firstItemText5.text = itemsToFind[4].ToString();


    }
}