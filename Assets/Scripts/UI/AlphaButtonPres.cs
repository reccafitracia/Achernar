using UnityEngine;
using UnityEngine.UI;

public class AlphaButtonPres : MonoBehaviour
{
    void Start()
    {
        Image img = GetComponent<Image>();
        if (img != null)
        {
            img.alphaHitTestMinimumThreshold = 0.5f;
        }
    }
}
