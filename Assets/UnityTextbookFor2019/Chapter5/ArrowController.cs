using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private ArrowController arrow;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private PlayerController player;
    [SerializeField] private ArrowRainGameDirector director;

    Rect viewPortRect = new Rect(0, 0, 1,1);

    private void Update()
    {
        arrow.transform.Translate(0, -.1f, 0);

        var viewPortPosition = mainCamera.WorldToViewportPoint(arrow.transform.position);
        if (!viewPortRect.Contains(viewPortPosition))
        {
            Destroy(arrow.gameObject);
        }

        Vector2 p1 = arrow.transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = .5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            director.GetComponent<ArrowRainGameDirector>() .DecreaseHp();
            Destroy(arrow.gameObject);
        }
    }
}
