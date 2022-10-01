using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;



public class MainSystem : MonoBehaviour
{
    
    [SerializeField] MemberMaster data;
    [SerializeField] Image slot1;
    [SerializeField] Image slot2;
    [SerializeField] Image slot3;
    private Sprite randomsprite1;
    private int randomGroupName ;
    private Sprite randomsprite2;
    private Sprite randomsprite3;
    List<MemberMaster.MemberMasterRecord> myCards = new List<MemberMaster.MemberMasterRecord>();
    public static float Score;
    [SerializeField] VideoMaster videoMaster;

    void Start()
    {

       

    }
    public void SelectSprite()
    {
        //var query = data.sheet
        //   //.Where(x => x.group == MemberMaster.Group.ノイミー)
        //   /*.Select(x => x.sprite  )*/
        //   .OrderBy(i => Guid.NewGuid())//中身シャッフル
        //   .ToList();//中身シャッフル

        var myCards1 =data.sheet
           .OrderBy(i => Guid.NewGuid())//中身シャッフル
           .ToList();//中身シャッフル
           
        var myCards2 = data.sheet
           .OrderBy(i => Guid.NewGuid())//中身シャッフル
           .ToList();//中身シャッフル
        var myCards3 = data.sheet
           .OrderBy(i => Guid.NewGuid())//中身シャッフル
           .ToList();//中身シャッフル

        var card1 = myCards1.First();
        var card2 = myCards2.First();
        var card3 = myCards3.First();

        randomsprite1 = card1.sprite;
        randomsprite2 = card2.sprite;
        randomsprite3 = card3.sprite;
        
        //役判定
        if (card1.group == MemberMaster.Group.ノイミー && card2.group == MemberMaster.Group.ノイミー && card3.group == MemberMaster.Group.ノイミー)//ノイミー役
        {
            Debug.Log("ノイミー役");
            videoMaster.VideoPlayStart();
        }
        if (card1.group == MemberMaster.Group.イコラブ && card2.group == MemberMaster.Group.イコラブ && card3.group == MemberMaster.Group.イコラブ)//イコラブ役
        {
            Debug.Log("イコラブ役");
        }
        if (card1.group == MemberMaster.Group.ニアジョイ && card2.group == MemberMaster.Group.ニアジョイ && card3.group == MemberMaster.Group.ニアジョイ)//ニアジョイ役
        {
            Debug.Log("ニアジョイ役");
        }
        if (card1.Name == "SuzukiHItomi"&& card3.Name == "TanizakiSaya")//サマーチョコレート役
        {
            Debug.Log("サマーチョコレート役");
        }




        //for (int i = 0; i < 3; i++)
        //{
        //    var card = query.First();
        //    myCards.Add(card);
        //    query.Remove(card);
        //    randomsprite1 = card.sprite;

        //}

        //query.First();//中身の一番上を取ってくる
        //var a = query[Random.Range(0, query.Count)];
        //foreach (var sprite in query)
        //{
        //    //query.First();
        //    Debug.Log(sprite.Name);
        //    randomsprite1 = sprite.sprite;
        //    randomsprite2 = sprite.sprite;
        //    randomsprite3 = sprite.sprite;
        //    //randomGroupName = sprite.group;


        //    if (sprite.group == MemberMaster.Group.ノイミー)
        //    {

        //    }
        //    #region やりたい事
        //    //if (randomsprite1 == MemberMaster.Group.ノイミー && randomsprite2 == MemberMaster.Group.ノイミー && randomsprite3 == MemberMaster.Group.ノイミー)
        //    //{
        //    //    Debug.Log("成功喜一");
        //    //}
        //    #endregion
        //    break;
        //}


    }

    public void OnClickSlot1()
    {
        slot1.sprite = randomsprite1;
        
    }
    public void OnClickSlot2()
    {
        slot2.sprite = randomsprite2;
    }
    public void OnClickSlot3()
    {
        slot3.sprite = randomsprite3;
        
    }
}
