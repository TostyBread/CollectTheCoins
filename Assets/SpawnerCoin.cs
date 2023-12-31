using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnerCoin : MonoBehaviour
{

    public GameObject PrefabCoin;
    //coin spawn rate
    public float DurationLeft = 60f;

    public float SpawnInterval = 1f;
    //coin spawning x-axis range
    public float MinX = -1f;
    public float MaxX = 1f;

    public static float CoinsCollected = 0f;
    public TMP_Text Text;

    private float randomX;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }

        else
        {
            float rand = Random.Range(MinX, MaxX);//Coins spawn at random X-axis

            Vector3 randomPos = new Vector3(rand, 0f, 0f);

            if(PrefabCoin != null)
            {
                GameObject.Instantiate(PrefabCoin, position:transform.position + randomPos, transform.rotation);
            }
            //Debug.Log(message:"Times up, should spawn coin");
            spawnTimer = SpawnInterval;
        }
    }

    public void AddCoins(float amount)
    {
        CoinsCollected += amount;
        //Debug.Log(message:"Collected coins " + CoinsCollected);

        if(Text != null)//Coin counter
        {
            Text.text = CoinsCollected.ToString();
        }
    }
}
