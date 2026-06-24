using System;
using UnityEngine;

public class PlayersQuestManagement : MonoBehaviour
{
    [SerializeField] private Quest currentQuest;



    public static PlayersQuestManagement Instance { set; get; }

    private void Start()
    {
        Instance = this;
        //reset the quest
        

        Rat.OnAnyDead += Rat_OnAnyDead;
    }

    private void Rat_OnAnyDead(object sender, EventArgs e)
    {
        addKill();
    }

    public void setQuest(Quest quest)
    {
        currentQuest = quest;
        //resets the quest
        currentQuest.GetQuestGoal().currentAmount = 0;
    }

    //later set up the type of gameobject
    public void addKill()
    {
        if(currentQuest.GetQuestGoal().goalType == GoalType.Kill)
        {
            currentQuest.GetQuestGoal().EnemyKilled();
            if (currentQuest.GetQuestGoal().GoalIsReached())
            {
                Debug.Log("COMPLETED");
            }
        }
    }

}
