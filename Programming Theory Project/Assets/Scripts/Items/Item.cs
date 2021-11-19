using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public enum ItemType { Edible, Debuff, Buff }
    public ItemType m_itemType;

    public abstract string ItemEffect();
}
