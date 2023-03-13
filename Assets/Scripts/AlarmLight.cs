using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLight : MonoBehaviour
{
    public Light lightL;

    void Start()
    {
        StartCoroutine(Light());
    }

    IEnumerator Light()
    {
        for (float f = 6f; f >= 1f; f -= 0.2f)
        {
            lightL.intensity = f;
            yield return new WaitForSeconds(0.015f);
        }
        for (float f = 1f; f <= 6f; f += 0.2f)
        {
            lightL.intensity = f;
            yield return new WaitForSeconds(0.015f);
        }
        StartCoroutine(Light());
    }
}
