using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

namespace BetterInputManager
{
    internal class BetterInputManagerProvider : SettingsProvider
    {
        private SerializedObject _inputManager;
        private SerializedProperty _axes;
        private ReorderableList _list;
        private Vector2 _scrollPos;
        private float[] _currentScrollViewHeight;
        private bool[] _currentFoldout = new bool[3];
        private bool _resize;
        private int _selectedTab;
        private int _selectedAxis;
        private Texture2D _gamepadIcon;
        private Texture2D _keyboardIcon;
        private Texture2D _mouseIcon;

        internal BetterInputManagerProvider(string path, SettingsScope scopes, IEnumerable<string> keywords = null) : base(path, scopes, keywords) { }

        [SettingsProvider]
        internal static SettingsProvider CreateMyCustomSettingsProvider()
        {
            BetterInputManagerProvider provider = new BetterInputManagerProvider("Project/Input Manager (Better)", SettingsScope.Project);
            provider.keywords = new HashSet<string>(new[] { "Better", "InputManager", "Input", "Inputs", "Manager" });
            return provider;
        }

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            _gamepadIcon = EditorGUIUtility.Load("Assets/KevinCastejon/BetterInputManager/Icons/GamePadIconMargin.png") as Texture2D;
            _keyboardIcon = EditorGUIUtility.Load("Assets/KevinCastejon/BetterInputManager/Icons/KeyboardIconMargin.png") as Texture2D;
            _mouseIcon = EditorGUIUtility.Load("Assets/KevinCastejon/BetterInputManager/Icons/MouseIconMargin.png") as Texture2D;
            _currentScrollViewHeight = new float[] { 300f,300f,300f };
            _inputManager = new SerializedObject(AssetDatabase.LoadAssetAtPath<Object>("ProjectSettings/InputManager.asset"));
            _axes = _inputManager.FindProperty("m_Axes");
            InitializeList();
        }

        private void InitializeList()
        {
            _list = new ReorderableList(_inputManager, _axes, true, false, false, false);
            _list.elementHeightCallback = ElementHeightCallback;
            _list.drawElementCallback = DrawElementCallback;
            _list.onSelectCallback = OnSelectCallback;
            _list.Select(0);
        }

        private void OnSelectCallback(ReorderableList list)
        {
            _selectedAxis = list.index;
        }

        private void DrawElementCallback(Rect rect, int index, bool isActive, bool isFocused)
        {
            SerializedProperty elt = _axes.GetArrayElementAtIndex(index);
            if (elt.FindPropertyRelative("type").enumValueIndex == _selectedTab)
            {
                EditorGUI.LabelField(rect, new GUIContent(elt.FindPropertyRelative("m_Name").stringValue, elt.FindPropertyRelative("m_Name").stringValue));
            }
        }

        private float ElementHeightCallback(int index)
        {
            return _axes.GetArrayElementAtIndex(index).FindPropertyRelative("type").enumValueIndex == _selectedTab ? 21f : 0f;
        }

        public override void OnGUI(string searchContext)
        {
            _inputManager.Update();
            SelectIfNotValid();
            DisplayLists();
            if (_selectedAxis > -1)
            {
                DisplayParams();
            }
            Repaint();
            _inputManager.ApplyModifiedProperties();
        }

        private void SelectIfNotValid()
        {
            if (_axes.arraySize == 0 || _selectedAxis == -1)
            {
                _selectedAxis = -1;
                return;
            }
            bool isValid = true;
            if (_axes.arraySize <= _selectedAxis)
            {
                isValid = false;
            }
            else if (_axes.GetArrayElementAtIndex(_selectedAxis).FindPropertyRelative("type").enumValueIndex != _selectedTab)
            {
                isValid = false;
            }
            if (isValid)
            {
                return;
            }

            List<int> axesTypes = new List<int>();
            for (int i = 0; i < _axes.arraySize; i++)
            {
                axesTypes.Add(_axes.GetArrayElementAtIndex(i).FindPropertyRelative("type").enumValueIndex);
            }
            _selectedAxis = axesTypes.FindIndex((x) => x == _selectedTab);
            _list.Select(_selectedAxis);
            return;

        }

