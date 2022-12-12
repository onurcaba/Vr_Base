using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public List<TextMeshProUGUI> itemsToFindTextElement = new List<TextMeshProUGUI>();

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

    UITimer timer;

    public GameItemType gameItemType;

    public List<string> allGameItemTypes = new List<string>();

    public List<string> itemsToFind = new List<string>();

    public int findingItemCount;
    private string itemName;
    private string itemDescription;
    public GameObject infoCanvas;
    public Transform infoCanvasPoint;
    public TextMeshProUGUI infoCanvasText;
    public string youWinText = "You Win";

    private void Awake()
    {
        timer = GetComponent<UITimer>();
    }

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

        int index = 0;

        foreach (var item in itemsToFind)
        {
            ItemEnumSwitchCase(item);

            // Loop itaration should be same as canvas count in scene
            for (int i = 0; i < 5; i++)
            {
                GameObject.FindGameObjectsWithTag("Text_Item_" + (index + 1).ToString())[i].GetComponent<TextMeshProUGUI>().text = itemName;
            }

            index++;
        }

        int index2 = 0;

        foreach (var item in allGameItemTypes)
        {
            ItemEnumSwitchCase(item);

            Debug.Log(item);
            Debug.Log(index2);

            // Loop itaration should be same as canvas count in scene
            for (int i = 0; i < 1; i++)
            {
                GameObject.FindGameObjectsWithTag("Text_Item_" + (index2 + 6).ToString())[i].GetComponent<TextMeshProUGUI>().text = itemName;
            }

            index2++;
        }

    }

    public void ItemEnumSwitchCase(string _item)
    {
        switch (_item)
        {

            case "BesMmCiftKatmanliCelikDisKabuk":
                itemName = "5 mm çift katmanlı çelik dış kabuk";
                itemDescription = "Kabinin yapısal dayanımını tarif eden bir bilgi çökmelere ve küçük çaplı patlamara dayanıklı yapı.";
                break;

            case "COVeCO2Scrubber":
                itemName = "CO ve CO2 Scrubber";
                itemDescription = "Hava solurken açığa çıkan karbondioksit ve karbonmonoksit gazlarını absorbe eden kimyasalların bir hava akışı ile bünyesinde toplamasını sağlayan cihaz.Belirli periyotlarda kimyasal değiştirilerek kullanım süresi uzatılıyor.";
                break;

            case "Klima":
                itemName = "Klima";
                itemDescription = "Birçok kişinin aynı kapalı ortamda uzun süre kalması havayı ısıtacağı için.Klima ile bu uygun şartlara getiriliyor.";
                break;

            case "AkrilikPencere":
                itemName = "Akrilik pencere";
                itemDescription = "Basınç farklarına ve kırılmalara dayanıklı akrilik cam.Dışarıdan ve içeriden gözlem yapmaya olanak sağlıyor.";
                break;

            case "AkuDestegi":
                itemName = "Akü desteği";
                itemDescription = "Kabin sürekli tesis elektriğiyle besleniyor.Herhangi bir elektrik kesintisi durumunda akü devreye girerek elektirikle çalışan cihazlara Güç sağlıyor.";
                break;

            case "IlkYardimKiti":
                itemName = "İlk yardım kiti";
                itemDescription = "Acil ve kısmi tıbbi destek amaçlı ilk yardım kiti.Pansuman malz. Birtakım ilaçlar vs.";
                break;

            case "YanginTupu":
                itemName = "Yangın tüpü";
                itemDescription = "Küçük çaplı yangınlara müdehale için portatif yangın tüpü.";
                break;

            case "BankTipiKoltuk":
                itemName = "Bank tipi koltuk ";
                itemDescription = "Kullanımı Pratik üstü açılabilen içi gerekli ekipman ve yaşam malzemelerini su,yiyecek vs. barındıracak koltuk.";
                break;

            case "ReflectifYazilar":
                itemName = "Reflektif yazılar";
                itemDescription = "Karanlık maden ortamında bir ışık kaynağı ile parlayıp fark edilen uyarı ve ikaz yazıları.";
                break;

            case "HavaGecirmeyenKapiKapak":
                itemName = "Hava geçirmeyen kapı & kapak";
                itemDescription = "Dışarıdan gelebilecek zararlı gazların kabine sızmasını önleyen conta ile izole edilmiş kapı.";
                break;

            case "KimyasalTuvalet":
                itemName = "Kimyasal tuvalet";
                itemDescription = "Acil durumlar için kullanılabilecek kısıtlı kapasitede portatif tuvalet.";
                break;

            case "OksijenDestegi":
                itemName = "Oksijen Desteği";
                itemDescription = "Kabine dışarıdan verilen hava desteğinin kesintiye uğraması durumunda devreye giren depolanmış oksijen desteği.";
                break;

            case "KisiselKurtarmaCihazi":
                itemName = "Kişisel Kurtarma Cihazı";
                itemDescription = "Her personele bir adet verilmek üzere bulundurulan kişisel solunum cihazı.(Alternatif ek solunum desteği)";
                break;

        }
    }

    public void CheckItemInList(int index)
    {
        // Loop for Textmesh Items to find and fill in scene;
        for (int i = 0; i < 5; i++)
        {
            GameObject.FindGameObjectsWithTag("Text_Item_" + (index + 1).ToString())[i].GetComponent<TextMeshProUGUI>().color = Color.green;
        }
    }

    public void YouWin()
    {
        timer.playing = false;

        youWinText = "Tebrikler Oyunu " + timer.ElappsedTime() + " sürede tamamladınız";

        ActivateAndPositionInfoCanvas(youWinText);
    }

    public void ActivateAndPositionInfoCanvas(string infoText)
    {
        //infoCanvas.SetActive(true);
        //infoCanvas.transform.position = infoCanvasPoint.position;
        //infoCanvas.transform.rotation = Quaternion.Euler(infoCanvasPoint.localRotation.eulerAngles.x, infoCanvasPoint.rotation.eulerAngles.y, 0);

        infoCanvasText.text = infoText;
    }
}