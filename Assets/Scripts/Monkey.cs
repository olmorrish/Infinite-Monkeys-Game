using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour {

    [Header("External References")]
    private GameMaster gameMaster;
    public GameObject keyPressNotificationPrefab;

    [Header("Internal References and State")]
    public Animator anim;
    public const string allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ .,':;?!-";

    // Start is called before the first frame update
    void Awake() {
        gameMaster = GameObject.Find("GameMasterObject").GetComponent<GameMaster>();
    }

    /// <summary>
    /// Select a random key then notify the GameMaster for handling.
    /// Called as animation event whenever the monkey hits the typewriter in the animation. The speed of the monkey is controlled entirely via animator speed. 
    /// </summary>
    public void HitRandomKey() {
        char hitKey = allChars[Random.Range(0, allChars.Length)];
        gameMaster.RegisterMonkeyKeyHit(hitKey, this);
        //Debug.Log("Hit: " + hitKey);
    }

    /// <summary>
    /// Sets the speed of the animator. Called by GameMaster to sync monkey speeds. 
    /// </summary>
    /// <param name="newSpeed">The new speed multiplier.</param>
    public void SetSpeed(float newSpeed) {
        anim.speed = newSpeed;
    }
}
