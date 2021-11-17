using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMaster : MonoBehaviour {

    public GameObject monkeyPrefab;
    private List<Monkey> allMonkeys;
    private int numMonkeys;

    // Start is called before the first frame update
    void Start() {
        allMonkeys = new List<Monkey>();
        numMonkeys = 0;
    }

    // Update is called once per frame
    void Update() {
        if (numMonkeys < 1)
            SpawnMonkey();
        
    }

    public void Step() {

    }

    private void SpawnMonkey() {
        GameObject newMonkey = Instantiate(monkeyPrefab, transform);
        numMonkeys++;
        newMonkey.name = "Monkey " + numMonkeys;

        allMonkeys.Add(newMonkey.GetComponent<Monkey>());



        newMonkey.GetComponent<Monkey>().SpeedMultiplier(5);
    }

    public void RegisterMonkeyKeyHit(char hitKey) {

    }
}
