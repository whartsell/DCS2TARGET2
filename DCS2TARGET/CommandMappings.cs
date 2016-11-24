using System;
using System.Collections.Generic;

namespace DCS2TARGET
{
    public static class CommandMappings
    {
        public static List<List<string>> commandFilters;
        // ORDER MATTERS
        // Remove the quotes
        static CommandMappings()
        {
            commandFilters = new List<List<string>>();
            //Remap the KP to the USB Macros
            commandFilters.Add(new List<String>{ "Num/", "USB_KPForwardSlash" });
            commandFilters.Add(new List<String>{"Num*", "USB_KPAsterisk" });
            commandFilters.Add(new List<String>{"Num-", "USB_KPMinus" });
            commandFilters.Add(new List<String>{"Num+", "USB_KPPlus" });
            commandFilters.Add(new List<String>{"NumEnter", "USB_KPEnter" });
            commandFilters.Add(new List<String>{"Num1", "USB_KP1" });
            commandFilters.Add(new List<String>{"Num2", "USB_KP2" });
            commandFilters.Add(new List<String>{"Num3", "USB_KP3" });
            commandFilters.Add(new List<String>{"Num4", "USB_KP4" });
            commandFilters.Add(new List<String>{"Num5", "USB_KP5" });
            commandFilters.Add(new List<String>{"Num6", "USB_KP6" });
            commandFilters.Add(new List<String>{"Num7", "USB_KP7" });
            commandFilters.Add(new List<String>{"Num8", "USB_KP8" });
            commandFilters.Add(new List<String>{"Num9", "USB_KP9" });
            commandFilters.Add(new List<String>{"Num0", "USB_KP0" });
            commandFilters.Add(new List<String>{"Num.", "USB_KPDecimal" });
            commandFilters.Add(new List<String>{"Num=", "USB_KPEquals" });
            // Now were safe to replace the concatonation to the proper format for TARGET
            commandFilters.Add(new List<String>{" - ", " + " });
            // Modifiers
            commandFilters.Add(new List<String>{"LShift", "L_SHIFT" });
            commandFilters.Add(new List<String>{"LCtrl", "L_CTL" });
            commandFilters.Add(new List<String>{"LWin", "L_WIN" });
            commandFilters.Add(new List<String>{"LAlt", "L_ALT" });
            commandFilters.Add(new List<String>{"RShift", "R_SHIFT" });
            commandFilters.Add(new List<String>{"RCtrl", "R_CTL" });
            commandFilters.Add(new List<String>{"RWin", "R_WIN" });
            commandFilters.Add(new List<String>{"RAlt", "R_ALT" });
            //Named Keys
            commandFilters.Add(new List<String>{"SysRQ", "USB_PrintScreen" });
            commandFilters.Add(new List<String>{"Scroll", "USB_ScrollLock" });
            commandFilters.Add(new List<String>{"Pause", "USB_Break" });
            //commandFilters.Add(new List<String>{"NULL","USB_Break" });
            commandFilters.Add(new List<String>{"Insert", "USB_Insert" });
            commandFilters.Add(new List<String>{"Home", "USB_Home" });
            commandFilters.Add(new List<String>{"PageUp", "USB_PageUp" });
            commandFilters.Add(new List<String>{"Delete", "USB_Delete" });
            commandFilters.Add(new List<String>{"End", "USB_End" });
            commandFilters.Add(new List<String>{"Insert", "USB_Insert" });
            commandFilters.Add(new List<String>{"PageDown", "USB_PageDown" });
            commandFilters.Add(new List<String>{"Right", "USB_RightArrow" });
            commandFilters.Add(new List<String>{"Left", "USB_LeftArrow" });
            commandFilters.Add(new List<String>{"Down", "USB_DownArrow" });
            commandFilters.Add(new List<String>{"Up", "USB_UpArrow" });
            commandFilters.Add(new List<String>{"NumLock", "USB_NumLock" });
            commandFilters.Add(new List<String>{"Enter", "USB_Return" });
            commandFilters.Add(new List<String>{"ESC", "USB_Escape" });
            commandFilters.Add(new List<String>{"Back", "USB_Backspace" });
            commandFilters.Add(new List<String>{"Tab", "USB_Tab" });
            commandFilters.Add(new List<String>{"Space", "USB_Space" });
            commandFilters.Add(new List<String>{"-", "USB_Minus" });
            commandFilters.Add(new List<String>{"=", "USB_Equals" });
            commandFilters.Add(new List<String>{"[", "USB_LBracket" });
            commandFilters.Add(new List<String>{"]", "USB_RBracket" });
            commandFilters.Add(new List<String>{"\\", "USB_BackSlash" });
            commandFilters.Add(new List<String>{";", "USB_SemiColon" });
            commandFilters.Add(new List<String>{"'", "USB_Apostrophe" });
            commandFilters.Add(new List<String>{"`", "USB_Tilde" });
            commandFilters.Add(new List<String>{",", "USB_Comma" });
            commandFilters.Add(new List<String>{".", "USB_Period" });
            commandFilters.Add(new List<String>{"/", "USB_ForwardSlash" });
            //commandFilters.Add(new List<String>{"NULL","USB_CapsLock" });
            //Function Keys
            commandFilters.Add(new List<String>{"F1", "USB_F1" });
            commandFilters.Add(new List<String>{"F2", "USB_F2" });
            commandFilters.Add(new List<String>{"F3", "USB_F3" });
            commandFilters.Add(new List<String>{"F4", "USB_F4" });
            commandFilters.Add(new List<String>{"F5", "USB_F5" });
            commandFilters.Add(new List<String>{"F6", "USB_F6" });
            commandFilters.Add(new List<String>{"F7", "USB_F7" });
            commandFilters.Add(new List<String>{"F8", "USB_F8" });
            commandFilters.Add(new List<String>{"F9", "USB_F9" });
            commandFilters.Add(new List<String>{"F10", "USB_F10" });
            commandFilters.Add(new List<String>{"F11", "USB_F11" });
            commandFilters.Add(new List<String>{"F12", "USB_F12" });
            // a-z0-9
            commandFilters.Add(new List<String>{"A", "USB_A" });
            commandFilters.Add(new List<String>{"B", "USB_B" });
            commandFilters.Add(new List<String>{"C", "USB_C" });
            commandFilters.Add(new List<String>{"D", "USB_D" });
            commandFilters.Add(new List<String>{"E", "USB_E" });
            commandFilters.Add(new List<String>{"F", "USB_F" });
            commandFilters.Add(new List<String>{"G", "USB_G" });
            commandFilters.Add(new List<String>{"H", "USB_H" });
            commandFilters.Add(new List<String>{"I", "USB_I" });
            commandFilters.Add(new List<String>{"J", "USB_J" });
            commandFilters.Add(new List<String>{"K", "USB_K" });
            commandFilters.Add(new List<String>{"L", "USB_L" });
            commandFilters.Add(new List<String>{"M", "USB_M" });
            commandFilters.Add(new List<String>{"N", "USB_N" });
            commandFilters.Add(new List<String>{"O", "USB_O" });
            commandFilters.Add(new List<String>{"P", "USB_P" });
            commandFilters.Add(new List<String>{"Q", "USB_Q" });
            commandFilters.Add(new List<String>{"R", "USB_R" });
            commandFilters.Add(new List<String>{"S", "USB_S" });
            commandFilters.Add(new List<String>{"T", "USB_T" });
            commandFilters.Add(new List<String>{"U", "USB_U" });
            commandFilters.Add(new List<String>{"V", "USB_V" });
            commandFilters.Add(new List<String>{"W", "USB_W" });
            commandFilters.Add(new List<String>{"X", "USB_X" });
            commandFilters.Add(new List<String>{"Y", "USB_Y" });
            commandFilters.Add(new List<String>{"Z", "USB_Z" });
            commandFilters.Add(new List<String>{"1", "USB_1" });
            commandFilters.Add(new List<String>{"2", "USB_2" });
            commandFilters.Add(new List<String>{"3", "USB_3" });
            commandFilters.Add(new List<String>{"4", "USB_4" });
            commandFilters.Add(new List<String>{"5", "USB_5" });
            commandFilters.Add(new List<String>{"6", "USB_6" });
            commandFilters.Add(new List<String>{"7", "USB_7" });
            commandFilters.Add(new List<String>{"8", "USB_8" });
            commandFilters.Add(new List<String>{"9", "USB_9" });
            commandFilters.Add(new List<String>{"0", "USB_0" });
        }
    }

}










  

