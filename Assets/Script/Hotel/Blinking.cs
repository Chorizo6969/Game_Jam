using System.Collections;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    public Light light;
    public bool isPartyEnabled = false;
    public Color colorOff;
    public float timeToStart;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
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
        light.color = new Color(164, 141, 81);
        yield return new WaitForSeconds(1f);
        light.color = colorOff;
        yield return new WaitForSeconds(0.5f);
        light.color = new Color(164, 141, 81);
        yield return new WaitForSeconds(0.6f);
        light.color = colorOff;
        yield return new WaitForSeconds(0.4f);
        light.color = new Color(164, 141, 81);
        yield return new WaitForSeconds(0.8f);
        light.color = colorOff;
        yield return new WaitForSeconds(0.3f);
        isPartyEnabled = false;
    }
}
