using System;
using UnityEngine;

[Serializable]
public class QuestGoal 
{
    public int requiredAmount;
    public int currentAmount = 0;
    public GoalType goalType;


    public bool GoalIsReached()
    {
        return currentAmount >= requiredAmount;
    }

    public void EnemyKilled()
    {
        if(goalType == GoalType.Kill)
        { 
            currentAmount++;
        }
    }

    public void itemCollected()
    {
        if(goalType == GoalType.Collect)
        { 
            currentAmount++;
        }
    }
}
public  enum GoalType
{
    Kill,
    Collect
}