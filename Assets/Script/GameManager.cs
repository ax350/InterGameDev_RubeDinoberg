using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton;

    public GameObject Player;
    public GameObject StartBlockLeft;
    public GameObject StartBlockRight;
    public GameObject Camera;
    public GameObject FirstTrigger;
    public GameObject SecondTrigger;
    public GameObject ThirdTrigger;
    public GameObject FourthTrigger;
    public GameObject FinalTrigger;
    private Boolean StartFlag = false;
    private Boolean Scene1flag = false;
    private Boolean Scene2flag = false;
    private Boolean Scene3flag = false;
    private Boolean Scene4flag = false;
    private Boolean Scene5flag = false;
    float tmp_v = 0f;

    private void Awake()
    {
        Singleton = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Singleton.StartFlag);
        //Just to prove I've used singleton in this script
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space) && !StartFlag)
        {

            StartFlag = true;
            
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

            
        }
        if (StartFlag)
        {
            float tmp_v2 = 0.01f;
            
            if (tmp_v <= 10)
            {
                //Debug.Log(tmp_v);
                //Debug.Log(tmp_v);
                tmp_v += tmp_v2;
                Vector3 tmp_v3 = new Vector3(tmp_v, 0, 0);
                StartBlockLeft.GetComponent<Transform>().Translate(-tmp_v3);
                StartBlockRight.GetComponent<Transform>().Translate(tmp_v3);
            }
        }
        if (FirstTrigger.GetComponent<BoxCollider2D>().IsTouching(Player.GetComponent<CircleCollider2D>()) && !Scene1flag)
        {
            Scene1flag = true;
            Camera.GetComponent<Transform>().Translate(new Vector3(0,-10,0));
        }
        if (SecondTrigger.GetComponent<BoxCollider2D>().IsTouching(Player.GetComponent<CircleCollider2D>()) && !Scene2flag)
        {
            Scene2flag = true;
            Camera.GetComponent<Transform>().Translate(new Vector3(-17.76f, 0, 0));
        }
        if (ThirdTrigger.GetComponent<BoxCollider2D>().IsTouching(Player.GetComponent<CircleCollider2D>()) && !Scene3flag)
        {
            Debug.Log("!!!");
            Scene3flag = true;
            Camera.GetComponent<Transform>().Translate(new Vector3(17.76f, -9.5f, 0));
        }
        if (FourthTrigger.GetComponent<BoxCollider2D>().IsTouching(Player.GetComponent<CircleCollider2D>()) && !Scene4flag)
        {
            Debug.Log("!!!");
            Scene4flag = true;
            Camera.GetComponent<Transform>().Translate(new Vector3(0, -10, 0));
        }
        if (FinalTrigger.GetComponent<BoxCollider2D>().IsTouching(Player.GetComponent<CircleCollider2D>()) && !Scene5flag)
        {
            Debug.Log("!!!");
            Scene5flag = true;
            Camera.GetComponent<Transform>().Translate(new Vector3(17.76f, 0, 0));
        }
    }
}
