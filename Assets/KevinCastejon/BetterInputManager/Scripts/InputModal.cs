using BetterInputManager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace BetterInputManager
{
    [Serializable]
    internal class InputModalOptions
    {
        [SerializeField] private string _description = "";
        [SerializeField] private string _btnOK = "Ok";
        [SerializeField] private string _btnCancel = "Cancel";
        [SerializeField] private string _input = "";
        [SerializeField] private string _label = "";
        [SerializeField] private string _labelTooltip = "";
        [SerializeField] private string _placeholder = "";
        [SerializeField] private string _excludedErrorMessage = "";
        [SerializeField] private string _emptyErrorMessage = "";
        [SerializeField] private bool _excludedCaseSensitive = true;
        [SerializeField] private bool _allowEmpty = false;
        [SerializeField] private bool _trimSpaces = true;
        [SerializeField] private bool _replaceSpacesWithUnderscores = false;
        [SerializeField] private bool _forceUpperCase = false;
        [SerializeField] private List<string> _excludes = new List<string>();

        internal string Description { get => _description; set => _description = value; }
        internal string BtnOK { get => _btnOK; set => _btnOK = value; }
        internal string BtnCancel { get => _btnCancel; set => _btnCancel = value; }
        internal string Input { get => _input; set => _input = value; }
        internal string Label { get => _label; set => _label = value; }
        internal string LabelTooltip { get => _labelTooltip; set => _labelTooltip = value; }
        internal string Placeholder { get => _placeholder; set => _placeholder = value; }
        internal string ExcludedErrorMessage { get => _excludedErrorMessage; set => _excludedErrorMessage = value; }
        internal string EmptyErrorMessage { get => _emptyErrorMessage; set => _emptyErrorMessage = value; }
        internal bool AllowEmpty { get => _allowEmpty; set => _allowEmpty = value; }
        internal bool ForceUpperCase { get => _forceUpperCase; set => _forceUpperCase = value; }
        internal bool ExcludedCaseSensitive { get => _excludedCaseSensitive; set => _excludedCaseSensitive = value; }
        internal bool ReplaceSpacesWithUnderscores { get => _replaceSpacesWithUnderscores; set => _replaceSpacesWithUnderscores = value; }
        internal List<string> Excludes { get => _excludes; set => _excludes = value; }
        internal bool TrimSpaces { get => _trimSpaces; set => _trimSpaces = value; }

        internal InputModalOptions Clone()
        {
            InputModalOptions ret = new InputModalOptions();
            ret._description = _description;
            ret._btnOK = _btnOK;
            ret._btnCancel = _btnCancel;
            ret._input = _input;
            ret._label = _label;
            ret._labelTooltip = _labelTooltip;
            ret._placeholder = _placeholder;
            ret._excludedErrorMessage = _excludedErrorMessage;
            ret._emptyErrorMessage = _emptyErrorMessage;
            ret._allowEmpty = _allowEmpty;
            ret._trimSpaces = _trimSpaces;
            ret._forceUpperCase = _forceUpperCase;
            ret._replaceSpacesWithUnderscores = _replaceSpacesWithUnderscores;
            ret._excludedCaseSensitive = _excludedCaseSensitive;
            foreach (string exclude in _excludes)
            {
                ret._excludes.Add(exclude);
            }
            return ret;
        }
    }

    internal class InputModal : EditorWindow
    {
        private InputModalOptions _options;
        private string _returnString = null;
        private bool _focus;
        internal string ReturnString { get => _returnString; }

        internal void Init(InputModalOptions options)
        {
            _options = options.Clone();
            _focus = true;
        }
        private void OnGUI()
        {
            EditorGUILayout.LabelField(_options.Description, new GUIStyle(EditorStyles.boldLabel) { alignment = TextAnchor.MiddleCenter });
            Rect errorRect = EditorGUILayout.GetControlRect(false, 30f);
            GUIStyleState styleState = new GUIStyleState();
            styleState.textColor = _options.Input.Length > 0 ? Color.white : Color.grey;
            GUI.SetNextControlName("InputModalTextfield");
            string liveInput = EditorGUILayout.TextField(new GUIContent(_options.Label, _options.LabelTooltip), _options.Input.Length > 0 ? _options.Input : _options.Placeholder, new GUIStyle(EditorStyles.textField) { fontStyle = _options.Input.Length > 0 ? FontStyle.Normal : FontStyle.Italic });
            liveInput = _options.TrimSpaces ? liveInput.Trim() : liveInput;
            liveInput = _options.ForceUpperCase ? liveInput.ToUpper() : liveInput;
            liveInput = _options.ReplaceSpacesWithUnderscores ? liveInput.Replace(" ", "_") : liveInput;
            _options.Input = liveInput.ToUpper().Replace(" ", "_") != _options.Placeholder.ToUpper().Replace(" ", "_") ? liveInput : "";
            bool isExcluded = _options.Excludes.FindIndex((x) => x.Equals(_options.Input, _options.ExcludedCaseSensitive ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase)) > -1;
            if (isExcluded && _options.ExcludedErrorMessage.Length > 0)
            {
                EditorGUI.HelpBox(errorRect, _options.ExcludedErrorMessage, MessageType.Error);
            }
            else if (!_options.AllowEmpty && _options.Input.Length == 0 && _options.EmptyErrorMessage.Length > 0)
            {
                EditorGUI.HelpBox(errorRect, _options.EmptyErrorMessage, MessageType.Error);
            }
            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginDisabledGroup(isExcluded || (!_options.AllowEmpty && _options.Input.Length == 0));
            if (GUILayout.Button(_options.BtnOK))
            {
                _returnString = _options.Input;
                Close();
            }
            EditorGUI.EndDisabledGroup();
            if (GUILayout.Button(_options.BtnCancel))
            {
                Close();
            }
            EditorGUILayout.EndHorizontal();
            if (_focus)
            {
                _focus = false;
                GUI.FocusControl("InputModalTextfield");
                Repaint();
            }
            Event e = Event.current;
            switch (e.type)
            {
                case EventType.KeyDown:
                    {
                        if (Event.current.keyCode == KeyCode.Return || Event.current.keyCode == KeyCode.KeypadEnter)
                        {
                            if (!(isExcluded || (!_options.AllowEmpty && _options.Input.Length == 0)))
                            {
                                _returnString = _options.Input;
                                Close();
                            }
                        }
                        else if (Event.current.keyCode == KeyCode.Escape)
                        {
                            Close();
                        }
                        break;
                    }
            }
        }

        internal static string Open(string title, InputModalOptions options)
        {
            InputModal window = CreateInstance<InputModal>();
            window.minSize = new Vector2(200f, 75f);
            window.maxSize = new Vector2(200f, 75f);
            window.CenterOnMainWin();
            window.titleContent = new GUIContent(title);
            window.Init(options);
            window.ShowModalUtility();
            return window.ReturnString;
        }
    }
}
