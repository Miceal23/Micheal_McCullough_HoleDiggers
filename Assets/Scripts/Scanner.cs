using Unity.VisualScripting;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    private Transform highlight;

    private void OnTriggerEnter(Collider other)
    {
        if (highlight != null)
        {
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
        }

        if (highlight.CompareTag("Gem") && highlight)
        {
            if (highlight.gameObject.GetComponent<Outline>() != null)
            {
                highlight.gameObject.GetComponent<Outline>().enabled = true;
            }
            else
            {
                Outline outline = highlight.gameObject.AddComponent<Outline>();
                outline.enabled = true;
                highlight.gameObject.GetComponent<Outline>().OutlineColor = Color.yellow;
                highlight.gameObject.GetComponent<Outline>().OutlineWidth = 3f;
            }
        }
        else
        {
            highlight = null;
        }
    }
}
