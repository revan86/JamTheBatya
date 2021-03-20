using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabPlayer;
    [SerializeField]
    private Transform pointSpawn;
    [SerializeField]
    private Transform pointFinish;
    private GameObject Player;
    [SerializeField]
    private Slider sliderAlcohol;
    private Alcohol alcohol;



    private float valueAlcohol;

    // Start is called before the first frame update
    void Start()
    {
        Player = Instantiate(prefabPlayer, pointSpawn.position, Quaternion.identity);
        alcohol = Player.GetComponent<Alcohol>();
        
    }

    // Update is called once per frame
    void Update()
    {

        sliderAlcohol.value = alcohol.alcohol;
    }
}
