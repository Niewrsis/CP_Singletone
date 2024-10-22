using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ResourceSystem.View
{
    public class ResourceAddMenu : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TMP_InputField resourceInputField;
        [SerializeField] private TMP_Dropdown resourceDropDown;
        [SerializeField] private Button addButton;

        private void Start()
        {
            addButton.onClick.AddListener(OnClickAddButton);
        }
        
        private void OnClickAddButton()
        {
            Debug.Log(resourceDropDown.value);
            Debug.Log(int.Parse(resourceInputField.text));
            Debug.Log(ResourceBank.Instance);
            ResourceBank.Instance.AddResources((ResourceType)resourceDropDown.value, int.Parse(resourceInputField.text));
        }
    }
}