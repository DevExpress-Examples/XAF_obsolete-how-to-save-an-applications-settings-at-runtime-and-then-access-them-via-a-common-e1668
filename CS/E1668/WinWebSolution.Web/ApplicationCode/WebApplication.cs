using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;

namespace WinWebSolution.Web {
    public partial class WinWebSolutionAspNetApplication : WebApplication {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private WinWebSolution.Module.WinWebSolutionModule module3;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
        private DevExpress.ExpressApp.Validation.ValidationModule module5;

        public WinWebSolutionAspNetApplication() {
            InitializeComponent();
        }

        private void WinWebSolutionAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new WinWebSolution.Module.WinWebSolutionModule();
            this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // module5
            // 
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleSetValidationResult));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleSetValidationResultItem));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RulePropertyValueProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleRequiredFieldProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleRangeProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleValueComparisonProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleStringComparisonProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleRegularExpressionProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleCriteriaProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleSearchObjectProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleObjectExistsProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleUniqueValueProperties));
            this.module5.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.Validation.RuleIsReferencedProperties));
            // 
            // WinWebSolutionAspNetApplication
            // 
            this.ApplicationName = "WinWebSolution";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module6);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module5);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.WinWebSolutionAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
