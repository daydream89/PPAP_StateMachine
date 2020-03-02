namespace PPAP_SEVER
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grdDB = new DevExpress.XtraGrid.GridControl();
            this.grvDB = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DB Connect";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // grdDB
            // 
            this.grdDB.Location = new System.Drawing.Point(58, 201);
            this.grdDB.MainView = this.grvDB;
            this.grdDB.Name = "grdDB";
            this.grdDB.Size = new System.Drawing.Size(400, 200);
            this.grdDB.TabIndex = 0;
            this.grdDB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDB});
            // 
            // grvDB
            // 
            this.grvDB.GridControl = this.grdDB;
            this.grvDB.Name = "grvDB";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 465);
            this.Controls.Add(this.grdDB);
            this.Name = "FrmMain";
            this.Text = "PPAP_SEVER";
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraGrid.GridControl grdDB;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDB;
    }
}

