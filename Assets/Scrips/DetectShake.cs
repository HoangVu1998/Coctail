using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectShake : MonoBehaviour
{
    public static DetectShake instance;
    float accelerometerUpdateInterval = 1.0f / 60.0f;
    // The greater the value of LowPassKernelWidthInSeconds, the slower the
    // filtered value will converge towards current input sample (and vice versa).
    float lowPassKernelWidthInSeconds = 1.0f;
    // This next parameter is initialized to 2.0 per Apple's recommendation,
    // or at least according to Brady! ;)
    float shakeDetectionThreshold = 2.0f;
    public float lowPassFilterFactor;
    public Vector3 lowPassValue;
    public static bool uonghet;
    public GameObject meunuIsShake;

    void Start()
    {
        lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
        shakeDetectionThreshold *= shakeDetectionThreshold;
        lowPassValue = Input.acceleration;
        uonghet = false; 
    }

    void Update()
    {
        if (uonghet == true)
        {
            meunuIsShake.SetActive(true);
            Vector3 acceleration = Input.acceleration;
            lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
            Vector3 deltaAcceleration = acceleration - lowPassValue;
            uonghet = false;
            //if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold)
            //{
            //    // Perform your "shaking actions" here. If necessary, add suitable
            //    // guards in the if check above to avoid redundant handling during
            //    // the same shake (e.g. a minimum refractory period).
            //    LevelController.isShake = true;
            //    uonghet = false;
            //    meunuIsShake.SetActive(false); 
            //}
        }
        //if (DIYController.instance.isMan5)
        //{
        //    DIYController.instance.isMan5 = false;
        //    meunuIsShake.SetActive(true);

        //    //Vector3 acceleration = Input.acceleration;
        //    //lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
        //    //Vector3 deltaAcceleration = acceleration - lowPassValue;

        //    //if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold)
        //    //{
        //    //    // Perform your "shaking actions" here. If necessary, add suitable
        //    //    // guards in the if check above to avoid redundant handling during
        //    //    // the same shake (e.g. a minimum refractory period).
        //    //    LevelController.isShake = true;
        //    //    uonghet = false;
        //    //    meunuIsShake.SetActive(false); 
        //    //}
        //}

    }
    public void ResetGame()
    {
        LevelController.isShake = true;
        uonghet = false;
        meunuIsShake.SetActive(false);
    }
}
