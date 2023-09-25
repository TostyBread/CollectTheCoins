using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int CoinsAmount = 10;
    public AudioSource _AudioSource;
    public GameObject CoinCollectedAudio;
    public GameObject Effects;

    public Collider2D _Collider2D;

    private SpawnerCoin _spawner;

    // Start is called before the first frame update
    private void Start()
    {
        _Collider2D = GetComponent<Collider2D>();

        _spawner = FindObjectOfType<SpawnerCoin>();

        _AudioSource = GetComponent<AudioSource>();
    }

    private void OnMouseOver()
    {

        if (CoinCollectedAudio != null)
        {
           GameObject.Instantiate(CoinCollectedAudio, transform.position, Quaternion.identity);
        }

        if (Effects != null)
        {
            GameObject.Instantiate(Effects, transform.position, Quaternion.identity);
        }


        if (_spawner != null)
        {
            // spawner will add points to CoinsCollected
            _spawner.AddCoins(CoinsAmount);
        }

        Destroy(this.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
