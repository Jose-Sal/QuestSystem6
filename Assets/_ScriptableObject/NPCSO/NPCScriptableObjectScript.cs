using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCScriptableObjectScript", menuName = "Scriptable Objects/NPCScriptableObjectScript")]
public class NPCScriptableObjectScript : ScriptableObject
{
    [SerializeField]private List<string> questStrings;
    [SerializeField] private ObjectiveScriptableObjectScript Objective;

    public List<string> getQuestStrings()
    {
        return questStrings;
    }

    public ObjectiveScriptableObjectScript GetObjective()
    {
        return Objective;
    }
}
