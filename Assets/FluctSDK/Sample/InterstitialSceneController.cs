using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterstitialSceneController : MonoBehaviour
{
    public Button button;
    private FluctInterstitial interstitial;

    void Start()
    {
        interstitial = gameObject.AddComponent<FluctInterstitial>();
    }

    void Show()
    {
        interstitial.ShowInterstitial("0000000108");
    }
}