        private void DisplayLists()
        {
            EditorGUI.BeginChangeCheck();
            _selectedTab = GUILayout.Toolbar(_selectedTab, new GUIContent[] { new GUIContent("Keys And Buttons", "Keys And Buttons"), new GUIContent("Mouse Movements", "Mouse Movements"), new GUIContent("Joystick Axes", "Joystick Axes") });
            if (EditorGUI.EndChangeCheck())
            {
                InitializeList();
            }
            _scrollPos = GUILayout.BeginScrollView(_scrollPos, GUILayout.Height(_currentScrollViewHeight[_selectedTab] - 48f));
            Rect topRect = EditorGUILayout.GetControlRect(false, _list.GetHeight() - 22f);
            _list.DoList(topRect);
            GUILayout.EndScrollView();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("+"))
            {
                string newName = InputModal.Open("New axis creation", new InputModalOptions() { Description="Enter a name for the new axis", Placeholder = "New axis name" });
                if (newName != null && newName != string.Empty)
                {
                    int insertIndex = _list.index == -1 ? 0 : _list.index;
                    _axes.InsertArrayElementAtIndex(insertIndex);
                    SerializedProperty newAxis = _axes.GetArrayElementAtIndex(insertIndex);
                    newAxis.FindPropertyRelative("m_Name").stringValue = newName;
                    newAxis.FindPropertyRelative("type").enumValueIndex = _selectedTab;
                    if (_selectedTab == 0)
                    {
                        newAxis.FindPropertyRelative("negativeButton").stringValue = "";
                        newAxis.FindPropertyRelative("positiveButton").stringValue = "";
                        newAxis.FindPropertyRelative("altNegativeButton").stringValue = "";
                        newAxis.FindPropertyRelative("altPositiveButton").stringValue = "";
                        newAxis.FindPropertyRelative("gravity").floatValue = 3f;
                        newAxis.FindPropertyRelative("dead").floatValue = 0.001f;
                        newAxis.FindPropertyRelative("sensitivity").floatValue = 3f;
                        newAxis.FindPropertyRelative("snap").boolValue = true;
                        newAxis.FindPropertyRelative("invert").boolValue = false;
                    }
                    else if (_selectedTab == 1)
                    {
                        newAxis.FindPropertyRelative("axis").intValue = 0;
                        newAxis.FindPropertyRelative("joyNum").intValue = 0;
                        newAxis.FindPropertyRelative("gravity").floatValue = 0f;
                        newAxis.FindPropertyRelative("dead").floatValue = 0f;
                        newAxis.FindPropertyRelative("sensitivity").floatValue = 0.1f;
                        newAxis.FindPropertyRelative("snap").boolValue = false;
                        newAxis.FindPropertyRelative("invert").boolValue = false;
                    }
                    else if (_selectedTab == 2)
                    {
                        newAxis.FindPropertyRelative("axis").intValue = 0;
                        newAxis.FindPropertyRelative("gravity").floatValue = 0f;
                        newAxis.FindPropertyRelative("dead").floatValue = 0.19f;
                        newAxis.FindPropertyRelative("sensitivity").floatValue = 1f;
                        newAxis.FindPropertyRelative("snap").boolValue = false;
                        newAxis.FindPropertyRelative("invert").boolValue = false;
                    }
                }
                _inputManager.ApplyModifiedProperties();
                GUIUtility.ExitGUI();
            }
            if (GUILayout.Button("-"))
            {
                int deleteIndex = _list.index == -1 ? 0 : _list.index;
                _axes.DeleteArrayElementAtIndex(deleteIndex);
            }
            GUILayout.EndHorizontal();
            ResizeScrollView();
        }

        private void DisplayParams()
        {
            SerializedProperty axis = _axes.GetArrayElementAtIndex(_list.index);
            EditorGUILayout.PropertyField(axis.FindPropertyRelative("m_Name"));
            EditorGUILayout.Space(10f);
            if (_selectedTab == 0)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label(GUIContent.none, GUILayout.Width(65f));
                Rect rect = EditorGUILayout.GetControlRect(true);
                GUI.Label(new Rect(rect.x, rect.y, rect.width * 0.5f, 18f), new GUIContent("Negative", "Buttons to be pressed for movement in negative direction"), new GUIStyle(EditorStyles.boldLabel) { alignment = TextAnchor.MiddleCenter });
                GUI.Label(new Rect(rect.x + rect.width * 0.5f, rect.y, rect.width * 0.5f, 18f), new GUIContent("Positive", "Buttons to be pressed for movement in positive direction"), new GUIStyle(EditorStyles.boldLabel) { alignment = TextAnchor.MiddleCenter });
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label(new GUIContent("Primary"), new GUIStyle(EditorStyles.boldLabel), GUILayout.Width(65f), GUILayout.Height(32f));
                SerializedProperty negBtnProp = axis.FindPropertyRelative("negativeButton");
                SerializedProperty posBtnProp = axis.FindPropertyRelative("positiveButton");
                rect = EditorGUILayout.GetControlRect(true, 32f);
                bool isMouse = negBtnProp.stringValue.Length >= 5 && negBtnProp.stringValue.Substring(0, 5) == "mouse";
                bool isJoystick = negBtnProp.stringValue.Length >= 8 && negBtnProp.stringValue.Substring(0, 8) == "joystick";
                Texture2D texture = isMouse ? _mouseIcon : isJoystick ? _gamepadIcon : _keyboardIcon;
                if (GUI.Button(new Rect(rect.x, rect.y, rect.width / 2, rect.height), new GUIContent(Keys.GetKeyCode(negBtnProp.stringValue).ToString(), texture, " " + Keys.GetKeyCode(negBtnProp.stringValue).ToString() + " - " + negBtnProp.stringValue)))
                {
                    string newName = PickButtonModal.Open(negBtnProp.stringValue);
                    negBtnProp.stringValue = newName;
                    _inputManager.ApplyModifiedProperties();
                    GUIUtility.ExitGUI();
                }
                isMouse = posBtnProp.stringValue.Length >= 5 && posBtnProp.stringValue.Substring(0, 5) == "mouse";
                isJoystick = posBtnProp.stringValue.Length >= 8 && posBtnProp.stringValue.Substring(0, 8) == "joystick";
                texture = isMouse ? _mouseIcon : isJoystick ? _gamepadIcon : _keyboardIcon;
                if (GUI.Button(new Rect(rect.x + rect.width * 0.5f, rect.y, rect.width * 0.5f, rect.height), new GUIContent(Keys.GetKeyCode(posBtnProp.stringValue).ToString(), texture, " " + Keys.GetKeyCode(posBtnProp.stringValue).ToString() + " - " + posBtnProp.stringValue)))
                {
                    string newName = PickButtonModal.Open(posBtnProp.stringValue);
                    posBtnProp.stringValue = newName;
                    _inputManager.ApplyModifiedProperties();
                    GUIUtility.ExitGUI();
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label(new GUIContent("Secondary"), new GUIStyle(EditorStyles.boldLabel), GUILayout.Width(65f), GUILayout.Height(32f));
                SerializedProperty altNegBtnProp = axis.FindPropertyRelative("altNegativeButton");
                SerializedProperty altPosBtnProp = axis.FindPropertyRelative("altPositiveButton");
                rect = EditorGUILayout.GetControlRect(true, 32f);
                isMouse = altNegBtnProp.stringValue.Length >= 5 && altNegBtnProp.stringValue.Substring(0, 5) == "mouse";
                isJoystick = altNegBtnProp.stringValue.Length >= 8 && altNegBtnProp.stringValue.Substring(0, 8) == "joystick";
                texture = isMouse ? _mouseIcon : isJoystick ? _gamepadIcon : _keyboardIcon;
                if (GUI.Button(new Rect(rect.x, rect.y, rect.width * 0.5f, rect.height), new GUIContent(Keys.GetKeyCode(altNegBtnProp.stringValue).ToString(), texture, " " + Keys.GetKeyCode(altNegBtnProp.stringValue).ToString() + " - " + altNegBtnProp.stringValue)))
                {
                    string newName = PickButtonModal.Open(altNegBtnProp.stringValue);
                    altNegBtnProp.stringValue = newName;
                    _inputManager.ApplyModifiedProperties();
                    GUIUtility.ExitGUI();
                }
                isMouse = altPosBtnProp.stringValue.Length >= 5 && altPosBtnProp.stringValue.Substring(0, 5) == "mouse";
                isJoystick = altPosBtnProp.stringValue.Length >= 8 && altPosBtnProp.stringValue.Substring(0, 8) == "joystick";
                texture = isMouse ? _mouseIcon : isJoystick ? _gamepadIcon : _keyboardIcon;
                if (GUI.Button(new Rect(rect.x + rect.width * 0.5f, rect.y, rect.width * 0.5f, rect.height), new GUIContent(Keys.GetKeyCode(altPosBtnProp.stringValue).ToString(), texture, " " + Keys.GetKeyCode(altPosBtnProp.stringValue).ToString() + " - " + altPosBtnProp.stringValue)))
                {
                    string newName = PickButtonModal.Open(altPosBtnProp.stringValue);
                    altPosBtnProp.stringValue = newName;
                    _inputManager.ApplyModifiedProperties();
                    GUIUtility.ExitGUI();
                }
                EditorGUILayout.EndHorizontal();
            }
            else if (_selectedTab == 1)
            {
                axis.FindPropertyRelative("axis").enumValueIndex = EditorGUILayout.Popup("Axis", axis.FindPropertyRelative("axis").enumValueIndex, new string[] { "X", "Y", "ScrollWheel" });
            }
            else if (_selectedTab == 2)
            {
                EditorGUILayout.PropertyField(axis.FindPropertyRelative("axis"));
                EditorGUILayout.PropertyField(axis.FindPropertyRelative("joyNum"));
            }
            EditorGUILayout.Space(10f);
            EditorGUILayout.Separator();
            _currentFoldout[_selectedTab] = EditorGUILayout.BeginFoldoutHeaderGroup(_currentFoldout[_selectedTab], new GUIContent("Smoothing"));
            if (_currentFoldout[_selectedTab])
            {
                EditorGUI.indentLevel++;
                EditorGUILayout.PropertyField(axis.FindPropertyRelative("gravity"));
                EditorGUILayout.PropertyField(axis.FindPropertyRelative("dead"));
                EditorGUILayout.PropertyField(axis.FindPropertyRelative("sensitivity"));
                EditorGUILayout.PropertyField(axis.FindPropertyRelative("snap"));
                EditorGUILayout.PropertyField(axis.FindPropertyRelative("invert"));
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();
        }

        private void ResizeScrollView()
        {
            Rect orect = EditorGUILayout.GetControlRect(false);
            _currentScrollViewHeight[_selectedTab] = Mathf.Min(_currentScrollViewHeight[_selectedTab], _list.GetHeight() + 31f);
            float handlesWidth = 15f;
            Rect cursorChangeRect = new Rect(0, _currentScrollViewHeight[_selectedTab], orect.width, 5f);
            Rect cursorChangeTopRect = new Rect(orect.width * 0.5f - handlesWidth * 0.5f + 5f, _currentScrollViewHeight[_selectedTab], handlesWidth, 1f);
            Rect cursorChangeBottomRect = new Rect(orect.width * 0.5f - handlesWidth * 0.5f + 5f, _currentScrollViewHeight[_selectedTab] + 4f, handlesWidth, 1f);
            Texture2D handleBar = Texture2D.grayTexture;
            Texture2D handles = Texture2D.whiteTexture;

            EditorGUIUtility.AddCursorRect(cursorChangeRect, MouseCursor.ResizeVertical);
            if (Event.current.type == EventType.MouseDown && cursorChangeRect.Contains(Event.current.mousePosition))
            {
                _resize = true;
            }
            if (_resize)
            {
                _currentScrollViewHeight[_selectedTab] = Mathf.Clamp(Event.current.mousePosition.y, 100f,_list.GetHeight() + 31f);
            }
            else
            {
                GUI.DrawTexture(cursorChangeRect, handleBar);
                GUI.DrawTexture(cursorChangeTopRect, handles);
                GUI.DrawTexture(cursorChangeBottomRect, handles);
            }
            if (Event.current.type == EventType.MouseUp)
            {
                _resize = false;
            }
        }
    }
}