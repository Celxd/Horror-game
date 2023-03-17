using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BetterInputManager
{
    internal static class Keys
    {
        //internal static string GetKeyName(BetterKeyCode BetterKeyCode)
        //{
        //    switch (BetterKeyCode)
        //    {
        //        case BetterKeyCode.None:
        //            return "";
        //        case BetterKeyCode.Backspace:
        //            return "backspace";
        //        case BetterKeyCode.Delete:
        //            return "delete";
        //        case BetterKeyCode.Tab:
        //            return "tab";
        //        case BetterKeyCode.Clear:
        //            return "clear";
        //        case BetterKeyCode.Return:
        //            return "return";
        //        case BetterKeyCode.Pause:
        //            return "pause";
        //        case BetterKeyCode.Escape:
        //            return "escape";
        //        case BetterKeyCode.Space:
        //            return "space";
        //        case BetterKeyCode.Keypad0:
        //            return "[0]";
        //        case BetterKeyCode.Keypad1:
        //            return "[1]";
        //        case BetterKeyCode.Keypad2:
        //            return "[2]";
        //        case BetterKeyCode.Keypad3:
        //            return "[3]";
        //        case BetterKeyCode.Keypad4:
        //            return "[4]";
        //        case BetterKeyCode.Keypad5:
        //            return "[5]";
        //        case BetterKeyCode.Keypad6:
        //            return "[6]";
        //        case BetterKeyCode.Keypad7:
        //            return "[7]";
        //        case BetterKeyCode.Keypad8:
        //            return "[8]";
        //        case BetterKeyCode.Keypad9:
        //            return "[9]";
        //        case BetterKeyCode.KeypadPeriod:
        //            return "[.]";
        //        case BetterKeyCode.KeypadDivide:
        //            return "[/]";
        //        case BetterKeyCode.KeypadMultiply:
        //            return "[*]";
        //        case BetterKeyCode.KeypadMinus:
        //            return "[-]";
        //        case BetterKeyCode.KeypadPlus:
        //            return "[+]";
        //        case BetterKeyCode.KeypadEnter:
        //            return "enter";
        //        case BetterKeyCode.KeypadEquals:
        //            return "equals";
        //        case BetterKeyCode.UpArrow:
        //            return "up";
        //        case BetterKeyCode.DownArrow:
        //            return "down";
        //        case BetterKeyCode.RightArrow:
        //            return "right";
        //        case BetterKeyCode.LeftArrow:
        //            return "left";
        //        case BetterKeyCode.Insert:
        //            return "insert";
        //        case BetterKeyCode.Home:
        //            return "home";
        //        case BetterKeyCode.End:
        //            return "end";
        //        case BetterKeyCode.PageUp:
        //            return "page up";
        //        case BetterKeyCode.PageDown:
        //            return "page down";
        //        case BetterKeyCode.F1:
        //            return "f1";
        //        case BetterKeyCode.F2:
        //            return "f2";
        //        case BetterKeyCode.F3:
        //            return "f3";
        //        case BetterKeyCode.F4:
        //            return "f4";
        //        case BetterKeyCode.F5:
        //            return "f5";
        //        case BetterKeyCode.F6:
        //            return "f6";
        //        case BetterKeyCode.F7:
        //            return "f7";
        //        case BetterKeyCode.F8:
        //            return "f8";
        //        case BetterKeyCode.F9:
        //            return "f9";
        //        case BetterKeyCode.F10:
        //            return "f10";
        //        case BetterKeyCode.F11:
        //            return "f11";
        //        case BetterKeyCode.F12:
        //            return "f12";
        //        case BetterKeyCode.F13:
        //            return "f13";
        //        case BetterKeyCode.F14:
        //            return "f14";
        //        case BetterKeyCode.F15:
        //            return "f15";
        //        case BetterKeyCode.Alpha0:
        //            return "0";
        //        case BetterKeyCode.Alpha1:
        //            return "1";
        //        case BetterKeyCode.Alpha2:
        //            return "2";
        //        case BetterKeyCode.Alpha3:
        //            return "3";
        //        case BetterKeyCode.Alpha4:
        //            return "4";
        //        case BetterKeyCode.Alpha5:
        //            return "5";
        //        case BetterKeyCode.Alpha6:
        //            return "6";
        //        case BetterKeyCode.Alpha7:
        //            return "7";
        //        case BetterKeyCode.Alpha8:
        //            return "8";
        //        case BetterKeyCode.Alpha9:
        //            return "9";
        //        case BetterKeyCode.Exclaim:
        //            return "!";
        //        case BetterKeyCode.DoubleQuote:
        //            return "\"";
        //        case BetterKeyCode.Hash:
        //            return "#";
        //        case BetterKeyCode.Dollar:
        //            return "$";
        //        case BetterKeyCode.Percent:
        //            return "%";
        //        case BetterKeyCode.Ampersand:
        //            return "&";
        //        case BetterKeyCode.Quote:
        //            return "'";
        //        case BetterKeyCode.LeftParen:
        //            return "(";
        //        case BetterKeyCode.RightParen:
        //            return ")";
        //        case BetterKeyCode.Asterisk:
        //            return "*";
        //        case BetterKeyCode.Plus:
        //            return "+";
        //        case BetterKeyCode.Comma:
        //            return ",";
        //        case BetterKeyCode.Minus:
        //            return "-";
        //        case BetterKeyCode.Period:
        //            return ".";
        //        case BetterKeyCode.Slash:
        //            return "/";
        //        case BetterKeyCode.Colon:
        //            return ":";
        //        case BetterKeyCode.Semicolon:
        //            return ";";
        //        case BetterKeyCode.Less:
        //            return "<";
        //        case BetterKeyCode.Equals:
        //            return "=";
        //        case BetterKeyCode.Greater:
        //            return ">";
        //        case BetterKeyCode.Question:
        //            return "?";
        //        case BetterKeyCode.At:
        //            return "@";
        //        case BetterKeyCode.LeftBracket:
        //            return "[";
        //        case BetterKeyCode.Backslash:
        //            return "\\";
        //        case BetterKeyCode.RightBracket:
        //            return "]";
        //        case BetterKeyCode.Caret:
        //            return "^";
        //        case BetterKeyCode.Underscore:
        //            return "_";
        //        case BetterKeyCode.BackQuote:
        //            return "`";
        //        case BetterKeyCode.A:
        //            return "a";
        //        case BetterKeyCode.B:
        //            return "b";
        //        case BetterKeyCode.C:
        //            return "c";
        //        case BetterKeyCode.D:
        //            return "d";
        //        case BetterKeyCode.E:
        //            return "e";
        //        case BetterKeyCode.F:
        //            return "f";
        //        case BetterKeyCode.G:
        //            return "g";
        //        case BetterKeyCode.H:
        //            return "h";
        //        case BetterKeyCode.I:
        //            return "i";
        //        case BetterKeyCode.J:
        //            return "j";
        //        case BetterKeyCode.K:
        //            return "k";
        //        case BetterKeyCode.L:
        //            return "l";
        //        case BetterKeyCode.M:
        //            return "m";
        //        case BetterKeyCode.N:
        //            return "n";
        //        case BetterKeyCode.O:
        //            return "o";
        //        case BetterKeyCode.P:
        //            return "p";
        //        case BetterKeyCode.Q:
        //            return "q";
        //        case BetterKeyCode.R:
        //            return "r";
        //        case BetterKeyCode.S:
        //            return "s";
        //        case BetterKeyCode.T:
        //            return "t";
        //        case BetterKeyCode.U:
        //            return "u";
        //        case BetterKeyCode.V:
        //            return "v";
        //        case BetterKeyCode.W:
        //            return "w";
        //        case BetterKeyCode.X:
        //            return "x";
        //        case BetterKeyCode.Y:
        //            return "y";
        //        case BetterKeyCode.Z:
        //            return "z";
        //        case BetterKeyCode.LeftCurlyBracket:
        //            return "{";
        //        case BetterKeyCode.Pipe:
        //            return "|";
        //        case BetterKeyCode.RightCurlyBracket:
        //            return "}";
        //        case BetterKeyCode.Tilde:
        //            return "~";
        //        case BetterKeyCode.Numlock:
        //            return "numlock";
        //        case BetterKeyCode.CapsLock:
        //            return "caps lock";
        //        case BetterKeyCode.ScrollLock:
        //            return "scroll lock";
        //        case BetterKeyCode.RightShift:
        //            return "right shift";
        //        case BetterKeyCode.LeftShift:
        //            return "left shift";
        //        case BetterKeyCode.RightControl:
        //            return "right ctrl";
        //        case BetterKeyCode.LeftControl:
        //            return "left ctrl";
        //        case BetterKeyCode.RightAlt:
        //            return "right alt";
        //        case BetterKeyCode.LeftAlt:
        //            return "left alt";
        //        case BetterKeyCode.LeftCommand:
        //            return "left cmd";
        //        case BetterKeyCode.LeftWindows:
        //            return "left cmd";
        //        case BetterKeyCode.RightCommand:
        //            return "right cmd";
        //        case BetterKeyCode.RightWindows:
        //            return "right cmd";
        //        case BetterKeyCode.AltGr:
        //            return "alt gr";
        //        case BetterKeyCode.Help:
        //            return "help";
        //        case BetterKeyCode.Print:
        //            return "print screen";
        //        case BetterKeyCode.SysReq:
        //            return "sys req";
        //        case BetterKeyCode.Break:
        //            return "break";
        //        case BetterKeyCode.Menu:
        //            return "menu";
        //        case BetterKeyCode.Mouse0:
        //            return "mouse 0";
        //        case BetterKeyCode.Mouse1:
        //            return "mouse 1";
        //        case BetterKeyCode.Mouse2:
        //            return "mouse 2";
        //        case BetterKeyCode.Mouse3:
        //            return "mouse 3";
        //        case BetterKeyCode.Mouse4:
        //            return "mouse 4";
        //        case BetterKeyCode.Mouse5:
        //            return "mouse 5";
        //        case BetterKeyCode.Mouse6:
        //            return "mouse 6";
        //        case BetterKeyCode.JoystickButton0:
        //            return "joystick button 0";
        //        case BetterKeyCode.JoystickButton1:
        //            return "joystick button 1";
        //        case BetterKeyCode.JoystickButton2:
        //            return "joystick button 2";
        //        case BetterKeyCode.JoystickButton3:
        //            return "joystick button 3";
        //        case BetterKeyCode.JoystickButton4:
        //            return "joystick button 4";
        //        case BetterKeyCode.JoystickButton5:
        //            return "joystick button 5";
        //        case BetterKeyCode.JoystickButton6:
        //            return "joystick button 6";
        //        case BetterKeyCode.JoystickButton7:
        //            return "joystick button 7";
        //        case BetterKeyCode.JoystickButton8:
        //            return "joystick button 8";
        //        case BetterKeyCode.JoystickButton9:
        //            return "joystick button 9";
        //        case BetterKeyCode.JoystickButton10:
        //            return "joystick button 10";
        //        case BetterKeyCode.JoystickButton11:
        //            return "joystick button 11";
        //        case BetterKeyCode.JoystickButton12:
        //            return "joystick button 12";
        //        case BetterKeyCode.JoystickButton13:
        //            return "joystick button 13";
        //        case BetterKeyCode.JoystickButton14:
        //            return "joystick button 14";
        //        case BetterKeyCode.JoystickButton15:
        //            return "joystick button 15";
        //        case BetterKeyCode.JoystickButton16:
        //            return "joystick button 16";
        //        case BetterKeyCode.JoystickButton17:
        //            return "joystick button 17";
        //        case BetterKeyCode.JoystickButton18:
        //            return "joystick button 18";
        //        case BetterKeyCode.JoystickButton19:
        //            return "joystick button 19";
        //        case BetterKeyCode.Joystick1Button0:
        //            return "joystick 1 button 0";
        //        case BetterKeyCode.Joystick1Button1:
        //            return "joystick 1 button 1";
        //        case BetterKeyCode.Joystick1Button2:
        //            return "joystick 1 button 2";
        //        case BetterKeyCode.Joystick1Button3:
        //            return "joystick 1 button 3";
        //        case BetterKeyCode.Joystick1Button4:
        //            return "joystick 1 button 4";
        //        case BetterKeyCode.Joystick1Button5:
        //            return "joystick 1 button 5";
        //        case BetterKeyCode.Joystick1Button6:
        //            return "joystick 1 button 6";
        //        case BetterKeyCode.Joystick1Button7:
        //            return "joystick 1 button 7";
        //        case BetterKeyCode.Joystick1Button8:
        //            return "joystick 1 button 8";
        //        case BetterKeyCode.Joystick1Button9:
        //            return "joystick 1 button 9";
        //        case BetterKeyCode.Joystick1Button10:
        //            return "joystick 1 button 10";
        //        case BetterKeyCode.Joystick1Button11:
        //            return "joystick 1 button 11";
        //        case BetterKeyCode.Joystick1Button12:
        //            return "joystick 1 button 12";
        //        case BetterKeyCode.Joystick1Button13:
        //            return "joystick 1 button 13";
        //        case BetterKeyCode.Joystick1Button14:
        //            return "joystick 1 button 14";
        //        case BetterKeyCode.Joystick1Button15:
        //            return "joystick 1 button 15";
        //        case BetterKeyCode.Joystick1Button16:
        //            return "joystick 1 button 16";
        //        case BetterKeyCode.Joystick1Button17:
        //            return "joystick 1 button 17";
        //        case BetterKeyCode.Joystick1Button18:
        //            return "joystick 1 button 18";
        //        case BetterKeyCode.Joystick1Button19:
        //            return "joystick 1 button 19";
        //        case BetterKeyCode.Joystick2Button0:
        //            return "joystick 2 button 0";
        //        case BetterKeyCode.Joystick2Button1:
        //            return "joystick 2 button 1";
        //        case BetterKeyCode.Joystick2Button2:
        //            return "joystick 2 button 2";
        //        case BetterKeyCode.Joystick2Button3:
        //            return "joystick 2 button 3";
        //        case BetterKeyCode.Joystick2Button4:
        //            return "joystick 2 button 4";
        //        case BetterKeyCode.Joystick2Button5:
        //            return "joystick 2 button 5";
        //        case BetterKeyCode.Joystick2Button6:
        //            return "joystick 2 button 6";
        //        case BetterKeyCode.Joystick2Button7:
        //            return "joystick 2 button 7";
        //        case BetterKeyCode.Joystick2Button8:
        //            return "joystick 2 button 8";
        //        case BetterKeyCode.Joystick2Button9:
        //            return "joystick 2 button 9";
        //        case BetterKeyCode.Joystick2Button10:
        //            return "joystick 2 button 10";
        //        case BetterKeyCode.Joystick2Button11:
        //            return "joystick 2 button 11";
        //        case BetterKeyCode.Joystick2Button12:
        //            return "joystick 2 button 12";
        //        case BetterKeyCode.Joystick2Button13:
        //            return "joystick 2 button 13";
        //        case BetterKeyCode.Joystick2Button14:
        //            return "joystick 2 button 14";
        //        case BetterKeyCode.Joystick2Button15:
        //            return "joystick 2 button 15";
        //        case BetterKeyCode.Joystick2Button16:
        //            return "joystick 2 button 16";
        //        case BetterKeyCode.Joystick2Button17:
        //            return "joystick 2 button 17";
        //        case BetterKeyCode.Joystick2Button18:
        //            return "joystick 2 button 18";
        //        case BetterKeyCode.Joystick2Button19:
        //            return "joystick 2 button 19";
        //        case BetterKeyCode.Joystick3Button0:
        //            return "joystick 3 button 0";
        //        case BetterKeyCode.Joystick3Button1:
        //            return "joystick 3 button 1";
        //        case BetterKeyCode.Joystick3Button2:
        //            return "joystick 3 button 2";
        //        case BetterKeyCode.Joystick3Button3:
        //            return "joystick 3 button 3";
        //        case BetterKeyCode.Joystick3Button4:
        //            return "joystick 3 button 4";
        //        case BetterKeyCode.Joystick3Button5:
        //            return "joystick 3 button 5";
        //        case BetterKeyCode.Joystick3Button6:
        //            return "joystick 3 button 6";
        //        case BetterKeyCode.Joystick3Button7:
        //            return "joystick 3 button 7";
        //        case BetterKeyCode.Joystick3Button8:
        //            return "joystick 3 button 8";
        //        case BetterKeyCode.Joystick3Button9:
        //            return "joystick 3 button 9";
        //        case BetterKeyCode.Joystick3Button10:
        //            return "joystick 3 button 10";
        //        case BetterKeyCode.Joystick3Button11:
        //            return "joystick 3 button 11";
        //        case BetterKeyCode.Joystick3Button12:
        //            return "joystick 3 button 12";
        //        case BetterKeyCode.Joystick3Button13:
        //            return "joystick 3 button 13";
        //        case BetterKeyCode.Joystick3Button14:
        //            return "joystick 3 button 14";
        //        case BetterKeyCode.Joystick3Button15:
        //            return "joystick 3 button 15";
        //        case BetterKeyCode.Joystick3Button16:
        //            return "joystick 3 button 16";
        //        case BetterKeyCode.Joystick3Button17:
        //            return "joystick 3 button 17";
        //        case BetterKeyCode.Joystick3Button18:
        //            return "joystick 3 button 18";
        //        case BetterKeyCode.Joystick3Button19:
        //            return "joystick 3 button 19";
        //        case BetterKeyCode.Joystick4Button0:
        //            return "joystick 4 button 0";
        //        case BetterKeyCode.Joystick4Button1:
        //            return "joystick 4 button 1";
        //        case BetterKeyCode.Joystick4Button2:
        //            return "joystick 4 button 2";
        //        case BetterKeyCode.Joystick4Button3:
        //            return "joystick 4 button 3";
        //        case BetterKeyCode.Joystick4Button4:
        //            return "joystick 4 button 4";
        //        case BetterKeyCode.Joystick4Button5:
        //            return "joystick 4 button 5";
        //        case BetterKeyCode.Joystick4Button6:
        //            return "joystick 4 button 6";
        //        case BetterKeyCode.Joystick4Button7:
        //            return "joystick 4 button 7";
        //        case BetterKeyCode.Joystick4Button8:
        //            return "joystick 4 button 8";
        //        case BetterKeyCode.Joystick4Button9:
        //            return "joystick 4 button 9";
        //        case BetterKeyCode.Joystick4Button10:
        //            return "joystick 4 button 10";
        //        case BetterKeyCode.Joystick4Button11:
        //            return "joystick 4 button 11";
        //        case BetterKeyCode.Joystick4Button12:
        //            return "joystick 4 button 12";
        //        case BetterKeyCode.Joystick4Button13:
        //            return "joystick 4 button 13";
        //        case BetterKeyCode.Joystick4Button14:
        //            return "joystick 4 button 14";
        //        case BetterKeyCode.Joystick4Button15:
        //            return "joystick 4 button 15";
        //        case BetterKeyCode.Joystick4Button16:
        //            return "joystick 4 button 16";
        //        case BetterKeyCode.Joystick4Button17:
        //            return "joystick 4 button 17";
        //        case BetterKeyCode.Joystick4Button18:
        //            return "joystick 4 button 18";
        //        case BetterKeyCode.Joystick4Button19:
        //            return "joystick 4 button 19";
        //        case BetterKeyCode.Joystick5Button0:
        //            return "joystick 5 button 0";
        //        case BetterKeyCode.Joystick5Button1:
        //            return "joystick 5 button 1";
        //        case BetterKeyCode.Joystick5Button2:
        //            return "joystick 5 button 2";
        //        case BetterKeyCode.Joystick5Button3:
        //            return "joystick 5 button 3";
        //        case BetterKeyCode.Joystick5Button4:
        //            return "joystick 5 button 4";
        //        case BetterKeyCode.Joystick5Button5:
        //            return "joystick 5 button 5";
        //        case BetterKeyCode.Joystick5Button6:
        //            return "joystick 5 button 6";
        //        case BetterKeyCode.Joystick5Button7:
        //            return "joystick 5 button 7";
        //        case BetterKeyCode.Joystick5Button8:
        //            return "joystick 5 button 8";
        //        case BetterKeyCode.Joystick5Button9:
        //            return "joystick 5 button 9";
        //        case BetterKeyCode.Joystick5Button10:
        //            return "joystick 5 button 10";
        //        case BetterKeyCode.Joystick5Button11:
        //            return "joystick 5 button 11";
        //        case BetterKeyCode.Joystick5Button12:
        //            return "joystick 5 button 12";
        //        case BetterKeyCode.Joystick5Button13:
        //            return "joystick 5 button 13";
        //        case BetterKeyCode.Joystick5Button14:
        //            return "joystick 5 button 14";
        //        case BetterKeyCode.Joystick5Button15:
        //            return "joystick 5 button 15";
        //        case BetterKeyCode.Joystick5Button16:
        //            return "joystick 5 button 16";
        //        case BetterKeyCode.Joystick5Button17:
        //            return "joystick 5 button 17";
        //        case BetterKeyCode.Joystick5Button18:
        //            return "joystick 5 button 18";
        //        case BetterKeyCode.Joystick5Button19:
        //            return "joystick 5 button 19";
        //        case BetterKeyCode.Joystick6Button0:
        //            return "joystick 6 button 0";
        //        case BetterKeyCode.Joystick6Button1:
        //            return "joystick 6 button 1";
        //        case BetterKeyCode.Joystick6Button2:
        //            return "joystick 6 button 2";
        //        case BetterKeyCode.Joystick6Button3:
        //            return "joystick 6 button 3";
        //        case BetterKeyCode.Joystick6Button4:
        //            return "joystick 6 button 4";
        //        case BetterKeyCode.Joystick6Button5:
        //            return "joystick 6 button 5";
        //        case BetterKeyCode.Joystick6Button6:
        //            return "joystick 6 button 6";
        //        case BetterKeyCode.Joystick6Button7:
        //            return "joystick 6 button 7";
        //        case BetterKeyCode.Joystick6Button8:
        //            return "joystick 6 button 8";
        //        case BetterKeyCode.Joystick6Button9:
        //            return "joystick 6 button 9";
        //        case BetterKeyCode.Joystick6Button10:
        //            return "joystick 6 button 10";
        //        case BetterKeyCode.Joystick6Button11:
        //            return "joystick 6 button 11";
        //        case BetterKeyCode.Joystick6Button12:
        //            return "joystick 6 button 12";
        //        case BetterKeyCode.Joystick6Button13:
        //            return "joystick 6 button 13";
        //        case BetterKeyCode.Joystick6Button14:
        //            return "joystick 6 button 14";
        //        case BetterKeyCode.Joystick6Button15:
        //            return "joystick 6 button 15";
        //        case BetterKeyCode.Joystick6Button16:
        //            return "joystick 6 button 16";
        //        case BetterKeyCode.Joystick6Button17:
        //            return "joystick 6 button 17";
        //        case BetterKeyCode.Joystick6Button18:
        //            return "joystick 6 button 18";
        //        case BetterKeyCode.Joystick6Button19:
        //            return "joystick 6 button 19";
        //        case BetterKeyCode.Joystick7Button0:
        //            return "joystick 7 button 0";
        //        case BetterKeyCode.Joystick7Button1:
        //            return "joystick 7 button 1";
        //        case BetterKeyCode.Joystick7Button2:
        //            return "joystick 7 button 2";
        //        case BetterKeyCode.Joystick7Button3:
        //            return "joystick 7 button 3";
        //        case BetterKeyCode.Joystick7Button4:
        //            return "joystick 7 button 4";
        //        case BetterKeyCode.Joystick7Button5:
        //            return "joystick 7 button 5";
        //        case BetterKeyCode.Joystick7Button6:
        //            return "joystick 7 button 6";
        //        case BetterKeyCode.Joystick7Button7:
        //            return "joystick 7 button 7";
        //        case BetterKeyCode.Joystick7Button8:
        //            return "joystick 7 button 8";
        //        case BetterKeyCode.Joystick7Button9:
        //            return "joystick 7 button 9";
        //        case BetterKeyCode.Joystick7Button10:
        //            return "joystick 7 button 10";
        //        case BetterKeyCode.Joystick7Button11:
        //            return "joystick 7 button 11";
        //        case BetterKeyCode.Joystick7Button12:
        //            return "joystick 7 button 12";
        //        case BetterKeyCode.Joystick7Button13:
        //            return "joystick 7 button 13";
        //        case BetterKeyCode.Joystick7Button14:
        //            return "joystick 7 button 14";
        //        case BetterKeyCode.Joystick7Button15:
        //            return "joystick 7 button 15";
        //        case BetterKeyCode.Joystick7Button16:
        //            return "joystick 7 button 16";
        //        case BetterKeyCode.Joystick7Button17:
        //            return "joystick 7 button 17";
        //        case BetterKeyCode.Joystick7Button18:
        //            return "joystick 7 button 18";
        //        case BetterKeyCode.Joystick7Button19:
        //            return "joystick 7 button 19";
        //        case BetterKeyCode.Joystick8Button0:
        //            return "joystick 8 button 0";
        //        case BetterKeyCode.Joystick8Button1:
        //            return "joystick 8 button 1";
        //        case BetterKeyCode.Joystick8Button2:
        //            return "joystick 8 button 2";
        //        case BetterKeyCode.Joystick8Button3:
        //            return "joystick 8 button 3";
        //        case BetterKeyCode.Joystick8Button4:
        //            return "joystick 8 button 4";
        //        case BetterKeyCode.Joystick8Button5:
        //            return "joystick 8 button 5";
        //        case BetterKeyCode.Joystick8Button6:
        //            return "joystick 8 button 6";
        //        case BetterKeyCode.Joystick8Button7:
        //            return "joystick 8 button 7";
        //        case BetterKeyCode.Joystick8Button8:
        //            return "joystick 8 button 8";
        //        case BetterKeyCode.Joystick8Button9:
        //            return "joystick 8 button 9";
        //        case BetterKeyCode.Joystick8Button10:
        //            return "joystick 8 button 10";
        //        case BetterKeyCode.Joystick8Button11:
        //            return "joystick 8 button 11";
        //        case BetterKeyCode.Joystick8Button12:
        //            return "joystick 8 button 12";
        //        case BetterKeyCode.Joystick8Button13:
        //            return "joystick 8 button 13";
        //        case BetterKeyCode.Joystick8Button14:
        //            return "joystick 8 button 14";
        //        case BetterKeyCode.Joystick8Button15:
        //            return "joystick 8 button 15";
        //        case BetterKeyCode.Joystick8Button16:
        //            return "joystick 8 button 16";
        //        case BetterKeyCode.Joystick8Button17:
        //            return "joystick 8 button 17";
        //        case BetterKeyCode.Joystick8Button18:
        //            return "joystick 8 button 18";
        //        case BetterKeyCode.Joystick8Button19:
        //            return "joystick 8 button 19";
        //        default:
        //            return "";
        //    }
        //}

        internal static BetterKeyCode GetKeyCode(string keyName)
        {
            switch (keyName)
            {
                case "backspace":
                    return BetterKeyCode.Backspace;
                case "delete":
                    return BetterKeyCode.Delete;
                case "tab":
                    return BetterKeyCode.Tab;
                case "clear":
                    return BetterKeyCode.Clear;
                case "return":
                    return BetterKeyCode.Return;
                case "pause":
                    return BetterKeyCode.Pause;
                case "escape":
                    return BetterKeyCode.Escape;
                case "space":
                    return BetterKeyCode.Space;
                case "[0]":
                    return BetterKeyCode.Keypad0;
                case "[1]":
                    return BetterKeyCode.Keypad1;
                case "[2]":
                    return BetterKeyCode.Keypad2;
                case "[3]":
                    return BetterKeyCode.Keypad3;
                case "[4]":
                    return BetterKeyCode.Keypad4;
                case "[5]":
                    return BetterKeyCode.Keypad5;
                case "[6]":
                    return BetterKeyCode.Keypad6;
                case "[7]":
                    return BetterKeyCode.Keypad7;
                case "[8]":
                    return BetterKeyCode.Keypad8;
                case "[9]":
                    return BetterKeyCode.Keypad9;
                case "[.]":
                    return BetterKeyCode.KeypadPeriod;
                case "[/]":
                    return BetterKeyCode.KeypadDivide;
                case "[*]":
                    return BetterKeyCode.KeypadMultiply;
                case "[-]":
                    return BetterKeyCode.KeypadMinus;
                case "[+]":
                    return BetterKeyCode.KeypadPlus;
                case "enter":
                    return BetterKeyCode.KeypadEnter;
                case "equals":
                    return BetterKeyCode.KeypadEquals;
                case "up":
                    return BetterKeyCode.UpArrow;
                case "down":
                    return BetterKeyCode.DownArrow;
                case "right":
                    return BetterKeyCode.RightArrow;
                case "left":
                    return BetterKeyCode.LeftArrow;
                case "insert":
                    return BetterKeyCode.Insert;
                case "home":
                    return BetterKeyCode.Home;
                case "end":
                    return BetterKeyCode.End;
                case "page up":
                    return BetterKeyCode.PageUp;
                case "page down":
                    return BetterKeyCode.PageDown;
                case "f1":
                    return BetterKeyCode.F1;
                case "f2":
                    return BetterKeyCode.F2;
                case "f3":
                    return BetterKeyCode.F3;
                case "f4":
                    return BetterKeyCode.F4;
                case "f5":
                    return BetterKeyCode.F5;
                case "f6":
                    return BetterKeyCode.F6;
                case "f7":
                    return BetterKeyCode.F7;
                case "f8":
                    return BetterKeyCode.F8;
                case "f9":
                    return BetterKeyCode.F9;
                case "f10":
                    return BetterKeyCode.F10;
                case "f11":
                    return BetterKeyCode.F11;
                case "f12":
                    return BetterKeyCode.F12;
                case "f13":
                    return BetterKeyCode.F13;
                case "f14":
                    return BetterKeyCode.F14;
                case "f15":
                    return BetterKeyCode.F15;
                case "0":
                    return BetterKeyCode.Alpha0;
                case "1":
                    return BetterKeyCode.Alpha1;
                case "2":
                    return BetterKeyCode.Alpha2;
                case "3":
                    return BetterKeyCode.Alpha3;
                case "4":
                    return BetterKeyCode.Alpha4;
                case "5":
                    return BetterKeyCode.Alpha5;
                case "6":
                    return BetterKeyCode.Alpha6;
                case "7":
                    return BetterKeyCode.Alpha7;
                case "8":
                    return BetterKeyCode.Alpha8;
                case "9":
                    return BetterKeyCode.Alpha9;
                case "!":
                    return BetterKeyCode.Exclaim;
                case "\"":
                    return BetterKeyCode.DoubleQuote;
                case "#":
                    return BetterKeyCode.Hash;
                case "$":
                    return BetterKeyCode.Dollar;
                case "%":
                    return BetterKeyCode.Percent;
                case "&":
                    return BetterKeyCode.Ampersand;
                case "'":
                    return BetterKeyCode.Quote;
                case "(":
                    return BetterKeyCode.LeftParen;
                case ")":
                    return BetterKeyCode.RightParen;
                case "*":
                    return BetterKeyCode.Asterisk;
                case "+":
                    return BetterKeyCode.Plus;
                case ",":
                    return BetterKeyCode.Comma;
                case "-":
                    return BetterKeyCode.Minus;
                case ".":
                    return BetterKeyCode.Period;
                case "/":
                    return BetterKeyCode.Slash;
                case ":":
                    return BetterKeyCode.Colon;
                case ";":
                    return BetterKeyCode.Semicolon;
                case "<":
                    return BetterKeyCode.Less;
                case "=":
                    return BetterKeyCode.Equals;
                case ">":
                    return BetterKeyCode.Greater;
                case "?":
                    return BetterKeyCode.Question;
                case "@":
                    return BetterKeyCode.At;
                case "[":
                    return BetterKeyCode.LeftBracket;
                case "\\":
                    return BetterKeyCode.Backslash;
                case "]":
                    return BetterKeyCode.RightBracket;
                case "^":
                    return BetterKeyCode.Caret;
                case "_":
                    return BetterKeyCode.Underscore;
                case "`":
                    return BetterKeyCode.BackQuote;
                case "a":
                    return BetterKeyCode.A;
                case "b":
                    return BetterKeyCode.B;
                case "c":
                    return BetterKeyCode.C;
                case "d":
                    return BetterKeyCode.D;
                case "e":
                    return BetterKeyCode.E;
                case "f":
                    return BetterKeyCode.F;
                case "g":
                    return BetterKeyCode.G;
                case "h":
                    return BetterKeyCode.H;
                case "i":
                    return BetterKeyCode.I;
                case "j":
                    return BetterKeyCode.J;
                case "k":
                    return BetterKeyCode.K;
                case "l":
                    return BetterKeyCode.L;
                case "m":
                    return BetterKeyCode.M;
                case "n":
                    return BetterKeyCode.N;
                case "o":
                    return BetterKeyCode.O;
                case "p":
                    return BetterKeyCode.P;
                case "q":
                    return BetterKeyCode.Q;
                case "r":
                    return BetterKeyCode.R;
                case "s":
                    return BetterKeyCode.S;
                case "t":
                    return BetterKeyCode.T;
                case "u":
                    return BetterKeyCode.U;
                case "v":
                    return BetterKeyCode.V;
                case "w":
                    return BetterKeyCode.W;
                case "x":
                    return BetterKeyCode.X;
                case "y":
                    return BetterKeyCode.Y;
                case "z":
                    return BetterKeyCode.Z;
                case "{":
                    return BetterKeyCode.LeftCurlyBracket;
                case "|":
                    return BetterKeyCode.Pipe;
                case "}":
                    return BetterKeyCode.RightCurlyBracket;
                case "~":
                    return BetterKeyCode.Tilde;
                case "numlock":
                    return BetterKeyCode.Numlock;
                case "caps lock":
                    return BetterKeyCode.CapsLock;
                case "scroll lock":
                    return BetterKeyCode.ScrollLock;
                case "right shift":
                    return BetterKeyCode.RightShift;
                case "left shift":
                    return BetterKeyCode.LeftShift;
                case "right ctrl":
                    return BetterKeyCode.RightControl;
                case "left ctrl":
                    return BetterKeyCode.LeftControl;
                case "right alt":
                    return BetterKeyCode.RightAlt;
                case "left alt":
                    return BetterKeyCode.LeftAlt;
                case "left cmd":
                    return BetterKeyCode.LeftCommand;
                case "right cmd":
                    return BetterKeyCode.RightCommand;
                case "alt gr":
                    return BetterKeyCode.AltGr;
                case "help":
                    return BetterKeyCode.Help;
                case "print screen":
                    return BetterKeyCode.Print;
                case "sys req":
                    return BetterKeyCode.SysReq;
                case "break":
                    return BetterKeyCode.Break;
                case "menu":
                    return BetterKeyCode.Menu;
                case "mouse 0":
                    return BetterKeyCode.Mouse0;
                case "mouse 1":
                    return BetterKeyCode.Mouse1;
                case "mouse 2":
                    return BetterKeyCode.Mouse2;
                case "mouse 3":
                    return BetterKeyCode.Mouse3;
                case "mouse 4":
                    return BetterKeyCode.Mouse4;
                case "mouse 5":
                    return BetterKeyCode.Mouse5;
                case "mouse 6":
                    return BetterKeyCode.Mouse6;
                case "joystick button 0":
                    return BetterKeyCode.JoystickButton0;
                case "joystick button 1":
                    return BetterKeyCode.JoystickButton1;
                case "joystick button 2":
                    return BetterKeyCode.JoystickButton2;
                case "joystick button 3":
                    return BetterKeyCode.JoystickButton3;
                case "joystick button 4":
                    return BetterKeyCode.JoystickButton4;
                case "joystick button 5":
                    return BetterKeyCode.JoystickButton5;
                case "joystick button 6":
                    return BetterKeyCode.JoystickButton6;
                case "joystick button 7":
                    return BetterKeyCode.JoystickButton7;
                case "joystick button 8":
                    return BetterKeyCode.JoystickButton8;
                case "joystick button 9":
                    return BetterKeyCode.JoystickButton9;
                case "joystick button 10":
                    return BetterKeyCode.JoystickButton10;
                case "joystick button 11":
                    return BetterKeyCode.JoystickButton11;
                case "joystick button 12":
                    return BetterKeyCode.JoystickButton12;
                case "joystick button 13":
                    return BetterKeyCode.JoystickButton13;
                case "joystick button 14":
                    return BetterKeyCode.JoystickButton14;
                case "joystick button 15":
                    return BetterKeyCode.JoystickButton15;
                case "joystick button 16":
                    return BetterKeyCode.JoystickButton16;
                case "joystick button 17":
                    return BetterKeyCode.JoystickButton17;
                case "joystick button 18":
                    return BetterKeyCode.JoystickButton18;
                case "joystick button 19":
                    return BetterKeyCode.JoystickButton19;
                case "joystick 1 button 0":
                    return BetterKeyCode.Joystick1Button0;
                case "joystick 1 button 1":
                    return BetterKeyCode.Joystick1Button1;
                case "joystick 1 button 2":
                    return BetterKeyCode.Joystick1Button2;
                case "joystick 1 button 3":
                    return BetterKeyCode.Joystick1Button3;
                case "joystick 1 button 4":
                    return BetterKeyCode.Joystick1Button4;
                case "joystick 1 button 5":
                    return BetterKeyCode.Joystick1Button5;
                case "joystick 1 button 6":
                    return BetterKeyCode.Joystick1Button6;
                case "joystick 1 button 7":
                    return BetterKeyCode.Joystick1Button7;
                case "joystick 1 button 8":
                    return BetterKeyCode.Joystick1Button8;
                case "joystick 1 button 9":
                    return BetterKeyCode.Joystick1Button9;
                case "joystick 1 button 10":
                    return BetterKeyCode.Joystick1Button10;
                case "joystick 1 button 11":
                    return BetterKeyCode.Joystick1Button11;
                case "joystick 1 button 12":
                    return BetterKeyCode.Joystick1Button12;
                case "joystick 1 button 13":
                    return BetterKeyCode.Joystick1Button13;
                case "joystick 1 button 14":
                    return BetterKeyCode.Joystick1Button14;
                case "joystick 1 button 15":
                    return BetterKeyCode.Joystick1Button15;
                case "joystick 1 button 16":
                    return BetterKeyCode.Joystick1Button16;
                case "joystick 1 button 17":
                    return BetterKeyCode.Joystick1Button17;
                case "joystick 1 button 18":
                    return BetterKeyCode.Joystick1Button18;
                case "joystick 1 button 19":
                    return BetterKeyCode.Joystick1Button19;
                case "joystick 2 button 0":
                    return BetterKeyCode.Joystick2Button0;
                case "joystick 2 button 1":
                    return BetterKeyCode.Joystick2Button1;
                case "joystick 2 button 2":
                    return BetterKeyCode.Joystick2Button2;
                case "joystick 2 button 3":
                    return BetterKeyCode.Joystick2Button3;
                case "joystick 2 button 4":
                    return BetterKeyCode.Joystick2Button4;
                case "joystick 2 button 5":
                    return BetterKeyCode.Joystick2Button5;
                case "joystick 2 button 6":
                    return BetterKeyCode.Joystick2Button6;
                case "joystick 2 button 7":
                    return BetterKeyCode.Joystick2Button7;
                case "joystick 2 button 8":
                    return BetterKeyCode.Joystick2Button8;
                case "joystick 2 button 9":
                    return BetterKeyCode.Joystick2Button9;
                case "joystick 2 button 10":
                    return BetterKeyCode.Joystick2Button10;
                case "joystick 2 button 11":
                    return BetterKeyCode.Joystick2Button11;
                case "joystick 2 button 12":
                    return BetterKeyCode.Joystick2Button12;
                case "joystick 2 button 13":
                    return BetterKeyCode.Joystick2Button13;
                case "joystick 2 button 14":
                    return BetterKeyCode.Joystick2Button14;
                case "joystick 2 button 15":
                    return BetterKeyCode.Joystick2Button15;
                case "joystick 2 button 16":
                    return BetterKeyCode.Joystick2Button16;
                case "joystick 2 button 17":
                    return BetterKeyCode.Joystick2Button17;
                case "joystick 2 button 18":
                    return BetterKeyCode.Joystick2Button18;
                case "joystick 2 button 19":
                    return BetterKeyCode.Joystick2Button19;
                case "joystick 3 button 0":
                    return BetterKeyCode.Joystick3Button0;
                case "joystick 3 button 1":
                    return BetterKeyCode.Joystick3Button1;
                case "joystick 3 button 2":
                    return BetterKeyCode.Joystick3Button2;
                case "joystick 3 button 3":
                    return BetterKeyCode.Joystick3Button3;
                case "joystick 3 button 4":
                    return BetterKeyCode.Joystick3Button4;
                case "joystick 3 button 5":
                    return BetterKeyCode.Joystick3Button5;
                case "joystick 3 button 6":
                    return BetterKeyCode.Joystick3Button6;
                case "joystick 3 button 7":
                    return BetterKeyCode.Joystick3Button7;
                case "joystick 3 button 8":
                    return BetterKeyCode.Joystick3Button8;
                case "joystick 3 button 9":
                    return BetterKeyCode.Joystick3Button9;
                case "joystick 3 button 10":
                    return BetterKeyCode.Joystick3Button10;
                case "joystick 3 button 11":
                    return BetterKeyCode.Joystick3Button11;
                case "joystick 3 button 12":
                    return BetterKeyCode.Joystick3Button12;
                case "joystick 3 button 13":
                    return BetterKeyCode.Joystick3Button13;
                case "joystick 3 button 14":
                    return BetterKeyCode.Joystick3Button14;
                case "joystick 3 button 15":
                    return BetterKeyCode.Joystick3Button15;
                case "joystick 3 button 16":
                    return BetterKeyCode.Joystick3Button16;
                case "joystick 3 button 17":
                    return BetterKeyCode.Joystick3Button17;
                case "joystick 3 button 18":
                    return BetterKeyCode.Joystick3Button18;
                case "joystick 3 button 19":
                    return BetterKeyCode.Joystick3Button19;
                case "joystick 4 button 0":
                    return BetterKeyCode.Joystick4Button0;
                case "joystick 4 button 1":
                    return BetterKeyCode.Joystick4Button1;
                case "joystick 4 button 2":
                    return BetterKeyCode.Joystick4Button2;
                case "joystick 4 button 3":
                    return BetterKeyCode.Joystick4Button3;
                case "joystick 4 button 4":
                    return BetterKeyCode.Joystick4Button4;
                case "joystick 4 button 5":
                    return BetterKeyCode.Joystick4Button5;
                case "joystick 4 button 6":
                    return BetterKeyCode.Joystick4Button6;
                case "joystick 4 button 7":
                    return BetterKeyCode.Joystick4Button7;
                case "joystick 4 button 8":
                    return BetterKeyCode.Joystick4Button8;
                case "joystick 4 button 9":
                    return BetterKeyCode.Joystick4Button9;
                case "joystick 4 button 10":
                    return BetterKeyCode.Joystick4Button10;
                case "joystick 4 button 11":
                    return BetterKeyCode.Joystick4Button11;
                case "joystick 4 button 12":
                    return BetterKeyCode.Joystick4Button12;
                case "joystick 4 button 13":
                    return BetterKeyCode.Joystick4Button13;
                case "joystick 4 button 14":
                    return BetterKeyCode.Joystick4Button14;
                case "joystick 4 button 15":
                    return BetterKeyCode.Joystick4Button15;
                case "joystick 4 button 16":
                    return BetterKeyCode.Joystick4Button16;
                case "joystick 4 button 17":
                    return BetterKeyCode.Joystick4Button17;
                case "joystick 4 button 18":
                    return BetterKeyCode.Joystick4Button18;
                case "joystick 4 button 19":
                    return BetterKeyCode.Joystick4Button19;
                case "joystick 5 button 0":
                    return BetterKeyCode.Joystick5Button0;
                case "joystick 5 button 1":
                    return BetterKeyCode.Joystick5Button1;
                case "joystick 5 button 2":
                    return BetterKeyCode.Joystick5Button2;
                case "joystick 5 button 3":
                    return BetterKeyCode.Joystick5Button3;
                case "joystick 5 button 4":
                    return BetterKeyCode.Joystick5Button4;
                case "joystick 5 button 5":
                    return BetterKeyCode.Joystick5Button5;
                case "joystick 5 button 6":
                    return BetterKeyCode.Joystick5Button6;
                case "joystick 5 button 7":
                    return BetterKeyCode.Joystick5Button7;
                case "joystick 5 button 8":
                    return BetterKeyCode.Joystick5Button8;
                case "joystick 5 button 9":
                    return BetterKeyCode.Joystick5Button9;
                case "joystick 5 button 10":
                    return BetterKeyCode.Joystick5Button10;
                case "joystick 5 button 11":
                    return BetterKeyCode.Joystick5Button11;
                case "joystick 5 button 12":
                    return BetterKeyCode.Joystick5Button12;
                case "joystick 5 button 13":
                    return BetterKeyCode.Joystick5Button13;
                case "joystick 5 button 14":
                    return BetterKeyCode.Joystick5Button14;
                case "joystick 5 button 15":
                    return BetterKeyCode.Joystick5Button15;
                case "joystick 5 button 16":
                    return BetterKeyCode.Joystick5Button16;
                case "joystick 5 button 17":
                    return BetterKeyCode.Joystick5Button17;
                case "joystick 5 button 18":
                    return BetterKeyCode.Joystick5Button18;
                case "joystick 5 button 19":
                    return BetterKeyCode.Joystick5Button19;
                case "joystick 6 button 0":
                    return BetterKeyCode.Joystick6Button0;
                case "joystick 6 button 1":
                    return BetterKeyCode.Joystick6Button1;
                case "joystick 6 button 2":
                    return BetterKeyCode.Joystick6Button2;
                case "joystick 6 button 3":
                    return BetterKeyCode.Joystick6Button3;
                case "joystick 6 button 4":
                    return BetterKeyCode.Joystick6Button4;
                case "joystick 6 button 5":
                    return BetterKeyCode.Joystick6Button5;
                case "joystick 6 button 6":
                    return BetterKeyCode.Joystick6Button6;
                case "joystick 6 button 7":
                    return BetterKeyCode.Joystick6Button7;
                case "joystick 6 button 8":
                    return BetterKeyCode.Joystick6Button8;
                case "joystick 6 button 9":
                    return BetterKeyCode.Joystick6Button9;
                case "joystick 6 button 10":
                    return BetterKeyCode.Joystick6Button10;
                case "joystick 6 button 11":
                    return BetterKeyCode.Joystick6Button11;
                case "joystick 6 button 12":
                    return BetterKeyCode.Joystick6Button12;
                case "joystick 6 button 13":
                    return BetterKeyCode.Joystick6Button13;
                case "joystick 6 button 14":
                    return BetterKeyCode.Joystick6Button14;
                case "joystick 6 button 15":
                    return BetterKeyCode.Joystick6Button15;
                case "joystick 6 button 16":
                    return BetterKeyCode.Joystick6Button16;
                case "joystick 6 button 17":
                    return BetterKeyCode.Joystick6Button17;
                case "joystick 6 button 18":
                    return BetterKeyCode.Joystick6Button18;
                case "joystick 6 button 19":
                    return BetterKeyCode.Joystick6Button19;
                case "joystick 7 button 0":
                    return BetterKeyCode.Joystick7Button0;
                case "joystick 7 button 1":
                    return BetterKeyCode.Joystick7Button1;
                case "joystick 7 button 2":
                    return BetterKeyCode.Joystick7Button2;
                case "joystick 7 button 3":
                    return BetterKeyCode.Joystick7Button3;
                case "joystick 7 button 4":
                    return BetterKeyCode.Joystick7Button4;
                case "joystick 7 button 5":
                    return BetterKeyCode.Joystick7Button5;
                case "joystick 7 button 6":
                    return BetterKeyCode.Joystick7Button6;
                case "joystick 7 button 7":
                    return BetterKeyCode.Joystick7Button7;
                case "joystick 7 button 8":
                    return BetterKeyCode.Joystick7Button8;
                case "joystick 7 button 9":
                    return BetterKeyCode.Joystick7Button9;
                case "joystick 7 button 10":
                    return BetterKeyCode.Joystick7Button10;
                case "joystick 7 button 11":
                    return BetterKeyCode.Joystick7Button11;
                case "joystick 7 button 12":
                    return BetterKeyCode.Joystick7Button12;
                case "joystick 7 button 13":
                    return BetterKeyCode.Joystick7Button13;
                case "joystick 7 button 14":
                    return BetterKeyCode.Joystick7Button14;
                case "joystick 7 button 15":
                    return BetterKeyCode.Joystick7Button15;
                case "joystick 7 button 16":
                    return BetterKeyCode.Joystick7Button16;
                case "joystick 7 button 17":
                    return BetterKeyCode.Joystick7Button17;
                case "joystick 7 button 18":
                    return BetterKeyCode.Joystick7Button18;
                case "joystick 7 button 19":
                    return BetterKeyCode.Joystick7Button19;
                case "joystick 8 button 0":
                    return BetterKeyCode.Joystick8Button0;
                case "joystick 8 button 1":
                    return BetterKeyCode.Joystick8Button1;
                case "joystick 8 button 2":
                    return BetterKeyCode.Joystick8Button2;
                case "joystick 8 button 3":
                    return BetterKeyCode.Joystick8Button3;
                case "joystick 8 button 4":
                    return BetterKeyCode.Joystick8Button4;
                case "joystick 8 button 5":
                    return BetterKeyCode.Joystick8Button5;
                case "joystick 8 button 6":
                    return BetterKeyCode.Joystick8Button6;
                case "joystick 8 button 7":
                    return BetterKeyCode.Joystick8Button7;
                case "joystick 8 button 8":
                    return BetterKeyCode.Joystick8Button8;
                case "joystick 8 button 9":
                    return BetterKeyCode.Joystick8Button9;
                case "joystick 8 button 10":
                    return BetterKeyCode.Joystick8Button10;
                case "joystick 8 button 11":
                    return BetterKeyCode.Joystick8Button11;
                case "joystick 8 button 12":
                    return BetterKeyCode.Joystick8Button12;
                case "joystick 8 button 13":
                    return BetterKeyCode.Joystick8Button13;
                case "joystick 8 button 14":
                    return BetterKeyCode.Joystick8Button14;
                case "joystick 8 button 15":
                    return BetterKeyCode.Joystick8Button15;
                case "joystick 8 button 16":
                    return BetterKeyCode.Joystick8Button16;
                case "joystick 8 button 17":
                    return BetterKeyCode.Joystick8Button17;
                case "joystick 8 button 18":
                    return BetterKeyCode.Joystick8Button18;
                case "joystick 8 button 19":
                    return BetterKeyCode.Joystick8Button19;
                case "joystick 9 button 0":
                    return BetterKeyCode.Joystick9Button0;
                case "joystick 9 button 1":
                    return BetterKeyCode.Joystick9Button1;
                case "joystick 9 button 2":
                    return BetterKeyCode.Joystick9Button2;
                case "joystick 9 button 3":
                    return BetterKeyCode.Joystick9Button3;
                case "joystick 9 button 4":
                    return BetterKeyCode.Joystick9Button4;
                case "joystick 9 button 5":
                    return BetterKeyCode.Joystick9Button5;
                case "joystick 9 button 6":
                    return BetterKeyCode.Joystick9Button6;
                case "joystick 9 button 7":
                    return BetterKeyCode.Joystick9Button7;
                case "joystick 9 button 8":
                    return BetterKeyCode.Joystick9Button8;
                case "joystick 9 button 9":
                    return BetterKeyCode.Joystick9Button9;
                case "joystick 9 button 10":
                    return BetterKeyCode.Joystick9Button10;
                case "joystick 9 button 11":
                    return BetterKeyCode.Joystick9Button11;
                case "joystick 9 button 12":
                    return BetterKeyCode.Joystick9Button12;
                case "joystick 9 button 13":
                    return BetterKeyCode.Joystick9Button13;
                case "joystick 9 button 14":
                    return BetterKeyCode.Joystick9Button14;
                case "joystick 9 button 15":
                    return BetterKeyCode.Joystick9Button15;
                case "joystick 9 button 16":
                    return BetterKeyCode.Joystick9Button16;
                case "joystick 9 button 17":
                    return BetterKeyCode.Joystick9Button17;
                case "joystick 9 button 18":
                    return BetterKeyCode.Joystick9Button18;
                case "joystick 9 button 19":
                    return BetterKeyCode.Joystick9Button19;
                case "joystick 10 button 0":
                    return BetterKeyCode.Joystick10Button0;
                case "joystick 10 button 1":
                    return BetterKeyCode.Joystick10Button1;
                case "joystick 10 button 2":
                    return BetterKeyCode.Joystick10Button2;
                case "joystick 10 button 3":
                    return BetterKeyCode.Joystick10Button3;
                case "joystick 10 button 4":
                    return BetterKeyCode.Joystick10Button4;
                case "joystick 10 button 5":
                    return BetterKeyCode.Joystick10Button5;
                case "joystick 10 button 6":
                    return BetterKeyCode.Joystick10Button6;
                case "joystick 10 button 7":
                    return BetterKeyCode.Joystick10Button7;
                case "joystick 10 button 8":
                    return BetterKeyCode.Joystick10Button8;
                case "joystick 10 button 9":
                    return BetterKeyCode.Joystick10Button9;
                case "joystick 10 button 10":
                    return BetterKeyCode.Joystick10Button10;
                case "joystick 10 button 11":
                    return BetterKeyCode.Joystick10Button11;
                case "joystick 10 button 12":
                    return BetterKeyCode.Joystick10Button12;
                case "joystick 10 button 13":
                    return BetterKeyCode.Joystick10Button13;
                case "joystick 10 button 14":
                    return BetterKeyCode.Joystick10Button14;
                case "joystick 10 button 15":
                    return BetterKeyCode.Joystick10Button15;
                case "joystick 10 button 16":
                    return BetterKeyCode.Joystick10Button16;
                case "joystick 10 button 17":
                    return BetterKeyCode.Joystick10Button17;
                case "joystick 10 button 18":
                    return BetterKeyCode.Joystick10Button18;
                case "joystick 10 button 19":
                    return BetterKeyCode.Joystick10Button19;
                case "joystick 11 button 0":
                    return BetterKeyCode.Joystick11Button0;
                case "joystick 11 button 1":
                    return BetterKeyCode.Joystick11Button1;
                case "joystick 11 button 2":
                    return BetterKeyCode.Joystick11Button2;
                case "joystick 11 button 3":
                    return BetterKeyCode.Joystick11Button3;
                case "joystick 11 button 4":
                    return BetterKeyCode.Joystick11Button4;
                case "joystick 11 button 5":
                    return BetterKeyCode.Joystick11Button5;
                case "joystick 11 button 6":
                    return BetterKeyCode.Joystick11Button6;
                case "joystick 11 button 7":
                    return BetterKeyCode.Joystick11Button7;
                case "joystick 11 button 8":
                    return BetterKeyCode.Joystick11Button8;
                case "joystick 11 button 9":
                    return BetterKeyCode.Joystick11Button9;
                case "joystick 11 button 10":
                    return BetterKeyCode.Joystick11Button10;
                case "joystick 11 button 11":
                    return BetterKeyCode.Joystick11Button11;
                case "joystick 11 button 12":
                    return BetterKeyCode.Joystick11Button12;
                case "joystick 11 button 13":
                    return BetterKeyCode.Joystick11Button13;
                case "joystick 11 button 14":
                    return BetterKeyCode.Joystick11Button14;
                case "joystick 11 button 15":
                    return BetterKeyCode.Joystick11Button15;
                case "joystick 11 button 16":
                    return BetterKeyCode.Joystick11Button16;
                case "joystick 11 button 17":
                    return BetterKeyCode.Joystick11Button17;
                case "joystick 11 button 18":
                    return BetterKeyCode.Joystick11Button18;
                case "joystick 11 button 19":
                    return BetterKeyCode.Joystick11Button19;
                case "joystick 12 button 0":
                    return BetterKeyCode.Joystick12Button0;
                case "joystick 12 button 1":
                    return BetterKeyCode.Joystick12Button1;
                case "joystick 12 button 2":
                    return BetterKeyCode.Joystick12Button2;
                case "joystick 12 button 3":
                    return BetterKeyCode.Joystick12Button3;
                case "joystick 12 button 4":
                    return BetterKeyCode.Joystick12Button4;
                case "joystick 12 button 5":
                    return BetterKeyCode.Joystick12Button5;
                case "joystick 12 button 6":
                    return BetterKeyCode.Joystick12Button6;
                case "joystick 12 button 7":
                    return BetterKeyCode.Joystick12Button7;
                case "joystick 12 button 8":
                    return BetterKeyCode.Joystick12Button8;
                case "joystick 12 button 9":
                    return BetterKeyCode.Joystick12Button9;
                case "joystick 12 button 10":
                    return BetterKeyCode.Joystick12Button10;
                case "joystick 12 button 11":
                    return BetterKeyCode.Joystick12Button11;
                case "joystick 12 button 12":
                    return BetterKeyCode.Joystick12Button12;
                case "joystick 12 button 13":
                    return BetterKeyCode.Joystick12Button13;
                case "joystick 12 button 14":
                    return BetterKeyCode.Joystick12Button14;
                case "joystick 12 button 15":
                    return BetterKeyCode.Joystick12Button15;
                case "joystick 12 button 16":
                    return BetterKeyCode.Joystick12Button16;
                case "joystick 12 button 17":
                    return BetterKeyCode.Joystick12Button17;
                case "joystick 12 button 18":
                    return BetterKeyCode.Joystick12Button18;
                case "joystick 12 button 19":
                    return BetterKeyCode.Joystick12Button19;
                case "joystick 13 button 0":
                    return BetterKeyCode.Joystick13Button0;
                case "joystick 13 button 1":
                    return BetterKeyCode.Joystick13Button1;
                case "joystick 13 button 2":
                    return BetterKeyCode.Joystick13Button2;
                case "joystick 13 button 3":
                    return BetterKeyCode.Joystick13Button3;
                case "joystick 13 button 4":
                    return BetterKeyCode.Joystick13Button4;
                case "joystick 13 button 5":
                    return BetterKeyCode.Joystick13Button5;
                case "joystick 13 button 6":
                    return BetterKeyCode.Joystick13Button6;
                case "joystick 13 button 7":
                    return BetterKeyCode.Joystick13Button7;
                case "joystick 13 button 8":
                    return BetterKeyCode.Joystick13Button8;
                case "joystick 13 button 9":
                    return BetterKeyCode.Joystick13Button9;
                case "joystick 13 button 10":
                    return BetterKeyCode.Joystick13Button10;
                case "joystick 13 button 11":
                    return BetterKeyCode.Joystick13Button11;
                case "joystick 13 button 12":
                    return BetterKeyCode.Joystick13Button12;
                case "joystick 13 button 13":
                    return BetterKeyCode.Joystick13Button13;
                case "joystick 13 button 14":
                    return BetterKeyCode.Joystick13Button14;
                case "joystick 13 button 15":
                    return BetterKeyCode.Joystick13Button15;
                case "joystick 13 button 16":
                    return BetterKeyCode.Joystick13Button16;
                case "joystick 13 button 17":
                    return BetterKeyCode.Joystick13Button17;
                case "joystick 13 button 18":
                    return BetterKeyCode.Joystick13Button18;
                case "joystick 13 button 19":
                    return BetterKeyCode.Joystick13Button19;
                case "joystick 14 button 0":
                    return BetterKeyCode.Joystick14Button0;
                case "joystick 14 button 1":
                    return BetterKeyCode.Joystick14Button1;
                case "joystick 14 button 2":
                    return BetterKeyCode.Joystick14Button2;
                case "joystick 14 button 3":
                    return BetterKeyCode.Joystick14Button3;
                case "joystick 14 button 4":
                    return BetterKeyCode.Joystick14Button4;
                case "joystick 14 button 5":
                    return BetterKeyCode.Joystick14Button5;
                case "joystick 14 button 6":
                    return BetterKeyCode.Joystick14Button6;
                case "joystick 14 button 7":
                    return BetterKeyCode.Joystick14Button7;
                case "joystick 14 button 8":
                    return BetterKeyCode.Joystick14Button8;
                case "joystick 14 button 9":
                    return BetterKeyCode.Joystick14Button9;
                case "joystick 14 button 10":
                    return BetterKeyCode.Joystick14Button10;
                case "joystick 14 button 11":
                    return BetterKeyCode.Joystick14Button11;
                case "joystick 14 button 12":
                    return BetterKeyCode.Joystick14Button12;
                case "joystick 14 button 13":
                    return BetterKeyCode.Joystick14Button13;
                case "joystick 14 button 14":
                    return BetterKeyCode.Joystick14Button14;
                case "joystick 14 button 15":
                    return BetterKeyCode.Joystick14Button15;
                case "joystick 14 button 16":
                    return BetterKeyCode.Joystick14Button16;
                case "joystick 14 button 17":
                    return BetterKeyCode.Joystick14Button17;
                case "joystick 14 button 18":
                    return BetterKeyCode.Joystick14Button18;
                case "joystick 14 button 19":
                    return BetterKeyCode.Joystick14Button19;
                case "joystick 15 button 0":
                    return BetterKeyCode.Joystick15Button0;
                case "joystick 15 button 1":
                    return BetterKeyCode.Joystick15Button1;
                case "joystick 15 button 2":
                    return BetterKeyCode.Joystick15Button2;
                case "joystick 15 button 3":
                    return BetterKeyCode.Joystick15Button3;
                case "joystick 15 button 4":
                    return BetterKeyCode.Joystick15Button4;
                case "joystick 15 button 5":
                    return BetterKeyCode.Joystick15Button5;
                case "joystick 15 button 6":
                    return BetterKeyCode.Joystick15Button6;
                case "joystick 15 button 7":
                    return BetterKeyCode.Joystick15Button7;
                case "joystick 15 button 8":
                    return BetterKeyCode.Joystick15Button8;
                case "joystick 15 button 9":
                    return BetterKeyCode.Joystick15Button9;
                case "joystick 15 button 10":
                    return BetterKeyCode.Joystick15Button10;
                case "joystick 15 button 11":
                    return BetterKeyCode.Joystick15Button11;
                case "joystick 15 button 12":
                    return BetterKeyCode.Joystick15Button12;
                case "joystick 15 button 13":
                    return BetterKeyCode.Joystick15Button13;
                case "joystick 15 button 14":
                    return BetterKeyCode.Joystick15Button14;
                case "joystick 15 button 15":
                    return BetterKeyCode.Joystick15Button15;
                case "joystick 15 button 16":
                    return BetterKeyCode.Joystick15Button16;
                case "joystick 15 button 17":
                    return BetterKeyCode.Joystick15Button17;
                case "joystick 15 button 18":
                    return BetterKeyCode.Joystick15Button18;
                case "joystick 15 button 19":
                    return BetterKeyCode.Joystick15Button19;
                case "joystick 16 button 0":
                    return BetterKeyCode.Joystick16Button0;
                case "joystick 16 button 1":
                    return BetterKeyCode.Joystick16Button1;
                case "joystick 16 button 2":
                    return BetterKeyCode.Joystick16Button2;
                case "joystick 16 button 3":
                    return BetterKeyCode.Joystick16Button3;
                case "joystick 16 button 4":
                    return BetterKeyCode.Joystick16Button4;
                case "joystick 16 button 5":
                    return BetterKeyCode.Joystick16Button5;
                case "joystick 16 button 6":
                    return BetterKeyCode.Joystick16Button6;
                case "joystick 16 button 7":
                    return BetterKeyCode.Joystick16Button7;
                case "joystick 16 button 8":
                    return BetterKeyCode.Joystick16Button8;
                case "joystick 16 button 9":
                    return BetterKeyCode.Joystick16Button9;
                case "joystick 16 button 10":
                    return BetterKeyCode.Joystick16Button10;
                case "joystick 16 button 11":
                    return BetterKeyCode.Joystick16Button11;
                case "joystick 16 button 12":
                    return BetterKeyCode.Joystick16Button12;
                case "joystick 16 button 13":
                    return BetterKeyCode.Joystick16Button13;
                case "joystick 16 button 14":
                    return BetterKeyCode.Joystick16Button14;
                case "joystick 16 button 15":
                    return BetterKeyCode.Joystick16Button15;
                case "joystick 16 button 16":
                    return BetterKeyCode.Joystick16Button16;
                case "joystick 16 button 17":
                    return BetterKeyCode.Joystick16Button17;
                case "joystick 16 button 18":
                    return BetterKeyCode.Joystick16Button18;
                case "joystick 16 button 19":
                    return BetterKeyCode.Joystick16Button19;
                default:
                    return BetterKeyCode.None;
            }
        }
    }
}