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
                itemName = "5 mm �ift katmanl� �elik d�� kabuk";
                itemDescription = "Kabinin yap�sal dayan�m�n� tarif eden bir bilgi ��kmelere ve k���k �apl� patlamara dayan�kl� yap�.";
                break;

            case GameItemType.COVeCO2Scrubber:
                itemName = "CO ve CO2 Scrubber";
                itemDescription = "Hava solurken a���a ��kan karbondioksit ve karbonmonoksit gazlar�n� absorbe eden kimyasallar�n bir hava ak��� ile b�nyesinde toplamas�n� sa�layan cihaz.Belirli periyotlarda kimyasal de�i�tirilerek kullan�m s�resi uzat�l�yor.";
                break;

            case GameItemType.Klima:
                itemName = "Klima";
                itemDescription = "Bir�ok ki�inin ayn� kapal� ortamda uzun s�re kalmas� havay� �s�taca�� i�in.Klima ile bu uygun �artlara getiriliyor.";
                break;

            case GameItemType.AkrilikPencere:
                itemName = "Akrilik pencere";
                itemDescription = "Bas�n� farklar�na ve k�r�lmalara dayan�kl� akrilik cam.D��ar�dan ve i�eriden g�zlem yapmaya olanak sa�l�yor.";
                break;

            case GameItemType.AkuDestegi:
                itemName = "Ak� deste�i";
                itemDescription = "Kabin s�rekli tesis elektri�iyle besleniyor.Herhangi bir elektrik kesintisi durumunda ak� devreye girerek elektirikle �al��an cihazlara G�� sa�l�yor.";
                break;

            case GameItemType.IlkYardimKiti:
                itemName = "�lk yard�m kiti";
                itemDescription = "Acil ve k�sm� t�bbi destek ama�l� ilk yard�m kiti.Pansuman malz. Birtak�m ila�lar vs.";
                break;

            case GameItemType.YanginTupu:
                itemName = "Yang�n t�p�";
                itemDescription = "K���k �apl� yang�nlara m�dehale i�in portatif yang�n t�p�.";
                break;

            case GameItemType.BankTipiKoltuk:
                itemName = "Bank tipi koltuk ";
                itemDescription = "Kullan�m� Pratik �st� a��labilen i�i gerekli ekipman ve ya�am malzemelerini su,yiyecek vs. bar�nd�racak koltuk.";
                break;

            case GameItemType.ReflectifYazilar:
                itemName = "Reflektif yaz�lar";
                itemDescription = "Karanl�k maden ortam�nda bir ���k kayna�� ile parlay�p fark edilen uyar� ve ikaz yaz�lar�.";
                break;

            case GameItemType.HavaGecirmeyenKapiKapak:
                itemName = "Hava ge�irmeyen kap� & kapak";
                itemDescription = "D��ar�dan gelebilecek zararl� gazlar�n kabine s�zmas�n� �nleyen conta ile izole edilmi� kap�.";
                break;

            case GameItemType.KimyasalTuvalet:
                itemName = "";
                itemDescription = "Acil durumlar i�in kullan�labilecek k�s�tl� kapasitede portatif tuvalet.";
                break;

            case GameItemType.OksijenDestegi:
                itemName = "Kimyasal tuvalet";
                itemDescription = "Kabine d��ar�dan verilen hava deste�inin kesintiye u�ramas� durumunda devreye giren depolanm�� oksijen deste�i.";
                break;

            case GameItemType.KisiselKurtarmaCihazi:
                itemName = "Ki�isel Kurtarma Cihaz�";
                itemDescription = "Her personele bir adet verilmek �zere bulundurulan ki�isel solunum cihaz�.(Alternatif ek solunum deste�i)";
                break;

        }

    }
}