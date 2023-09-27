using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int CoinsAmount = 10;
    public GameObject CoinCollectedAudio;
    public GameObject Effects;


    public float DespawnInterval;
    private float despawnTimer;
    public Collider2D _Collider2D;

    private SpawnerCoin _spawner;

    // Start is called before the first frame update
    private void Start()
    {
        _Collider2D = GetComponent<Collider2D>();
        despawnTimer = DespawnInterval;
        _spawner = FindObjectOfType<SpawnerCoin>();
    }

    private void OnMouseOver()
    {
        //will sound the coin
        if (CoinCollectedAudio != null)
        {
           GameObject.Instantiate(CoinCollectedAudio, transform.position, Quaternion.identity);
        }
        //when coin collected
        if (Effects != null)
        {
            GameObject.Instantiate(Effects, transform.position, Quaternion.identity);
        }


        if (_spawner != null)
        {
            // spawner will add points to CoinsCollected
            _spawner.AddCoins(CoinsAmount);
        }

        //After collect coins
        Destroy(this.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (despawnTimer > 0)
        {
            despawnTimer -= Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
