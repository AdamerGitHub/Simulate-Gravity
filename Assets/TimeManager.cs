using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float timeSpeed = 1;

    public void SetSpeed(float speed)
    {
        timeSpeed = speed;

        Time.timeScale = timeSpeed;
        Time.fixedDeltaTime = 0.02f * timeSpeed;

        print(timeSpeed);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetSpeed(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetSpeed(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetSpeed(3);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetSpeed(0);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SetSpeed(10);
        }
    }
}
