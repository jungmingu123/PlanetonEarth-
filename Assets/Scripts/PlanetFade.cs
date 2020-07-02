using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlanetFade : MonoBehaviour
    {
        Renderer renderer;
    public GameObject gameObject;
        void Start()
        {
        renderer = this.GetComponent<Renderer>();
        StartCoroutine("PlanetTimer");
    }

    IEnumerator PlanetTimer()
    {
        StartCoroutine("PlanetFadeIn");
        yield return new WaitForSeconds(7f);
        StartCoroutine("PlanetFadeOut");
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

        IEnumerator PlanetFadeOut()
        {
            int i = 50;
            while (i > 0)
            {
                i -= 1;
                float f = i / 50.0f;
                Color c = renderer.material.color;
                c.a = f;
                renderer.material.color = c;
                yield return new WaitForSeconds(0.02f);
            }
        }

        IEnumerator PlanetFadeIn()
        {
            int i = 0;
            while (i < 50)
            {
                i += 1;
                float f = i / 50.0f;
                Color c = renderer.material.color;
                c.a = f;
                renderer.material.color = c;
                yield return new WaitForSeconds(0.02f);
            }
        }

        void Update()
        {
        }
    }