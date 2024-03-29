﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;

namespace Canon_EOS_Remote.Commands
{
    class Command_DriveLensNearTwo : ICommand, INotifyPropertyChanged
    {
        private IntPtr cameraPtr;

        public IntPtr CameraPtr
        {
            get { return cameraPtr; }
            set { cameraPtr = value;
            update("Camera");
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        private void update(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
                Console.WriteLine("Command_TakePhoto say : PropertyChanged : " + property);
            }
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            Console.WriteLine(
    "|-----------------|\n" +
    "|Driving Lens Near2|\n" +
    "|-----------------|\n");
            EDSDKLib.EDSDK.EdsSendCommand(this.CameraPtr, EDSDKLib.EDSDK.CameraCommand_DoEvfAf, 1);
            EDSDKLib.EDSDK.EdsSendCommand(this.CameraPtr, EDSDKLib.EDSDK.CameraCommand_DriveLensEvf, EDSDKLib.EDSDK.EvfDriveLens_Near2);
            EDSDKLib.EDSDK.EdsSendCommand(this.CameraPtr, EDSDKLib.EDSDK.CameraCommand_DoEvfAf, 0);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
