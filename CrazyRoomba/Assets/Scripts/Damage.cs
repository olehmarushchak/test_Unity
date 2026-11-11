using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float fadeDuration = 0.5f;
    private int hits;
    private Coroutine fadeCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("f"))
        //{
        //    Debug.Log("Furniture Scratched!! COUNT HIT:" + hits);

        //    StartCoroutine(Fade());
        //}
    }

    private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("Furniture Scratched!! COUNT HIT:" + hits);
        //GetComponent<MeshRenderer>().material.color = Color.red;
        StartColorFade(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        //GetComponent<MeshRenderer>().material.color = Color.white;
        StartColorFade(false);
    }

    private void StartColorFade(bool red)
    {
        if (fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }

        fadeCoroutine = StartCoroutine(FadeToColor(red));
    }

    private IEnumerator FadeToColor(bool red)
    {
        Color targetColor = red ? Color.red : Color.white;
        Color startColor = GetComponent<MeshRenderer>().material.color;
        float elapsed = 0f;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;

            float t = Mathf.Clamp01(elapsed / fadeDuration);

            GetComponent<MeshRenderer>().material.color =
                Color.Lerp(startColor, targetColor, t);

            yield return null;
        }

        GetComponent<MeshRenderer>().material.color = targetColor;
        fadeCoroutine = null;
    }
}
