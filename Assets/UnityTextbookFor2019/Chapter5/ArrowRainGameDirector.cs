using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowRainGameDirector : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image hpGauge;

    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= .1f;
    }
}
