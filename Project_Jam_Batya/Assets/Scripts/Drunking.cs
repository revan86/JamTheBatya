using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drunking : MonoBehaviour
{
   [SerializeField] private Sprite spr1, spr2, spr3;
    [SerializeField] private GameObject SpritePlayer;
    private Alcohol alcohol;
    // Start is called before the first frame update
    void Start()
    {
        alcohol = GetComponent<Alcohol>();
    }
     void Update()
    {
          //условие для замены спрайта

         if (alcohol.alcohol < 0.3f) {
             SpritePlayer.GetComponent<SpriteRenderer>().sprite = spr1;
         }
         if (alcohol.alcohol > 0.5f) {
            SpritePlayer.GetComponent <SpriteRenderer> ().sprite = spr2;
             }
        if (alcohol.alcohol > 0.8f)
        {
            SpritePlayer.GetComponent<SpriteRenderer>().sprite = spr3;
        }
      
       

      
    }
}
