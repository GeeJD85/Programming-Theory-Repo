using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    protected override void ItemInRange()
    {
        if (m_item != null)
        {
            // Eat item etc
            m_item = null;
        }
    }
}
