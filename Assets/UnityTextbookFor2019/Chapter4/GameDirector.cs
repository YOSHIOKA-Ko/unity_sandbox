using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    [SerializeField] private CarController car;
    [SerializeField] private SpriteRenderer flag;
    [SerializeField] private Text distance;

    private void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = length.ToString("F2");
    }
}
