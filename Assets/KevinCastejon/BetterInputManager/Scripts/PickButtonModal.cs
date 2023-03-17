using BetterInputManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace BetterInputManager
{
    internal enum KeyboardKeyType
    {
        LETTER,
        ALPHA,
        FUNC,
        KEYPAD,
        MODIFIER,
        ARROW,
        SPECIAL
    }

    internal class PickButtonModal : EditorWindow
    {
        private string _keyName;
        private string _keyNameBackup;
        private int _selectedTab;
        private KeyboardKeyType _selectedKeyType;
        private Texture2D _gamepadIcon;
        private Texture2D _keyboardIcon;
        private Texture2D _mouseIcon;
        private bool _closeDebug;

        internal string KeyName { get => _keyName; }

        private void OnEnable()
        {
            _gamepadIcon = EditorGUIUtility.Load("Assets/KevinCastejon/BetterInputManager/Icons/GamePadIcon.png") as Texture2D;
            _keyboardIcon = EditorGUIUtility.Load("Assets/KevinCastejon/BetterInputManager/Icons/KeyboardIcon.png") as Texture2D;
            _mouseIcon = EditorGUIUtility.Load("Assets/KevinCastejon/BetterInputManager/Icons/MouseIcon.png") as Texture2D;
        }

        internal void Init(string keyName)
        {
            _keyName = keyName;
            _keyNameBackup = _keyName;
            if (KeysDictionaries.gamePadNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 0;
            }
            else if (KeysDictionaries.letterNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 1;
                _selectedKeyType = KeyboardKeyType.LETTER;
            }
            else if (KeysDictionaries.alphaNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 1;
                _selectedKeyType = KeyboardKeyType.ALPHA;
            }
            else if (KeysDictionaries.funcNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 1;
                _selectedKeyType = KeyboardKeyType.FUNC;
            }
            else if (KeysDictionaries.keypadNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 1;
                _selectedKeyType = KeyboardKeyType.KEYPAD;
            }
            else if (KeysDictionaries.modifierNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 1;
                _selectedKeyType = KeyboardKeyType.MODIFIER;
            }
            else if (KeysDictionaries.arrowNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 1;
                _selectedKeyType = KeyboardKeyType.ARROW;
            }
            else if (KeysDictionaries.specialNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 1;
                _selectedKeyType = KeyboardKeyType.SPECIAL;
            }
            else if (KeysDictionaries.mouseNameToCode.ContainsKey(_keyName))
            {
                _selectedTab = 2;
            }
            else
            {
                _keyName = "joystick button 0";
            }
        }
        private void OnGUI()
        {
            EditorGUI.BeginChangeCheck();
            _selectedTab = GUILayout.Toolbar(_selectedTab, new GUIContent[] { new GUIContent(_gamepadIcon, "Gamepad buttons"), new GUIContent(_keyboardIcon, "Keyboard keys"), new GUIContent(_mouseIcon, "Mouse buttons") }, GUILayout.Height(32f));
            if (EditorGUI.EndChangeCheck())
            {
                if (_selectedTab == 0)
                {
                    _keyName = "joystick button 0";
                }
                else if (_selectedTab == 1)
                {
                    _keyName = "a";
                    _selectedKeyType = 0;
                }
                else if (_selectedTab == 2)
                {
                    _keyName = "mouse 0";
                }
            }
            if (_selectedTab == 0)
            {
                DisplayGamePad();
            }
            else if (_selectedTab == 1)
            {
                DisplayKeyboard();
            }
            else if (_selectedTab == 2)
            {
                DisplayMouse();
            }
            GUILayout.Space(10f);
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Ok"))
            {
                _closeDebug = true;
                Close();
            }
            else if (GUILayout.Button("Clear"))
            {
                _closeDebug = true;
                _keyName = "";
                Close();
            }
            else if (GUILayout.Button("Cancel"))
            {
                _closeDebug = true;
                _keyName = _keyNameBackup;
                Close();
            }
            GUILayout.EndHorizontal();
        }

        private void DisplayGamePad()
        {
            GUILayout.Label("Gamepad Buttons", new GUIStyle(EditorStyles.boldLabel) { alignment = TextAnchor.MiddleCenter });
            GUILayout.Space(10f);
            string[] joystickIds = new string[17];
            for (int i = 0; i < joystickIds.Length; i++) joystickIds[i] = i.ToString();
            joystickIds[0] = "Any";
            string[] buttonIds = new string[20];
            for (int i = 0; i < buttonIds.Length; i++) buttonIds[i] = i.ToString();
            int parsedJoyId;
            int joystickId = EditorGUILayout.Popup(new GUIContent("Joystick"), _keyName[9] == 'b' ? 0 : int.TryParse(_keyName.Substring(9, 2), out parsedJoyId) ? parsedJoyId : int.Parse(_keyName.Substring(9, 1)), joystickIds);
            int parsedBtnId;
            int currentButtonId = int.TryParse(_keyName.Substring(_keyName.Length - 2), out parsedBtnId) ? parsedBtnId : int.Parse(_keyName.Substring(_keyName.Length - 1));
            int buttonId = EditorGUILayout.Popup(new GUIContent("Button"), currentButtonId, buttonIds);
            _keyName = "joystick" + (joystickId == 0 ? "" : " " + joystickId) + " button " + buttonId;
        }
        private void DisplayKeyboard()
        {
            GUILayout.Label("Keyboard Keys", new GUIStyle(EditorStyles.boldLabel) { alignment = TextAnchor.MiddleCenter });
            GUILayout.Space(10f);
            EditorGUI.BeginChangeCheck();
            _selectedKeyType = (KeyboardKeyType)EditorGUILayout.EnumPopup(new GUIContent("Key type"), (KeyboardKeyType)_selectedKeyType);
            if (EditorGUI.EndChangeCheck())
            {
                switch (_selectedKeyType)
                {
                    case KeyboardKeyType.LETTER:
                        _keyName = "a";
                        break;
                    case KeyboardKeyType.ALPHA:
                        _keyName = "0";
                        break;
                    case KeyboardKeyType.FUNC:
                        _keyName = "f1";
                        break;
                    case KeyboardKeyType.KEYPAD:
                        _keyName = "[0]";
                        break;
                    case KeyboardKeyType.MODIFIER:
                        _keyName = "left shift";
                        break;
                    case KeyboardKeyType.ARROW:
                        _keyName = "left";
                        break;
                    case KeyboardKeyType.SPECIAL:
                        _keyName = "backspace";
                        break;
                    default:
                        break;
                }
            }
            Dictionary<string, BetterKeyCode> nameToCode;
            Dictionary<BetterKeyCode, string> codeToName;
            switch (_selectedKeyType)
            {
                case KeyboardKeyType.LETTER:
                    nameToCode = KeysDictionaries.letterNameToCode;
                    codeToName = KeysDictionaries.letterCodeToName;
                    break;
                case KeyboardKeyType.ALPHA:
                    nameToCode = KeysDictionaries.alphaNameToCode;
                    codeToName = KeysDictionaries.alphaCodeToName;
                    break;
                case KeyboardKeyType.FUNC:
                    nameToCode = KeysDictionaries.funcNameToCode;
                    codeToName = KeysDictionaries.funcCodeToName;
                    break;
                case KeyboardKeyType.KEYPAD:
                    nameToCode = KeysDictionaries.keypadNameToCode;
                    codeToName = KeysDictionaries.keypadCodeToName;
                    break;
                case KeyboardKeyType.MODIFIER:
                    nameToCode = KeysDictionaries.modifierNameToCode;
                    codeToName = KeysDictionaries.modifierCodeToName;
                    break;
                case KeyboardKeyType.ARROW:
                    nameToCode = KeysDictionaries.arrowNameToCode;
                    codeToName = KeysDictionaries.arrowCodeToName;
                    break;
                case KeyboardKeyType.SPECIAL:
                    nameToCode = KeysDictionaries.specialNameToCode;
                    codeToName = KeysDictionaries.specialCodeToName;
                    break;
                default:
                    nameToCode = KeysDictionaries.letterNameToCode;
                    codeToName = KeysDictionaries.letterCodeToName;
                    break;
            }
            int currentIndex = (int)nameToCode[_keyName];
            int newIndex = EditorGUILayout.IntPopup("Key", currentIndex, nameToCode.Keys.Select((x, i) => nameToCode.Values.ToArray()[i].ToString().Replace("/", "\u2215") + " - " + x.Replace("/", "\u2215")).ToArray(), nameToCode.Values.Select((x) => (int)x).ToArray());
            _keyName = codeToName[(BetterKeyCode)newIndex];
        }
        private void DisplayMouse()
        {
            GUILayout.Label("Mouse Buttons", new GUIStyle(EditorStyles.boldLabel) { alignment = TextAnchor.MiddleCenter });
            GUILayout.Space(10f);
            string[] buttonIds = new string[7];
            for (int i = 0; i < buttonIds.Length; i++) buttonIds[i] = i.ToString();
            _keyName = "mouse " + EditorGUILayout.Popup(new GUIContent("Mouse button"), int.Parse(_keyName.Substring(6, 1)), buttonIds);
            GUILayout.Space(20f);
        }

        private void OnDestroy()
        {
            if (!_closeDebug)
            {
                _keyName = _keyNameBackup;
            }
        }

        internal static string Open(string keyName)
        {
            PickButtonModal window = CreateInstance<PickButtonModal>();
            window.minSize = new Vector2(300f, 135f);
            window.maxSize = new Vector2(300f, 135f);
            window.CenterOnMainWin();
            window.titleContent = new GUIContent("Pick a button");
            window.Init(keyName);
            window.ShowModalUtility();
            return window.KeyName;
        }
    }
}
