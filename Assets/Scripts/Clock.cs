using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    [SerializeField] private Transform hoursPivotArm, minutesPivotArm, secondsPivotArm;
    private const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f ;
    private void Update()
    {
        var currentTime = DateTime.Now;

        hoursPivotArm.localRotation = Quaternion.Euler(0f,0f,(float) currentTime.TimeOfDay.TotalHours * hoursToDegrees);
        minutesPivotArm.localRotation = Quaternion.Euler(0f,0f,(float) currentTime.TimeOfDay.TotalMinutes * minutesToDegrees);
        secondsPivotArm.localRotation = Quaternion.Euler(0f,0f,(float) currentTime.TimeOfDay.TotalSeconds * secondsToDegrees);
    }
}
