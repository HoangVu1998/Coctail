using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectShakeDIY : DetectShake
{
    public GameObject meunuIsShakeMan4;
    void Update()
    {
        if (DIYController.instance.isMan5)
        {
            uonghet = false;
            DIYController.instance.isMan5 = false;
            meunuIsShakeMan4.SetActive(true);

            //Vector3 acceleration = Input.acceleration;
            //lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
            //Vector3 deltaAcceleration = acceleration - lowPassValue;
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
    }
}
