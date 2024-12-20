using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;

public class araba : MonoBehaviour {

	// Use this for initialization
    public WheelJoint2D arka_tekerlek;
    public WheelJoint2D on_tekerlek;
    public float hiz;
    private float hareket;
    private float rot_ilk;
    private float rot_mevcut;
    private float rot_son;
    private float rot_ilk_t;
    private float rot_mevcut_t;
    private float rot_son_t;
    public int toplam_altin;
    public Text altin_texti;
    public Image yakit_resmi;
    public float toplam_yakit = 142;
    public float yakit_azalma_hiz;
    public Sprite spritemiz;
    public Texture2D texture_resim;
    public bool hayatta_mi = true;
    float mevcut_yakit;
    public Text text_takla;
    public int altin_miktari_takla;
    public float sayac = 0.1f;
    public GameObject panel;
    public Image gosterilen_resim;
    public Text takla_sayisi_text;
    public Text ters_takla_sayisi_text;
    public Text altin_sayisi_text;
    private int takla_sayisi = 0;
    private int ters_takla_sayisi = 0;
    public bool gas;
    public bool fren;
    public float ivme;
    public int kaydet_altin;
    public GameObject tofaskbutton;
    public int fiyat;
    public int fiyat2;
    public GameObject satınbutton;
    public int sosisci;
    public int Karakterid;
    public GameObject karakter1;
    public GameObject karakter2;
    public int mapler;
    public GameObject mapsatıngıt;
    public GameObject mapsecgel;
    public GameObject mapsatıngıt2;
    public GameObject mapsecgel2;
    public int mapfiyat1;
    public int mapfiyat2;
    public GameObject arabaseclisi;
    public GameObject arabal;
    public int gtraraba;
    public float mesafe;
    public Transform BaslangıcNoktası;
    public Text mesafeYazisi;
    private RewardedAd rewardedAd;
    public Button reklams;
    public Text kontrol_metni;
    public int reklamodullupara;
    public int odullungeldi = 500;
    private InterstitialAd interstitial;
    public GameObject parayok;

    void Start () {    
        rot_mevcut = transform.rotation.eulerAngles.z;
        rot_ilk = rot_mevcut;
        rot_son = rot_mevcut;
        rot_mevcut_t = transform.rotation.eulerAngles.z;
        rot_ilk_t = rot_mevcut_t;
        rot_son_t = rot_mevcut_t;
        ivme = 0;
        kaydet_altin = PlayerPrefs.GetInt("altin");
        Debug.Log(kaydet_altin);
        PlayerPrefs.SetInt("Satıldı", 1);
        Karakterid = PlayerPrefs.GetInt("Karakterid");
        mapler = PlayerPrefs.GetInt("mapler");
        gtraraba = PlayerPrefs.GetInt("gtraraba");
        reklamodullupara = PlayerPrefs.GetInt("reklamodullu");

#if UNITY_ANDROID
        string gecisreklamkodu = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string gecisreklamkodu = "ca-app-pub-3940256099942544/4411468910";
#else
        string gecisreklamkodu = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(gecisreklamkodu);

        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.interstitial.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        // Create an empty ad request.
        AdRequest arequest = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(arequest);




        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/5224354917"; // buraya kendi reklam kodumuz eklenecek!!
#elif UNITY_IPHONE
adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
adUnitId = "unexpected_platform";
#endif
        MobileAds.Initialize(initStatus => { });
        this.rewardedAd = new RewardedAd(adUnitId);

        // Reklam çağırma işlemi başarılı ise
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Reklam çağırma işlemi başarısız ise
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // reklam gösterilmeye başlandığında
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // reklam gösterilmesinde hata olduysa
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // reklam başarılı bir şekilde izlendiğinde.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Reklam erkenden kapatılırsa
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        AdRequest request = new AdRequest.Builder().Build();

        this.rewardedAd.LoadAd(request);
    }


  

