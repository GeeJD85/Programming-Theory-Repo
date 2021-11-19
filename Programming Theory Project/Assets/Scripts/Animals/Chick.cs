using UnityEngine;

// INHERITANCE - from Animal parent class
public class Chick : Animal
{
    // What to do if we selected world space as move target (optional)
    public override void GoTo(Vector3 position)
    {        
        base.GoTo(position);
        
    }

    // What to do if we selected an item as move target (optional)
    public override void GoTo(Item target) // POLYMORPHISM
    {        
        if (target.m_itemType == Item.ItemType.Edible)
            m_agent.speed *= 2;
        base.GoTo(target);
    }

    // What to do when we reach a targetted Item (compulsory)
    protected override void ItemInRange()
    {
        if (m_item != null)
        {
            // Eat item etc
            Debug.Log(m_item.ItemEffect());
            Destroy(m_item.gameObject);
            m_agent.speed /= 2;
            m_item = null;
        }
    }
}
