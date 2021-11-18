using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public abstract class Animal : MonoBehaviour
{
    protected NavMeshAgent m_agent;
    protected Item m_item;

    protected void Awake()
    {
        m_agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(m_item != null)
        {
            float distance = Vector3.Distance(m_item.transform.position, transform.position);

            if(distance < 1)
            {
                m_agent.isStopped = true;
                ItemInRange();
            }
        }
    }

    public virtual void Goto(Vector3 position)
    {
        m_item = null;
        m_agent.SetDestination(position);
        m_agent.isStopped = false;
    }

    public virtual void GoTo(Item target)
    {
        m_item = target;

        if(m_item != null)
        {
            m_agent.SetDestination(target.transform.position);
            m_agent.isStopped = false;
        }        
    }

    protected abstract void ItemInRange();
}
