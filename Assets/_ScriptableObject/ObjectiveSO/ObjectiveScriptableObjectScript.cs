using UnityEngine;

[CreateAssetMenu(fileName = "ObjectiveScriptableObjectScript", menuName = "Scriptable Objects/ObjectiveScriptableObjectScript")]
public class ObjectiveScriptableObjectScript : ScriptableObject
{
    [SerializeField] private Quest quest;
    public Quest GetQuest()
    {
        return quest;
    }
}
