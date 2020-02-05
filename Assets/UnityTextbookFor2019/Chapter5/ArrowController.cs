using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private ArrowController arrow;
    [SerializeField] private Camera mainCamera;

    Rect viewPortRect = new Rect(0, 0, 1,1);

    private void Update()
    {
        arrow.transform.Translate(0, -.1f, 0);

        var viewPortPosition = mainCamera.WorldToViewportPoint(arrow.transform.position);
        if (!viewPortRect.Contains(viewPortPosition))
        {
            Destroy(arrow.gameObject);
        }
    }
}