    // Update is called once per frame
    void Update () {
        PlayerPrefs.SetInt("reklamodullu", reklamodullupara);
        PlayerPrefs.SetInt("Karakterid", Karakterid);
        PlayerPrefs.SetInt("mapler", mapler);
        PlayerPrefs.SetInt("gtraraba", gtraraba);
        mesafe = Vector2.Distance(BaslangıcNoktası.position,transform.position);
        mesafeYazisi.text = (int)mesafe + " Meter";

        if (Karakterid == 1)
        {
            PlayerPrefs.GetInt("altin");
            karakter1.SetActive(true);
            karakter2.SetActive(false);



        
        }
        if (Karakterid == 2)
        {
            
            karakter1.SetActive(true);
            karakter2.SetActive(false);
        }
        if (Karakterid==3)
        {
         
            karakter1.SetActive(false);
            karakter2.SetActive(true);
           
        }

        if (gtraraba == 4)
        {
            PlayerPrefs.GetInt("altin");
            arabaseclisi.SetActive(true);
            arabal.SetActive(false);




        }
        if (gtraraba == 5)
        {

            arabaseclisi.SetActive(true);
            arabal.SetActive(false);
        }
    


        if (mapler==1)
        {
            PlayerPrefs.GetInt("altin");
            mapsatıngıt.SetActive(false);
            mapsecgel.SetActive(true);

        }

       

        if (mapler == 3)
        {
            PlayerPrefs.GetInt("altin");
            mapsatıngıt2.SetActive(false);
            mapsecgel2.SetActive(true);
            mapsatıngıt.SetActive(false);
            mapsecgel.SetActive(true);

        }
        

        if (mapler == 5)
        {
            mapsatıngıt.SetActive(true);
            mapsecgel.SetActive(false);

            mapsatıngıt2.SetActive(true);
            mapsecgel2.SetActive(false);
        }

        if(reklamodullupara==3)
        {
            
        }





        if (!hayatta_mi)
        {
            return;
        }


        //float v = Input.GetAxis("Horizontal");
        //hareket = hiz * v;
        if (gas)
        {
            ivme += 0.009f;
            if (ivme > 1f)
            {
                ivme = 1f;
            }
        }
        if (fren)
        {
            ivme -= 0.009f;
            if (ivme < -1f)
            {
                ivme = -1f;
            }
        }
        if (gas == false && fren == false)
        {
            ivme = 0;
        }
        hareket = hiz * ivme;
      Takla();
      TersTakla();
      RectTransform asd = yakit_resmi.GetComponent<RectTransform>();
      mevcut_yakit = asd.sizeDelta.x - Time.deltaTime * yakit_azalma_hiz;
      asd.sizeDelta = new Vector2(mevcut_yakit, asd.sizeDelta.y);
      altin_texti.text = kaydet_altin.ToString();
      if (mevcut_yakit < 0)
      {
          Resim_Cek();
      }
      if (text_takla.text != "")
      {
          sayac -= Time.deltaTime;
      }
      if (sayac <= 0)
      {
          text_takla.text = "";
          sayac = 0.1f;
      }
	}
    void FixedUpdate()
    {
        if (hareket == 0)
        {
            arka_tekerlek.useMotor = false;
            on_tekerlek.useMotor = false;
        }
        else 
        {
            arka_tekerlek.useMotor = true;
            on_tekerlek.useMotor = true;
            JointMotor2D motore = new JointMotor2D();
            motore.motorSpeed = hareket;
            motore.maxMotorTorque = 10000;
            arka_tekerlek.motor = motore;
            on_tekerlek.motor = motore;
        }
     
    }
    void Takla()
    {
        rot_mevcut = transform.rotation.eulerAngles.z;
        if (rot_son < rot_mevcut)
        {
            rot_ilk = rot_mevcut;
        }
        else if (rot_son > rot_mevcut && rot_son - rot_mevcut > 100)
        {
            rot_ilk = rot_mevcut;
        }
        if (rot_ilk - rot_mevcut > 300)
        {
            rot_ilk = rot_mevcut;
            text_takla.text = "Flip +" + altin_miktari_takla;
            kaydet_altin += altin_miktari_takla;
            takla_sayisi++;
        }
        rot_son = rot_mevcut;
    }
    void TersTakla()
    {
        rot_mevcut_t = transform.rotation.eulerAngles.z;
        if (rot_son_t > rot_mevcut_t)
        {
            rot_ilk_t = rot_mevcut_t;
        }
        else if (rot_son_t < rot_mevcut_t && rot_mevcut_t - rot_son_t > 100)
        {
            rot_ilk_t = rot_mevcut_t;
        }
        if (rot_mevcut_t - rot_ilk_t > 300)
        {
            rot_ilk_t = rot_mevcut_t;
            text_takla.text = "Back Flip +" + altin_miktari_takla;
            kaydet_altin += altin_miktari_takla;
            ters_takla_sayisi++;
        }
        rot_son_t = rot_mevcut_t;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "altin")
        {
            int miktar = coll.GetComponent<altinn>().miktar;
            kaydet_altin += miktar;
            toplam_altin += miktar;
            GameObject.Destroy(coll.gameObject);
            altin_texti.text = toplam_altin.ToString();
        }
        if (coll.gameObject.tag == "yakit")
        {
            RectTransform asd = yakit_resmi.GetComponent<RectTransform>();
            asd.sizeDelta = new Vector2(toplam_yakit, asd.sizeDelta.y);
            GameObject.Destroy(coll.gameObject);
        }
    }
    public void Resim_Cek()
    {
        if (!hayatta_mi)
        {
            return;
        }

       // kaydet_altin += toplam_altin;
        PlayerPrefs.SetInt("altin", kaydet_altin);
        Texture2D text = new Texture2D(Screen.width/2, Screen.height/2, TextureFormat.RGB24, false);
        texture_resim = new Texture2D(Screen.width/2, Screen.height/2);
        text.ReadPixels(new Rect(Screen.width/4,Screen.height/4 , Screen.width/2, Screen.height/2), 0, 0);
        text.Apply();
        texture_resim = text;
        text.Compress(false);
        spritemiz = Sprite.Create(texture_resim, new Rect(0, 0, texture_resim.width, texture_resim.height), new Vector2(0, 0));
        hayatta_mi = false;
        panel.SetActive(true);
        gosterilen_resim.sprite = spritemiz;
        takla_sayisi_text.text = "Flip: " + takla_sayisi;
        ters_takla_sayisi_text.text = "Back Flip: " + ters_takla_sayisi;
        altin_sayisi_text.text = "Gold: " + toplam_altin;
    }
    public void Tekrar_Oyna()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Gas_press()
    {
        gas = true;
    }
    public void Gas_break()
    {

        gas = false;
    }
    public void Fren_press()
    {
        fren = true;
    }
    public void Fren_break()
    {
        fren = false;
    }

    public void market1()
    {
        if (kaydet_altin >= fiyat)
        {
            Karakterid = 1;
            kaydet_altin -= fiyat;

            PlayerPrefs.SetInt("altin",kaydet_altin);
            
        }
        else
        {
            Debug.Log("para yetmiyo");
            parayok.SetActive(true);
        }



    }
    public void market2()
    {
        Karakterid = 2;
   
    }

    public void market3()
    {
        if (kaydet_altin >= fiyat2)
        {
            gtraraba = 4;
            kaydet_altin -= fiyat2;

            PlayerPrefs.SetInt("altin", kaydet_altin);

        }
        else
        {
            Debug.Log("para yetmiyo");
            parayok.SetActive(true);
        }



    }
    public void market4()
    {
        gtraraba = 5;

    }

    public void silmek()
    {
        Karakterid = 3;
        PlayerPrefs.SetInt("Karakterid",Karakterid);
    }

    public void mapmarket()
    {
        if (kaydet_altin >= mapfiyat1)
        {
            mapler = 1;
            kaydet_altin -= mapfiyat1;

            PlayerPrefs.SetInt("altin", kaydet_altin);

        }
        else
        {
            Debug.Log("para yetmiyo");
            parayok.SetActive(true);
        }



    }
    

    public void mapmarket3()
    {
        if (kaydet_altin >= mapfiyat2)
        {
            mapler = 3;
            kaydet_altin -= mapfiyat2;

            PlayerPrefs.SetInt("altin", kaydet_altin);

        }
        else
        {
            Debug.Log("para yetmiyo");
            parayok.SetActive(true);
        }
    }
   

    public void mapsil()
    {
        mapler = 5;
        PlayerPrefs.SetInt("mapler", mapler);
    }


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        kontrol_metni.text = "reklam yüklendi";
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        kontrol_metni.text = "reklam yüklenemedi";
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        kontrol_metni.text = "reklam açık";
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        kontrol_metni.text = "reklam gösterilirken bir hata oluştu.";
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        kontrol_metni.text = "reklamı kapattın neden ? ";
        reklams.interactable = false;
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        

    }
    public void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
            kaydet_altin += odullungeldi;

            PlayerPrefs.SetInt("altin", kaydet_altin);

        }
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }

    public void gameodsd()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }

}

