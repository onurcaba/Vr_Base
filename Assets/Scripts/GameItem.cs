using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class GameItem : MonoBehaviour
{
    public enum GameItemType
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
    public string itemDescription;
    public string itemName;

    public Renderer customMeshRenderer;

    private void Start()
    {


        switch (gameItemType)
        {

            case GameItemType.BesMmCiftKatmanliCelikDisKabuk:
                itemName = "5 mm çift katmanlý çelik dýþ kabuk";
                itemDescription = "Kabinin yapýsal dayanýmýný tarif eden bir bilgi çökmelere ve küçük çaplý patlamara dayanýklý yapý.";
                break;

            case GameItemType.COVeCO2Scrubber:
                itemName = "CO ve CO2 Scrubber";
                itemDescription = "Hava solurken açýða çýkan karbondioksit ve karbonmonoksit gazlarýný absorbe eden kimyasallarýn bir hava akýþý ile bünyesinde toplamasýný saðlayan cihaz.Belirli periyotlarda kimyasal deðiþtirilerek kullaným süresi uzatýlýyor.";
                break;

            case GameItemType.Klima:
                itemName = "Klima";
                itemDescription = "Birçok kiþinin ayný kapalý ortamda uzun süre kalmasý havayý ýsýtacaðý için.Klima ile bu uygun þartlara getiriliyor.";
                break;

            case GameItemType.AkrilikPencere:
                itemName = "Akrilik pencere";
                itemDescription = "Basýnç farklarýna ve kýrýlmalara dayanýklý akrilik cam.Dýþarýdan ve içeriden gözlem yapmaya olanak saðlýyor.";
                break;

            case GameItemType.AkuDestegi:
                itemName = "Akü desteði";
                itemDescription = "Kabin sürekli tesis elektriðiyle besleniyor.Herhangi bir elektrik kesintisi durumunda akü devreye girerek elektirikle çalýþan cihazlara Güç saðlýyor.";
                break;

            case GameItemType.IlkYardimKiti:
                itemName = "Ýlk yardým kiti";
                itemDescription = "Acil ve kýsmý týbbi destek amaçlý ilk yardým kiti.Pansuman malz. Birtakým ilaçlar vs.";
                break;

            case GameItemType.YanginTupu:
                itemName = "Yangýn tüpü";
                itemDescription = "Küçük çaplý yangýnlara müdehale için portatif yangýn tüpü.";
                break;

            case GameItemType.BankTipiKoltuk:
                itemName = "Bank tipi koltuk ";
                itemDescription = "Kullanýmý Pratik üstü açýlabilen içi gerekli ekipman ve yaþam malzemelerini su,yiyecek vs. barýndýracak koltuk.";
                break;

            case GameItemType.ReflectifYazilar:
                itemName = "Reflektif yazýlar";
                itemDescription = "Karanlýk maden ortamýnda bir ýþýk kaynaðý ile parlayýp fark edilen uyarý ve ikaz yazýlarý.";
                break;

            case GameItemType.HavaGecirmeyenKapiKapak:
                itemName = "Hava geçirmeyen kapý & kapak";
                itemDescription = "Dýþarýdan gelebilecek zararlý gazlarýn kabine sýzmasýný önleyen conta ile izole edilmiþ kapý.";
                break;

            case GameItemType.KimyasalTuvalet:
                itemName = "";
                itemDescription = "Acil durumlar için kullanýlabilecek kýsýtlý kapasitede portatif tuvalet.";
                break;

            case GameItemType.OksijenDestegi:
                itemName = "Kimyasal tuvalet";
                itemDescription = "Kabine dýþarýdan verilen hava desteðinin kesintiye uðramasý durumunda devreye giren depolanmýþ oksijen desteði.";
                break;

            case GameItemType.KisiselKurtarmaCihazi:
                itemName = "Kiþisel Kurtarma Cihazý";
                itemDescription = "Her personele bir adet verilmek üzere bulundurulan kiþisel solunum cihazý.(Alternatif ek solunum desteði)";
                break;

        }

    }
}