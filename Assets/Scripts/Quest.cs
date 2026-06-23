using System;
using UnityEngine;

[Serializable]
public class Quest 
{
    public string questName;
    public string questDescription;
    public bool isCompleted;

    [SerializeField] private QuestGoal questGoal;

}
