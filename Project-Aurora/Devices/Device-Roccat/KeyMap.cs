﻿using System.Collections.Generic;
using Aurora;
using Aurora.Devices;
using Aurora.Settings;

namespace Device_Roccat
{
    static class KeyMap
    {
        //Ansi Layout? SDK Docs are mentioning Enter = 52 is DE/iso Layout
        public static Dictionary<DeviceKeys, byte> DeviceKeysMap = new Dictionary<DeviceKeys, byte>
        {
            {DeviceKeys.ESC, 0 },
            {DeviceKeys.F1, 1 },
            {DeviceKeys.F2, 2 },
            {DeviceKeys.F3, 3 },
            {DeviceKeys.F4, 4 },
            {DeviceKeys.F5, 5 },
            {DeviceKeys.F6, 6 },
            {DeviceKeys.F7, 7 },
            {DeviceKeys.F8, 8 },
            {DeviceKeys.F9, 9 },
            {DeviceKeys.F10, 10 },
            {DeviceKeys.F11, 11 },
            {DeviceKeys.F12, 12 },
            {DeviceKeys.PRINT_SCREEN, 13 },
            {DeviceKeys.SCROLL_LOCK, 14 },
            {DeviceKeys.PAUSE_BREAK, 15 },
            {DeviceKeys.G1, 16 },
            {DeviceKeys.TILDE, 17 },
            {DeviceKeys.ONE, 18 },
            {DeviceKeys.TWO, 19 },
            {DeviceKeys.THREE, 20 },
            {DeviceKeys.FOUR, 21 },
            {DeviceKeys.FIVE, 22 },
            {DeviceKeys.SIX, 23 },
            {DeviceKeys.SEVEN, 24 },
            {DeviceKeys.EIGHT, 25 },
            {DeviceKeys.NINE, 26 },
            {DeviceKeys.ZERO, 27 },
            {DeviceKeys.MINUS, 28 },
            {DeviceKeys.EQUALS, 29 },
            {DeviceKeys.BACKSPACE, 30 },
            {DeviceKeys.INSERT, 31 },
            {DeviceKeys.HOME, 32 },
            {DeviceKeys.PAGE_UP, 33 },
            {DeviceKeys.NUM_LOCK, 34 },
            {DeviceKeys.NUM_SLASH, 35 },
            {DeviceKeys.NUM_ASTERISK, 36 },
            {DeviceKeys.NUM_MINUS, 37 },
            {DeviceKeys.G2, 38 },
            {DeviceKeys.TAB, 39 },
            {DeviceKeys.Q, 40 },
            {DeviceKeys.W, 41 },
            {DeviceKeys.E, 42 },
            {DeviceKeys.R, 43 },
            {DeviceKeys.T, 44 },
            {DeviceKeys.Y, 45 },
            {DeviceKeys.U, 46 },
            {DeviceKeys.I, 47 },
            {DeviceKeys.O, 48 },
            {DeviceKeys.P, 49 },
            {DeviceKeys.OPEN_BRACKET, 50 },
            {DeviceKeys.CLOSE_BRACKET, 51 },
            {DeviceKeys.BACKSLASH, 52 },
            {DeviceKeys.DELETE, 53 },
            {DeviceKeys.END, 54 },
            {DeviceKeys.PAGE_DOWN, 55 },
            {DeviceKeys.NUM_SEVEN, 56 },
            {DeviceKeys.NUM_EIGHT, 57 },
            {DeviceKeys.NUM_NINE, 58 },
            {DeviceKeys.NUM_PLUS, 59 },
            {DeviceKeys.G3, 60 },
            {DeviceKeys.CAPS_LOCK, 61 },
            {DeviceKeys.A, 62 },
            {DeviceKeys.S, 63 },
            {DeviceKeys.D, 64 },
            {DeviceKeys.F, 65 },
            {DeviceKeys.G, 66 },
            {DeviceKeys.H, 67 },
            {DeviceKeys.J, 68 },
            {DeviceKeys.K, 69 },
            {DeviceKeys.L, 70 },
            {DeviceKeys.SEMICOLON, 71 },
            {DeviceKeys.APOSTROPHE, 72 },
            {DeviceKeys.ENTER, 73 },
            {DeviceKeys.NUM_FOUR, 74 },
            {DeviceKeys.NUM_FIVE, 75 },
            {DeviceKeys.NUM_SIX, 76 },
            {DeviceKeys.G4, 77 },
            {DeviceKeys.LEFT_SHIFT, 78 },
            {DeviceKeys.BACKSLASH_UK, 79 },
            {DeviceKeys.Z, 80 },
            {DeviceKeys.X, 81 },
            {DeviceKeys.C, 82 },
            {DeviceKeys.V, 83 },
            {DeviceKeys.B, 84 },
            {DeviceKeys.N, 85 },
            {DeviceKeys.M, 86 },
            {DeviceKeys.COMMA, 87 },
            {DeviceKeys.PERIOD, 88 },
            {DeviceKeys.FORWARD_SLASH, 89 },
            {DeviceKeys.RIGHT_SHIFT, 90 },
            {DeviceKeys.ARROW_UP, 91 },
            {DeviceKeys.NUM_ONE, 92 },
            {DeviceKeys.NUM_TWO, 93 },
            {DeviceKeys.NUM_THREE, 94 },
            {DeviceKeys.NUM_ENTER, 95 },
            {DeviceKeys.G5, 96 },
            {DeviceKeys.LEFT_CONTROL, 97 },
            {DeviceKeys.LEFT_WINDOWS, 98 },
            {DeviceKeys.LEFT_ALT, 99 },
            {DeviceKeys.SPACE, 100 },
            {DeviceKeys.RIGHT_ALT, 101 },
            {DeviceKeys.FN_Key, 102 },
            {DeviceKeys.APPLICATION_SELECT, 103 },
            {DeviceKeys.RIGHT_CONTROL, 104 },
            {DeviceKeys.ARROW_LEFT, 105 },
            {DeviceKeys.ARROW_DOWN, 106 },
            {DeviceKeys.ARROW_RIGHT, 107 },
            {DeviceKeys.NUM_ZERO, 108 },
            {DeviceKeys.NUM_PERIOD, 109 }
        };

        public static DeviceLayout GetLayout()
        {
            if (Global.Configuration.keyboard_localization == PreferredKeyboardLocalization.dvorak
                || Global.Configuration.keyboard_localization == PreferredKeyboardLocalization.us
                || Global.Configuration.keyboard_localization == PreferredKeyboardLocalization.ru)
                return DeviceLayout.ANSI;
            else if (Global.Configuration.keyboard_localization == PreferredKeyboardLocalization.jpn)
                return DeviceLayout.JP;
            else
                return DeviceLayout.ISO;
        }

        public enum DeviceLayout : byte
        {
            ISO = 0,
            ANSI = 1,
            JP = 2
        }

        public static DeviceKeys LocalizeKey(DeviceKeys Key)
        {
            //Solution to slightly different mapping rather than giving a whole different dictionary

            if (GetLayout() == DeviceLayout.ISO)
            {
                if (Key == DeviceKeys.ENTER)
                    Key = DeviceKeys.BACKSLASH;
                if (Key == DeviceKeys.HASHTAG)
                    Key = DeviceKeys.ENTER;
            }
            return Key;
        }
    }
}
