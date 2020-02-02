using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitreShake : MonoBehaviour
{
    [SerializeField]
    private float shakeAtm;
    private float duration = 20;


    void OnMouseEnter()
    {
        StartCoroutine("Shakeit");
    }

    IEnumerator Shakeit()
    {
        Vector3 originalPos = transform.position;

        float elapsed = 0;

        while(elapsed < duration)
        {
            float x = Random.Range(-2f, 2f) * shakeAtm;
            transform.position = new Vector3(x, originalPos.y, originalPos.z);

            elapsed += Time.deltaTime;
        }

       

        yield return null;

        transform.position = originalPos;
    }
    

}
