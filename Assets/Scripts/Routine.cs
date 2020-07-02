using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;



public class Routine : MonoBehaviour
{
    public Text objText;
    public Color newColor;
    public bool check = true;
    public float fadeTime; //maybe rename this to fadeSpeed'

    public Transform moon;
    public Transform earth;
    public Transform jupiter;
    public Transform neptune;
    public Transform mars;
    public Transform uranus;
    public Transform venus;

    // Use this for initialization


    void Start()
    {
        fadeTime = 2f;
        StartCoroutine("Timer");
    }


    //note the change from 'void' to 'IEnumerator'

    IEnumerator FadeIn()
    {
        //ugly while, Update would be ideal
        while (objText.color.r >= 0)
        {
            objText.color = Color.Lerp(objText.color, Color.white, fadeTime * Time.deltaTime);
            yield return null;
        }
        //code after fading is finished
    }

    IEnumerator FadeOut()
    {
        //ugly while, Update would be ideal
        while (objText.color.a > 0)
        {
            objText.color = Color.Lerp(objText.color, newColor, fadeTime * Time.deltaTime);
            yield return null;
        }
        //code after fading is finished
    }



    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        objText.text = "안녕하세요, 행성에서 본 지구입니다. \n Welcome to Planet on Earth.";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        objText.text = "지금부터, 달부터 목성까지 행성을 보여드리겠습니다. \n From now on, we will show you Planets, moon to jupiter";
        yield return new WaitForSeconds(5f);
        objText.text = "각 행성의 크기는 실제 비율을 참고한 것입니다. \n The size of each planet is based on actual proportions.";
        yield return new WaitForSeconds(5f);
        objText.text = "그러면, 즐거운 감상 되세요 \n Then, have a nice Watch";
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(2.5f);
        StopCoroutine("FadeOut");

        StartCoroutine("Moon");
    }



    IEnumerator Moon()
    {

        Instantiate(moon, new Vector3(-210, 19, 124), Quaternion.identity);
        objText.text = "달 \n Moon";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StartCoroutine("Mars");
    }

    IEnumerator Mars()
    {

        Instantiate(moon, new Vector3(-210, 19, 124), Quaternion.identity);
        objText.text = "화성 \n Mars";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StartCoroutine("Venus");
    }

    IEnumerator Venus()
    {

        Instantiate(venus, new Vector3(-210, 19, 124), Quaternion.identity);
        objText.text = "금성 \n Venus";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StartCoroutine("Earth");
    }

    IEnumerator Earth()
    {

        Instantiate(earth, new Vector3(-210, 19, 124), Quaternion.identity);
        objText.text = "지구 \n Earth";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StartCoroutine("Neptune");
    }

    IEnumerator Neptune()
    {

        Instantiate(neptune, new Vector3(-210, 19, 124), Quaternion.identity);
        objText.text = "혜왕성 \n Neptune";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StartCoroutine("Uranus");
    }

    IEnumerator Uranus()
    {

        Instantiate(uranus, new Vector3(-210, 19, 124), Quaternion.identity);
        objText.text = "천왕성 \n Uranus";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StartCoroutine("Jupiter");
    }

    IEnumerator Jupiter()
    {

        Instantiate(jupiter, new Vector3(-210, 19, 124), Quaternion.identity);
        objText.text = "목성 \n Jupiter";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StartCoroutine("End");
    }

    IEnumerator End()
    {
        objText.text = "이상입니다. \n The End";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(1.5f);
        objText.text = "끝까지 시청해주셔서 감사합니다.. \n Thank you for watching this Video";
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(5f);
        StopCoroutine("FadeIn");
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
        StopCoroutine("FadeOut");
        yield return new WaitForSeconds(3f);
    }
}
