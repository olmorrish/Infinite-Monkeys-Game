using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyPresetText : MonoBehaviour {

    [Header("External References")]
    public GameObject keyPressNotificationPrefab;
    public GameObject panel;

    [Header("Internal References")]
    public Animator anim;
    public float animSpeed;
    private int index;

    public string charsToIterateOver;

    // Start is called before the first frame update
    void Awake() {
        index = 0;
        SetSpeed(animSpeed);
    }

    // Update is called once per frame
    void Update() {

    }

    /// <summary>
    /// Called as animation event.
    /// </summary>
    public void HitRandomKey() {
        char hitKey = charsToIterateOver[index];

        GameObject newNotification = Instantiate(keyPressNotificationPrefab, panel.transform);
        newNotification.GetComponent<KeyPressNotification>().Init(hitKey, this.gameObject.transform, false);

        Debug.Log("Hit: " + hitKey);
        index = (index + 1) % charsToIterateOver.Length;
    }

    public void SetSpeed(float newSpeed) {
        anim.speed = newSpeed;
    }
}
