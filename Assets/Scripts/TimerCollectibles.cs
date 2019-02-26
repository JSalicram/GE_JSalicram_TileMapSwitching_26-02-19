using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCollectibles : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D otherColliderInCollision)
    {
        LevelManager.instance.OnLevelItemTriggerEnter(otherColliderInCollision, this);
    }
}
