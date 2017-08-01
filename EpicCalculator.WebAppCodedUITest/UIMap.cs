namespace EpicCalculator.WebAppCodedUITest
{
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// Method to open the EpicCalculator QA site
        /// </summary>
        public void OpenSite()
        {
            #region Variable Declarations
            WinComboBox uIOpenComboBox = this.UIRunWindow.UIItemWindow.UIOpenComboBox;
            WinEdit uIOpenEdit = this.UIRunWindow.UIItemWindow1.UIOpenEdit;
            HtmlHyperlink uIStandardCalculatorHyperlink = this.UIEpicCalculatorHomePaWindow.UIEpicCalculatorHomePaDocument.UIStandardCalculatorHyperlink;
            #endregion

            // Press keyboard shortcut keys 'Windows + r'
            Keyboard.SendKeys(this.OpenSiteParams.SendKeys, ModifierKeys.Windows);

            // Select 'iexplore http://devepiccalculator.azurewebsites.net/' in 'Open:' combo box
            uIOpenComboBox.EditableItem = this.OpenSiteParams.UIOpenComboBoxEditableItem;

            // Type '{Enter}' in 'Open:' text box
            Keyboard.SendKeys(uIOpenEdit, this.OpenSiteParams.UIOpenEditSendKeys, ModifierKeys.None);

            // Click 'Standard Calculator' link
            Mouse.Click(uIStandardCalculatorHyperlink, new Point(69, 28));
        }

        public virtual OpenSiteParams OpenSiteParams
        {
            get
            {
                if ((this.mOpenSiteParams == null))
                {
                    this.mOpenSiteParams = new OpenSiteParams();
                }
                return this.mOpenSiteParams;
            }
        }

        private OpenSiteParams mOpenSiteParams;
    }
    /// <summary>
    /// Parameters to be passed into 'OpenSite'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class OpenSiteParams
    {

        #region Fields
        /// <summary>
        /// Press keyboard shortcut keys 'Windows + r'
        /// </summary>
        public string SendKeys = "r";

        /// <summary>
        /// Select 'iexplore http://devepiccalculator.azurewebsites.net/' in 'Open:' combo box
        /// </summary>
        public string UIOpenComboBoxEditableItem = "iexplore http://devepiccalculator.azurewebsites.net/";

        /// <summary>
        /// Type '{Enter}' in 'Open:' text box
        /// </summary>
        public string UIOpenEditSendKeys = "{Enter}";
        #endregion
    }
}
