using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCard : MonoBehaviour
{
    private List<GameObject> CardsRemainList => CardManager.Instance.GetComponent<CardRemain>().CardList;

    public Button drawbutton;
    private const int MAXHANDCARD = 5;
    public GameObject changeColorPanel;
    Color32 inv = new Color32(255,255,255,0);
    Color32 grayy = new Color32(43, 43, 43, 221); 
    private bool isCoolDown = false;
    public void Onclick()
    {
        if(isCoolDown)return;
        CardManager.Instance.HandCards2GraveYard();
        for (int i = 0; i < MAXHANDCARD; i++)
        {
            GameObject cardObj = GetRandomCard();
            cardObj.GetComponent<CardUse>().HandCardNumber = i;
            CardManager.Instance.GetComponent<HandCards>().CardList.Add(cardObj);
        }
        CardManager.Instance.ShowHandCard();
        drawbutton.enabled = false;//抽卡按鈕關閉
        changeColorPanel.GetComponent<Image>().color = grayy;
        UseDraw();
    }

    private GameObject GetRandomCard()
    {
        if (CardsRemainList.Count == 0)
            CardManager.Instance.GraveYard2CardRemain();
        int RandomIndex = Random.Range(0, CardsRemainList.Count);
        GameObject cardObj = CardsRemainList[RandomIndex];
        CardsRemainList.RemoveAt(RandomIndex);
        return cardObj;
    }

    private IEnumerator DrawCoolDown()   //計時器
    {
        isCoolDown = true;
        yield return new WaitForSecondsRealtime(5/*5*/);//真實秒數
        drawbutton.enabled = true;
        changeColorPanel.GetComponent <Image>().color = inv;
        isCoolDown = false;
    }

    private void UseDraw()//觸發計時器用
    {
        StartCoroutine(DrawCoolDown());
    }
}