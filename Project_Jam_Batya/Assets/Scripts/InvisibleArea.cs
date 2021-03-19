using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleArea : MonoBehaviour
{
    [SerializeField]
    private GameObject OutSideSprite;
    [SerializeField]
    private GameObject InSideSprite;




    // Start is called before the first frame update
    void Start()
    {
        OutSideSprite.SetActive(true);
        InSideSprite.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("InSide");
            OutSideSprite.SetActive(false);
            InSideSprite.SetActive(true);

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("OutSide");
            OutSideSprite.SetActive(true);
            InSideSprite.SetActive(false);
        }
    }
}
