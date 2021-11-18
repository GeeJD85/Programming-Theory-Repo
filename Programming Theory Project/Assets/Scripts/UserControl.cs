using UnityEngine;

public class UserControl : MonoBehaviour
{
    public Camera gameCam;
    Animal m_animal;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            HandleSelection();

        if (Input.GetMouseButtonDown(1))
            HandleActions();
    }

    protected void HandleSelection()
    {
        var ray = gameCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            var animal = hit.collider.GetComponent<Animal>();
            m_animal = animal;
        }
    }

    protected void HandleActions()
    {
        if(m_animal != null)
        {
            var ray = gameCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                m_animal.Goto(hit.point);
            }
            
        }
    }
}
