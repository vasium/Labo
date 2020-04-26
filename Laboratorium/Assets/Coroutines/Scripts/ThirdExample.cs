// In this example we show how to invoke a coroutine using a string name and stop it.

using UnityEngine;
using System.Collections;

public class ThirdExample : MonoBehaviour
{
    IEnumerator Start()
    {
        StartCoroutine("DoSomething", 2.0f);
        yield return new WaitForSeconds(1);
        StopCoroutine("DoSomething");
    }

    IEnumerator DoSomething(float someParameter)
    {
        while (true)
        {
            print("DoSomething Loop");

            // Yield execution of this coroutine and return to the main loop until next frame
            yield return null;
        }
    }
}