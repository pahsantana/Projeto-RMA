using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandartAssets.Vehicles.Car;

public class CounterDownManager : MonoBehaviour
{
    public GameObject CounterLabel;
    //public AudioSource ReadySound;
    //public AudioSource GoSound;
    public GameObject Car;
    public GameObject LapTimer;

    void Start()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown(){
        yield return new WaitForSeconds(0.03f);
        CounterLabel.GetComponent<Text>().text = "3";
        //ReadySound.Play();
        CounterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        CounterLabel.SetActive(false);
        CounterLabel.GetComponent<Text>().text = "2";
        //ReadySound.Play();
        CounterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        CounterLabel.SetActive(false);
        CounterLabel.GetComponent<Text>().text = "1";
        //ReadySound.Play();
        CounterLabel.SetActive(true);
        yield return new WaitForSeconds(1);
        CounterLabel.SetActive(false);
        //GoSound.Play();

        //Car.GetComponent<CarController>().enabled = true;
        LapTimer.GetComponent<LapTimerDown>().enabled = true;
        
    }
}
