using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;


public class CameraController: MonoBehaviour {

    public GameObject playerPrefab;
    private Transform player;
    private string levelName;

	// Use this for initialization
	void Start ()
    {

        if (!GameObject.FindGameObjectWithTag("Player"))       
        { 
            Instantiate(playerPrefab);
        }

        player = GameObject.FindGameObjectWithTag("Player").transform;

        levelName = SceneManager.GetActiveScene().name;
        if ((levelName == "Coastal Level" || levelName == "Newgrange Level") && !player.name.ToLower().Contains("adult"))
        {
            ReplaceCharacter();
        }

        if (levelName == "Castle Level" && !player.name.ToLower().Contains("elder"))
        {
            ReplaceCharacter();
        }

        var filename = Path.Combine(Application.persistentDataPath, "playerprogress.json");

        if (File.Exists(filename))
        {            
            string jsonFromFile = File.ReadAllText( filename );
            SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
            player.position = copy.position;
            player.rotation = copy.rotation;
        }        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (player != null)
        transform.position = new Vector3(player.position.x, player.position.y + 1, player.position.z - 1);
        else
        player = player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private void ReplaceCharacter()
    {
        Destroy(player.gameObject);
        Instantiate(playerPrefab);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
