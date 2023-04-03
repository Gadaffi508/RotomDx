using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningControl : MonoBehaviour
{
    public float timer;

    public void StartWarning()
    {
        StopAllCoroutines();
        StartCoroutine(OnActive());
    }

    IEnumerator OnActive()
    {
        yield return new WaitForSeconds(timer);
        gameObject.SetActive(false);
    }
}
