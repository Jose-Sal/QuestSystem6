using System;
using UnityEngine;

[Serializable]
public class QuestGoal 
{
    public int requiredAmount;
    public int amount;
    public GoalType goalType;
    
    public enum GoalType
    {
        Kill,
        Collect
    }
}
