using ResourceSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceView : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> resources;
    [SerializeField] private TMP_Dropdown dropdown;

    private void Update()
    {
        switch (dropdown.value)
        {
            case 0:
                resources[0].text = ResourceBank.Instance.GetResourceAmount((ResourceType)0).ToString(); 
                break;
            case 1:
                resources[1].text = ResourceBank.Instance.GetResourceAmount((ResourceType)1).ToString();
                break;
            case 2:
                resources[2].text = ResourceBank.Instance.GetResourceAmount((ResourceType)2).ToString();
                break;
        }
    }
}
