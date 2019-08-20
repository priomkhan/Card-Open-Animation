using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CardPack : MonoBehaviour
{

    public Animator packAnimator;
    private bool ismouseHobering = false;
    private bool mouseClick = false;

    public Animator cardAnimator1;
    public Animator cardAnimator2;
    public Animator cardAnimator3;
    private GameObject CardPack1;
    private GameObject CardPack2;
    private GameObject CardPack3;

    // Use this for initialization
    void Start()
    {
        packAnimator = gameObject.GetComponent<Animator>();
        CardPack1 = GameObject.Find("CardPack1");
        CardPack2 = GameObject.Find("CardPack2");
        CardPack3 = GameObject.Find("CardPack3");
        cardAnimator1 = CardPack1.GetComponent<Animator>();
        cardAnimator2 = CardPack2.GetComponent<Animator>();
        cardAnimator3 = CardPack3.GetComponent<Animator>();



    }

    void OnMouseDown()
    {
        //Debug.Log("Mouse In Area");
        if (this.gameObject.Equals(CardPack1))
        {
            Debug.Log("Mouse click CardPack1 Area");

            packAnimator.SetInteger("selection", 0);

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (this.gameObject.Equals(CardPack2))
        {
            Debug.Log("Mouse click CardPack2 Area");
            packAnimator.SetInteger("selection", 1);

           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (this.gameObject.Equals(CardPack3))
        {
            Debug.Log("Mouse click CardPack3 Area");
            packAnimator.SetInteger("selection", 2);
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }



}
