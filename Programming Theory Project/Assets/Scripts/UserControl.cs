using UnityEngine;

public class UserControl : MonoBehaviour
{
    public Camera gameCam;
    private Animal m_animal = null;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            HandleSelection();

        else if (Input.GetMouseButtonDown(1) && m_animal != null)
            HandleActions();
    }

    protected void HandleSelection()
    {
        var ray = gameCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            var animal = hit.collider.GetComponentInParent<Animal>();
            m_animal = animal;
        }
    }

    protected void HandleActions()
    {
        var ray = gameCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            var item = hit.collider.GetComponentInParent<Item>();
                
            if(item != null)
            {
                m_animal.GoTo(item);
            }
            else
            {
                m_animal.GoTo(hit.point);
            }
        }
    }
}
