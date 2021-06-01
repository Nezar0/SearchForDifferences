using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text countText;
    [SerializeField] private int total;
    private int foundDiff;

    private void Start()
    {
        countText.text = $"{foundDiff}/{total}";
    }

    public void WriteCount()
    {
        foundDiff++; 
        countText.text = $"{foundDiff}/{total}";
    }
}
