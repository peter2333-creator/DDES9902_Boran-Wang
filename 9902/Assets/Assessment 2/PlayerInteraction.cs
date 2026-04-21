using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hitInfo))
            {
                var interaction = hitInfo.collider.GetComponent<Interaction>();
                if (interaction != null)
                {
                    Debug.Log($"µã»÷ÁË£º{interaction.name}");
                    interaction.Interact();
                }
            }
        }
    }
}
