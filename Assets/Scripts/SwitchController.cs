using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {
    public void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager.instance.tileMapA.SetActive(!LevelManager.instance.tileMapA.activeSelf);
        LevelManager.instance.tileMapB.SetActive(!LevelManager.instance.tileMapB.activeSelf);
    }
}
