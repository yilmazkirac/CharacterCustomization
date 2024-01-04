using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private Button _button;
    
    private void Start()
    {
        _character._color.color=Color.green; 
        _button.onClick.AddListener(() => { _character.CreatCharacter(); });
    }
}
