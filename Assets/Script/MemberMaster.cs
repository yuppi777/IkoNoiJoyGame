using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/CreateAsset")]
public class MemberMaster : ScriptableObject
{
    public List<MemberMasterRecord> sheet;

    public enum JobPost
    {
        Programer,
        Modeler,
        Motion,
        Director
    }

    public enum Rarity
    {
        N = 0,
        R = 1,
        SR = 2,
        SSR = 3
    }
    public enum Group
    {
        ノイミー,
        イコラブ,
        ニアジョイ,
    }


    [Serializable]
    public class MemberMasterRecord
    {
        public string Name;
        public int Hp;
        public Sprite sprite;
        public MemberMaster.Rarity Rarity;
        public MemberMaster.JobPost Post;
        public MemberMaster.Group group;
    }
}
