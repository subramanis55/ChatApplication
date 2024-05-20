﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Manager
{
    public static class FeaturesMethods
    {
        // Import the GetWindowLong and SetWindowLong functions from user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        // Constants for window styles
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TOOLWINDOW = 0x80;

        // Method to set the WS_EX_TOOLWINDOW style to remove the form from Alt+Tab
       public static void AltTabFormShowStop(IntPtr handle)
        {
            int extendedStyle = GetWindowLong(handle, GWL_EXSTYLE);
            extendedStyle |= WS_EX_TOOLWINDOW;
            SetWindowLong(handle, GWL_EXSTYLE, extendedStyle);
        }


        public static Color GetNamePColor(string Name)
        {
            char FirstLetter = Name[0];

            Color NamePColor;

            // if(FirstLetter == 'a' || FirstLetter=='A')NamePColor= Color.FromArgb(0x53BDEB);
            switch (Char.ToUpper(FirstLetter))
            {
                case 'A': return Color.FromArgb(0x53BDEB); // Blue
                case 'B': return Color.FromArgb(0xFF5733); // Orange
                case 'C': return Color.FromArgb(0xC70039); // Red
                case 'D': return Color.FromArgb(0xFFC300); // Yellow
                case 'E': return Color.FromArgb(0xFF6363); // Light Red
                case 'F': return Color.FromArgb(0x7D3C98); // Purple
                case 'G': return Color.FromArgb(0x4CAF50); // Green
                case 'H': return Color.FromArgb(0x9B59B6); // Violet
                case 'I': return Color.FromArgb(0x03A9F4); // Sky Blue
                case 'J': return Color.FromArgb(0x8E44AD); // Dark Purple
                case 'K': return Color.FromArgb(0xFFA07A); // Light Salmon
                case 'L': return Color.FromArgb(0x009688); // Teal
                case 'M': return Color.FromArgb(0x00BCD4); // Cyan
                case 'N': return Color.FromArgb(0x2196F3); // Blue
                case 'O': return Color.FromArgb(0x8BC34A); // Light Green
                case 'P': return Color.FromArgb(0xFF9800); // Orange
                case 'Q': return Color.FromArgb(0xF44336); // Dark Red
                case 'R': return Color.FromArgb(0xE91E63); // Pink
                case 'S': return Color.FromArgb(0x2196F3);// Yellow
                case 'T': return Color.FromArgb(0xFF5722); // Deep Orange
                case 'U': return Color.FromArgb(0x607D8B); // Blue Grey
                case 'V': return Color.FromArgb(0x795548); // Brown
                case 'W': return Color.FromArgb(0x9E9E9E); // Grey
                case 'X': return Color.FromArgb(0x607D8B); // Dark Grey
                case 'Y': return Color.FromArgb(0x2196F3);// Blue
                case 'Z': return Color.FromArgb(0x673AB7); // Deep Purple
                default: return Color.Black; // Default color
            }
        }
    }
}
