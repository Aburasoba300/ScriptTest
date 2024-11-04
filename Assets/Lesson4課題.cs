using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = { 43, 53, 89, 67, 23 };
        for (int i = 0; i < points.Length; i++)
        {
           for(int j = 0;j<points.Length; j++) 
            {
                if (points[i] < points[j])
                {
                    int x = points[j];
                    points[j] = points[i];
                    points[i] = x;

                }
            }
        }
        for (int k = 0; k < points.Length; k++)
        {
            Debug.Log(points[k]);
        }

        int[] points2 = { 19,97,73,59,31 };
        for (int i = 0; i < points2.Length; i++)
        {
            for (int j = 0; j < points2.Length; j++)
            {
                if (points2[i] > points2[j])
                {
                    int x = points2[j];
                    points2[j] = points2[i];
                    points2[i] = x;

                }
            }
        }
        for (int k = 0; k < points2.Length; k++)
        {
            Debug.Log(points2[k]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
