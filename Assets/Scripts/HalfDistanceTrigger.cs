using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDistanceTrigger : MonoBehaviour
{
    public GameObject HalfPoint;

    public GameObject FinishPoint;

    void OnTriggerEnter(){
        HalfPoint.SetActive(false);
        FinishPoint.SetActive(true);
    }
}
