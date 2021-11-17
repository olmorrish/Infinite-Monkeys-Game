using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressNotification : MonoBehaviour {

    public TMPro.TextMeshProUGUI textMesh;
    public float ttl;
    private float deathTime;

    private void Start() {
        deathTime = Time.time + ttl;
    }

    private void FixedUpdate() {
        float xPos = transform.position.x;
        float yPos = transform.position.y + 0.01f;
        transform.position = new Vector2(xPos, yPos);
    }

    public void Init(char c, Transform spawnPos) {
        textMesh.text = c.ToString();
        gameObject.transform.position = new Vector2(spawnPos.position.x, spawnPos.position.y + 1);
    }

    // Update is called once per frame
    void Update() {
        if (Time.time > deathTime)
            Destroy(gameObject);
    }
}
