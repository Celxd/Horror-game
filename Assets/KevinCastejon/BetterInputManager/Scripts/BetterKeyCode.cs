namespace BetterInputManager
{
    //
    // R�sum�:
    //     Key codes returned by Event.keyCode. These map directly to a physical key on
    //     the keyboard.
    internal enum BetterKeyCode
    {
        //
        // R�sum�:
        //     Not assigned (never returned as the result of a keystroke).
        None,
        //
        // R�sum�:
        //     The backspace key.
        Backspace,
        //
        // R�sum�:
        //     The tab key.
        Tab,
        //
        // R�sum�:
        //     The Clear key.
        Clear,
        //
        // R�sum�:
        //     Return key.
        Return,
        //
        // R�sum�:
        //     Pause on PC machines.
        Pause,
        //
        // R�sum�:
        //     Escape key.
        Escape,
        //
        // R�sum�:
        //     Space key.
        Space,
        //
        // R�sum�:
        //     Exclamation mark key '!'.
        Exclaim,
        //
        // R�sum�:
        //     Double quote key '"'.
        DoubleQuote,
        //
        // R�sum�:
        //     Hash key '#'.
        Hash,
        //
        // R�sum�:
        //     Dollar sign key '$'.
        Dollar,
        //
        // R�sum�:
        //     Percent '%' key.
        Percent,
        //
        // R�sum�:
        //     Ampersand key '&'.
        Ampersand,
        //
        // R�sum�:
        //     Quote key '.
        Quote,
        //
        // R�sum�:
        //     Left Parenthesis key '('.
        LeftParen,
        //
        // R�sum�:
        //     Right Parenthesis key ')'.
        RightParen,
        //
        // R�sum�:
        //     Asterisk key '*'.
        Asterisk,
        //
        // R�sum�:
        //     Plus key '+'.
        Plus,
        //
        // R�sum�:
        //     Comma ',' key.
        Comma,
        //
        // R�sum�:
        //     Minus '-' key.
        Minus,
        //
        // R�sum�:
        //     Period '.' key.
        Period,
        //
        // R�sum�:
        //     Slash '/' key.
        Slash,
        //
        // R�sum�:
        //     The '0' key on the top of the alphanumeric keyboard.
        Alpha0,
        //
        // R�sum�:
        //     The '1' key on the top of the alphanumeric keyboard.
        Alpha1,
        //
        // R�sum�:
        //     The '2' key on the top of the alphanumeric keyboard.
        Alpha2,
        //
        // R�sum�:
        //     The '3' key on the top of the alphanumeric keyboard.
        Alpha3,
        //
        // R�sum�:
        //     The '4' key on the top of the alphanumeric keyboard.
        Alpha4,
        //
        // R�sum�:
        //     The '5' key on the top of the alphanumeric keyboard.
        Alpha5,
        //
        // R�sum�:
        //     The '6' key on the top of the alphanumeric keyboard.
        Alpha6,
        //
        // R�sum�:
        //     The '7' key on the top of the alphanumeric keyboard.
        Alpha7,
        //
        // R�sum�:
        //     The '8' key on the top of the alphanumeric keyboard.
        Alpha8,
        //
        // R�sum�:
        //     The '9' key on the top of the alphanumeric keyboard.
        Alpha9,
        //
        // R�sum�:
        //     Colon ':' key.
        Colon,
        //
        // R�sum�:
        //     Semicolon ';' key.
        Semicolon,
        //
        // R�sum�:
        //     Less than '<' key.
        Less,
        //
        // R�sum�:
        //     Equals '=' key.
        Equals,
        //
        // R�sum�:
        //     Greater than '>' key.
        Greater,
        //
        // R�sum�:
        //     Question mark '?' key.
        Question,
        //
        // R�sum�:
        //     At key '@'.
        At,
        //
        // R�sum�:
        //     Left square bracket key '['.
        LeftBracket,
        //
        // R�sum�:
        //     Backslash key '\'.
        Backslash,
        //
        // R�sum�:
        //     Right square bracket key ']'.
        RightBracket,
        //
        // R�sum�:
        //     Caret key '^'.
        Caret,
        //
        // R�sum�:
        //     Underscore '_' key.
        Underscore,
        //
        // R�sum�:
        //     Back quote key '`'.
        BackQuote,
        //
        // R�sum�:
        //     'a' key.
        A,
        //
        // R�sum�:
        //     'b' key.
        B,
        //
        // R�sum�:
        //     'c' key.
        C,
        //
        // R�sum�:
        //     'd' key.
        D,
        //
        // R�sum�:
        //     'e' key.
        E,
        //
        // R�sum�:
        //     'f' key.
        F,
        //
        // R�sum�:
        //     'g' key.
        G,
        //
        // R�sum�:
        //     'h' key.
        H,
        //
        // R�sum�:
        //     'i' key.
        I,
        //
        // R�sum�:
        //     'j' key.
        J,
        //
        // R�sum�:
        //     'k' key.
        K,
        //
        // R�sum�:
        //     'l' key.
        L,
        //
        // R�sum�:
        //     'm' key.
        M,
        //
        // R�sum�:
        //     'n' key.
        N,
        //
        // R�sum�:
        //     'o' key.
        O,
        //
        // R�sum�:
        //     'p' key.
        P,
        //
        // R�sum�:
        //     'q' key.
        Q,
        //
        // R�sum�:
        //     'r' key.
        R,
        //
        // R�sum�:
        //     's' key.
        S,
        //
        // R�sum�:
        //     't' key.
        T,
        //
        // R�sum�:
        //     'u' key.
        U,
        //
        // R�sum�:
        //     'v' key.
        V,
        //
        // R�sum�:
        //     'w' key.
        W,
        //
        // R�sum�:
        //     'x' key.
        X,
        //
        // R�sum�:
        //     'y' key.
        Y,
        //
        // R�sum�:
        //     'z' key.
        Z,
        //
        // R�sum�:
        //     Left curly bracket key '{'.
        LeftCurlyBracket,
        //
        // R�sum�:
        //     Pipe '|' key.
        Pipe,
        //
        // R�sum�:
        //     Right curly bracket key '}'.
        RightCurlyBracket,
        //
        // R�sum�:
        //     Tilde '~' key.
        Tilde,
        //
        // R�sum�:
        //     The forward delete key.
        Delete,
        //
        // R�sum�:
        //     Numeric keypad 0.
        Keypad0,
        //
        // R�sum�:
        //     Numeric keypad 1.
        Keypad1,
        //
        // R�sum�:
        //     Numeric keypad 2.
        Keypad2,
        //
        // R�sum�:
        //     Numeric keypad 3.
        Keypad3,
        //
        // R�sum�:
        //     Numeric keypad 4.
        Keypad4,
        //
        // R�sum�:
        //     Numeric keypad 5.
        Keypad5,
        //
        // R�sum�:
        //     Numeric keypad 6.
        Keypad6,
        //
        // R�sum�:
        //     Numeric keypad 7.
        Keypad7,
        //
        // R�sum�:
        //     Numeric keypad 8.
        Keypad8,
        //
        // R�sum�:
        //     Numeric keypad 9.
        Keypad9,
        //
        // R�sum�:
        //     Numeric keypad '.'.
        KeypadPeriod,
        //
        // R�sum�:
        //     Numeric keypad '/'.
        KeypadDivide,
        //
        // R�sum�:
        //     Numeric keypad '*'.
        KeypadMultiply,
        //
        // R�sum�:
        //     Numeric keypad '-'.
        KeypadMinus,
        //
        // R�sum�:
        //     Numeric keypad '+'.
        KeypadPlus,
        //
        // R�sum�:
        //     Numeric keypad Enter.
        KeypadEnter,
        //
        // R�sum�:
        //     Numeric keypad '='.
        KeypadEquals,
        //
        // R�sum�:
        //     Up arrow key.
        UpArrow,
        //
        // R�sum�:
        //     Down arrow key.
        DownArrow,
        //
        // R�sum�:
        //     Right arrow key.
        RightArrow,
        //
        // R�sum�:
        //     Left arrow key.
        LeftArrow,
        //
        // R�sum�:
        //     Insert key key.
        Insert,
        //
        // R�sum�:
        //     Home key.
        Home,
        //
        // R�sum�:
        //     End key.
        End,
        //
        // R�sum�:
        //     Page up.
        PageUp,
        //
        // R�sum�:
        //     Page down.
        PageDown,
        //
        // R�sum�:
        //     F1 function key.
        F1,
        //
        // R�sum�:
        //     F2 function key.
        F2,
        //
        // R�sum�:
        //     F3 function key.
        F3,
        //
        // R�sum�:
        //     F4 function key.
        F4,
        //
        // R�sum�:
        //     F5 function key.
        F5,
        //
        // R�sum�:
        //     F6 function key.
        F6,
        //
        // R�sum�:
        //     F7 function key.
        F7,
        //
        // R�sum�:
        //     F8 function key.
        F8,
        //
        // R�sum�:
        //     F9 function key.
        F9,
        //
        // R�sum�:
        //     F10 function key.
        F10,
        //
        // R�sum�:
        //     F11 function key.
        F11,
        //
        // R�sum�:
        //     F12 function key.
        F12,
        //
        // R�sum�:
        //     F13 function key.
        F13,
        //
        // R�sum�:
        //     F14 function key.
        F14,
        //
        // R�sum�:
        //     F15 function key.
        F15,
        //
        // R�sum�:
        //     Numlock key.
        Numlock,
        //
        // R�sum�:
        //     Capslock key.
        CapsLock,
        //
        // R�sum�:
        //     Scroll lock key.
        ScrollLock,
        //
        // R�sum�:
        //     Right shift key.
        RightShift,
        //
        // R�sum�:
        //     Left shift key.
        LeftShift,
        //
        // R�sum�:
        //     Right Control key.
        RightControl,
        //
        // R�sum�:
        //     Left Control key.
        LeftControl,
        //
        // R�sum�:
        //     Right Alt key.
        RightAlt,
        //
        // R�sum�:
        //     Left Alt key.
        LeftAlt,
        //
        // R�sum�:
        //     Maps to right Windows key or right Command key if physical keys are enabled in
        //     Input Manager settings, otherwise maps to right Command key only.
        RightMeta,
        //
        // R�sum�:
        //     Right Command key.
        RightCommand,
        //
        // R�sum�:
        //     Right Command key.
        RightApple,
        //
        // R�sum�:
        //     Maps to left Windows key or left Command key if physical keys are enabled in
        //     Input Manager settings, otherwise maps to left Command key only.
        LeftMeta,
        //
        // R�sum�:
        //     Left Command key.
        LeftCommand,
        //
        // R�sum�:
        //     Left Command key.
        LeftApple,
        //
        // R�sum�:
        //     Left Windows key.
        LeftWindows,
        //
        // R�sum�:
        //     Right Windows key.
        RightWindows,
        //
        // R�sum�:
        //     Alt Gr key.
        AltGr,
        //
        // R�sum�:
        //     Help key.
        Help,
        //
        // R�sum�:
        //     Print key.
        Print,
        //
        // R�sum�:
        //     Sys Req key.
        SysReq,
        //
        // R�sum�:
        //     Break key.
        Break,
        //
        // R�sum�:
        //     Menu key.
        Menu,
        //
        // R�sum�:
        //     The Left (or primary) mouse button.
        Mouse0,
        //
        // R�sum�:
        //     Right mouse button (or secondary mouse button).
        Mouse1,
        //
        // R�sum�:
        //     Middle mouse button (or third button).
        Mouse2,
        //
        // R�sum�:
        //     Additional (fourth) mouse button.
        Mouse3,
        //
        // R�sum�:
        //     Additional (fifth) mouse button.
        Mouse4,
        //
        // R�sum�:
        //     Additional (or sixth) mouse button.
        Mouse5,
        //
        // R�sum�:
        //     Additional (or seventh) mouse button.
        Mouse6,
        //
        // R�sum�:
        //     Button 0 on any joystick.
        JoystickButton0,
        //
        // R�sum�:
        //     Button 1 on any joystick.
        JoystickButton1,
        //
        // R�sum�:
        //     Button 2 on any joystick.
        JoystickButton2,
        //
        // R�sum�:
        //     Button 3 on any joystick.
        JoystickButton3,
        //
        // R�sum�:
        //     Button 4 on any joystick.
        JoystickButton4,
        //
        // R�sum�:
        //     Button 5 on any joystick.
        JoystickButton5,
        //
        // R�sum�:
        //     Button 6 on any joystick.
        JoystickButton6,
        //
        // R�sum�:
        //     Button 7 on any joystick.
        JoystickButton7,
        //
        // R�sum�:
        //     Button 8 on any joystick.
        JoystickButton8,
        //
        // R�sum�:
        //     Button 9 on any joystick.
        JoystickButton9,
        //
        // R�sum�:
        //     Button 10 on any joystick.
        JoystickButton10,
        //
        // R�sum�:
        //     Button 11 on any joystick.
        JoystickButton11,
        //
        // R�sum�:
        //     Button 12 on any joystick.
        JoystickButton12,
        //
        // R�sum�:
        //     Button 13 on any joystick.
        JoystickButton13,
        //
        // R�sum�:
        //     Button 14 on any joystick.
        JoystickButton14,
        //
        // R�sum�:
        //     Button 15 on any joystick.
        JoystickButton15,
        //
        // R�sum�:
        //     Button 16 on any joystick.
        JoystickButton16,
        //
        // R�sum�:
        //     Button 17 on any joystick.
        JoystickButton17,
        //
        // R�sum�:
        //     Button 18 on any joystick.
        JoystickButton18,
        //
        // R�sum�:
        //     Button 19 on any joystick.
        JoystickButton19,
        //
        // R�sum�:
        //     Button 0 on first joystick.
        Joystick1Button0,
        //
        // R�sum�:
        //     Button 1 on first joystick.
        Joystick1Button1,
        //
        // R�sum�:
        //     Button 2 on first joystick.
        Joystick1Button2,
        //
        // R�sum�:
        //     Button 3 on first joystick.
        Joystick1Button3,
        //
        // R�sum�:
        //     Button 4 on first joystick.
        Joystick1Button4,
        //
        // R�sum�:
        //     Button 5 on first joystick.
        Joystick1Button5,
        //
        // R�sum�:
        //     Button 6 on first joystick.
        Joystick1Button6,
        //
        // R�sum�:
        //     Button 7 on first joystick.
        Joystick1Button7,
        //
        // R�sum�:
        //     Button 8 on first joystick.
        Joystick1Button8,
        //
        // R�sum�:
        //     Button 9 on first joystick.
        Joystick1Button9,
        //
        // R�sum�:
        //     Button 10 on first joystick.
        Joystick1Button10,
        //
        // R�sum�:
        //     Button 11 on first joystick.
        Joystick1Button11,
        //
        // R�sum�:
        //     Button 12 on first joystick.
        Joystick1Button12,
        //
        // R�sum�:
        //     Button 13 on first joystick.
        Joystick1Button13,
        //
        // R�sum�:
        //     Button 14 on first joystick.
        Joystick1Button14,
        //
        // R�sum�:
        //     Button 15 on first joystick.
        Joystick1Button15,
        //
        // R�sum�:
        //     Button 16 on first joystick.
        Joystick1Button16,
        //
        // R�sum�:
        //     Button 17 on first joystick.
        Joystick1Button17,
        //
        // R�sum�:
        //     Button 18 on first joystick.
        Joystick1Button18,
        //
        // R�sum�:
        //     Button 19 on first joystick.
        Joystick1Button19,
        //
        // R�sum�:
        //     Button 0 on second joystick.
        Joystick2Button0,
        //
        // R�sum�:
        //     Button 1 on second joystick.
        Joystick2Button1,
        //
        // R�sum�:
        //     Button 2 on second joystick.
        Joystick2Button2,
        //
        // R�sum�:
        //     Button 3 on second joystick.
        Joystick2Button3,
        //
        // R�sum�:
        //     Button 4 on second joystick.
        Joystick2Button4,
        //
        // R�sum�:
        //     Button 5 on second joystick.
        Joystick2Button5,
        //
        // R�sum�:
        //     Button 6 on second joystick.
        Joystick2Button6,
        //
        // R�sum�:
        //     Button 7 on second joystick.
        Joystick2Button7,
        //
        // R�sum�:
        //     Button 8 on second joystick.
        Joystick2Button8,
        //
        // R�sum�:
        //     Button 9 on second joystick.
        Joystick2Button9,
        //
        // R�sum�:
        //     Button 10 on second joystick.
        Joystick2Button10,
        //
        // R�sum�:
        //     Button 11 on second joystick.
        Joystick2Button11,
        //
        // R�sum�:
        //     Button 12 on second joystick.
        Joystick2Button12,
        //
        // R�sum�:
        //     Button 13 on second joystick.
        Joystick2Button13,
        //
        // R�sum�:
        //     Button 14 on second joystick.
        Joystick2Button14,
        //
        // R�sum�:
        //     Button 15 on second joystick.
        Joystick2Button15,
        //
        // R�sum�:
        //     Button 16 on second joystick.
        Joystick2Button16,
        //
        // R�sum�:
        //     Button 17 on second joystick.
        Joystick2Button17,
        //
        // R�sum�:
        //     Button 18 on second joystick.
        Joystick2Button18,
        //
        // R�sum�:
        //     Button 19 on second joystick.
        Joystick2Button19,
        //
        // R�sum�:
        //     Button 0 on third joystick.
        Joystick3Button0,
        //
        // R�sum�:
        //     Button 1 on third joystick.
        Joystick3Button1,
        //
        // R�sum�:
        //     Button 2 on third joystick.
        Joystick3Button2,
        //
        // R�sum�:
        //     Button 3 on third joystick.
        Joystick3Button3,
        //
        // R�sum�:
        //     Button 4 on third joystick.
        Joystick3Button4,
        //
        // R�sum�:
        //     Button 5 on third joystick.
        Joystick3Button5,
        //
        // R�sum�:
        //     Button 6 on third joystick.
        Joystick3Button6,
        //
        // R�sum�:
        //     Button 7 on third joystick.
        Joystick3Button7,
        //
        // R�sum�:
        //     Button 8 on third joystick.
        Joystick3Button8,
        //
        // R�sum�:
        //     Button 9 on third joystick.
        Joystick3Button9,
        //
        // R�sum�:
        //     Button 10 on third joystick.
        Joystick3Button10,
        //
        // R�sum�:
        //     Button 11 on third joystick.
        Joystick3Button11,
        //
        // R�sum�:
        //     Button 12 on third joystick.
        Joystick3Button12,
        //
        // R�sum�:
        //     Button 13 on third joystick.
        Joystick3Button13,
        //
        // R�sum�:
        //     Button 14 on third joystick.
        Joystick3Button14,
        //
        // R�sum�:
        //     Button 15 on third joystick.
        Joystick3Button15,
        //
        // R�sum�:
        //     Button 16 on third joystick.
        Joystick3Button16,
        //
        // R�sum�:
        //     Button 17 on third joystick.
        Joystick3Button17,
        //
        // R�sum�:
        //     Button 18 on third joystick.
        Joystick3Button18,
        //
        // R�sum�:
        //     Button 19 on third joystick.
        Joystick3Button19,
        //
        // R�sum�:
        //     Button 0 on forth joystick.
        Joystick4Button0,
        //
        // R�sum�:
        //     Button 1 on forth joystick.
        Joystick4Button1,
        //
        // R�sum�:
        //     Button 2 on forth joystick.
        Joystick4Button2,
        //
        // R�sum�:
        //     Button 3 on forth joystick.
        Joystick4Button3,
        //
        // R�sum�:
        //     Button 4 on forth joystick.
        Joystick4Button4,
        //
        // R�sum�:
        //     Button 5 on forth joystick.
        Joystick4Button5,
        //
        // R�sum�:
        //     Button 6 on forth joystick.
        Joystick4Button6,
        //
        // R�sum�:
        //     Button 7 on forth joystick.
        Joystick4Button7,
        //
        // R�sum�:
        //     Button 8 on forth joystick.
        Joystick4Button8,
        //
        // R�sum�:
        //     Button 9 on forth joystick.
        Joystick4Button9,
        //
        // R�sum�:
        //     Button 10 on forth joystick.
        Joystick4Button10,
        //
        // R�sum�:
        //     Button 11 on forth joystick.
        Joystick4Button11,
        //
        // R�sum�:
        //     Button 12 on forth joystick.
        Joystick4Button12,
        //
        // R�sum�:
        //     Button 13 on forth joystick.
        Joystick4Button13,
        //
        // R�sum�:
        //     Button 14 on forth joystick.
        Joystick4Button14,
        //
        // R�sum�:
        //     Button 15 on forth joystick.
        Joystick4Button15,
        //
        // R�sum�:
        //     Button 16 on forth joystick.
        Joystick4Button16,
        //
        // R�sum�:
        //     Button 17 on forth joystick.
        Joystick4Button17,
        //
        // R�sum�:
        //     Button 18 on forth joystick.
        Joystick4Button18,
        //
        // R�sum�:
        //     Button 19 on forth joystick.
        Joystick4Button19,
        //
        // R�sum�:
        //     Button 0 on fifth joystick.
        Joystick5Button0,
        //
        // R�sum�:
        //     Button 1 on fifth joystick.
        Joystick5Button1,
        //
        // R�sum�:
        //     Button 2 on fifth joystick.
        Joystick5Button2,
        //
        // R�sum�:
        //     Button 3 on fifth joystick.
        Joystick5Button3,
        //
        // R�sum�:
        //     Button 4 on fifth joystick.
        Joystick5Button4,
        //
        // R�sum�:
        //     Button 5 on fifth joystick.
        Joystick5Button5,
        //
        // R�sum�:
        //     Button 6 on fifth joystick.
        Joystick5Button6,
        //
        // R�sum�:
        //     Button 7 on fifth joystick.
        Joystick5Button7,
        //
        // R�sum�:
        //     Button 8 on fifth joystick.
        Joystick5Button8,
        //
        // R�sum�:
        //     Button 9 on fifth joystick.
        Joystick5Button9,
        //
        // R�sum�:
        //     Button 10 on fifth joystick.
        Joystick5Button10,
        //
        // R�sum�:
        //     Button 11 on fifth joystick.
        Joystick5Button11,
        //
        // R�sum�:
        //     Button 12 on fifth joystick.
        Joystick5Button12,
        //
        // R�sum�:
        //     Button 13 on fifth joystick.
        Joystick5Button13,
        //
        // R�sum�:
        //     Button 14 on fifth joystick.
        Joystick5Button14,
        //
        // R�sum�:
        //     Button 15 on fifth joystick.
        Joystick5Button15,
        //
        // R�sum�:
        //     Button 16 on fifth joystick.
        Joystick5Button16,
        //
        // R�sum�:
        //     Button 17 on fifth joystick.
        Joystick5Button17,
        //
        // R�sum�:
        //     Button 18 on fifth joystick.
        Joystick5Button18,
        //
        // R�sum�:
        //     Button 19 on fifth joystick.
        Joystick5Button19,
        //
        // R�sum�:
        //     Button 0 on sixth joystick.
        Joystick6Button0,
        //
        // R�sum�:
        //     Button 1 on sixth joystick.
        Joystick6Button1,
        //
        // R�sum�:
        //     Button 2 on sixth joystick.
        Joystick6Button2,
        //
        // R�sum�:
        //     Button 3 on sixth joystick.
        Joystick6Button3,
        //
        // R�sum�:
        //     Button 4 on sixth joystick.
        Joystick6Button4,
        //
        // R�sum�:
        //     Button 5 on sixth joystick.
        Joystick6Button5,
        //
        // R�sum�:
        //     Button 6 on sixth joystick.
        Joystick6Button6,
        //
        // R�sum�:
        //     Button 7 on sixth joystick.
        Joystick6Button7,
        //
        // R�sum�:
        //     Button 8 on sixth joystick.
        Joystick6Button8,
        //
        // R�sum�:
        //     Button 9 on sixth joystick.
        Joystick6Button9,
        //
        // R�sum�:
        //     Button 10 on sixth joystick.
        Joystick6Button10,
        //
        // R�sum�:
        //     Button 11 on sixth joystick.
        Joystick6Button11,
        //
        // R�sum�:
        //     Button 12 on sixth joystick.
        Joystick6Button12,
        //
        // R�sum�:
        //     Button 13 on sixth joystick.
        Joystick6Button13,
        //
        // R�sum�:
        //     Button 14 on sixth joystick.
        Joystick6Button14,
        //
        // R�sum�:
        //     Button 15 on sixth joystick.
        Joystick6Button15,
        //
        // R�sum�:
        //     Button 16 on sixth joystick.
        Joystick6Button16,
        //
        // R�sum�:
        //     Button 17 on sixth joystick.
        Joystick6Button17,
        //
        // R�sum�:
        //     Button 18 on sixth joystick.
        Joystick6Button18,
        //
        // R�sum�:
        //     Button 19 on sixth joystick.
        Joystick6Button19,
        //
        // R�sum�:
        //     Button 0 on seventh joystick.
        Joystick7Button0,
        //
        // R�sum�:
        //     Button 1 on seventh joystick.
        Joystick7Button1,
        //
        // R�sum�:
        //     Button 2 on seventh joystick.
        Joystick7Button2,
        //
        // R�sum�:
        //     Button 3 on seventh joystick.
        Joystick7Button3,
        //
        // R�sum�:
        //     Button 4 on seventh joystick.
        Joystick7Button4,
        //
        // R�sum�:
        //     Button 5 on seventh joystick.
        Joystick7Button5,
        //
        // R�sum�:
        //     Button 6 on seventh joystick.
        Joystick7Button6,
        //
        // R�sum�:
        //     Button 7 on seventh joystick.
        Joystick7Button7,
        //
        // R�sum�:
        //     Button 8 on seventh joystick.
        Joystick7Button8,
        //
        // R�sum�:
        //     Button 9 on seventh joystick.
        Joystick7Button9,
        //
        // R�sum�:
        //     Button 10 on seventh joystick.
        Joystick7Button10,
        //
        // R�sum�:
        //     Button 11 on seventh joystick.
        Joystick7Button11,
        //
        // R�sum�:
        //     Button 12 on seventh joystick.
        Joystick7Button12,
        //
        // R�sum�:
        //     Button 13 on seventh joystick.
        Joystick7Button13,
        //
        // R�sum�:
        //     Button 14 on seventh joystick.
        Joystick7Button14,
        //
        // R�sum�:
        //     Button 15 on seventh joystick.
        Joystick7Button15,
        //
        // R�sum�:
        //     Button 16 on seventh joystick.
        Joystick7Button16,
        //
        // R�sum�:
        //     Button 17 on seventh joystick.
        Joystick7Button17,
        //
        // R�sum�:
        //     Button 18 on seventh joystick.
        Joystick7Button18,
        //
        // R�sum�:
        //     Button 19 on seventh joystick.
        Joystick7Button19,
        //
        // R�sum�:
        //     Button 0 on eighth joystick.
        Joystick8Button0,
        //
        // R�sum�:
        //     Button 1 on eighth joystick.
        Joystick8Button1,
        //
        // R�sum�:
        //     Button 2 on eighth joystick.
        Joystick8Button2,
        //
        // R�sum�:
        //     Button 3 on eighth joystick.
        Joystick8Button3,
        //
        // R�sum�:
        //     Button 4 on eighth joystick.
        Joystick8Button4,
        //
        // R�sum�:
        //     Button 5 on eighth joystick.
        Joystick8Button5,
        //
        // R�sum�:
        //     Button 6 on eighth joystick.
        Joystick8Button6,
        //
        // R�sum�:
        //     Button 7 on eighth joystick.
        Joystick8Button7,
        //
        // R�sum�:
        //     Button 8 on eighth joystick.
        Joystick8Button8,
        //
        // R�sum�:
        //     Button 9 on eighth joystick.
        Joystick8Button9,
        //
        // R�sum�:
        //     Button 10 on eighth joystick.
        Joystick8Button10,
        //
        // R�sum�:
        //     Button 11 on eighth joystick.
        Joystick8Button11,
        //
        // R�sum�:
        //     Button 12 on eighth joystick.
        Joystick8Button12,
        //
        // R�sum�:
        //     Button 13 on eighth joystick.
        Joystick8Button13,
        //
        // R�sum�:
        //     Button 14 on eighth joystick.
        Joystick8Button14,
        //
        // R�sum�:
        //     Button 15 on eighth joystick.
        Joystick8Button15,
        //
        // R�sum�:
        //     Button 16 on eighth joystick.
        Joystick8Button16,
        //
        // R�sum�:
        //     Button 17 on eighth joystick.
        Joystick8Button17,
        //
        // R�sum�:
        //     Button 18 on eighth joystick.
        Joystick8Button18,
        //
        // R�sum�:
        //     Button 19 on eighth joystick.
        Joystick8Button19,
        //
        // R�sum�:
        //     Button 0 on ninth joystick.
        Joystick9Button0,
        //
        // R�sum�:
        //     Button 1 on ninth joystick.
        Joystick9Button1,
        //
        // R�sum�:
        //     Button 2 on ninth joystick.
        Joystick9Button2,
        //
        // R�sum�:
        //     Button 3 on ninth joystick.
        Joystick9Button3,
        //
        // R�sum�:
        //     Button 4 on ninth joystick.
        Joystick9Button4,
        //
        // R�sum�:
        //     Button 5 on ninth joystick.
        Joystick9Button5,
        //
        // R�sum�:
        //     Button 6 on ninth joystick.
        Joystick9Button6,
        //
        // R�sum�:
        //     Button 7 on ninth joystick.
        Joystick9Button7,
        //
        // R�sum�:
        //     Button 8 on ninth joystick.
        Joystick9Button8,
        //
        // R�sum�:
        //     Button 9 on ninth joystick.
        Joystick9Button9,
        //
        // R�sum�:
        //     Button 10 on ninth joystick.
        Joystick9Button10,
        //
        // R�sum�:
        //     Button 11 on ninth joystick.
        Joystick9Button11,
        //
        // R�sum�:
        //     Button 12 on ninth joystick.
        Joystick9Button12,
        //
        // R�sum�:
        //     Button 13 on ninth joystick.
        Joystick9Button13,
        //
        // R�sum�:
        //     Button 14 on ninth joystick.
        Joystick9Button14,
        //
        // R�sum�:
        //     Button 15 on ninth joystick.
        Joystick9Button15,
        //
        // R�sum�:
        //     Button 16 on ninth joystick.
        Joystick9Button16,
        //
        // R�sum�:
        //     Button 17 on ninth joystick.
        Joystick9Button17,
        //
        // R�sum�:
        //     Button 18 on ninth joystick.
        Joystick9Button18,
        //
        // R�sum�:
        //     Button 19 on ninth joystick.
        Joystick9Button19,
        //
        // R�sum�:
        //     Button 0 on tenth joystick.
        Joystick10Button0,
        //
        // R�sum�:
        //     Button 1 on tenth joystick.
        Joystick10Button1,
        //
        // R�sum�:
        //     Button 2 on tenth joystick.
        Joystick10Button2,
        //
        // R�sum�:
        //     Button 3 on tenth joystick.
        Joystick10Button3,
        //
        // R�sum�:
        //     Button 4 on tenth joystick.
        Joystick10Button4,
        //
        // R�sum�:
        //     Button 5 on tenth joystick.
        Joystick10Button5,
        //
        // R�sum�:
        //     Button 6 on tenth joystick.
        Joystick10Button6,
        //
        // R�sum�:
        //     Button 7 on tenth joystick.
        Joystick10Button7,
        //
        // R�sum�:
        //     Button 8 on tenth joystick.
        Joystick10Button8,
        //
        // R�sum�:
        //     Button 9 on tenth joystick.
        Joystick10Button9,
        //
        // R�sum�:
        //     Button 10 on tenth joystick.
        Joystick10Button10,
        //
        // R�sum�:
        //     Button 11 on tenth joystick.
        Joystick10Button11,
        //
        // R�sum�:
        //     Button 12 on tenth joystick.
        Joystick10Button12,
        //
        // R�sum�:
        //     Button 13 on tenth joystick.
        Joystick10Button13,
        //
        // R�sum�:
        //     Button 14 on tenth joystick.
        Joystick10Button14,
        //
        // R�sum�:
        //     Button 15 on tenth joystick.
        Joystick10Button15,
        //
        // R�sum�:
        //     Button 16 on tenth joystick.
        Joystick10Button16,
        //
        // R�sum�:
        //     Button 17 on tenth joystick.
        Joystick10Button17,
        //
        // R�sum�:
        //     Button 18 on tenth joystick.
        Joystick10Button18,
        //
        // R�sum�:
        //     Button 19 on tenth joystick.
        Joystick10Button19,
        //
        // R�sum�:
        //     Button 0 on eleventh joystick.
        Joystick11Button0,
        //
        // R�sum�:
        //     Button 1 on eleventh joystick.
        Joystick11Button1,
        //
        // R�sum�:
        //     Button 2 on eleventh joystick.
        Joystick11Button2,
        //
        // R�sum�:
        //     Button 3 on eleventh joystick.
        Joystick11Button3,
        //
        // R�sum�:
        //     Button 4 on eleventh joystick.
        Joystick11Button4,
        //
        // R�sum�:
        //     Button 5 on eleventh joystick.
        Joystick11Button5,
        //
        // R�sum�:
        //     Button 6 on eleventh joystick.
        Joystick11Button6,
        //
        // R�sum�:
        //     Button 7 on eleventh joystick.
        Joystick11Button7,
        //
        // R�sum�:
        //     Button 8 on eleventh joystick.
        Joystick11Button8,
        //
        // R�sum�:
        //     Button 9 on eleventh joystick.
        Joystick11Button9,
        //
        // R�sum�:
        //     Button 10 on eleventh joystick.
        Joystick11Button10,
        //
        // R�sum�:
        //     Button 11 on eleventh joystick.
        Joystick11Button11,
        //
        // R�sum�:
        //     Button 12 on eleventh joystick.
        Joystick11Button12,
        //
        // R�sum�:
        //     Button 13 on eleventh joystick.
        Joystick11Button13,
        //
        // R�sum�:
        //     Button 14 on eleventh joystick.
        Joystick11Button14,
        //
        // R�sum�:
        //     Button 15 on eleventh joystick.
        Joystick11Button15,
        //
        // R�sum�:
        //     Button 16 on eleventh joystick.
        Joystick11Button16,
        //
        // R�sum�:
        //     Button 17 on eleventh joystick.
        Joystick11Button17,
        //
        // R�sum�:
        //     Button 18 on eleventh joystick.
        Joystick11Button18,
        //
        // R�sum�:
        //     Button 19 on eleventh joystick.
        Joystick11Button19,
        //
        // R�sum�:
        //     Button 0 on twelfth joystick.
        Joystick12Button0,
        //
        // R�sum�:
        //     Button 1 on twelfth joystick.
        Joystick12Button1,
        //
        // R�sum�:
        //     Button 2 on twelfth joystick.
        Joystick12Button2,
        //
        // R�sum�:
        //     Button 3 on twelfth joystick.
        Joystick12Button3,
        //
        // R�sum�:
        //     Button 4 on twelfth joystick.
        Joystick12Button4,
        //
        // R�sum�:
        //     Button 5 on twelfth joystick.
        Joystick12Button5,
        //
        // R�sum�:
        //     Button 6 on twelfth joystick.
        Joystick12Button6,
        //
        // R�sum�:
        //     Button 7 on twelfth joystick.
        Joystick12Button7,
        //
        // R�sum�:
        //     Button 8 on twelfth joystick.
        Joystick12Button8,
        //
        // R�sum�:
        //     Button 9 on twelfth joystick.
        Joystick12Button9,
        //
        // R�sum�:
        //     Button 10 on twelfth joystick.
        Joystick12Button10,
        //
        // R�sum�:
        //     Button 11 on twelfth joystick.
        Joystick12Button11,
        //
        // R�sum�:
        //     Button 12 on twelfth joystick.
        Joystick12Button12,
        //
        // R�sum�:
        //     Button 13 on twelfth joystick.
        Joystick12Button13,
        //
        // R�sum�:
        //     Button 14 on twelfth joystick.
        Joystick12Button14,
        //
        // R�sum�:
        //     Button 15 on twelfth joystick.
        Joystick12Button15,
        //
        // R�sum�:
        //     Button 16 on twelfth joystick.
        Joystick12Button16,
        //
        // R�sum�:
        //     Button 17 on twelfth joystick.
        Joystick12Button17,
        //
        // R�sum�:
        //     Button 18 on twelfth joystick.
        Joystick12Button18,
        //
        // R�sum�:
        //     Button 19 on twelfth joystick.
        Joystick12Button19,
        //
        // R�sum�:
        //     Button 0 on thirteenth joystick.
        Joystick13Button0,
        //
        // R�sum�:
        //     Button 1 on thirteenth joystick.
        Joystick13Button1,
        //
        // R�sum�:
        //     Button 2 on thirteenth joystick.
        Joystick13Button2,
        //
        // R�sum�:
        //     Button 3 on thirteenth joystick.
        Joystick13Button3,
        //
        // R�sum�:
        //     Button 4 on thirteenth joystick.
        Joystick13Button4,
        //
        // R�sum�:
        //     Button 5 on thirteenth joystick.
        Joystick13Button5,
        //
        // R�sum�:
        //     Button 6 on thirteenth joystick.
        Joystick13Button6,
        //
        // R�sum�:
        //     Button 7 on thirteenth joystick.
        Joystick13Button7,
        //
        // R�sum�:
        //     Button 8 on thirteenth joystick.
        Joystick13Button8,
        //
        // R�sum�:
        //     Button 9 on thirteenth joystick.
        Joystick13Button9,
        //
        // R�sum�:
        //     Button 10 on thirteenth joystick.
        Joystick13Button10,
        //
        // R�sum�:
        //     Button 11 on thirteenth joystick.
        Joystick13Button11,
        //
        // R�sum�:
        //     Button 12 on thirteenth joystick.
        Joystick13Button12,
        //
        // R�sum�:
        //     Button 13 on thirteenth joystick.
        Joystick13Button13,
        //
        // R�sum�:
        //     Button 14 on thirteenth joystick.
        Joystick13Button14,
        //
        // R�sum�:
        //     Button 15 on thirteenth joystick.
        Joystick13Button15,
        //
        // R�sum�:
        //     Button 16 on thirteenth joystick.
        Joystick13Button16,
        //
        // R�sum�:
        //     Button 17 on thirteenth joystick.
        Joystick13Button17,
        //
        // R�sum�:
        //     Button 18 on thirteenth joystick.
        Joystick13Button18,
        //
        // R�sum�:
        //     Button 19 on thirteenth joystick.
        Joystick13Button19,
        //
        // R�sum�:
        //     Button 0 on fourteenth joystick.
        Joystick14Button0,
        //
        // R�sum�:
        //     Button 1 on fourteenth joystick.
        Joystick14Button1,
        //
        // R�sum�:
        //     Button 2 on fourteenth joystick.
        Joystick14Button2,
        //
        // R�sum�:
        //     Button 3 on fourteenth joystick.
        Joystick14Button3,
        //
        // R�sum�:
        //     Button 4 on fourteenth joystick.
        Joystick14Button4,
        //
        // R�sum�:
        //     Button 5 on fourteenth joystick.
        Joystick14Button5,
        //
        // R�sum�:
        //     Button 6 on fourteenth joystick.
        Joystick14Button6,
        //
        // R�sum�:
        //     Button 7 on fourteenth joystick.
        Joystick14Button7,
        //
        // R�sum�:
        //     Button 8 on fourteenth joystick.
        Joystick14Button8,
        //
        // R�sum�:
        //     Button 9 on fourteenth joystick.
        Joystick14Button9,
        //
        // R�sum�:
        //     Button 10 on fourteenth joystick.
        Joystick14Button10,
        //
        // R�sum�:
        //     Button 11 on fourteenth joystick.
        Joystick14Button11,
        //
        // R�sum�:
        //     Button 12 on fourteenth joystick.
        Joystick14Button12,
        //
        // R�sum�:
        //     Button 13 on fourteenth joystick.
        Joystick14Button13,
        //
        // R�sum�:
        //     Button 14 on fourteenth joystick.
        Joystick14Button14,
        //
        // R�sum�:
        //     Button 15 on fourteenth joystick.
        Joystick14Button15,
        //
        // R�sum�:
        //     Button 16 on fourteenth joystick.
        Joystick14Button16,
        //
        // R�sum�:
        //     Button 17 on fourteenth joystick.
        Joystick14Button17,
        //
        // R�sum�:
        //     Button 18 on fourteenth joystick.
        Joystick14Button18,
        //
        // R�sum�:
        //     Button 19 on fourteenth joystick.
        Joystick14Button19,
        //
        // R�sum�:
        //     Button 0 on fifteenth joystick.
        Joystick15Button0,
        //
        // R�sum�:
        //     Button 1 on fifteenth joystick.
        Joystick15Button1,
        //
        // R�sum�:
        //     Button 2 on fifteenth joystick.
        Joystick15Button2,
        //
        // R�sum�:
        //     Button 3 on fifteenth joystick.
        Joystick15Button3,
        //
        // R�sum�:
        //     Button 4 on fifteenth joystick.
        Joystick15Button4,
        //
        // R�sum�:
        //     Button 5 on fifteenth joystick.
        Joystick15Button5,
        //
        // R�sum�:
        //     Button 6 on fifteenth joystick.
        Joystick15Button6,
        //
        // R�sum�:
        //     Button 7 on fifteenth joystick.
        Joystick15Button7,
        //
        // R�sum�:
        //     Button 8 on fifteenth joystick.
        Joystick15Button8,
        //
        // R�sum�:
        //     Button 9 on fifteenth joystick.
        Joystick15Button9,
        //
        // R�sum�:
        //     Button 10 on fifteenth joystick.
        Joystick15Button10,
        //
        // R�sum�:
        //     Button 11 on fifteenth joystick.
        Joystick15Button11,
        //
        // R�sum�:
        //     Button 12 on fifteenth joystick.
        Joystick15Button12,
        //
        // R�sum�:
        //     Button 13 on fifteenth joystick.
        Joystick15Button13,
        //
        // R�sum�:
        //     Button 14 on fifteenth joystick.
        Joystick15Button14,
        //
        // R�sum�:
        //     Button 15 on fifteenth joystick.
        Joystick15Button15,
        //
        // R�sum�:
        //     Button 16 on fifteenth joystick.
        Joystick15Button16,
        //
        // R�sum�:
        //     Button 17 on fifteenth joystick.
        Joystick15Button17,
        //
        // R�sum�:
        //     Button 18 on fifteenth joystick.
        Joystick15Button18,
        //
        // R�sum�:
        //     Button 19 on fifteenth joystick.
        Joystick15Button19,
        //
        // R�sum�:
        //     Button 0 on sixteenth joystick.
        Joystick16Button0,
        //
        // R�sum�:
        //     Button 1 on sixteenth joystick.
        Joystick16Button1,
        //
        // R�sum�:
        //     Button 2 on sixteenth joystick.
        Joystick16Button2,
        //
        // R�sum�:
        //     Button 3 on sixteenth joystick.
        Joystick16Button3,
        //
        // R�sum�:
        //     Button 4 on sixteenth joystick.
        Joystick16Button4,
        //
        // R�sum�:
        //     Button 5 on sixteenth joystick.
        Joystick16Button5,
        //
        // R�sum�:
        //     Button 6 on sixteenth joystick.
        Joystick16Button6,
        //
        // R�sum�:
        //     Button 7 on sixteenth joystick.
        Joystick16Button7,
        //
        // R�sum�:
        //     Button 8 on sixteenth joystick.
        Joystick16Button8,
        //
        // R�sum�:
        //     Button 9 on sixteenth joystick.
        Joystick16Button9,
        //
        // R�sum�:
        //     Button 10 on sixteenth joystick.
        Joystick16Button10,
        //
        // R�sum�:
        //     Button 11 on sixteenth joystick.
        Joystick16Button11,
        //
        // R�sum�:
        //     Button 12 on sixteenth joystick.
        Joystick16Button12,
        //
        // R�sum�:
        //     Button 13 on sixteenth joystick.
        Joystick16Button13,
        //
        // R�sum�:
        //     Button 14 on sixteenth joystick.
        Joystick16Button14,
        //
        // R�sum�:
        //     Button 15 on sixteenth joystick.
        Joystick16Button15,
        //
        // R�sum�:
        //     Button 16 on sixteenth joystick.
        Joystick16Button16,
        //
        // R�sum�:
        //     Button 17 on sixteenth joystick.
        Joystick16Button17,
        //
        // R�sum�:
        //     Button 18 on sixteenth joystick.
        Joystick16Button18,
        //
        // R�sum�:
        //     Button 19 on sixteenth joystick.
        Joystick16Button19,
    }
}