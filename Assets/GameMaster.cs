using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameMaster : MonoBehaviour {

    private const string kingLearSceneI = "KING LEAR ACT I SCENE I. KING LEAR'S PALACE. ENTER KENT, GLOUCESTER, AND EDMUND KENT I THOUGHT THE KING HAD MORE AFFECTED THE DUKE OF ALBANY THAN CORNWALL. GLOUCESTER IT DID ALWAYS SEEM SO TO US: BUT NOW, IN THE DIVISION OF THE KINGDOM, IT APPEARS NOT WHICH OF THE DUKES HE VALUES MOST; FOR EQUALITIES ARE SO WEIGHED, THAT CURIOSITY IN NEITHER CAN MAKE CHOICE OF EITHER'S MOIETY.KENT IS NOT THIS YOUR SON, MY LORD? GLOUCESTER HIS BREEDING, SIR, HATH BEEN AT MY CHARGE: I HAVE SO OFTEN BLUSHED TO ACKNOWLEDGE HIM, THAT NOW I AM BRAZED TO IT.KENT I CANNOT CONCEIVE YOU.GLOUCESTER SIR, THIS YOUNG FELLOW'S MOTHER COULD: WHEREUPON SHE GREW ROUND-WOMBED, AND HAD, INDEED, SIR, A SON FOR HER CRADLE ERE SHE HAD A HUSBAND FOR HER BED. DO YOU SMELL A FAULT? KENT I CANNOT WISH THE FAULT UNDONE, THE ISSUE OF IT BEING SO PROPER. GLOUCESTER BUT I HAVE, SIR, A SON BY ORDER OF LAW, SOME YEAR ELDER THAN THIS, WHO YET IS NO DEARER IN MY ACCOUNT: THOUGH THIS KNAVE CAME SOMETHING SAUCILY INTO THE WORLD BEFORE HE WAS SENT FOR, YET WAS HIS MOTHER FAIR; THERE WAS GOOD SPORT AT HIS MAKING, AND THE WHORESON MUST BE ACKNOWLEDGED. DO YOU KNOW THIS NOBLE GENTLEMAN, EDMUND? EDMUND NO, MY LORD. GLOUCESTER MY LORD OF KENT: REMEMBER HIM HEREAFTER AS MY HONOURABLE FRIEND. EDMUND MY SERVICES TO YOUR LORDSHIP. KENT I MUST LOVE YOU, AND SUE TO KNOW YOU BETTER. EDMUND SIR, I SHALL STUDY DESERVING. GLOUCESTER HE HATH BEEN OUT NINE YEARS, AND AWAY HE SHALL AGAIN. THE KING IS COMING. SENNET. ENTER KING LEAR, CORNWALL, ALBANY, GONERIL, REGAN, CORDELIA, AND ATTENDANTS KING LEAR ATTEND THE LORDS OF FRANCE AND BURGUNDY, GLOUCESTER. GLOUCESTER I SHALL, MY LIEGE. EXEUNT GLOUCESTER AND EDMUND KING LEAR MEANTIME WE SHALL EXPRESS OUR DARKER PURPOSE. GIVE ME THE MAP THERE. KNOW THAT WE HAVE DIVIDED IN THREE OUR KINGDOM: AND 'TIS OUR FAST INTENT TO SHAKE ALL CARES AND BUSINESS FROM OUR AGE; CONFERRING THEM ON YOUNGER STRENGTHS, WHILE WE UNBURTHEN'D CRAWL TOWARD DEATH. OUR SON OF CORNWALL, AND YOU, OUR NO LESS LOVING SON OF ALBANY, WE HAVE THIS HOUR A CONSTANT WILL TO PUBLISH OUR DAUGHTERS' SEVERAL DOWERS, THAT FUTURE STRIFE MAY BE PREVENTED NOW.THE PRINCES, FRANCE AND BURGUNDY, GREAT RIVALS IN OUR YOUNGEST DAUGHTER'S LOVE, LONG IN OUR COURT HAVE MADE THEIR AMOROUS SOJOURN, AND HERE ARE TO BE ANSWER'D.TELL ME, MY DAUGHTERS,-- SINCE NOW WE WILL DIVEST US BOTH OF RULE, INTEREST OF TERRITORY, CARES OF STATE,-- WHICH OF YOU SHALL WE SAY DOTH LOVE US MOST? THAT WE OUR LARGEST BOUNTY MAY EXTEND WHERE NATURE DOTH WITH MERIT CHALLENGE.GONERIL, OUR ELDEST-BORN, SPEAK FIRST. GONERIL SIR, I LOVE YOU MORE THAN WORDS CAN WIELD THE MATTER; DEARER THAN EYE-SIGHT, SPACE, AND LIBERTY; BEYOND WHAT CAN BE VALUED, RICH OR RARE; NO LESS THAN LIFE, WITH GRACE, HEALTH, BEAUTY, HONOUR; AS MUCH AS CHILD E'ER LOVED, OR FATHER FOUND; A LOVE THAT MAKES BREATH POOR, AND SPEECH UNABLE; BEYOND ALL MANNER OF SO MUCH I LOVE YOU. CORDELIA ASIDE WHAT SHALL CORDELIA DO? LOVE, AND BE SILENT. LEAR OF ALL THESE BOUNDS, EVEN FROM THIS LINE TO THIS, WITH SHADOWY FORESTS AND WITH CHAMPAINS RICH'D, WITH PLENTEOUS RIVERS AND WIDE-SKIRTED MEADS, WE MAKE THEE LADY: TO THINE AND ALBANY'S ISSUE BE THIS PERPETUAL. WHAT SAYS OUR SECOND DAUGHTER, OUR DEAREST REGAN, WIFE TO CORNWALL? SPEAK. REGAN SIR, I AM MADE OF THE SELF-SAME METAL THAT MY SISTER IS, AND PRIZE ME AT HER WORTH. IN MY TRUE HEART I FIND SHE NAMES MY VERY DEED OF LOVE; ONLY SHE COMES TOO SHORT: THAT I PROFESS MYSELF AN ENEMY TO ALL OTHER JOYS, WHICH THE MOST PRECIOUS SQUARE OF SENSE POSSESSES; AND FIND I AM ALONE FELICITATE IN YOUR DEAR HIGHNESS' LOVE.CORDELIA ASIDE THEN POOR CORDELIA! AND YET NOT SO; SINCE, I AM SURE, MY LOVE'S MORE RICHER THAN MY TONGUE. KING LEAR TO THEE AND THINE HEREDITARY EVER REMAIN THIS AMPLE THIRD OF OUR FAIR KINGDOM; NO LESS IN SPACE, VALIDITY, AND PLEASURE, THAN THAT CONFERR'D ON GONERIL.NOW, OUR JOY, ALTHOUGH THE LAST, NOT LEAST; TO WHOSE YOUNG LOVE THE VINES OF FRANCE AND MILK OF BURGUNDY STRIVE TO BE INTERESS'D; WHAT CAN YOU SAY TO DRAW A THIRD MORE OPULENT THAN YOUR SISTERS? SPEAK. CORDELIA NOTHING, MY LORD. KING LEAR NOTHING! CORDELIA NOTHING. KING LEAR NOTHING WILL COME OF NOTHING: SPEAK AGAIN. CORDELIA UNHAPPY THAT I AM, I CANNOT HEAVE MY HEART INTO MY MOUTH: I LOVE YOUR MAJESTY ACCORDING TO MY BOND; NOR MORE NOR LESS. KING LEAR HOW, HOW, CORDELIA! MEND YOUR SPEECH A LITTLE, LEST IT MAY MAR YOUR FORTUNES. CORDELIA GOOD MY LORD, YOU HAVE BEGOT ME, BRED ME, LOVED ME: I RETURN THOSE DUTIES BACK AS ARE RIGHT FIT, OBEY YOU, LOVE YOU, AND MOST HONOUR YOU. WHY HAVE MY SISTERS HUSBANDS, IF THEY SAY THEY LOVE YOU ALL? HAPLY, WHEN I SHALL WED, THAT LORD WHOSE HAND MUST TAKE MY PLIGHT SHALL CARRY HALF MY LOVE WITH HIM, HALF MY CARE AND DUTY: SURE, I SHALL NEVER MARRY LIKE MY SISTERS, TO LOVE MY FATHER ALL. KING LEAR BUT GOES THY HEART WITH THIS? CORDELIA AY, GOOD MY LORD. KING LEAR SO YOUNG, AND SO UNTENDER? CORDELIA SO YOUNG, MY LORD, AND TRUE. KING LEAR LET IT BE SO; THY TRUTH, THEN, BE THY DOWER: FOR, BY THE SACRED RADIANCE OF THE SUN, THE MYSTERIES OF HECATE, AND THE NIGHT; BY ALL THE OPERATION OF THE ORBS FROM WHOM WE DO EXIST, AND CEASE TO BE; HERE I DISCLAIM ALL MY PATERNAL CARE, PROPINQUITY AND PROPERTY OF BLOOD, AND AS A STRANGER TO MY HEART AND ME HOLD THEE, FROM THIS, FOR EVER. THE BARBAROUS SCYTHIAN, OR HE THAT MAKES HIS GENERATION MESSES TO GORGE HIS APPETITE, SHALL TO MY BOSOM BE AS WELL NEIGHBOUR'D, PITIED, AND RELIEVED, AS THOU MY SOMETIME DAUGHTER.KENT GOOD MY LIEGE,-- KING LEAR PEACE, KENT! COME NOT BETWEEN THE DRAGON AND HIS WRATH. I LOVED HER MOST, AND THOUGHT TO SET MY REST ON HER KIND NURSERY. HENCE, AND AVOID MY SIGHT! SO BE MY GRAVE MY PEACE, AS HERE I GIVE HER FATHER'S HEART FROM HER! CALL FRANCE; WHO STIRS? CALL BURGUNDY. CORNWALL AND ALBANY, WITH MY TWO DAUGHTERS' DOWERS DIGEST THIS THIRD: LET PRIDE, WHICH SHE CALLS PLAINNESS, MARRY HER. I DO INVEST YOU JOINTLY WITH MY POWER, PRE-EMINENCE, AND ALL THE LARGE EFFECTS THAT TROOP WITH MAJESTY.OURSELF, BY MONTHLY COURSE, WITH RESERVATION OF AN HUNDRED KNIGHTS, BY YOU TO BE SUSTAIN'D, SHALL OUR ABODE MAKE WITH YOU BY DUE TURNS. ONLY WE STILL RETAIN THE NAME, AND ALL THE ADDITIONS TO A KING; THE SWAY, REVENUE, EXECUTION OF THE REST, BELOVED SONS, BE YOURS: WHICH TO CONFIRM, THIS CORONET PART BETWIXT YOU. GIVING THE CROWN KENT ROYAL LEAR, WHOM I HAVE EVER HONOUR'D AS MY KING, LOVED AS MY FATHER, AS MY MASTER FOLLOW'D, AS MY GREAT PATRON THOUGHT ON IN MY PRAYERS,-- KING LEAR THE BOW IS BENT AND DRAWN, MAKE FROM THE SHAFT. KENT LET IT FALL RATHER, THOUGH THE FORK INVADE THE REGION OF MY HEART: BE KENT UNMANNERLY, WHEN LEAR IS MAD. WHAT WILT THOU DO, OLD MAN? THINK'ST THOU THAT DUTY SHALL HAVE DREAD TO SPEAK, WHEN POWER TO FLATTERY BOWS? TO PLAINNESS HONOUR'S BOUND, WHEN MAJESTY STOOPS TO FOLLY. REVERSE THY DOOM; AND, IN THY BEST CONSIDERATION, CHEQUE THIS HIDEOUS RASHNESS: ANSWER MY LIFE MY JUDGMENT, THY YOUNGEST DAUGHTER DOES NOT LOVE THEE LEAST; NOR ARE THOSE EMPTY-HEARTED WHOSE LOW SOUND REVERBS NO HOLLOWNESS. KING LEAR KENT, ON THY LIFE, NO MORE. KENT MY LIFE I NEVER HELD BUT AS A PAWN TO WAGE AGAINST THY ENEMIES; NOR FEAR TO LOSE IT, THY SAFETY BEING THE MOTIVE. KING LEAR OUT OF MY SIGHT! KENT SEE BETTER, LEAR; AND LET ME STILL REMAIN THE TRUE BLANK OF THINE EYE. KING LEAR NOW, BY APOLLO,-- KENT NOW, BY APOLLO, KING, THOU SWEAR'ST THY GODS IN VAIN.KING LEAR O, VASSAL! MISCREANT! LAYING HIS HAND ON HIS SWORD ALBANY CORNWALL DEAR SIR, FORBEAR.KENT DO: KILL THY PHYSICIAN, AND THE FEE BESTOW UPON THY FOUL DISEASE. REVOKE THY DOOM; OR, WHILST I CAN VENT CLAMOUR FROM MY THROAT, I'LL TELL THEE THOU DOST EVIL. KING LEAR HEAR ME, RECREANT! ON THINE ALLEGIANCE, HEAR ME! SINCE THOU HAST SOUGHT TO MAKE US BREAK OUR VOW, WHICH WE DURST NEVER YET, AND WITH STRAIN'D PRIDE TO COME BETWEEN OUR SENTENCE AND OUR POWER, WHICH NOR OUR NATURE NOR OUR PLACE CAN BEAR, OUR POTENCY MADE GOOD, TAKE THY REWARD.FIVE DAYS WE DO ALLOT THEE, FOR PROVISION TO SHIELD THEE FROM DISEASES OF THE WORLD; AND ON THE SIXTH TO TURN THY HATED BACK UPON OUR KINGDOM: IF, ON THE TENTH DAY FOLLOWING, THY BANISH'D TRUNK BE FOUND IN OUR DOMINIONS, THE MOMENT IS THY DEATH. AWAY! BY JUPITER, THIS SHALL NOT BE REVOKED. KENT FARE THEE WELL, KING: SITH THUS THOU WILT APPEAR, FREEDOM LIVES HENCE, AND BANISHMENT IS HERE. TO CORDELIA THE GODS TO THEIR DEAR SHELTER TAKE THEE, MAID, THAT JUSTLY THINK'ST, AND HAST MOST RIGHTLY SAID! TO REGAN AND GONERIL AND YOUR LARGE SPEECHES MAY YOUR DEEDS APPROVE, THAT GOOD EFFECTS MAY SPRING FROM WORDS OF LOVE.THUS KENT, O PRINCES, BIDS YOU ALL ADIEU; HE'LL SHAPE HIS OLD COURSE IN A COUNTRY NEW. EXIT FLOURISH. RE-ENTER GLOUCESTER, WITH KING OF FRANCE, BURGUNDY, AND ATTENDANTS GLOUCESTER HERE'S FRANCE AND BURGUNDY, MY NOBLE LORD.KING LEAR MY LORD OF BURGUNDY.WE FIRST ADDRESS TOWARDS YOU, WHO WITH THIS KING HATH RIVALL'D FOR OUR DAUGHTER: WHAT, IN THE LEAST, WILL YOU REQUIRE IN PRESENT DOWER WITH HER, OR CEASE YOUR QUEST OF LOVE? BURGUNDY MOST ROYAL MAJESTY, I CRAVE NO MORE THAN WHAT YOUR HIGHNESS OFFER'D, NOR WILL YOU TENDER LESS.KING LEAR RIGHT NOBLE BURGUNDY, WHEN SHE WAS DEAR TO US, WE DID HOLD HER SO; BUT NOW HER PRICE IS FALL'N. SIR, THERE SHE STANDS: IF AUGHT WITHIN THAT LITTLE SEEMING SUBSTANCE, OR ALL OF IT, WITH OUR DISPLEASURE PIECED, AND NOTHING MORE, MAY FITLY LIKE YOUR GRACE, SHE'S THERE, AND SHE IS YOURS.BURGUNDY I KNOW NO ANSWER.KING LEAR WILL YOU, WITH THOSE INFIRMITIES SHE OWES, UNFRIENDED, NEW-ADOPTED TO OUR HATE, DOWER'D WITH OUR CURSE, AND STRANGER'D WITH OUR OATH, TAKE HER, OR LEAVE HER? BURGUNDY PARDON ME, ROYAL SIR; ELECTION MAKES NOT UP ON SUCH CONDITIONS.KING LEAR THEN LEAVE HER, SIR; FOR, BY THE POWER THAT MADE ME, I TELL YOU ALL HER WEALTH.TO KING OF FRANCE FOR YOU, GREAT KING, I WOULD NOT FROM YOUR LOVE MAKE SUCH A STRAY, TO MATCH YOU WHERE I HATE; THEREFORE BESEECH YOU TO AVERT YOUR LIKING A MORE WORTHIER WAY THAN ON A WRETCH WHOM NATURE IS ASHAMED ALMOST TO ACKNOWLEDGE HERS.KING OF FRANCE THIS IS MOST STRANGE, THAT SHE, THAT EVEN BUT NOW WAS YOUR BEST OBJECT, THE ARGUMENT OF YOUR PRAISE, BALM OF YOUR AGE, MOST BEST, MOST DEAREST, SHOULD IN THIS TRICE OF TIME COMMIT A THING SO MONSTROUS, TO DISMANTLE SO MANY FOLDS OF FAVOUR.SURE, HER OFFENCE MUST BE OF SUCH UNNATURAL DEGREE, THAT MONSTERS IT, OR YOUR FORE-VOUCH'D AFFECTION FALL'N INTO TAINT: WHICH TO BELIEVE OF HER, MUST BE A FAITH THAT REASON WITHOUT MIRACLE COULD NEVER PLANT IN ME.CORDELIA I YET BESEECH YOUR MAJESTY,-- IF FOR I WANT THAT GLIB AND OILY ART, TO SPEAK AND PURPOSE NOT; SINCE WHAT I WELL INTEND, I'LL DO'T BEFORE I SPEAK,--THAT YOU MAKE KNOWN IT IS NO VICIOUS BLOT, MURDER, OR FOULNESS, NO UNCHASTE ACTION, OR DISHONOUR'D STEP, THAT HATH DEPRIVED ME OF YOUR GRACE AND FAVOUR; BUT EVEN FOR WANT OF THAT FOR WHICH I AM RICHER, A STILL-SOLICITING EYE, AND SUCH A TONGUE AS I AM GLAD I HAVE NOT, THOUGH NOT TO HAVE IT HATH LOST ME IN YOUR LIKING. KING LEAR BETTER THOU HADST NOT BEEN BORN THAN NOT TO HAVE PLEASED ME BETTER. KING OF FRANCE IS IT BUT THIS,--A TARDINESS IN NATURE WHICH OFTEN LEAVES THE HISTORY UNSPOKE THAT IT INTENDS TO DO? MY LORD OF BURGUNDY, WHAT SAY YOU TO THE LADY? LOVE'S NOT LOVE WHEN IT IS MINGLED WITH REGARDS THAT STAND ALOOF FROM THE ENTIRE POINT.WILL YOU HAVE HER? SHE IS HERSELF A DOWRY. BURGUNDY ROYAL LEAR, GIVE BUT THAT PORTION WHICH YOURSELF PROPOSED, AND HERE I TAKE CORDELIA BY THE HAND, DUCHESS OF BURGUNDY.KING LEAR NOTHING: I HAVE SWORN; I AM FIRM.BURGUNDY I AM SORRY, THEN, YOU HAVE SO LOST A FATHER THAT YOU MUST LOSE A HUSBAND.CORDELIA PEACE BE WITH BURGUNDY! SINCE THAT RESPECTS OF FORTUNE ARE HIS LOVE, I SHALL NOT BE HIS WIFE.KING OF FRANCE FAIREST CORDELIA, THAT ART MOST RICH, BEING POOR; MOST CHOICE, FORSAKEN; AND MOST LOVED, DESPISED! THEE AND THY VIRTUES HERE I SEIZE UPON: BE IT LAWFUL I TAKE UP WHAT'S CAST AWAY. GODS, GODS! 'TIS STRANGE THAT FROM THEIR COLD'ST NEGLECT MY LOVE SHOULD KINDLE TO INFLAMED RESPECT. THY DOWERLESS DAUGHTER, KING, THROWN TO MY CHANCE, IS QUEEN OF US, OF OURS, AND OUR FAIR FRANCE: NOT ALL THE DUKES OF WATERISH BURGUNDY CAN BUY THIS UNPRIZED PRECIOUS MAID OF ME. BID THEM FAREWELL, CORDELIA, THOUGH UNKIND: THOU LOSEST HERE, A BETTER WHERE TO FIND. KING LEAR THOU HAST HER, FRANCE: LET HER BE THINE; FOR WE HAVE NO SUCH DAUGHTER, NOR SHALL EVER SEE THAT FACE OF HERS AGAIN. THEREFORE BE GONE WITHOUT OUR GRACE, OUR LOVE, OUR BENISON. COME, NOBLE BURGUNDY. FLOURISH. EXEUNT ALL BUT KING OF FRANCE, GONERIL, REGAN, AND CORDELIA KING OF FRANCE BID FAREWELL TO YOUR SISTERS. CORDELIA THE JEWELS OF OUR FATHER, WITH WASH'D EYES CORDELIA LEAVES YOU: I KNOW YOU WHAT YOU ARE; AND LIKE A SISTER AM MOST LOATH TO CALL YOUR FAULTS AS THEY ARE NAMED.USE WELL OUR FATHER: TO YOUR PROFESSED BOSOMS I COMMIT HIM BUT YET, ALAS, STOOD I WITHIN HIS GRACE, I WOULD PREFER HIM TO A BETTER PLACE.SO, FAREWELL TO YOU BOTH. REGAN PRESCRIBE NOT US OUR DUTIES. GONERIL LET YOUR STUDY BE TO CONTENT YOUR LORD, WHO HATH RECEIVED YOU AT FORTUNE'S ALMS. YOU HAVE OBEDIENCE SCANTED, AND WELL ARE WORTH THE WANT THAT YOU HAVE WANTED. CORDELIA TIME SHALL UNFOLD WHAT PLAITED CUNNING HIDES: WHO COVER FAULTS, AT LAST SHAME THEM DERIDES. WELL MAY YOU PROSPER! KING OF FRANCE COME, MY FAIR CORDELIA. EXEUNT KING OF FRANCE AND CORDELIA GONERIL SISTER, IT IS NOT A LITTLE I HAVE TO SAY OF WHAT MOST NEARLY APPERTAINS TO US BOTH. I THINK OUR FATHER WILL HENCE TO-NIGHT. REGAN THAT'S MOST CERTAIN, AND WITH YOU; NEXT MONTH WITH US.GONERIL YOU SEE HOW FULL OF CHANGES HIS AGE IS; THE OBSERVATION WE HAVE MADE OF IT HATH NOT BEEN LITTLE: HE ALWAYS LOVED OUR SISTER MOST; AND WITH WHAT POOR JUDGMENT HE HATH NOW CAST HER OFF APPEARS TOO GROSSLY.REGAN 'TIS THE INFIRMITY OF HIS AGE: YET HE HATH EVER BUT SLENDERLY KNOWN HIMSELF. GONERIL THE BEST AND SOUNDEST OF HIS TIME HATH BEEN BUT RASH; THEN MUST WE LOOK TO RECEIVE FROM HIS AGE, NOT ALONE THE IMPERFECTIONS OF LONG-ENGRAFFED CONDITION, BUT THEREWITHAL THE UNRULY WAYWARDNESS THAT INFIRM AND CHOLERIC YEARS BRING WITH THEM. REGAN SUCH UNCONSTANT STARTS ARE WE LIKE TO HAVE FROM HIM AS THIS OF KENT'S BANISHMENT. GONERIL THERE IS FURTHER COMPLIMENT OF LEAVETAKING BETWEEN FRANCE AND HIM.PRAY YOU, LET'S HIT TOGETHER: IF OUR FATHER CARRY AUTHORITY WITH SUCH DISPOSITIONS AS HE BEARS, THIS LAST SURRENDER OF HIS WILL BUT OFFEND US. REGAN WE SHALL FURTHER THINK ON'T.GONERIL WE MUST DO SOMETHING, AND I' THE HEAT. EXEUNT";

    [Header("Prefab References")]
    public GameObject monkeyPrefab;
    public GameObject keyPressNotificationPrefab;
    public GameObject keyPressNotificationSuccessPrefab;
    public GameObject learTilePrefab;
    public GameObject endPanelPrefab;

    [Header("External References")]
    public GameObject canvas;
    public List<Transform> monkeySpawnPositions;
    public TMPro.TextMeshProUGUI whiteboardText;
    public TMPro.TextMeshProUGUI progressText;
    public TMPro.TextMeshProUGUI moneyText;
    public TMPro.TextMeshProUGUI costText;

    [Header("Lear Tile Spawn Data")]
    public float learTileClearDist;
    public int maxLearTilesOnscreen;
    public LayerMask whatIsLearTile;
    public Transform learTileSpawnPoint;
    private int learTileSpawnIndex;                 //the index in the string up to which Lear tiles have been spawned
    private int learTileGoalIndex;

    [Header("Internal State and Progression")]
    private List<Monkey> allMonkeys;
    private List<LearTile> allLearTiles;            //a queue; head is removed on correct key press
    public List<GameObject> allPlants;
    public List<GameObject> allPosters;
    private int numMonkeys;
    private int numPlants;
    private int numPosters;
    private Color darkRed;
    public int money;
    public bool sound;
    bool gameOver;

    [Header("Upgrade Costs")]
    public List<int> allMonkeyCosts;
    public List<int> allPlantCosts;
    public List<int> allPosterCosts;

    [Header("Music and SFX")]
    public AudioSource music;
    public AudioSource sfxSuccess;
    public AudioSource sfxKaching;

    // Start is called before the first frame update
    void Start() {

        //init state
        allMonkeys = new List<Monkey>();
        allLearTiles = new List<LearTile>();
        numMonkeys = 0;
        numPlants = 0;
        numPosters = 0;

        //Despawn all plants and posters
        foreach (GameObject plant in allPlants)
            plant.SetActive(false);
        foreach (GameObject poster in allPosters)
            poster.SetActive(false);

        //init progress
        learTileSpawnIndex = 0;
        learTileGoalIndex = 0;
        darkRed = costText.color;
        money = 0;
        sound = true;
        gameOver = false;

        //spawn first monkey and first tile
        SpawnMonkey();
        SpawnLearTile();
    }

    // Update is called once per frame
    void Update() {

        //set goal on first update
        if(learTileGoalIndex == 0) {
            allLearTiles[0].MakeGoal();
        }

        //spawn new lear tile if there is room and max not reached
        Collider2D[] cols = Physics2D.OverlapCircleAll(learTileSpawnPoint.position, learTileClearDist, whatIsLearTile);
        if (allLearTiles.Count < maxLearTilesOnscreen && cols.Length < 1) {
            SpawnLearTile();
        }

        //update progress and money feedback
        float progress = (((float)learTileGoalIndex) / ((float)kingLearSceneI.Length - 1))*100f;
        progressText.text = string.Format("{0:0.0000}%", progress);
        moneyText.text = "$" + money;

        //gameover check
        if (!gameOver && progress >= 100f) {
            gameOver = true;
            foreach(Monkey m in allMonkeys) {
                m.SetSpeed(0f);
            }
            Instantiate(endPanelPrefab, canvas.transform);
        }
    }

    /// <summary>
    /// Spawns a new monkey at the next available spawn position. The monkey is added to the allMonkeys list.
    /// </summary>
    private void SpawnMonkey() {

        if (monkeySpawnPositions.Count < numMonkeys + 1) {
            Debug.LogError("Cannot spawn monkey; not enough spawn positions.");
            return;
        }

        GameObject newMonkeyObj = Instantiate(monkeyPrefab, transform);
        Monkey newMonkey = newMonkeyObj.GetComponent<Monkey>();

        newMonkeyObj.transform.position = new Vector2(monkeySpawnPositions[numMonkeys].transform.position.x, monkeySpawnPositions[numMonkeys].transform.position.y);

        allMonkeys.Add(newMonkey);
        newMonkey.SetSpeed(1f);
        numMonkeys++;
        newMonkeyObj.name = "Monkey " + numMonkeys;
    }

    /// <summary>
    /// Called by Monkey script. Handles a key being hit by a monkey. 
    /// </summary>
    /// <param name="hitKey">The character the monkey hit.</param>
    /// <param name="monkey">The monkey that hit the character; the callee.</param>
    public void RegisterMonkeyKeyHit(char hitKey, Monkey monkey) {

        bool success = false;

        if (hitKey == kingLearSceneI[learTileGoalIndex] && allLearTiles.Count > 0) {
            success = true;

            if(allLearTiles[0].character == hitKey) {
                allLearTiles[0].Pass();     //turn the newly-passed LearTile pink and allow it to pass the barrier (see layers and physics collision rules)
                allLearTiles.RemoveAt(0);
                allLearTiles[0].MakeGoal(); //turn the new goal LearTile lighter blue
                money++;
                if(sound)
                    sfxSuccess.Play();
            }
            else {
                Debug.Log("DESYNC: the leading LearTile doesn't have a matching character to the goal index character in the string of text.");
            }
            learTileGoalIndex++;
        }

        //spawn the notification near the monkey on the canvas
        GameObject newNotification = Instantiate(success ? keyPressNotificationSuccessPrefab : keyPressNotificationPrefab, canvas.transform);
        newNotification.GetComponent<KeyPressNotification>().Init(hitKey, monkey.gameObject.transform, success);

    }

    /// <summary>
    /// Updates the whiteboard text and upgrade cost. 
    /// Called on misc UI events depending on where the mouse is on the canvas. 
    /// </summary>
    /// <param name="newText">A string denoting the type of message to display.</param>
    public void ChangeWhiteboardText(string newText) {

        costText.color = darkRed;

        switch (newText) {
            case "monkey":
                whiteboardText.text = "HIRE A NEW MONKEY";
                if (numMonkeys < 10) {
                    costText.text = "-$" + allMonkeyCosts[numMonkeys];
                }
                else {
                    costText.text = "MAX";
                }
                break;
            case "plant":
                whiteboardText.text = "BUY PLANT: ++BASE SPD";
                if(numPlants < 4) {
                    costText.text = "-$" + allPlantCosts[numPlants];
                }
                else {
                    costText.text = "MAX";
                }
                break;
            case "poster":
                whiteboardText.text = "BUY POSTER: ++SPD MULT";
                if(numPosters < 4) {
                    costText.text = "-$" + allPosterCosts[numPosters];
                }
                else {
                    costText.text = "MAX";
                }
                break;
            case "radio":
                whiteboardText.text = "TOGGLE MUSIC + SFX";
                costText.color = Color.black;
                costText.text = "SHOP";
                break;
            case "none":
                whiteboardText.text = "WRITE SOME SHAKESPEARE!";
                costText.color = Color.black;
                costText.text = "SHOP";
                break;
        }
    }

    /// <summary>
    /// Recalculates all monkey speeds. 
    /// Called whenever a new upgrade is purchased to ensure all monkeys work at the same speed. 
    /// </summary>
    private void UpdateAllMonkeySpeed() {
        float speedToSet = 1;
        speedToSet += (0.5f * numPosters);
        if(numPlants > 0)
            speedToSet *= 1 + (numPlants * 0.5f);

        foreach(Monkey m in allMonkeys) {
            m.SetSpeed(speedToSet);
        }
    }

    /// <summary>
    /// Handles monkey hiring. Called by menu button. 
    /// </summary>
    public void AttemptToBuyMonkey() {

        if(money >= allMonkeyCosts[numMonkeys]) {
            money -= allMonkeyCosts[numMonkeys];
            if(sound)
                sfxKaching.Play();
            SpawnMonkey();
            UpdateAllMonkeySpeed();
        }
    }

    /// <summary>
    /// Handles plant purchases. Called by menu button. 
    /// </summary>
    public void AttemptToBuyPlants() {

        if (money >= allPlantCosts[numPlants]) {
            money -= allPlantCosts[numPlants];
            if(sound)
                sfxKaching.Play();

            if (numPlants < 4) {
                allPlants[numPlants].SetActive(true);
                numPlants++;
                UpdateAllMonkeySpeed();
            }
            else {
                whiteboardText.text = "No more room for plants!";
            }
        }
    }

    /// <summary>
    /// Handles poster purchases. Called by menu button.
    /// </summary>
    public void AttemptToBuyPosters() {

        if (money >= allPosterCosts[numPosters]) {
            money -= allPosterCosts[numPosters];
            if(sound)
                sfxKaching.Play();

            if (numPosters < 4) {
                allPosters[numPosters].SetActive(true);
                numPosters++;
                UpdateAllMonkeySpeed();
            }
            else {
                whiteboardText.text = "No more room for posters!";
            }
        }
    }

    /// <summary>
    /// Toggles the music play/pause state and sound boolean. 
    /// </summary>
    public void ToggleMusic() {
        sound = !sound;
        if (sound)
            music.Play();
        else
            music.Pause();
    }

    /// <summary>
    /// Spawns and initializes a lear tile, which denotes a letter the player must press.
    /// This updates the index within the full text as well. 
    /// </summary>
    public void SpawnLearTile() {
        if (learTileSpawnIndex < kingLearSceneI.Length) {
            GameObject newLearTileObj = Instantiate(learTilePrefab, canvas.transform);
            newLearTileObj.transform.position = new Vector2(learTileSpawnPoint.transform.position.x, learTileSpawnPoint.transform.position.y);
            newLearTileObj.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 2f, ForceMode2D.Impulse);

            LearTile newLearTile = newLearTileObj.GetComponent<LearTile>();
            newLearTile.Init(kingLearSceneI[learTileSpawnIndex]);
            allLearTiles.Add(newLearTile);
            learTileSpawnIndex++;
        }
    }
}
