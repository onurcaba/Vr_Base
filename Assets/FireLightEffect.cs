using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLightEffect : MonoBehaviour
{
    public float rate = 0.1f;

    Light _light;
    private void Start()
    {
        _light = gameObject.GetComponent<Light>();

        InvokeRepeating("LightRandom", 0f, rate);
    }

    private void LightRandom()
    {
        _light.intensity = Random.Range(5, 30);
    }
}
