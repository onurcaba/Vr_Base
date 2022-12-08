using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<TextMeshProUGUI> itemsToFindTextElement = new List<TextMeshProUGUI>();

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
    private string itemName;
    private string itemDescription;

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
            switch (item)
            {

                case "BesMmCiftKatmanliCelikDisKabuk":
                    itemName = "5 mm çift katmanlý çelik dýþ kabuk";
                    itemDescription = "Kabinin yapýsal dayanýmýný tarif eden bir bilgi çökmelere ve küçük çaplý patlamara dayanýklý yapý.";
                    break;

                case "COVeCO2Scrubber":
                    itemName = "CO ve CO2 Scrubber";
                    itemDescription = "Hava solurken açýða çýkan karbondioksit ve karbonmonoksit gazlarýný absorbe eden kimyasallarýn bir hava akýþý ile bünyesinde toplamasýný saðlayan cihaz.Belirli periyotlarda kimyasal deðiþtirilerek kullaným süresi uzatýlýyor.";
                    break;

                case "Klima":
                    itemName = "Klima";
                    itemDescription = "Birçok kiþinin ayný kapalý ortamda uzun süre kalmasý havayý ýsýtacaðý için.Klima ile bu uygun þartlara getiriliyor.";
                    break;

                case "AkrilikPencere":
                    itemName = "Akrilik pencere";
                    itemDescription = "Basýnç farklarýna ve kýrýlmalara dayanýklý akrilik cam.Dýþarýdan ve içeriden gözlem yapmaya olanak saðlýyor.";
                    break;

                case "AkuDestegi":
                    itemName = "Akü desteði";
                    itemDescription = "Kabin sürekli tesis elektriðiyle besleniyor.Herhangi bir elektrik kesintisi durumunda akü devreye girerek elektirikle çalýþan cihazlara Güç saðlýyor.";
                    break;

                case "IlkYardimKiti":
                    itemName = "Ýlk yardým kiti";
                    itemDescription = "Acil ve kısmi tıbbi destek amaçlı ilk yardým kiti.Pansuman malz. Birtakým ilaçlar vs.";
                    break;

                case "YanginTupu":
                    itemName = "Yangýn tüpü";
                    itemDescription = "Küçük çaplý yangýnlara müdehale için portatif yangýn tüpü.";
                    break;

                case "BankTipiKoltuk":
                    itemName = "Bank tipi koltuk ";
                    itemDescription = "Kullanýmý Pratik üstü açýlabilen içi gerekli ekipman ve yaþam malzemelerini su,yiyecek vs. barýndýracak koltuk.";
                    break;

                case "ReflectifYazilar":
                    itemName = "Reflektif yazýlar";
                    itemDescription = "Karanlýk maden ortamýnda bir ýþýk kaynaðý ile parlayýp fark edilen uyarý ve ikaz yazýlarý.";
                    break;

                case "HavaGecirmeyenKapiKapak":
                    itemName = "Hava geçirmeyen kapý & kapak";
                    itemDescription = "Dýþarýdan gelebilecek zararlý gazlarýn kabine sýzmasýný önleyen conta ile izole edilmiþ kapý.";
                    break;

                case "KimyasalTuvalet":
                    itemName = "Kimyasal tuvalet";
                    itemDescription = "Acil durumlar için kullanýlabilecek kýsýtlý kapasitede portatif tuvalet.";
                    break;

                case "OksijenDestegi":
                    itemName = "Oksijen Desteği";
                    itemDescription = "Kabine dýþarýdan verilen hava desteðinin kesintiye uðramasý durumunda devreye giren depolanmýþ oksijen desteði.";
                    break;

                case "KisiselKurtarmaCihazi":
                    itemName = "Kişisel Kurtarma Cihazı";
                    itemDescription = "Her personele bir adet verilmek üzere bulundurulan kiþisel solunum cihazý.(Alternatif ek solunum desteði)";
                    break;

            }

            itemsToFindTextElement[index].text = itemName;

            index++;
        }

    }
}