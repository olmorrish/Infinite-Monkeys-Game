using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressNotification : MonoBehaviour {

    [Header("Parameters")]
    public TMPro.TextMeshProUGUI textMesh;
    public float timeToLive;
    private float deathTime;

    private void Start() {
        deathTime = Time.time + timeToLive;
    }

    // Update is called once per frame
    void Update() {
        if (Time.time > deathTime)
            Destroy(gameObject);
    }

    //Notifications float upwards slowly.
    private void FixedUpdate() {
        float xPos = transform.position.x;
        float yPos = transform.position.y + 0.015f;
        transform.position = new Vector2(xPos, yPos);
    }

    /// <summary>
    /// Initialize the notification. Called by spawning script. 
    /// </summary>
    /// <param name="c">Character to display.</param>
    /// <param name="spawnPos">Location to spawn notification.</param>
    /// <param name="invertTextColor">True if text should be black instead of white.</param>
    public void Init(char c, Transform spawnPos, bool invertTextColor) {
        textMesh.text = c.ToString();
        if (invertTextColor)
            textMesh.color = Color.black;
        gameObject.transform.position = new Vector2(spawnPos.position.x, spawnPos.position.y + 0.8f);
    }

}
