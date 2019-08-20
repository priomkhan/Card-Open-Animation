using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPack : MonoBehaviour {

    public Animator packAnimator;
    private bool ismouseHobering = false;
    private bool mouseClick = false;

    public Animator cardAnimator1;
    public Animator cardAnimator2;
    public Animator cardAnimator3;
    public Animator animGameField;
    private GameObject CardPack1;
    private GameObject CardPack2;
    private GameObject CardPack3;
    private GameObject GameField;

    // Use this for initialization
    void Start()
    {
        packAnimator = gameObject.GetComponent<Animator>();
         CardPack1 = GameObject.Find("CardPack1");
         CardPack2 = GameObject.Find("CardPack2");
         CardPack3 = GameObject.Find("CardPack3");
        GameField = GameObject.Find("GameField");
        cardAnimator1 = CardPack1.GetComponent<Animator>();
        cardAnimator2 = CardPack2.GetComponent<Animator>();
        cardAnimator3 = CardPack3.GetComponent<Animator>();
        animGameField = GameField.GetComponent<Animator>();


    }

    void OnMouseEnter()
    {
        Debug.Log("Mouse In Area");
        if (this.gameObject.Equals(CardPack1)) {
            Debug.Log("Mouse In CardPack1 Area");
            //cardAnimator1.enabled = true;
            cardAnimator1.SetBool("mouseHobering", true);
            
        }

        if (this.gameObject.Equals(CardPack2))
        {
            Debug.Log("Mouse In CardPack2 Area");
            //cardAnimator2.enabled = true;
            cardAnimator2.SetBool("mouseHobering", true);

        }

        if (this.gameObject.Equals(CardPack3))
        {
            Debug.Log("Mouse In CardPack3 Area");
            //cardAnimator3.enabled = true;
            cardAnimator3.SetBool("mouseHobering", true);

        }

    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is not in the Area");
        packAnimator.SetBool("mouseHobering", false);
    }

    void OnMouseDown() {
        Debug.Log("Mouse Clicked");
        animGameField.enabled = true;
        animGameField.SetBool("isSelected", true);
        if (this.gameObject.Equals(CardPack1))
        {
            Debug.Log("Mouse click CardPack1 Area");
            //cardAnimator1.enabled = true;
            CardPack2.SetActive(false);
            CardPack3.SetActive(false);
            animGameField.SetInteger("selectedCard", 1);

            StartCoroutine(Example());

        }

        if (this.gameObject.Equals(CardPack2))
        {
            Debug.Log("Mouse click CardPack2 Area");
            //cardAnimator2.enabled = true;
            CardPack1.SetActive(false);
            CardPack3.SetActive(false);
            animGameField.SetInteger("selectedCard", 2);
            StartCoroutine(Example());

        }

        if (this.gameObject.Equals(CardPack3))
        {
            Debug.Log("Mouse click CardPack3 Area");
            //cardAnimator3.enabled = true;
            CardPack1.SetActive(false);
            CardPack2.SetActive(false);
            animGameField.SetInteger("selectedCard", 3);

            StartCoroutine(Example());
        }

       

        

    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
