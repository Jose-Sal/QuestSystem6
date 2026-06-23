using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCScriptableObjectScript", menuName = "Scriptable Objects/NPCScriptableObjectScript")]
public class NPCScriptableObjectScript : ScriptableObject
{
    [SerializeField]private List<string> questStrings;

    public List<string> getQuestStrings()
    {
        return questStrings;
    }
}
