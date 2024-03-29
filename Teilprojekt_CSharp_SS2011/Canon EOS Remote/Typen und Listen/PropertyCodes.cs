﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Canon_EOS_Remote.Types;

namespace Canon_EOS_Remote.classes
{
    class PropertyCodes
    {
        private List<TPropertyID> propIDs;

        public List<TPropertyID> PropIDs
        {
            get { return propIDs; }
            private set { propIDs = value; }
        }

        public PropertyCodes()
        {
            this.propIDs = new List<TPropertyID>();
            init();
        }

        private void init()
        {
            this.PropIDs.Add(new TPropertyID("PropID_Unknown", 0x0000ffff));
            this.PropIDs.Add(new TPropertyID("PropID_ProductName", 0x00000002));
            this.PropIDs.Add(new TPropertyID("PropID_BodyIDEx", 0x00000015));
            this.PropIDs.Add(new TPropertyID("PropID_OwnerName", 0x00000004));
            this.PropIDs.Add(new TPropertyID("PropID_MakerName", 0x00000005));
            this.PropIDs.Add(new TPropertyID("PropID_DateTime", 0x00000006));
            this.PropIDs.Add(new TPropertyID("PropID_FirmwareVersion", 0x00000007));
            this.PropIDs.Add(new TPropertyID("PropID_BatteryLevel", 0x00000008));
            this.PropIDs.Add(new TPropertyID("PropID_CFn", 0x00000009));
            this.PropIDs.Add(new TPropertyID("PropID_SaveTo", 0x0000000b));
            this.PropIDs.Add(new TPropertyID("kEdsPropID_CurrentStorage", 0x0000000c));
            this.PropIDs.Add(new TPropertyID("kEdsPropID_CurrentFolder", 0x0000000d));
            this.PropIDs.Add(new TPropertyID("kEdsPropID_MyMenu", 0x0000000e));
            this.PropIDs.Add(new TPropertyID("PropID_BatteryQuality", 0x00000010));
            this.PropIDs.Add(new TPropertyID("PropID_HDDirectoryStructure", 0x00000020));
            this.PropIDs.Add(new TPropertyID("PropID_ImageQuality", 0x00000100));
            this.PropIDs.Add(new TPropertyID("PropID_JpegQuality", 0x00000101));
            this.PropIDs.Add(new TPropertyID("PropID_Orientation", 0x00000102));
            this.PropIDs.Add(new TPropertyID("PropID_ICCProfile", 0x00000103));
            this.PropIDs.Add(new TPropertyID("PropID_FocusInfo", 0x00000104));
            this.PropIDs.Add(new TPropertyID("PropID_DigitalExposure", 0x00000105));
            this.PropIDs.Add(new TPropertyID("PropID_WhiteBalance", 0x00000106));
            this.PropIDs.Add(new TPropertyID("PropID_ColorTemperature", 0x00000107));
            this.PropIDs.Add(new TPropertyID("PropID_WhiteBalanceShift", 0x00000108));
            this.PropIDs.Add(new TPropertyID("PropID_Contrast", 0x00000109));
            this.PropIDs.Add(new TPropertyID("PropID_ColorSaturation", 0x0000010a));
            this.PropIDs.Add(new TPropertyID("PropID_ColorTone", 0x0000010b));
            this.PropIDs.Add(new TPropertyID("PropID_Sharpness", 0x0000010c));
            this.PropIDs.Add(new TPropertyID("PropID_ColorSpace", 0x0000010d));
            this.PropIDs.Add(new TPropertyID("PropID_ToneCurve", 0x0000010e));
            this.PropIDs.Add(new TPropertyID("PropID_PhotoEffect", 0x0000010f));
            this.PropIDs.Add(new TPropertyID("PropID_FilterEffect", 0x00000110));
            this.PropIDs.Add(new TPropertyID("PropID_ToningEffect", 0x00000111));
            this.PropIDs.Add(new TPropertyID("PropID_ParameterSet", 0x00000112));
            this.PropIDs.Add(new TPropertyID("PropID_ColorMatrix", 0x00000113));
            this.PropIDs.Add(new TPropertyID("PropID_PictureStyle", 0x00000114));
            this.PropIDs.Add(new TPropertyID("PropID_PictureStyleDesc", 0x00000115));
            this.PropIDs.Add(new TPropertyID("PropID_PictureStyleCaption", 0x00000200));
            this.PropIDs.Add(new TPropertyID("PropID_AEMode", 0x00000400));
            this.PropIDs.Add(new TPropertyID("PropID_DriveMode", 0x00000401));
            this.PropIDs.Add(new TPropertyID("PropID_ISOSpeed", 0x00000402));
            this.PropIDs.Add(new TPropertyID("PropID_MeteringMode", 0x00000403));
            this.PropIDs.Add(new TPropertyID("PropID_AFMode", 0x00000404));
            this.PropIDs.Add(new TPropertyID("PropID_Av", 0x00000405));
            this.PropIDs.Add(new TPropertyID("PropID_Tv", 0x00000406));
            this.PropIDs.Add(new TPropertyID("PropID_ExposureCompensation", 0x00000407));
            this.PropIDs.Add(new TPropertyID("PropID_FlashCompensation", 0x00000408));
            this.PropIDs.Add(new TPropertyID("PropID_FocalLength", 0x00000409));
            this.PropIDs.Add(new TPropertyID("PropID_AvailableShots", 0x0000040a));
            this.PropIDs.Add(new TPropertyID("PropID_Bracket", 0x0000040b));
            this.PropIDs.Add(new TPropertyID("PropID_WhiteBalanceBracket", 0x0000040c));
            this.PropIDs.Add(new TPropertyID("PropID_LensName", 0x0000040d));
            this.PropIDs.Add(new TPropertyID("PropID_AEBracket", 0x0000040e));
            this.PropIDs.Add(new TPropertyID("PropID_FEBracket", 0x0000040f));
            this.PropIDs.Add(new TPropertyID("PropID_ISOBracket", 0x00000410));
            this.PropIDs.Add(new TPropertyID("PropID_NoiseReduction", 0x00000411));
            this.PropIDs.Add(new TPropertyID("PropID_FlashOn", 0x00000412));
            this.PropIDs.Add(new TPropertyID("PropID_RedEye", 0x00000413));
            this.PropIDs.Add(new TPropertyID("PropID_FlashMode", 0x00000414));
            this.PropIDs.Add(new TPropertyID("PropID_LensStatus", 0x00000416));
            this.PropIDs.Add(new TPropertyID("PropID_Artist", 0x00000418));
            this.PropIDs.Add(new TPropertyID("PropID_Copyright", 0x00000419));
            this.PropIDs.Add(new TPropertyID("PropID_DepthOfField", 0x0000041b));
            this.PropIDs.Add(new TPropertyID("PropID_EFCompensation", 0x0000041e));
            this.PropIDs.Add(new TPropertyID("PropID_Linear", 0x00000300));
            this.PropIDs.Add(new TPropertyID("PropID_ClickWBPoint", 0x00000301));
            this.PropIDs.Add(new TPropertyID("PropID_WBCoeffs", 0x00000302));
            this.PropIDs.Add(new TPropertyID("PropID_AtCapture_Flag", 0x80000000));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_Zoom", 0x00000507));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_ZoomPosition", 0x00000508));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_FocusAid", 0x00000509));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_Histogram", 0x0000050A));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_ImagePosition", 0x0000050B));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_HistogramStatus", 0x0000050C));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_AFMode", 0x0000050E));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_OutputDevice", 0x00000500));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_Mode", 0x00000501));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_WhiteBalance", 0x00000502));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_ColorTemperature", 0x00000503));
            this.PropIDs.Add(new TPropertyID("PropID_Evf_DepthOfFieldPreview", 0x00000504));
            this.PropIDs.Add(new TPropertyID("PropID_GPSVersionID", 0x00000800));
            this.PropIDs.Add(new TPropertyID("PropID_GPSLatitudeRef", 0x00000801));
            this.PropIDs.Add(new TPropertyID("PropID_GPSLatitude", 0x00000802));
            this.PropIDs.Add(new TPropertyID("PropID_GPSLongitudeRef", 0x00000803));
            this.PropIDs.Add(new TPropertyID("PropID_GPSLongitude", 0x00000804));
            this.PropIDs.Add(new TPropertyID("PropID_GPSAltitudeRef", 0x00000805));
            this.PropIDs.Add(new TPropertyID("PropID_GPSAltitude", 0x00000806));
            this.PropIDs.Add(new TPropertyID("PropID_GPSTimeStamp", 0x00000807));
            this.PropIDs.Add(new TPropertyID("PropID_GPSSatellites", 0x00000808));
            this.PropIDs.Add(new TPropertyID("PropID_GPSStatus", 0x00000809));
            this.PropIDs.Add(new TPropertyID("PropID_GPSMapDatum", 0x00000812));
            this.PropIDs.Add(new TPropertyID("PropID_GPSDateStamp", 0x0000081D));
        }

        public string getPropertyString(UInt32 propIDCode)
        {
            for (int i = 0; i < this.PropIDs.Count; i++)
            {
                if (this.PropIDs.ElementAt(i).PropertyIDNumber == propIDCode)
                {
                    return this.PropIDs.ElementAt(i).PropertyIDString;
                }
            }
            return "unknown";
        }
    }
}
