using UnityEngine;
using UnityEngine.UI;

public class FoundObj : MonoBehaviour
{
    private Button btn;
    private Image img;
    [SerializeField] private Counter counter;
    private void Start()
    {
        btn = GetComponent<Button>();
        img = GetComponent<Image>();
    }
    public void Found()
    {
        counter.WriteCount();
        img.color = Color.red;
        btn.enabled = false;
    }
}