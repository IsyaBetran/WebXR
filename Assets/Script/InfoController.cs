using UnityEngine;

public class InfoController : MonoBehaviour
{
    private bool infoOpen = false;

    [SerializeField] private GameObject infoPanel;

    public void ToggleInfo()
    {
        infoOpen = !infoOpen;
        infoPanel.SetActive(infoOpen);
    }
}
