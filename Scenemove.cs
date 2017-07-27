﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenemove : MonoBehaviour
{
    GameObject player;
    GameObject topdown;
    public string Scenename;
    public Vector3 position;
    float b;
    GameObject fedeobj, Canvas;
    Image fede;
    public GameObject kompas;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            kompas.SetActive(false);
            fedeobj = GameObject.Find("fede");
            fede = fedeobj.GetComponent<Image>();
            fede.enabled = true;
            while (b <= 1)
            {
                b += 0.01f;
                fede.color = new Color(0, 0, 0, 0 + b);
                yield return null;
            }
            Vector3 m_pos = transform.localPosition;
            GameObject topdown = GameObject.Find("PlayerMove");
            GameObject player = GameObject.Find("topdownset");
            DontDestroyOnLoad(player);//プレイヤーを破棄しないでシーン移行
            topdown.transform.rotation = Quaternion.Euler(0, 0, 0);
            topdown.AddComponent<boss1start>();//プレイヤーにボス開始時の演出のscriptの追加
            SceneManager.LoadScene(Scenename);
            topdown.transform.position = position;
        }
    }
}
