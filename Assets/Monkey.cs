using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour {

    [Header("External References")]
    private GameMaster gameMaster;
    public GameObject keyPressNotificationPrefab;

    [Header("Internal References")]
    public Animator anim;
    
    public const string allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ .,':;?-";

    // Start is called before the first frame update
    void Awake() {
        gameMaster = GameObject.Find("GameMasterObject").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update() {
    }

    /// <summary>
    /// Called as animation event.
    /// </summary>
    public void HitRandomKey() {
        char hitKey = allChars[Random.Range(0, allChars.Length - 1)];
        gameMaster.RegisterMonkeyKeyHit(hitKey, this);

        Debug.Log("Hit: " + hitKey);
    }

    public float GetSpeed() {
        return anim.speed;
    }

    public void SetSpeed(float newSpeed) {
        anim.speed = newSpeed;
    }

    public void SpeedMultiplier(float multiplier) {
        anim.speed *= multiplier;
    }

    public void SpeedDelta(float delta) {
        anim.speed += delta;
    }
}
