using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicWater : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public GameObject[] points;

    void Start()
    {
        
    }

    void Update()
    {
        lineRenderer.positionCount = points.Length;
        for (int i = 0; i < points.Length; i++)
        {
            lineRenderer.SetPosition(i, points[i].transform.position);
        }        
    }
}
