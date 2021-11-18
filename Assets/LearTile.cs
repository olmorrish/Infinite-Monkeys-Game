using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearTile : MonoBehaviour {

    public char character;
    private Rigidbody2D rb;
    private Collider2D col;
    public TMPro.TextMeshProUGUI textMesh;

    private Image image;
    public Sprite passedSprite;
    public Sprite goalSprite;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        image = GetComponent<Image>();
    }

    public void Init(char charToSet) {
        character = charToSet;
        textMesh.text = charToSet.ToString();
    }

    private void FixedUpdate() {
        rb.AddForce(Vector2.left, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update() {
        if(transform.position.x < -25f) {
            Destroy(gameObject);
        }
    }

    public void MakeGoal() {
        image.sprite = goalSprite;
    }

    public void Pass() {
        gameObject.layer = LayerMask.NameToLayer("LearTilePassed"); //makes this tile only collide with other tiles
        image.sprite = passedSprite;
        //col.enabled = false;
    }
}
