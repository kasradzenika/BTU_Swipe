using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
    public Text swipeText;

    public void WriteText(string message)
    {
        swipeText.text = message;
    }
}
