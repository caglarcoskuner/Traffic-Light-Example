using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficlamb : MonoBehaviour
{
    public GameObject[] obje = new GameObject[3];
    float a;
    void Start()
    {
        obje[0].SetActive(false);
        obje[1].SetActive(false);
        obje[2].SetActive(false);
    }
    void Update()
    {
        a += Time.deltaTime*5;
        if (a <= 30)
        {
            obje[0].SetActive(true);

            if (a >= 27 && a <= 30)
            {
                obje[1].SetActive(true);
            }
        }
        else
        {
            obje[0].SetActive(false);
            obje[1].SetActive(false);
            obje[2].SetActive(true);
        }

        if (a >=50 && a<= 53)
        {
            obje[1].SetActive(true);
            obje[2].SetActive(false);
        }

        if (a >= 53)
        {
            a = 0;
            obje[1].SetActive(false);
            obje[2].SetActive(false);
        }
    }
}

