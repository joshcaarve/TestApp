using System;
using AppKit;
using Foundation;
using System.Collections.Generic;
namespace TestApp
{
    public partial class ViewController : NSViewController
    {

        private Dictionary<string, bool> optionsPairs = new Dictionary<string, bool>();
       
        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            ProcessLog.StringValue = "";
            optionsPairs.Add("Orphans", true);
            optionsPairs.Add("Duplicates", true);
            optionsPairs.Add("Missing", true);
            optionsPairs.Add("Untagged", true);
            optionsPairs.Add("Unanalyzed", true);
            optionsPairs.Add("Unreferenced", true);
           
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void OrphansButtonCheck(Foundation.NSObject sender)
        {
            if (OrphansButton.State == NSCellStateValue.On)
            {
                optionsPairs["Orphans"] = true;
            }
            else
            {
                optionsPairs["Orphans"] = false;
            }
        }


        partial void DuplicateButtonCheck(Foundation.NSObject sender)
        {
            if (DuplicatesButton.State == NSCellStateValue.On)
            {
                optionsPairs["Duplicates"] = true;
            }
            else
            {
                optionsPairs["Duplicates"] = false;
            }
        }

        partial void MissingButtonCheck(Foundation.NSObject sender)
        {
            if (MissingButton.State == NSCellStateValue.On)
            {
                optionsPairs["Missing"] = true;
            }
            else
            {
                optionsPairs["Missing"] = false;
            }
        }

        partial void UntaggedButtonCheck(Foundation.NSObject sender)
        {
            if (UntaggedButton.State == NSCellStateValue.On)
            {
                optionsPairs["Untagged"] = true;
            }
            else
            {
                optionsPairs["Untagged"] = false;
            }
        }

        partial void UnanalyzedButtonCheck(Foundation.NSObject sender)
        {
            if (UnanalyzedButton.State == NSCellStateValue.On)
            {
                optionsPairs["Unanalyzed"] = true;
            }
            else
            {
                optionsPairs["Unanalyzed"] = false;
            }
        }

        partial void UnreferencedButtonCheck(Foundation.NSObject sender)
        {
            if (UnreferencedButton.State == NSCellStateValue.On)
            {
                optionsPairs["Unreferenced"] = true;
            }
            else
            {
                optionsPairs["Unreferenced"] = false;
            }
        }
        
        partial void RadioButtonsCheck(Foundation.NSObject sender)
        {
            var check = sender as NSButton;
        }
        
        partial void ExecuteButtonCheck(Foundation.NSObject sender)
        {
            ProcessLog.StringValue = "";
            int optionsCount = 0;
            foreach (KeyValuePair<string, bool> element in optionsPairs)
            {

                if (element.Value == true)
                {
                    ProcessLog.StringValue += element.Key + "\n";
                }
                else
                {
                    optionsCount++;
                }
            }
            if (optionsCount == optionsPairs.Count)
            {
                ProcessLog.StringValue = "No options selected";
            }
        }
    }
}
