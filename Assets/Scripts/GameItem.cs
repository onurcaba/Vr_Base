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
                itemName = "5 mm çift katmanlı çelik dış kabuk";
                itemDescription = "Kabinin yapısal dayanımını tarif eden bir bilgi çökmelere ve küçük çaplı patlamara dayanıklı yapı.";
                break;

            case GameItemType.COVeCO2Scrubber:
                itemName = "CO ve CO2 Scrubber";
                itemDescription = "Hava solurken açığa çıkan karbondioksit ve karbonmonoksit gazlarını absorbe eden kimyasalların bir hava akışı ile bünyesinde toplamasını sağlayan cihaz.Belirli periyotlarda kimyasal değiştirilerek kullanım süresi uzatılıyor.";
                break;

            case GameItemType.Klima:
                itemName = "Klima";
                itemDescription = "Birçok kişinin aynı kapalı ortamda uzun süre kalması havayı ısıtacağı için.Klima ile bu uygun şartlara getiriliyor.";
                break;

            case GameItemType.AkrilikPencere:
                itemName = "Akrilik pencere";
                itemDescription = "Basınç farklarına ve kırılmalara dayanıklı akrilik cam.Dışarıdan ve içeriden gözlem yapmaya olanak sağlıyor.";
                break;

            case GameItemType.AkuDestegi:
                itemName = "Akü desteği";
                itemDescription = "Kabin sürekli tesis elektriğiyle besleniyor.Herhangi bir elektrik kesintisi durumunda akü devreye girerek elektirikle çalışan cihazlara Güç sağlıyor.";
                break;

            case GameItemType.IlkYardimKiti:
                itemName = "ılk yardım kiti";
                itemDescription = "Acil ve kısmı tıbbi destek amaçlı ilk yardım kiti.Pansuman malz. Birtakım ilaçlar vs.";
                break;

            case GameItemType.YanginTupu:
                itemName = "Yangın tüpü";
                itemDescription = "Küçük çaplı yangınlara müdehale için portatif yangın tüpü.";
                break;

            case GameItemType.BankTipiKoltuk:
                itemName = "Bank tipi koltuk ";
                itemDescription = "Kullanımı Pratik üstü açılabilen içi gerekli ekipman ve yaşam malzemelerini su,yiyecek vs. barındıracak koltuk.";
                break;

            case GameItemType.ReflectifYazilar:
                itemName = "Reflektif yazılar";
                itemDescription = "Karanlık maden ortamında bir ışık kaynağı ile parlayıp fark edilen uyarı ve ikaz yazıları.";
                break;

            case GameItemType.HavaGecirmeyenKapiKapak:
                itemName = "Hava geçirmeyen kapı & kapak";
                itemDescription = "Dışarıdan gelebilecek zararlı gazların kabine sızmasını önleyen conta ile izole edilmiş kapı.";
                break;

            case GameItemType.KimyasalTuvalet:
                itemName = "";
                itemDescription = "Acil durumlar için kullanılabilecek kısıtlı kapasitede portatif tuvalet.";
                break;

            case GameItemType.OksijenDestegi:
                itemName = "Kimyasal tuvalet";
                itemDescription = "Kabine dışarıdan verilen hava desteğinin kesintiye uğraması durumunda devreye giren depolanmış oksijen desteği.";
                break;

            case GameItemType.KisiselKurtarmaCihazi:
                itemName = "Kişisel Kurtarma Cihazı";
                itemDescription = "Her personele bir adet verilmek üzere bulundurulan kişisel solunum cihazı.(Alternatif ek solunum desteği)";
                break;

        }

    }
}