using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour {

    Vector3 targetPosition;
    Vector3 lookAtTarget;
    Quaternion playerRot;
    float rotSpeed = 5;
    float speed = 10;
    public bool moving = false;
    private Animation anim;
    public static string CharIdle = "n";
    public static string CharWalk = "n";
    public static int movement = 0;
    public static bool battleReady;
    public GameObject player;


    /////////////////////////////////////////////////////  // anything between these comment blocks is stuff I've written
    //hexagon Parent
    private Transform hexParent;

    //all the hexagons, children of the hexParent object
    private static List<Transform> hexSpaces;
    ////////////////////////////////////////////////////

    // Use this for initialization
    void Start () {

        DontDestroyOnLoad(this);        

        battleReady = false;
        anim = player.GetComponent<Animation>();

        CreateListOfHexes();
        hexSpaces = new List<Transform>();

    }
	
	// Update is called once per frame
	void Update () {

        if ((SceneManager.GetActiveScene().name == "Village Mockup" || SceneManager.GetActiveScene().name == "Forest Level" || SceneManager.GetActiveScene().name == "Coastal Level" || SceneManager.GetActiveScene().name == "Newgrange Level") || SceneManager.GetActiveScene().name == "Castle Level" && hexSpaces.Count == 0)
        {
            CreateListOfHexes();
        }

        if (SceneManager.GetActiveScene().name == "Village Mockup" || SceneManager.GetActiveScene().name == "Forest Level" || SceneManager.GetActiveScene().name == "Coastal Level" || SceneManager.GetActiveScene().name == "Newgrange Level" || SceneManager.GetActiveScene().name == "Castle Level")
        {

            player.SetActive(true);

            if (CharIdle == "y")
            {

                anim.Play("CharIdle");

            }

            if (CharWalk == "y")

            {

                anim.Play("Run Cycle");

            }

            if (Input.GetMouseButton(0))
            {

                SetTargetPosition();

            }
            if (moving)

                Move();

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex1 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Village Mockup")
            {
                SceneManager.LoadScene("Battle System Quiz 1", LoadSceneMode.Single);
               
            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex2 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Village Mockup")
            {
                SceneManager.LoadScene("Battle System Quiz 2", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex3 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Village Mockup")
            {
                SceneManager.LoadScene("Battle System Quiz 3", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score >= 3000 && SceneManager.GetActiveScene().name == "Village Mockup")
            {
                Reset();
                SceneManager.LoadScene("Village Boss Scene", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score < 3000 && SceneManager.GetActiveScene().name == "Village Mockup")
            {
                Reset();

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex1 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Forest Level")
            {
                SceneManager.LoadScene("Forest Battle 1", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex2 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Forest Level")
            {
                SceneManager.LoadScene("Forest Battle 2", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex3 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Forest Level")
            {
                SceneManager.LoadScene("Forest Battle 3", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score >= 9000 && SceneManager.GetActiveScene().name == "Forest Level")
            {
                Reset();
                SceneManager.LoadScene("Forest Boss Scene 1", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score < 9000 && SceneManager.GetActiveScene().name == "Forest Level")
            {
                Reset();

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex1 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Coastal Level")
            {
                SceneManager.LoadScene("Coastal Battle 1", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex2 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Coastal Level")
            {
                SceneManager.LoadScene("Coastal Battle 2", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex3 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Coastal Level")
            {
                SceneManager.LoadScene("Coastal Battle 3", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score >= 20000 && SceneManager.GetActiveScene().name == "Coastal Level")
            {
                Reset();
                SceneManager.LoadScene("Coastal Boss Scene 1", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score < 20000 && SceneManager.GetActiveScene().name == "Coastal Level")
            {
                Reset();

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex1 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Newgrange Level")
            {
                SceneManager.LoadScene("Newgrange Battle 1", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex2 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Newgrange Level")
            {
                SceneManager.LoadScene("Newgrange Battle 2", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex3 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Newgrange Level")
            {
                SceneManager.LoadScene("Newgrange Battle 3", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score >= 30000 && SceneManager.GetActiveScene().name == "Newgrange Level")
            {
                Reset();
                SceneManager.LoadScene("Newgrange Boss Scene 1", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score < 30000 && SceneManager.GetActiveScene().name == "Newgrange Level")
            {
                Reset();
            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex1 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Castle Level")
            {
                SceneManager.LoadScene("Castle Battle 1", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex2 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Castle Level")
            {
                SceneManager.LoadScene("Castle Battle 2", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHex3 && moving == false && battleReady == true && SceneManager.GetActiveScene().name == "Castle Level")
            {
                SceneManager.LoadScene("Castle Battle 3", LoadSceneMode.Single);

            }

            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score >= 40000 && SceneManager.GetActiveScene().name == "Castle Level")
            {
                Reset();
                SceneManager.LoadScene("Castle Boss Scene 1", LoadSceneMode.Single);

            }


            if (hexSpaces[movement].GetComponent<Hex>().isBattleHexBattle && moving == false && battleReady == true && ScoreManager.Score < 40000 && SceneManager.GetActiveScene().name == "Castle Level")
            {
                Reset();                
            }

        }
        else
        {
            hexSpaces = new List<Transform>();
            battleReady = false;
            player.SetActive(false);
        }
    }

    void SetTargetPosition()

    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))

        {
            //targetPosition = hit.point;
            targetPosition = new Vector3(hexSpaces[movement].position.x, transform.position.y, hexSpaces[movement].position.z);
            GameObject ourHitObject = hit.collider.transform.gameObject;
            //if (ourHitObject.GetComponent<Hex>() != null)
            if (ourHitObject.GetComponent<Hex>().hexValue == movement && ourHitObject.GetComponent<Hex>().isBattleHex == true)
            {
                this.transform.LookAt(targetPosition);

                CharIdle = "n";
                CharWalk = "y";
                //lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.z);
                lookAtTarget = new Vector3(hexSpaces[movement].position.x, transform.position.y, hexSpaces[movement].position.z);
                playerRot = Quaternion.LookRotation(lookAtTarget);
                moving = true;
                battleReady = true;

            }

            else

            if (ourHitObject.GetComponent<Hex>().hexValue == movement && ourHitObject.GetComponent<Hex>().isBattleHex == false)
            {
                this.transform.LookAt(targetPosition);

                CharIdle = "n";
                CharWalk = "y";
                //lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.z);
                lookAtTarget = new Vector3(hexSpaces[movement].position.x, transform.position.y, hexSpaces[movement].position.z);
                playerRot = Quaternion.LookRotation(lookAtTarget);
                battleReady = false;
                moving = true;

                //if (movement >= 42)

                {

                    //CharIdle = "n";
                    //CharWalk = "y";
                    //lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.z);
                    //lookAtTarget = new Vector3(hexSpaces[41].position.x, transform.position.y, hexSpaces[41].position.z);
                    //playerRot = Quaternion.LookRotation(lookAtTarget);
                    //moving = true;

                }
            }

        }

        

    }

    void Move()

    {
        
        transform.rotation = Quaternion.Slerp(transform.rotation, playerRot, rotSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, rotSpeed * Time.deltaTime);

        if (transform.position == targetPosition)

        {

            CharWalk = "n";
            CharIdle = "y";
            VillageBoardController.diceRolled = false;
            ForestBoardController.diceRolled = false;
            CoastalBoardController.diceRolled = false;
            NewgrangeBoardController.diceRolled = false;
            CastleBoardController.diceRolled = false;
            moving = false;
            Camera.main.GetComponent<SaveSerializer>().Save();
        }  
    }

    void CreateListOfHexes()

    {
        hexParent = GameObject.FindGameObjectWithTag("HexParent").transform;

        hexSpaces = new List<Transform>();

        // "foreach" is just a For Loop that carries on for as many times as there are number of your chosen variable. In this
        // instance, the number of children that hexParent has (the total number of hexagons). Here, we're adding all of hexParent's children
        // to our list of hexagons
        foreach (Transform child in hexParent)
        {
            hexSpaces.Add(child);
        }
    }

    public static void Reset()
    {
        movement = 0;
        GameMusic.AudioPlayed = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(-0.02397828f, 0.003362048f, -0.03969407f);
        Camera.main.GetComponent<SaveSerializer>().Save();

    }

}
