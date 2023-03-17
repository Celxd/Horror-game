namespace BetterInputManager
{
    //
    // Résumé :
    //     Key codes returned by Event.keyCode. These map directly to a physical key on
    //     the keyboard.
    internal enum BetterKeyCode
    {
        //
        // Résumé :
        //     Not assigned (never returned as the result of a keystroke).
        None,
        //
        // Résumé :
        //     The backspace key.
        Backspace,
        //
        // Résumé :
        //     The tab key.
        Tab,
        //
        // Résumé :
        //     The Clear key.
        Clear,
        //
        // Résumé :
        //     Return key.
        Return,
        //
        // Résumé :
        //     Pause on PC machines.
        Pause,
        //
        // Résumé :
        //     Escape key.
        Escape,
        //
        // Résumé :
        //     Space key.
        Space,
        //
        // Résumé :
        //     Exclamation mark key '!'.
        Exclaim,
        //
        // Résumé :
        //     Double quote key '"'.
        DoubleQuote,
        //
        // Résumé :
        //     Hash key '#'.
        Hash,
        //
        // Résumé :
        //     Dollar sign key '$'.
        Dollar,
        //
        // Résumé :
        //     Percent '%' key.
        Percent,
        //
        // Résumé :
        //     Ampersand key '&'.
        Ampersand,
        //
        // Résumé :
        //     Quote key '.
        Quote,
        //
        // Résumé :
        //     Left Parenthesis key '('.
        LeftParen,
        //
        // Résumé :
        //     Right Parenthesis key ')'.
        RightParen,
        //
        // Résumé :
        //     Asterisk key '*'.
        Asterisk,
        //
        // Résumé :
        //     Plus key '+'.
        Plus,
        //
        // Résumé :
        //     Comma ',' key.
        Comma,
        //
        // Résumé :
        //     Minus '-' key.
        Minus,
        //
        // Résumé :
        //     Period '.' key.
        Period,
        //
        // Résumé :
        //     Slash '/' key.
        Slash,
        //
        // Résumé :
        //     The '0' key on the top of the alphanumeric keyboard.
        Alpha0,
        //
        // Résumé :
        //     The '1' key on the top of the alphanumeric keyboard.
        Alpha1,
        //
        // Résumé :
        //     The '2' key on the top of the alphanumeric keyboard.
        Alpha2,
        //
        // Résumé :
        //     The '3' key on the top of the alphanumeric keyboard.
        Alpha3,
        //
        // Résumé :
        //     The '4' key on the top of the alphanumeric keyboard.
        Alpha4,
        //
        // Résumé :
        //     The '5' key on the top of the alphanumeric keyboard.
        Alpha5,
        //
        // Résumé :
        //     The '6' key on the top of the alphanumeric keyboard.
        Alpha6,
        //
        // Résumé :
        //     The '7' key on the top of the alphanumeric keyboard.
        Alpha7,
        //
        // Résumé :
        //     The '8' key on the top of the alphanumeric keyboard.
        Alpha8,
        //
        // Résumé :
        //     The '9' key on the top of the alphanumeric keyboard.
        Alpha9,
        //
        // Résumé :
        //     Colon ':' key.
        Colon,
        //
        // Résumé :
        //     Semicolon ';' key.
        Semicolon,
        //
        // Résumé :
        //     Less than '<' key.
        Less,
        //
        // Résumé :
        //     Equals '=' key.
        Equals,
        //
        // Résumé :
        //     Greater than '>' key.
        Greater,
        //
        // Résumé :
        //     Question mark '?' key.
        Question,
        //
        // Résumé :
        //     At key '@'.
        At,
        //
        // Résumé :
        //     Left square bracket key '['.
        LeftBracket,
        //
        // Résumé :
        //     Backslash key '\'.
        Backslash,
        //
        // Résumé :
        //     Right square bracket key ']'.
        RightBracket,
        //
        // Résumé :
        //     Caret key '^'.
        Caret,
        //
        // Résumé :
        //     Underscore '_' key.
        Underscore,
        //
        // Résumé :
        //     Back quote key '`'.
        BackQuote,
        //
        // Résumé :
        //     'a' key.
        A,
        //
        // Résumé :
        //     'b' key.
        B,
        //
        // Résumé :
        //     'c' key.
        C,
        //
        // Résumé :
        //     'd' key.
        D,
        //
        // Résumé :
        //     'e' key.
        E,
        //
        // Résumé :
        //     'f' key.
        F,
        //
        // Résumé :
        //     'g' key.
        G,
        //
        // Résumé :
        //     'h' key.
        H,
        //
        // Résumé :
        //     'i' key.
        I,
        //
        // Résumé :
        //     'j' key.
        J,
        //
        // Résumé :
        //     'k' key.
        K,
        //
        // Résumé :
        //     'l' key.
        L,
        //
        // Résumé :
        //     'm' key.
        M,
        //
        // Résumé :
        //     'n' key.
        N,
        //
        // Résumé :
        //     'o' key.
        O,
        //
        // Résumé :
        //     'p' key.
        P,
        //
        // Résumé :
        //     'q' key.
        Q,
        //
        // Résumé :
        //     'r' key.
        R,
        //
        // Résumé :
        //     's' key.
        S,
        //
        // Résumé :
        //     't' key.
        T,
        //
        // Résumé :
        //     'u' key.
        U,
        //
        // Résumé :
        //     'v' key.
        V,
        //
        // Résumé :
        //     'w' key.
        W,
        //
        // Résumé :
        //     'x' key.
        X,
        //
        // Résumé :
        //     'y' key.
        Y,
        //
        // Résumé :
        //     'z' key.
        Z,
        //
        // Résumé :
        //     Left curly bracket key '{'.
        LeftCurlyBracket,
        //
        // Résumé :
        //     Pipe '|' key.
        Pipe,
        //
        // Résumé :
        //     Right curly bracket key '}'.
        RightCurlyBracket,
        //
        // Résumé :
        //     Tilde '~' key.
        Tilde,
        //
        // Résumé :
        //     The forward delete key.
        Delete,
        //
        // Résumé :
        //     Numeric keypad 0.
        Keypad0,
        //
        // Résumé :
        //     Numeric keypad 1.
        Keypad1,
        //
        // Résumé :
        //     Numeric keypad 2.
        Keypad2,
        //
        // Résumé :
        //     Numeric keypad 3.
        Keypad3,
        //
        // Résumé :
        //     Numeric keypad 4.
        Keypad4,
        //
        // Résumé :
        //     Numeric keypad 5.
        Keypad5,
        //
        // Résumé :
        //     Numeric keypad 6.
        Keypad6,
        //
        // Résumé :
        //     Numeric keypad 7.
        Keypad7,
        //
        // Résumé :
        //     Numeric keypad 8.
        Keypad8,
        //
        // Résumé :
        //     Numeric keypad 9.
        Keypad9,
        //
        // Résumé :
        //     Numeric keypad '.'.
        KeypadPeriod,
        //
        // Résumé :
        //     Numeric keypad '/'.
        KeypadDivide,
        //
        // Résumé :
        //     Numeric keypad '*'.
        KeypadMultiply,
        //
        // Résumé :
        //     Numeric keypad '-'.
        KeypadMinus,
        //
        // Résumé :
        //     Numeric keypad '+'.
        KeypadPlus,
        //
        // Résumé :
        //     Numeric keypad Enter.
        KeypadEnter,
        //
        // Résumé :
        //     Numeric keypad '='.
        KeypadEquals,
        //
        // Résumé :
        //     Up arrow key.
        UpArrow,
        //
        // Résumé :
        //     Down arrow key.
        DownArrow,
        //
        // Résumé :
        //     Right arrow key.
        RightArrow,
        //
        // Résumé :
        //     Left arrow key.
        LeftArrow,
        //
        // Résumé :
        //     Insert key key.
        Insert,
        //
        // Résumé :
        //     Home key.
        Home,
        //
        // Résumé :
        //     End key.
        End,
        //
        // Résumé :
        //     Page up.
        PageUp,
        //
        // Résumé :
        //     Page down.
        PageDown,
        //
        // Résumé :
        //     F1 function key.
        F1,
        //
        // Résumé :
        //     F2 function key.
        F2,
        //
        // Résumé :
        //     F3 function key.
        F3,
        //
        // Résumé :
        //     F4 function key.
        F4,
        //
        // Résumé :
        //     F5 function key.
        F5,
        //
        // Résumé :
        //     F6 function key.
        F6,
        //
        // Résumé :
        //     F7 function key.
        F7,
        //
        // Résumé :
        //     F8 function key.
        F8,
        //
        // Résumé :
        //     F9 function key.
        F9,
        //
        // Résumé :
        //     F10 function key.
        F10,
        //
        // Résumé :
        //     F11 function key.
        F11,
        //
        // Résumé :
        //     F12 function key.
        F12,
        //
        // Résumé :
        //     F13 function key.
        F13,
        //
        // Résumé :
        //     F14 function key.
        F14,
        //
        // Résumé :
        //     F15 function key.
        F15,
        //
        // Résumé :
        //     Numlock key.
        Numlock,
        //
        // Résumé :
        //     Capslock key.
        CapsLock,
        //
        // Résumé :
        //     Scroll lock key.
        ScrollLock,
        //
        // Résumé :
        //     Right shift key.
        RightShift,
        //
        // Résumé :
        //     Left shift key.
        LeftShift,
        //
        // Résumé :
        //     Right Control key.
        RightControl,
        //
        // Résumé :
        //     Left Control key.
        LeftControl,
        //
        // Résumé :
        //     Right Alt key.
        RightAlt,
        //
        // Résumé :
        //     Left Alt key.
        LeftAlt,
        //
        // Résumé :
        //     Maps to right Windows key or right Command key if physical keys are enabled in
        //     Input Manager settings, otherwise maps to right Command key only.
        RightMeta,
        //
        // Résumé :
        //     Right Command key.
        RightCommand,
        //
        // Résumé :
        //     Right Command key.
        RightApple,
        //
        // Résumé :
        //     Maps to left Windows key or left Command key if physical keys are enabled in
        //     Input Manager settings, otherwise maps to left Command key only.
        LeftMeta,
        //
        // Résumé :
        //     Left Command key.
        LeftCommand,
        //
        // Résumé :
        //     Left Command key.
        LeftApple,
        //
        // Résumé :
        //     Left Windows key.
        LeftWindows,
        //
        // Résumé :
        //     Right Windows key.
        RightWindows,
        //
        // Résumé :
        //     Alt Gr key.
        AltGr,
        //
        // Résumé :
        //     Help key.
        Help,
        //
        // Résumé :
        //     Print key.
        Print,
        //
        // Résumé :
        //     Sys Req key.
        SysReq,
        //
        // Résumé :
        //     Break key.
        Break,
        //
        // Résumé :
        //     Menu key.
        Menu,
        //
        // Résumé :
        //     The Left (or primary) mouse button.
        Mouse0,
        //
        // Résumé :
        //     Right mouse button (or secondary mouse button).
        Mouse1,
        //
        // Résumé :
        //     Middle mouse button (or third button).
        Mouse2,
        //
        // Résumé :
        //     Additional (fourth) mouse button.
        Mouse3,
        //
        // Résumé :
        //     Additional (fifth) mouse button.
        Mouse4,
        //
        // Résumé :
        //     Additional (or sixth) mouse button.
        Mouse5,
        //
        // Résumé :
        //     Additional (or seventh) mouse button.
        Mouse6,
        //
        // Résumé :
        //     Button 0 on any joystick.
        JoystickButton0,
        //
        // Résumé :
        //     Button 1 on any joystick.
        JoystickButton1,
        //
        // Résumé :
        //     Button 2 on any joystick.
        JoystickButton2,
        //
        // Résumé :
        //     Button 3 on any joystick.
        JoystickButton3,
        //
        // Résumé :
        //     Button 4 on any joystick.
        JoystickButton4,
        //
        // Résumé :
        //     Button 5 on any joystick.
        JoystickButton5,
        //
        // Résumé :
        //     Button 6 on any joystick.
        JoystickButton6,
        //
        // Résumé :
        //     Button 7 on any joystick.
        JoystickButton7,
        //
        // Résumé :
        //     Button 8 on any joystick.
        JoystickButton8,
        //
        // Résumé :
        //     Button 9 on any joystick.
        JoystickButton9,
        //
        // Résumé :
        //     Button 10 on any joystick.
        JoystickButton10,
        //
        // Résumé :
        //     Button 11 on any joystick.
        JoystickButton11,
        //
        // Résumé :
        //     Button 12 on any joystick.
        JoystickButton12,
        //
        // Résumé :
        //     Button 13 on any joystick.
        JoystickButton13,
        //
        // Résumé :
        //     Button 14 on any joystick.
        JoystickButton14,
        //
        // Résumé :
        //     Button 15 on any joystick.
        JoystickButton15,
        //
        // Résumé :
        //     Button 16 on any joystick.
        JoystickButton16,
        //
        // Résumé :
        //     Button 17 on any joystick.
        JoystickButton17,
        //
        // Résumé :
        //     Button 18 on any joystick.
        JoystickButton18,
        //
        // Résumé :
        //     Button 19 on any joystick.
        JoystickButton19,
        //
        // Résumé :
        //     Button 0 on first joystick.
        Joystick1Button0,
        //
        // Résumé :
        //     Button 1 on first joystick.
        Joystick1Button1,
        //
        // Résumé :
        //     Button 2 on first joystick.
        Joystick1Button2,
        //
        // Résumé :
        //     Button 3 on first joystick.
        Joystick1Button3,
        //
        // Résumé :
        //     Button 4 on first joystick.
        Joystick1Button4,
        //
        // Résumé :
        //     Button 5 on first joystick.
        Joystick1Button5,
        //
        // Résumé :
        //     Button 6 on first joystick.
        Joystick1Button6,
        //
        // Résumé :
        //     Button 7 on first joystick.
        Joystick1Button7,
        //
        // Résumé :
        //     Button 8 on first joystick.
        Joystick1Button8,
        //
        // Résumé :
        //     Button 9 on first joystick.
        Joystick1Button9,
        //
        // Résumé :
        //     Button 10 on first joystick.
        Joystick1Button10,
        //
        // Résumé :
        //     Button 11 on first joystick.
        Joystick1Button11,
        //
        // Résumé :
        //     Button 12 on first joystick.
        Joystick1Button12,
        //
        // Résumé :
        //     Button 13 on first joystick.
        Joystick1Button13,
        //
        // Résumé :
        //     Button 14 on first joystick.
        Joystick1Button14,
        //
        // Résumé :
        //     Button 15 on first joystick.
        Joystick1Button15,
        //
        // Résumé :
        //     Button 16 on first joystick.
        Joystick1Button16,
        //
        // Résumé :
        //     Button 17 on first joystick.
        Joystick1Button17,
        //
        // Résumé :
        //     Button 18 on first joystick.
        Joystick1Button18,
        //
        // Résumé :
        //     Button 19 on first joystick.
        Joystick1Button19,
        //
        // Résumé :
        //     Button 0 on second joystick.
        Joystick2Button0,
        //
        // Résumé :
        //     Button 1 on second joystick.
        Joystick2Button1,
        //
        // Résumé :
        //     Button 2 on second joystick.
        Joystick2Button2,
        //
        // Résumé :
        //     Button 3 on second joystick.
        Joystick2Button3,
        //
        // Résumé :
        //     Button 4 on second joystick.
        Joystick2Button4,
        //
        // Résumé :
        //     Button 5 on second joystick.
        Joystick2Button5,
        //
        // Résumé :
        //     Button 6 on second joystick.
        Joystick2Button6,
        //
        // Résumé :
        //     Button 7 on second joystick.
        Joystick2Button7,
        //
        // Résumé :
        //     Button 8 on second joystick.
        Joystick2Button8,
        //
        // Résumé :
        //     Button 9 on second joystick.
        Joystick2Button9,
        //
        // Résumé :
        //     Button 10 on second joystick.
        Joystick2Button10,
        //
        // Résumé :
        //     Button 11 on second joystick.
        Joystick2Button11,
        //
        // Résumé :
        //     Button 12 on second joystick.
        Joystick2Button12,
        //
        // Résumé :
        //     Button 13 on second joystick.
        Joystick2Button13,
        //
        // Résumé :
        //     Button 14 on second joystick.
        Joystick2Button14,
        //
        // Résumé :
        //     Button 15 on second joystick.
        Joystick2Button15,
        //
        // Résumé :
        //     Button 16 on second joystick.
        Joystick2Button16,
        //
        // Résumé :
        //     Button 17 on second joystick.
        Joystick2Button17,
        //
        // Résumé :
        //     Button 18 on second joystick.
        Joystick2Button18,
        //
        // Résumé :
        //     Button 19 on second joystick.
        Joystick2Button19,
        //
        // Résumé :
        //     Button 0 on third joystick.
        Joystick3Button0,
        //
        // Résumé :
        //     Button 1 on third joystick.
        Joystick3Button1,
        //
        // Résumé :
        //     Button 2 on third joystick.
        Joystick3Button2,
        //
        // Résumé :
        //     Button 3 on third joystick.
        Joystick3Button3,
        //
        // Résumé :
        //     Button 4 on third joystick.
        Joystick3Button4,
        //
        // Résumé :
        //     Button 5 on third joystick.
        Joystick3Button5,
        //
        // Résumé :
        //     Button 6 on third joystick.
        Joystick3Button6,
        //
        // Résumé :
        //     Button 7 on third joystick.
        Joystick3Button7,
        //
        // Résumé :
        //     Button 8 on third joystick.
        Joystick3Button8,
        //
        // Résumé :
        //     Button 9 on third joystick.
        Joystick3Button9,
        //
        // Résumé :
        //     Button 10 on third joystick.
        Joystick3Button10,
        //
        // Résumé :
        //     Button 11 on third joystick.
        Joystick3Button11,
        //
        // Résumé :
        //     Button 12 on third joystick.
        Joystick3Button12,
        //
        // Résumé :
        //     Button 13 on third joystick.
        Joystick3Button13,
        //
        // Résumé :
        //     Button 14 on third joystick.
        Joystick3Button14,
        //
        // Résumé :
        //     Button 15 on third joystick.
        Joystick3Button15,
        //
        // Résumé :
        //     Button 16 on third joystick.
        Joystick3Button16,
        //
        // Résumé :
        //     Button 17 on third joystick.
        Joystick3Button17,
        //
        // Résumé :
        //     Button 18 on third joystick.
        Joystick3Button18,
        //
        // Résumé :
        //     Button 19 on third joystick.
        Joystick3Button19,
        //
        // Résumé :
        //     Button 0 on forth joystick.
        Joystick4Button0,
        //
        // Résumé :
        //     Button 1 on forth joystick.
        Joystick4Button1,
        //
        // Résumé :
        //     Button 2 on forth joystick.
        Joystick4Button2,
        //
        // Résumé :
        //     Button 3 on forth joystick.
        Joystick4Button3,
        //
        // Résumé :
        //     Button 4 on forth joystick.
        Joystick4Button4,
        //
        // Résumé :
        //     Button 5 on forth joystick.
        Joystick4Button5,
        //
        // Résumé :
        //     Button 6 on forth joystick.
        Joystick4Button6,
        //
        // Résumé :
        //     Button 7 on forth joystick.
        Joystick4Button7,
        //
        // Résumé :
        //     Button 8 on forth joystick.
        Joystick4Button8,
        //
        // Résumé :
        //     Button 9 on forth joystick.
        Joystick4Button9,
        //
        // Résumé :
        //     Button 10 on forth joystick.
        Joystick4Button10,
        //
        // Résumé :
        //     Button 11 on forth joystick.
        Joystick4Button11,
        //
        // Résumé :
        //     Button 12 on forth joystick.
        Joystick4Button12,
        //
        // Résumé :
        //     Button 13 on forth joystick.
        Joystick4Button13,
        //
        // Résumé :
        //     Button 14 on forth joystick.
        Joystick4Button14,
        //
        // Résumé :
        //     Button 15 on forth joystick.
        Joystick4Button15,
        //
        // Résumé :
        //     Button 16 on forth joystick.
        Joystick4Button16,
        //
        // Résumé :
        //     Button 17 on forth joystick.
        Joystick4Button17,
        //
        // Résumé :
        //     Button 18 on forth joystick.
        Joystick4Button18,
        //
        // Résumé :
        //     Button 19 on forth joystick.
        Joystick4Button19,
        //
        // Résumé :
        //     Button 0 on fifth joystick.
        Joystick5Button0,
        //
        // Résumé :
        //     Button 1 on fifth joystick.
        Joystick5Button1,
        //
        // Résumé :
        //     Button 2 on fifth joystick.
        Joystick5Button2,
        //
        // Résumé :
        //     Button 3 on fifth joystick.
        Joystick5Button3,
        //
        // Résumé :
        //     Button 4 on fifth joystick.
        Joystick5Button4,
        //
        // Résumé :
        //     Button 5 on fifth joystick.
        Joystick5Button5,
        //
        // Résumé :
        //     Button 6 on fifth joystick.
        Joystick5Button6,
        //
        // Résumé :
        //     Button 7 on fifth joystick.
        Joystick5Button7,
        //
        // Résumé :
        //     Button 8 on fifth joystick.
        Joystick5Button8,
        //
        // Résumé :
        //     Button 9 on fifth joystick.
        Joystick5Button9,
        //
        // Résumé :
        //     Button 10 on fifth joystick.
        Joystick5Button10,
        //
        // Résumé :
        //     Button 11 on fifth joystick.
        Joystick5Button11,
        //
        // Résumé :
        //     Button 12 on fifth joystick.
        Joystick5Button12,
        //
        // Résumé :
        //     Button 13 on fifth joystick.
        Joystick5Button13,
        //
        // Résumé :
        //     Button 14 on fifth joystick.
        Joystick5Button14,
        //
        // Résumé :
        //     Button 15 on fifth joystick.
        Joystick5Button15,
        //
        // Résumé :
        //     Button 16 on fifth joystick.
        Joystick5Button16,
        //
        // Résumé :
        //     Button 17 on fifth joystick.
        Joystick5Button17,
        //
        // Résumé :
        //     Button 18 on fifth joystick.
        Joystick5Button18,
        //
        // Résumé :
        //     Button 19 on fifth joystick.
        Joystick5Button19,
        //
        // Résumé :
        //     Button 0 on sixth joystick.
        Joystick6Button0,
        //
        // Résumé :
        //     Button 1 on sixth joystick.
        Joystick6Button1,
        //
        // Résumé :
        //     Button 2 on sixth joystick.
        Joystick6Button2,
        //
        // Résumé :
        //     Button 3 on sixth joystick.
        Joystick6Button3,
        //
        // Résumé :
        //     Button 4 on sixth joystick.
        Joystick6Button4,
        //
        // Résumé :
        //     Button 5 on sixth joystick.
        Joystick6Button5,
        //
        // Résumé :
        //     Button 6 on sixth joystick.
        Joystick6Button6,
        //
        // Résumé :
        //     Button 7 on sixth joystick.
        Joystick6Button7,
        //
        // Résumé :
        //     Button 8 on sixth joystick.
        Joystick6Button8,
        //
        // Résumé :
        //     Button 9 on sixth joystick.
        Joystick6Button9,
        //
        // Résumé :
        //     Button 10 on sixth joystick.
        Joystick6Button10,
        //
        // Résumé :
        //     Button 11 on sixth joystick.
        Joystick6Button11,
        //
        // Résumé :
        //     Button 12 on sixth joystick.
        Joystick6Button12,
        //
        // Résumé :
        //     Button 13 on sixth joystick.
        Joystick6Button13,
        //
        // Résumé :
        //     Button 14 on sixth joystick.
        Joystick6Button14,
        //
        // Résumé :
        //     Button 15 on sixth joystick.
        Joystick6Button15,
        //
        // Résumé :
        //     Button 16 on sixth joystick.
        Joystick6Button16,
        //
        // Résumé :
        //     Button 17 on sixth joystick.
        Joystick6Button17,
        //
        // Résumé :
        //     Button 18 on sixth joystick.
        Joystick6Button18,
        //
        // Résumé :
        //     Button 19 on sixth joystick.
        Joystick6Button19,
        //
        // Résumé :
        //     Button 0 on seventh joystick.
        Joystick7Button0,
        //
        // Résumé :
        //     Button 1 on seventh joystick.
        Joystick7Button1,
        //
        // Résumé :
        //     Button 2 on seventh joystick.
        Joystick7Button2,
        //
        // Résumé :
        //     Button 3 on seventh joystick.
        Joystick7Button3,
        //
        // Résumé :
        //     Button 4 on seventh joystick.
        Joystick7Button4,
        //
        // Résumé :
        //     Button 5 on seventh joystick.
        Joystick7Button5,
        //
        // Résumé :
        //     Button 6 on seventh joystick.
        Joystick7Button6,
        //
        // Résumé :
        //     Button 7 on seventh joystick.
        Joystick7Button7,
        //
        // Résumé :
        //     Button 8 on seventh joystick.
        Joystick7Button8,
        //
        // Résumé :
        //     Button 9 on seventh joystick.
        Joystick7Button9,
        //
        // Résumé :
        //     Button 10 on seventh joystick.
        Joystick7Button10,
        //
        // Résumé :
        //     Button 11 on seventh joystick.
        Joystick7Button11,
        //
        // Résumé :
        //     Button 12 on seventh joystick.
        Joystick7Button12,
        //
        // Résumé :
        //     Button 13 on seventh joystick.
        Joystick7Button13,
        //
        // Résumé :
        //     Button 14 on seventh joystick.
        Joystick7Button14,
        //
        // Résumé :
        //     Button 15 on seventh joystick.
        Joystick7Button15,
        //
        // Résumé :
        //     Button 16 on seventh joystick.
        Joystick7Button16,
        //
        // Résumé :
        //     Button 17 on seventh joystick.
        Joystick7Button17,
        //
        // Résumé :
        //     Button 18 on seventh joystick.
        Joystick7Button18,
        //
        // Résumé :
        //     Button 19 on seventh joystick.
        Joystick7Button19,
        //
        // Résumé :
        //     Button 0 on eighth joystick.
        Joystick8Button0,
        //
        // Résumé :
        //     Button 1 on eighth joystick.
        Joystick8Button1,
        //
        // Résumé :
        //     Button 2 on eighth joystick.
        Joystick8Button2,
        //
        // Résumé :
        //     Button 3 on eighth joystick.
        Joystick8Button3,
        //
        // Résumé :
        //     Button 4 on eighth joystick.
        Joystick8Button4,
        //
        // Résumé :
        //     Button 5 on eighth joystick.
        Joystick8Button5,
        //
        // Résumé :
        //     Button 6 on eighth joystick.
        Joystick8Button6,
        //
        // Résumé :
        //     Button 7 on eighth joystick.
        Joystick8Button7,
        //
        // Résumé :
        //     Button 8 on eighth joystick.
        Joystick8Button8,
        //
        // Résumé :
        //     Button 9 on eighth joystick.
        Joystick8Button9,
        //
        // Résumé :
        //     Button 10 on eighth joystick.
        Joystick8Button10,
        //
        // Résumé :
        //     Button 11 on eighth joystick.
        Joystick8Button11,
        //
        // Résumé :
        //     Button 12 on eighth joystick.
        Joystick8Button12,
        //
        // Résumé :
        //     Button 13 on eighth joystick.
        Joystick8Button13,
        //
        // Résumé :
        //     Button 14 on eighth joystick.
        Joystick8Button14,
        //
        // Résumé :
        //     Button 15 on eighth joystick.
        Joystick8Button15,
        //
        // Résumé :
        //     Button 16 on eighth joystick.
        Joystick8Button16,
        //
        // Résumé :
        //     Button 17 on eighth joystick.
        Joystick8Button17,
        //
        // Résumé :
        //     Button 18 on eighth joystick.
        Joystick8Button18,
        //
        // Résumé :
        //     Button 19 on eighth joystick.
        Joystick8Button19,
        //
        // Résumé :
        //     Button 0 on ninth joystick.
        Joystick9Button0,
        //
        // Résumé :
        //     Button 1 on ninth joystick.
        Joystick9Button1,
        //
        // Résumé :
        //     Button 2 on ninth joystick.
        Joystick9Button2,
        //
        // Résumé :
        //     Button 3 on ninth joystick.
        Joystick9Button3,
        //
        // Résumé :
        //     Button 4 on ninth joystick.
        Joystick9Button4,
        //
        // Résumé :
        //     Button 5 on ninth joystick.
        Joystick9Button5,
        //
        // Résumé :
        //     Button 6 on ninth joystick.
        Joystick9Button6,
        //
        // Résumé :
        //     Button 7 on ninth joystick.
        Joystick9Button7,
        //
        // Résumé :
        //     Button 8 on ninth joystick.
        Joystick9Button8,
        //
        // Résumé :
        //     Button 9 on ninth joystick.
        Joystick9Button9,
        //
        // Résumé :
        //     Button 10 on ninth joystick.
        Joystick9Button10,
        //
        // Résumé :
        //     Button 11 on ninth joystick.
        Joystick9Button11,
        //
        // Résumé :
        //     Button 12 on ninth joystick.
        Joystick9Button12,
        //
        // Résumé :
        //     Button 13 on ninth joystick.
        Joystick9Button13,
        //
        // Résumé :
        //     Button 14 on ninth joystick.
        Joystick9Button14,
        //
        // Résumé :
        //     Button 15 on ninth joystick.
        Joystick9Button15,
        //
        // Résumé :
        //     Button 16 on ninth joystick.
        Joystick9Button16,
        //
        // Résumé :
        //     Button 17 on ninth joystick.
        Joystick9Button17,
        //
        // Résumé :
        //     Button 18 on ninth joystick.
        Joystick9Button18,
        //
        // Résumé :
        //     Button 19 on ninth joystick.
        Joystick9Button19,
        //
        // Résumé :
        //     Button 0 on tenth joystick.
        Joystick10Button0,
        //
        // Résumé :
        //     Button 1 on tenth joystick.
        Joystick10Button1,
        //
        // Résumé :
        //     Button 2 on tenth joystick.
        Joystick10Button2,
        //
        // Résumé :
        //     Button 3 on tenth joystick.
        Joystick10Button3,
        //
        // Résumé :
        //     Button 4 on tenth joystick.
        Joystick10Button4,
        //
        // Résumé :
        //     Button 5 on tenth joystick.
        Joystick10Button5,
        //
        // Résumé :
        //     Button 6 on tenth joystick.
        Joystick10Button6,
        //
        // Résumé :
        //     Button 7 on tenth joystick.
        Joystick10Button7,
        //
        // Résumé :
        //     Button 8 on tenth joystick.
        Joystick10Button8,
        //
        // Résumé :
        //     Button 9 on tenth joystick.
        Joystick10Button9,
        //
        // Résumé :
        //     Button 10 on tenth joystick.
        Joystick10Button10,
        //
        // Résumé :
        //     Button 11 on tenth joystick.
        Joystick10Button11,
        //
        // Résumé :
        //     Button 12 on tenth joystick.
        Joystick10Button12,
        //
        // Résumé :
        //     Button 13 on tenth joystick.
        Joystick10Button13,
        //
        // Résumé :
        //     Button 14 on tenth joystick.
        Joystick10Button14,
        //
        // Résumé :
        //     Button 15 on tenth joystick.
        Joystick10Button15,
        //
        // Résumé :
        //     Button 16 on tenth joystick.
        Joystick10Button16,
        //
        // Résumé :
        //     Button 17 on tenth joystick.
        Joystick10Button17,
        //
        // Résumé :
        //     Button 18 on tenth joystick.
        Joystick10Button18,
        //
        // Résumé :
        //     Button 19 on tenth joystick.
        Joystick10Button19,
        //
        // Résumé :
        //     Button 0 on eleventh joystick.
        Joystick11Button0,
        //
        // Résumé :
        //     Button 1 on eleventh joystick.
        Joystick11Button1,
        //
        // Résumé :
        //     Button 2 on eleventh joystick.
        Joystick11Button2,
        //
        // Résumé :
        //     Button 3 on eleventh joystick.
        Joystick11Button3,
        //
        // Résumé :
        //     Button 4 on eleventh joystick.
        Joystick11Button4,
        //
        // Résumé :
        //     Button 5 on eleventh joystick.
        Joystick11Button5,
        //
        // Résumé :
        //     Button 6 on eleventh joystick.
        Joystick11Button6,
        //
        // Résumé :
        //     Button 7 on eleventh joystick.
        Joystick11Button7,
        //
        // Résumé :
        //     Button 8 on eleventh joystick.
        Joystick11Button8,
        //
        // Résumé :
        //     Button 9 on eleventh joystick.
        Joystick11Button9,
        //
        // Résumé :
        //     Button 10 on eleventh joystick.
        Joystick11Button10,
        //
        // Résumé :
        //     Button 11 on eleventh joystick.
        Joystick11Button11,
        //
        // Résumé :
        //     Button 12 on eleventh joystick.
        Joystick11Button12,
        //
        // Résumé :
        //     Button 13 on eleventh joystick.
        Joystick11Button13,
        //
        // Résumé :
        //     Button 14 on eleventh joystick.
        Joystick11Button14,
        //
        // Résumé :
        //     Button 15 on eleventh joystick.
        Joystick11Button15,
        //
        // Résumé :
        //     Button 16 on eleventh joystick.
        Joystick11Button16,
        //
        // Résumé :
        //     Button 17 on eleventh joystick.
        Joystick11Button17,
        //
        // Résumé :
        //     Button 18 on eleventh joystick.
        Joystick11Button18,
        //
        // Résumé :
        //     Button 19 on eleventh joystick.
        Joystick11Button19,
        //
        // Résumé :
        //     Button 0 on twelfth joystick.
        Joystick12Button0,
        //
        // Résumé :
        //     Button 1 on twelfth joystick.
        Joystick12Button1,
        //
        // Résumé :
        //     Button 2 on twelfth joystick.
        Joystick12Button2,
        //
        // Résumé :
        //     Button 3 on twelfth joystick.
        Joystick12Button3,
        //
        // Résumé :
        //     Button 4 on twelfth joystick.
        Joystick12Button4,
        //
        // Résumé :
        //     Button 5 on twelfth joystick.
        Joystick12Button5,
        //
        // Résumé :
        //     Button 6 on twelfth joystick.
        Joystick12Button6,
        //
        // Résumé :
        //     Button 7 on twelfth joystick.
        Joystick12Button7,
        //
        // Résumé :
        //     Button 8 on twelfth joystick.
        Joystick12Button8,
        //
        // Résumé :
        //     Button 9 on twelfth joystick.
        Joystick12Button9,
        //
        // Résumé :
        //     Button 10 on twelfth joystick.
        Joystick12Button10,
        //
        // Résumé :
        //     Button 11 on twelfth joystick.
        Joystick12Button11,
        //
        // Résumé :
        //     Button 12 on twelfth joystick.
        Joystick12Button12,
        //
        // Résumé :
        //     Button 13 on twelfth joystick.
        Joystick12Button13,
        //
        // Résumé :
        //     Button 14 on twelfth joystick.
        Joystick12Button14,
        //
        // Résumé :
        //     Button 15 on twelfth joystick.
        Joystick12Button15,
        //
        // Résumé :
        //     Button 16 on twelfth joystick.
        Joystick12Button16,
        //
        // Résumé :
        //     Button 17 on twelfth joystick.
        Joystick12Button17,
        //
        // Résumé :
        //     Button 18 on twelfth joystick.
        Joystick12Button18,
        //
        // Résumé :
        //     Button 19 on twelfth joystick.
        Joystick12Button19,
        //
        // Résumé :
        //     Button 0 on thirteenth joystick.
        Joystick13Button0,
        //
        // Résumé :
        //     Button 1 on thirteenth joystick.
        Joystick13Button1,
        //
        // Résumé :
        //     Button 2 on thirteenth joystick.
        Joystick13Button2,
        //
        // Résumé :
        //     Button 3 on thirteenth joystick.
        Joystick13Button3,
        //
        // Résumé :
        //     Button 4 on thirteenth joystick.
        Joystick13Button4,
        //
        // Résumé :
        //     Button 5 on thirteenth joystick.
        Joystick13Button5,
        //
        // Résumé :
        //     Button 6 on thirteenth joystick.
        Joystick13Button6,
        //
        // Résumé :
        //     Button 7 on thirteenth joystick.
        Joystick13Button7,
        //
        // Résumé :
        //     Button 8 on thirteenth joystick.
        Joystick13Button8,
        //
        // Résumé :
        //     Button 9 on thirteenth joystick.
        Joystick13Button9,
        //
        // Résumé :
        //     Button 10 on thirteenth joystick.
        Joystick13Button10,
        //
        // Résumé :
        //     Button 11 on thirteenth joystick.
        Joystick13Button11,
        //
        // Résumé :
        //     Button 12 on thirteenth joystick.
        Joystick13Button12,
        //
        // Résumé :
        //     Button 13 on thirteenth joystick.
        Joystick13Button13,
        //
        // Résumé :
        //     Button 14 on thirteenth joystick.
        Joystick13Button14,
        //
        // Résumé :
        //     Button 15 on thirteenth joystick.
        Joystick13Button15,
        //
        // Résumé :
        //     Button 16 on thirteenth joystick.
        Joystick13Button16,
        //
        // Résumé :
        //     Button 17 on thirteenth joystick.
        Joystick13Button17,
        //
        // Résumé :
        //     Button 18 on thirteenth joystick.
        Joystick13Button18,
        //
        // Résumé :
        //     Button 19 on thirteenth joystick.
        Joystick13Button19,
        //
        // Résumé :
        //     Button 0 on fourteenth joystick.
        Joystick14Button0,
        //
        // Résumé :
        //     Button 1 on fourteenth joystick.
        Joystick14Button1,
        //
        // Résumé :
        //     Button 2 on fourteenth joystick.
        Joystick14Button2,
        //
        // Résumé :
        //     Button 3 on fourteenth joystick.
        Joystick14Button3,
        //
        // Résumé :
        //     Button 4 on fourteenth joystick.
        Joystick14Button4,
        //
        // Résumé :
        //     Button 5 on fourteenth joystick.
        Joystick14Button5,
        //
        // Résumé :
        //     Button 6 on fourteenth joystick.
        Joystick14Button6,
        //
        // Résumé :
        //     Button 7 on fourteenth joystick.
        Joystick14Button7,
        //
        // Résumé :
        //     Button 8 on fourteenth joystick.
        Joystick14Button8,
        //
        // Résumé :
        //     Button 9 on fourteenth joystick.
        Joystick14Button9,
        //
        // Résumé :
        //     Button 10 on fourteenth joystick.
        Joystick14Button10,
        //
        // Résumé :
        //     Button 11 on fourteenth joystick.
        Joystick14Button11,
        //
        // Résumé :
        //     Button 12 on fourteenth joystick.
        Joystick14Button12,
        //
        // Résumé :
        //     Button 13 on fourteenth joystick.
        Joystick14Button13,
        //
        // Résumé :
        //     Button 14 on fourteenth joystick.
        Joystick14Button14,
        //
        // Résumé :
        //     Button 15 on fourteenth joystick.
        Joystick14Button15,
        //
        // Résumé :
        //     Button 16 on fourteenth joystick.
        Joystick14Button16,
        //
        // Résumé :
        //     Button 17 on fourteenth joystick.
        Joystick14Button17,
        //
        // Résumé :
        //     Button 18 on fourteenth joystick.
        Joystick14Button18,
        //
        // Résumé :
        //     Button 19 on fourteenth joystick.
        Joystick14Button19,
        //
        // Résumé :
        //     Button 0 on fifteenth joystick.
        Joystick15Button0,
        //
        // Résumé :
        //     Button 1 on fifteenth joystick.
        Joystick15Button1,
        //
        // Résumé :
        //     Button 2 on fifteenth joystick.
        Joystick15Button2,
        //
        // Résumé :
        //     Button 3 on fifteenth joystick.
        Joystick15Button3,
        //
        // Résumé :
        //     Button 4 on fifteenth joystick.
        Joystick15Button4,
        //
        // Résumé :
        //     Button 5 on fifteenth joystick.
        Joystick15Button5,
        //
        // Résumé :
        //     Button 6 on fifteenth joystick.
        Joystick15Button6,
        //
        // Résumé :
        //     Button 7 on fifteenth joystick.
        Joystick15Button7,
        //
        // Résumé :
        //     Button 8 on fifteenth joystick.
        Joystick15Button8,
        //
        // Résumé :
        //     Button 9 on fifteenth joystick.
        Joystick15Button9,
        //
        // Résumé :
        //     Button 10 on fifteenth joystick.
        Joystick15Button10,
        //
        // Résumé :
        //     Button 11 on fifteenth joystick.
        Joystick15Button11,
        //
        // Résumé :
        //     Button 12 on fifteenth joystick.
        Joystick15Button12,
        //
        // Résumé :
        //     Button 13 on fifteenth joystick.
        Joystick15Button13,
        //
        // Résumé :
        //     Button 14 on fifteenth joystick.
        Joystick15Button14,
        //
        // Résumé :
        //     Button 15 on fifteenth joystick.
        Joystick15Button15,
        //
        // Résumé :
        //     Button 16 on fifteenth joystick.
        Joystick15Button16,
        //
        // Résumé :
        //     Button 17 on fifteenth joystick.
        Joystick15Button17,
        //
        // Résumé :
        //     Button 18 on fifteenth joystick.
        Joystick15Button18,
        //
        // Résumé :
        //     Button 19 on fifteenth joystick.
        Joystick15Button19,
        //
        // Résumé :
        //     Button 0 on sixteenth joystick.
        Joystick16Button0,
        //
        // Résumé :
        //     Button 1 on sixteenth joystick.
        Joystick16Button1,
        //
        // Résumé :
        //     Button 2 on sixteenth joystick.
        Joystick16Button2,
        //
        // Résumé :
        //     Button 3 on sixteenth joystick.
        Joystick16Button3,
        //
        // Résumé :
        //     Button 4 on sixteenth joystick.
        Joystick16Button4,
        //
        // Résumé :
        //     Button 5 on sixteenth joystick.
        Joystick16Button5,
        //
        // Résumé :
        //     Button 6 on sixteenth joystick.
        Joystick16Button6,
        //
        // Résumé :
        //     Button 7 on sixteenth joystick.
        Joystick16Button7,
        //
        // Résumé :
        //     Button 8 on sixteenth joystick.
        Joystick16Button8,
        //
        // Résumé :
        //     Button 9 on sixteenth joystick.
        Joystick16Button9,
        //
        // Résumé :
        //     Button 10 on sixteenth joystick.
        Joystick16Button10,
        //
        // Résumé :
        //     Button 11 on sixteenth joystick.
        Joystick16Button11,
        //
        // Résumé :
        //     Button 12 on sixteenth joystick.
        Joystick16Button12,
        //
        // Résumé :
        //     Button 13 on sixteenth joystick.
        Joystick16Button13,
        //
        // Résumé :
        //     Button 14 on sixteenth joystick.
        Joystick16Button14,
        //
        // Résumé :
        //     Button 15 on sixteenth joystick.
        Joystick16Button15,
        //
        // Résumé :
        //     Button 16 on sixteenth joystick.
        Joystick16Button16,
        //
        // Résumé :
        //     Button 17 on sixteenth joystick.
        Joystick16Button17,
        //
        // Résumé :
        //     Button 18 on sixteenth joystick.
        Joystick16Button18,
        //
        // Résumé :
        //     Button 19 on sixteenth joystick.
        Joystick16Button19,
    }
}