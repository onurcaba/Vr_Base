using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLightEffect : MonoBehaviour
{
    Light light;
    private void Start()
    {
        light = gameObject.GetComponent<Light>();

        InvokeRepeating("LightRandom", 0f, 0.1f);
    }

    private void LightRandom()
    {
        light.intensity = Random.Range(5, 20);
    }
}
