using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {
    public Text Timer;
    public int Time;

    IEnumerator TimeCoroutine()
    {
        while (LevelManager.instance.Timing)
        {
            Time++;

            yield return null;
        }
    }
	
}
