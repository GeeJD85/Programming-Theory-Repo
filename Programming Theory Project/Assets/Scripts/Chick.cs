using UnityEngine;

public class Chick : Animal
{
    public override void Goto(Vector3 position)
    {
        base.Goto(position);
    }

    public override void GoTo(Item target)
    {
        base.GoTo(target);
    }

    protected override void ItemInRange()
    {
        if (m_item != null)
        {
            // Eat item etc
            m_item = null;
        }
    }
}
