using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject tileMapA;
    public GameObject tileMapB;

    public bool Timing;

    public TimerController Timer;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;

    #if UNITY_EDITOR
        if (tileMapA == null || tileMapB == null)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    #else
        Application.Quit();
    #endif

    }

    public void OnLevelItemTriggerEnter(Collider2D otherColliderInCollision, TimerCollectibles itemInCollision)
    {
        if (itemInCollision.name == "Start")
        {
            Timing = true;
            Timer
        }

        if (itemInCollision.name == "Stop")
        {
            Timing = false;
        }

        Destroy(itemInCollision.gameObject);
    }

}
