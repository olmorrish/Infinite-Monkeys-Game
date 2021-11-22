using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearTile : MonoBehaviour {

    [Header("Internal References")]
    public char character;
    private Image image;
    private Rigidbody2D rb;
    private Collider2D col;
    public TMPro.TextMeshProUGUI textMesh;

    [Header("External References")]
    public Sprite passedSprite;
    public Sprite goalSprite;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        image = GetComponent<Image>();
    }

    /// <summary>
    /// Initialize the Lear Tile. Called by the spawning script. 
    /// </summary>
    /// <param name="charToSet">Character to display and internally remember.</param>
    public void Init(char charToSet) {
        character = charToSet;
        textMesh.text = charToSet.ToString();
    }

    //Lear Tiles float left slowly.
    private void FixedUpdate() {
        rb.AddForce(Vector2.left, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update() {
        if(transform.position.x < -25f) {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Changes the sprite to indicate this is the goal letter.
    /// </summary>
    public void MakeGoal() {
        image.sprite = goalSprite;
    }

    /// <summary>
    /// Changes the layer of the Lear Tile so it can pass through the invisible barrier and eventually despawn.
    /// Called on this tile if it's the first (goal) tile and it's char is pressed by a monkey.  
    /// </summary>
    public void Pass() {
        gameObject.layer = LayerMask.NameToLayer("LearTilePassed");
        image.sprite = passedSprite;
    }
}
