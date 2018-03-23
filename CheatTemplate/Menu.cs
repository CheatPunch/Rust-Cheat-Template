using UnityEngine;

namespace CheatTemplate
{
    public class Menu : MonoBehaviour
    {
        private bool _toggled;
        private readonly GUIStyle _myStyle = new GUIStyle();

        private void Start()
        {
            _myStyle.fontSize = 21;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                _toggled = !_toggled;
            }
        }

        private void OnGUI()
        {
            if (_toggled)
            {
                GUI.Label(new Rect(Screen.width / 2f, Screen.height / 2f, 150f, 80f), "Rust Cheat Template - https://github.com/CheatPunch");
            }
        }
    }
}