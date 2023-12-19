using System.Collections;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    //public Light light;
    public bool isPartyEnabled = false;
    public GameObject _light;
    public float timeToStart;

    // Start is called before the first frame update
    void Start()
    {
        //light = GetComponent<Light>();
    }

    void FixedUpdate()
    {
        if (!isPartyEnabled)
        {
            StartCoroutine(BlinkingEffect());
        }
    }

    public IEnumerator BlinkingEffect()
    {
        yield return new WaitForSeconds(timeToStart);
        isPartyEnabled = true;
        _light.SetActive(true);
        yield return new WaitForSeconds(2f);
        _light.SetActive(false);
        yield return new WaitForSeconds(1f);
        _light.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        _light.SetActive(false);
        yield return new WaitForSeconds(0.8f);
        _light.SetActive(true);
        yield return new WaitForSeconds(1.6f);
        _light.SetActive(false);
        yield return new WaitForSeconds(0.6f);
        isPartyEnabled = false;
    }
}
