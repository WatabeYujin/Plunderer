using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//0.11~0.625~0.75
public class Lifebar2: MonoBehaviour {
	PlayerLife    playerLife;
    public bool bar2 = true;
	float lifepa;
    Image bar;
	void Start () {
		GameObject obj = GameObject.Find ("PlayerMove");
		playerLife = obj.GetComponent<PlayerLife> ();
        if (!bar2) bar = GetComponent<Image>();
    }
	
	void Update ()
	{
        lifepa = Mathf.Round(playerLife.life);
        if(bar2){
            lifepa = (lifepa * 5) - 255;
            if (playerLife.life <= 0)
            {
                iTween.MoveTo(gameObject, iTween.Hash(
                "x", -255, "isLocal", true
            ));
            }
            else
            {
                iTween.MoveTo(gameObject, iTween.Hash(
                    "x", lifepa, "isLocal", true
                ));
            }
        }else{
            if (playerLife.life <= 0)
            {
                bar.fillAmount = 0;
            }
            else
            {
                bar.fillAmount = lifepa / 100;
            }
        }
	}
}
