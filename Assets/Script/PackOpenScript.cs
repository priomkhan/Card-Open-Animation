using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackOpenScript : MonoBehaviour
{
    public Animator cardPackAnimator;
    public Animator cardfieldAnimator;
    public Animator animGameField;

    private GameObject cardPack;
    private GameObject cardfield;
    private GameObject GameField;

    private GameObject card1;
    private GameObject card2;

    public Animator card1Animator;
    public Animator card2Animator;

    public Sprite Epic;
    public Sprite Rare;
    public Sprite Basic;

    public Sprite cardType1;
    public Sprite cardType2;
    public Sprite cardType3;
    public Sprite cardType4;
    public Sprite cardType5;

    private BoxCollider boxCollider;

    private bool card1Revaied = false;
    private bool card2Revaied = false;

    // Use this for initialization
    void Start()
    {
        GameField = GameObject.Find("GameField");
        animGameField = GameField.GetComponent<Animator>();

        cardPack = GameObject.Find("CardPack");
        cardPackAnimator = cardPack.GetComponent<Animator>();

        cardfield = GameObject.Find("CardField");
        cardfieldAnimator = cardfield.GetComponent<Animator>();

        card1 = GameObject.Find("Card-1");
        card2 = GameObject.Find("Card-2");

        card1Animator = card1.GetComponent<Animator>();
        card2Animator = card2.GetComponent<Animator>();

        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
    }



    void OnMouseEnter()
    {
        Debug.Log("Mouse In Area");


        animGameField.enabled = false;
        cardPackAnimator.enabled = false;
        
       
        //cardPack.SetActive(false);
        if (this.gameObject.Equals(card1))
        {
            Debug.Log("Mouse In Card-1 Area");
            //cardAnimator1.enabled = true;
            card1Animator.SetBool("mouseHovering", true);

        }

        if (this.gameObject.Equals(card2))
        {
            Debug.Log("Mouse In Card-2 Area");
            //cardAnimator1.enabled = true;
            card2Animator.SetBool("mouseHovering", true);

        }


    }
    void OnMouseExit()
    {
        card1Animator.SetBool("mouseHovering", false);
        card2Animator.SetBool("mouseHovering", false);
    }

    void OnMouseDown() {
        Debug.Log("Mouse click Area");

        if (this.gameObject.Equals(card1))
        {
            Debug.Log("Mouse click Card-1 Area");
            //cardAnimator1.enabled = true;
            card1Animator.SetBool("mouseHovering", true);
            GameObject card1Rarity = card1.transform.GetChild(0).gameObject;
            GameObject card1Type = card1.transform.GetChild(1).gameObject;

            if(card1Revaied == false) {
                card1Rarity.gameObject.GetComponent<SpriteRenderer>().sprite = getRandomCardRarity();
                card1Type.gameObject.GetComponent<SpriteRenderer>().sprite = GetRendomCardType();
                card1Revaied = true;
            }

        }
        if (this.gameObject.Equals(card2))
        {
            Debug.Log("Mouse click Card-2 Area");
            //cardAnimator1.enabled = true;
            card2Animator.SetBool("mouseHovering", true);
            GameObject card2Rarity = card2.transform.GetChild(0).gameObject;
            GameObject card2Type = card2.transform.GetChild(1).gameObject;

            if (card2Revaied == false)
            {
                card2Rarity.gameObject.GetComponent<SpriteRenderer>().sprite = getRandomCardRarity();
                card2Type.gameObject.GetComponent<SpriteRenderer>().sprite = GetRendomCardType();
                card2Revaied = true;
            }
        }

    }

    private int random(int range) {

        System.Random rnd = new System.Random();
        int value = rnd.Next(1, range);
        return value;
    }

    private Sprite GetRendomCardType() {
        int randomVal = random(5);

        if (randomVal == 1)
        {
            return cardType1;
        }
        else if (randomVal == 2)
        {
            return cardType2;
        }
        else if (randomVal == 3)
        {
            return cardType3;
        }
        else if (randomVal == 4)
        {
            return cardType4;
        }
        else if (randomVal == 5)
        {
            return cardType5;
        }
        else {
            return cardType1;
           }

    }

    private Sprite getRandomCardRarity()
    {
        int randomVal = random(3);


        Sprite cardType = Basic;

        if (randomVal == 1)
        {
            cardType = Epic;
        }
        else if (randomVal == 2)
        {
            cardType = Rare;
        }
        else if(randomVal == 3){
            cardType = Basic;
        }

        return cardType;

    }


}
