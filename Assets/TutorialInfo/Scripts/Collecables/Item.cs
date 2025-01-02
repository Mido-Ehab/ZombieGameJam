using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Scriptable Objects/Itemss")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;
}
