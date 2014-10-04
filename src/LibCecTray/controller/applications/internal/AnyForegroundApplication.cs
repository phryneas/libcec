using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using CecSharp;

namespace LibCECTray.controller.applications.@internal
{
    internal class AnyForegroundApplication : ApplicationController
    {

        public AnyForegroundApplication(CECController controller) :
            base(controller,
           "AnyForegroundApplication",
           "any",
           "any",
           Environment.SystemDirectory)
        {
            IsInternal = true;
            AutoStartApplication.Value = false;
            ControlApplication.Value = true;
        }

        public override ApplicationAction DefaultValue(CecKeypress key)
        {
            KeyInput keyInput = new KeyInput(null);
            switch (key.Keycode)
            {
                case CecUserControlCode.RightUp:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_RIGHT);
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_UP);
                    break;
                case CecUserControlCode.LeftUp:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_LEFT);
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_UP);
                    break;
                case CecUserControlCode.Up:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_UP);
                    break;
                case CecUserControlCode.RightDown:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_RIGHT);
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_DOWN);
                    break;
                case CecUserControlCode.LeftDown:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_LEFT);
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_DOWN);
                    break;
                case CecUserControlCode.Down:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_DOWN);
                    break;
                case CecUserControlCode.Left:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_LEFT);
                    break;
                case CecUserControlCode.Right:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_RIGHT);
                    break;
                case CecUserControlCode.Select:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_RETURN);
                    break;
                case CecUserControlCode.Exit:
                case CecUserControlCode.SamsungReturn:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_BACK);
                    break;
                case CecUserControlCode.RootMenu:
                case CecUserControlCode.SetupMenu:
                case CecUserControlCode.ContentsMenu:
                case CecUserControlCode.FavoriteMenu:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_MENU);
                    break;
                case CecUserControlCode.Number0:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD0);
                    break;
                case CecUserControlCode.Number1:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD1);
                    break;
                case CecUserControlCode.Number2:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD2);
                    break;
                case CecUserControlCode.Number3:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD3);
                    break;
                case CecUserControlCode.Number4:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD4);
                    break;
                case CecUserControlCode.Number5:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD5);
                    break;
                case CecUserControlCode.Number6:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD6);
                    break;
                case CecUserControlCode.Number7:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD7);
                    break;
                case CecUserControlCode.Number8:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD8);
                    break;
                case CecUserControlCode.Number9:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_NUMPAD9);
                    break;
                case CecUserControlCode.Dot:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_SELECT);
                    break;
                case CecUserControlCode.Enter:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_RETURN);
                    break;
                case CecUserControlCode.Clear:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_CLEAR);
                    break;
                case CecUserControlCode.F1Blue:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_F1);
                    break;
                case CecUserControlCode.F2Red:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_F2);
                    break;
                case CecUserControlCode.F3Green:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_F3);
                    break;
                case CecUserControlCode.F4Yellow:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_F4);
                    break;
                case CecUserControlCode.F5:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_F5);
                    break;
                case CecUserControlCode.ChannelUp:
                case CecUserControlCode.PageUp:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_MEDIA_NEXT_TRACK);
                    break;
                case CecUserControlCode.ChannelDown:
                case CecUserControlCode.PageDown:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_MEDIA_PREV_TRACK);
                    break;
                case CecUserControlCode.VolumeUp:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_VOLUME_UP);
                    break;
                case CecUserControlCode.VolumeDown:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_VOLUME_DOWN);
                    break;
                case CecUserControlCode.Mute:
                case CecUserControlCode.MuteFunction:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_VOLUME_MUTE);
                    break;
                case CecUserControlCode.Play:
                case CecUserControlCode.PlayFunction:
                case CecUserControlCode.Pause:
                case CecUserControlCode.PausePlayFunction:
                case CecUserControlCode.PauseRecord:
                case CecUserControlCode.PauseRecordFunction:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_SPACE);
                    break;
                case CecUserControlCode.Stop:
                case CecUserControlCode.StopFunction:
                case CecUserControlCode.StopRecord:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_MEDIA_STOP);
                    break;
                case CecUserControlCode.Rewind:
                case CecUserControlCode.Backward:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_LEFT);
                    break;
                case CecUserControlCode.Forward:
                case CecUserControlCode.FastForward:
                    keyInput.AddKey(WindowsAPI.VirtualKeyCode.VK_RIGHT);
                    break;

                //currently unmapped
                //case CecUserControlCode.NextFavorite:
                //case CecUserControlCode.PreviousChannel:
                //case CecUserControlCode.SoundSelect:
                //case CecUserControlCode.InputSelect:
                //case CecUserControlCode.DisplayInformation:
                //case CecUserControlCode.Help:
                //case CecUserControlCode.Record:
                //case CecUserControlCode.Eject:
                //case CecUserControlCode.Angle:
                //case CecUserControlCode.SubPicture:
                //case CecUserControlCode.VideoOnDemand:
                //case CecUserControlCode.ElectronicProgramGuide:
                //case CecUserControlCode.TimerProgramming:
                //case CecUserControlCode.RecordFunction:
                //case CecUserControlCode.RestoreVolumeFunction:
                //case CecUserControlCode.TuneFunction:
                //case CecUserControlCode.SelectMediaFunction:
                //case CecUserControlCode.SelectAVInputFunction:
                //case CecUserControlCode.SelectAudioInputFunction:
                //case CecUserControlCode.Data:
                //default:
                //  break;
            }

            return keyInput.Empty() ? null : keyInput;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();


        /// <summary>
        /// The main window handle of the application if it's running.
        /// </summary>
        /// <returns>The main window handle, or IntPtr.Zero if it's not found</returns>
        override protected IntPtr FindInstance()
        {
            return GetForegroundWindow();
        }


    }
}
