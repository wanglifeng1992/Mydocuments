using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace RichTextBoxExtended
{
   	#region StampActions
	public enum StampActions
	{
		EditedBy = 1,
		DateTime = 2,
		Custom = 4
	}
	#endregion

	/// <summary>
	/// An extended RichTextBox that contains a toolbar.
	/// </summary>
	public class RichTextBoxExtended : System.Windows.Forms.UserControl
	{
		//Used for looping
		private RichTextBox rtbTemp = new RichTextBox();

		#region Windows Generated
		private System.Windows.Forms.ToolBar tb1;
		private System.Windows.Forms.RichTextBox rtb1;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.ToolBarButton tbbBold;
		private System.Windows.Forms.ToolBarButton tbbItalic;
		private System.Windows.Forms.ToolBarButton tbbUnderline;
		private System.Windows.Forms.ToolBarButton tbbCenter;
		private System.Windows.Forms.ToolBarButton tbbRight;
		private System.Windows.Forms.ToolBarButton tbbStrikeout;
		private System.Windows.Forms.ToolBarButton tbbColor;
		private System.Windows.Forms.ContextMenu cmColors;
		private System.Windows.Forms.MenuItem miBlack;
		private System.Windows.Forms.MenuItem miBlue;
		private System.Windows.Forms.MenuItem miRed;
		private System.Windows.Forms.MenuItem miGreen;
		private System.Windows.Forms.ToolBarButton tbbStamp;
		private System.Windows.Forms.ToolBarButton tbbOpen;
		private System.Windows.Forms.ToolBarButton tbbSave;
		private System.Windows.Forms.ToolBarButton tbbUndo;
		private System.Windows.Forms.ToolBarButton tbbRedo;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.ToolBarButton tbbLeft;
		private System.Windows.Forms.OpenFileDialog ofd1;
		private System.Windows.Forms.SaveFileDialog sfd1;
		private System.Windows.Forms.ContextMenu cmFonts;
		private System.Windows.Forms.MenuItem miArial;
		private System.Windows.Forms.MenuItem miGaramond;
		private System.Windows.Forms.MenuItem miTahoma;
		private System.Windows.Forms.MenuItem miTimesNewRoman;
		private System.Windows.Forms.MenuItem miVerdana;
		private System.Windows.Forms.ToolBarButton tbbFont;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.MenuItem miCourierNew;
		private System.Windows.Forms.MenuItem miMicrosoftSansSerif;
		private System.Windows.Forms.ContextMenu cmFontSizes;
		private System.Windows.Forms.MenuItem mi8;
		private System.Windows.Forms.MenuItem mi9;
		private System.Windows.Forms.MenuItem mi10;
		private System.Windows.Forms.MenuItem mi11;
		private System.Windows.Forms.MenuItem mi12;
		private System.Windows.Forms.MenuItem mi14;
		private System.Windows.Forms.MenuItem mi16;
		private System.Windows.Forms.MenuItem mi18;
		private System.Windows.Forms.MenuItem mi20;
		private System.Windows.Forms.MenuItem mi22;
		private System.Windows.Forms.MenuItem mi24;
		private System.Windows.Forms.MenuItem mi26;
		private System.Windows.Forms.MenuItem mi28;
		private System.Windows.Forms.MenuItem mi36;
		private System.Windows.Forms.MenuItem mi48;
		private System.Windows.Forms.MenuItem mi72;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolBarButton tbbCut;
		private System.Windows.Forms.ToolBarButton tbbCopy;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.ColorDialog dlgColor;
		private System.Windows.Forms.FontDialog dlgFont;
		private System.Windows.Forms.ToolBarButton tbbBullet;
		private System.Windows.Forms.ToolBarButton tbbZoom;
		private System.Windows.Forms.ToolBarButton tbbShrink;
		private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private MenuItem miWhite;
        private MenuItem miYellow;
        private MenuItem miGray;
        private ToolBarButton tbbImage;
        private OpenFileDialog OpenFileDialog1;
		private System.Windows.Forms.ToolBarButton tbbPaste;

		public RichTextBoxExtended()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			//Update the graphics on the toolbar
			UpdateToolbar();

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichTextBoxExtended));
            this.tb1 = new System.Windows.Forms.ToolBar();
            this.tbbSave = new System.Windows.Forms.ToolBarButton();
            this.tbbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbFont = new System.Windows.Forms.ToolBarButton();
            this.tbbColor = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
            this.tbbBold = new System.Windows.Forms.ToolBarButton();
            this.tbbItalic = new System.Windows.Forms.ToolBarButton();
            this.tbbUnderline = new System.Windows.Forms.ToolBarButton();
            this.tbbStrikeout = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbLeft = new System.Windows.Forms.ToolBarButton();
            this.tbbCenter = new System.Windows.Forms.ToolBarButton();
            this.tbbRight = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbUndo = new System.Windows.Forms.ToolBarButton();
            this.tbbRedo = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
            this.tbbCut = new System.Windows.Forms.ToolBarButton();
            this.tbbCopy = new System.Windows.Forms.ToolBarButton();
            this.tbbPaste = new System.Windows.Forms.ToolBarButton();
            this.tbbStamp = new System.Windows.Forms.ToolBarButton();
            this.tbbBullet = new System.Windows.Forms.ToolBarButton();
            this.tbbZoom = new System.Windows.Forms.ToolBarButton();
            this.tbbShrink = new System.Windows.Forms.ToolBarButton();
            this.tbbImage = new System.Windows.Forms.ToolBarButton();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmFontSizes = new System.Windows.Forms.ContextMenu();
            this.mi8 = new System.Windows.Forms.MenuItem();
            this.mi9 = new System.Windows.Forms.MenuItem();
            this.mi10 = new System.Windows.Forms.MenuItem();
            this.mi11 = new System.Windows.Forms.MenuItem();
            this.mi12 = new System.Windows.Forms.MenuItem();
            this.mi14 = new System.Windows.Forms.MenuItem();
            this.mi16 = new System.Windows.Forms.MenuItem();
            this.mi18 = new System.Windows.Forms.MenuItem();
            this.mi20 = new System.Windows.Forms.MenuItem();
            this.mi22 = new System.Windows.Forms.MenuItem();
            this.mi24 = new System.Windows.Forms.MenuItem();
            this.mi26 = new System.Windows.Forms.MenuItem();
            this.mi28 = new System.Windows.Forms.MenuItem();
            this.mi36 = new System.Windows.Forms.MenuItem();
            this.mi48 = new System.Windows.Forms.MenuItem();
            this.mi72 = new System.Windows.Forms.MenuItem();
            this.cmFonts = new System.Windows.Forms.ContextMenu();
            this.miArial = new System.Windows.Forms.MenuItem();
            this.miCourierNew = new System.Windows.Forms.MenuItem();
            this.miGaramond = new System.Windows.Forms.MenuItem();
            this.miMicrosoftSansSerif = new System.Windows.Forms.MenuItem();
            this.miTahoma = new System.Windows.Forms.MenuItem();
            this.miTimesNewRoman = new System.Windows.Forms.MenuItem();
            this.miVerdana = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.cmColors = new System.Windows.Forms.ContextMenu();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.miBlack = new System.Windows.Forms.MenuItem();
            this.miBlue = new System.Windows.Forms.MenuItem();
            this.miRed = new System.Windows.Forms.MenuItem();
            this.miGreen = new System.Windows.Forms.MenuItem();
            this.miWhite = new System.Windows.Forms.MenuItem();
            this.miYellow = new System.Windows.Forms.MenuItem();
            this.miGray = new System.Windows.Forms.MenuItem();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tb1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbSave,
            this.tbbOpen,
            this.tbbSeparator3,
            this.tbbFont,
            this.tbbColor,
            this.tbbSeparator5,
            this.tbbBold,
            this.tbbItalic,
            this.tbbUnderline,
            this.tbbStrikeout,
            this.tbbSeparator1,
            this.tbbLeft,
            this.tbbCenter,
            this.tbbRight,
            this.tbbSeparator2,
            this.tbbUndo,
            this.tbbRedo,
            this.tbbSeparator4,
            this.tbbCut,
            this.tbbCopy,
            this.tbbPaste,
            this.tbbStamp,
            this.tbbBullet,
            this.tbbZoom,
            this.tbbShrink,
            this.tbbImage});
            this.tb1.ButtonSize = new System.Drawing.Size(16, 16);
            this.tb1.Divider = false;
            this.tb1.DropDownArrows = true;
            this.tb1.ImageList = this.imgList1;
            this.tb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.ShowToolTips = true;
            this.tb1.Size = new System.Drawing.Size(502, 26);
            this.tb1.TabIndex = 0;
            this.tb1.Tag = "image";
            this.tb1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tb1_ButtonClick);
            // 
            // tbbSave
            // 
            this.tbbSave.ImageIndex = 11;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.Tag = "save";
            // 
            // tbbOpen
            // 
            this.tbbOpen.ImageIndex = 10;
            this.tbbOpen.Name = "tbbOpen";
            this.tbbOpen.Tag = "open";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbFont
            // 
            this.tbbFont.ImageIndex = 14;
            this.tbbFont.Name = "tbbFont";
            this.tbbFont.Tag = "font";
            // 
            // tbbColor
            // 
            this.tbbColor.ImageIndex = 7;
            this.tbbColor.Name = "tbbColor";
            this.tbbColor.Tag = "color";
            // 
            // tbbSeparator5
            // 
            this.tbbSeparator5.Name = "tbbSeparator5";
            this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbBold
            // 
            this.tbbBold.ImageIndex = 0;
            this.tbbBold.Name = "tbbBold";
            this.tbbBold.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbBold.Tag = "bold";
            // 
            // tbbItalic
            // 
            this.tbbItalic.ImageIndex = 1;
            this.tbbItalic.Name = "tbbItalic";
            this.tbbItalic.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbItalic.Tag = "italic";
            // 
            // tbbUnderline
            // 
            this.tbbUnderline.ImageIndex = 2;
            this.tbbUnderline.Name = "tbbUnderline";
            this.tbbUnderline.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbUnderline.Tag = "underline";
            // 
            // tbbStrikeout
            // 
            this.tbbStrikeout.ImageIndex = 3;
            this.tbbStrikeout.Name = "tbbStrikeout";
            this.tbbStrikeout.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbStrikeout.Tag = "strikeout";
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbLeft
            // 
            this.tbbLeft.ImageIndex = 4;
            this.tbbLeft.Name = "tbbLeft";
            this.tbbLeft.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbLeft.Tag = "left";
            // 
            // tbbCenter
            // 
            this.tbbCenter.ImageIndex = 5;
            this.tbbCenter.Name = "tbbCenter";
            this.tbbCenter.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbCenter.Tag = "center";
            // 
            // tbbRight
            // 
            this.tbbRight.ImageIndex = 6;
            this.tbbRight.Name = "tbbRight";
            this.tbbRight.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbRight.Tag = "right";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbUndo
            // 
            this.tbbUndo.ImageIndex = 12;
            this.tbbUndo.Name = "tbbUndo";
            this.tbbUndo.Tag = "undo";
            // 
            // tbbRedo
            // 
            this.tbbRedo.ImageIndex = 13;
            this.tbbRedo.Name = "tbbRedo";
            this.tbbRedo.Tag = "redo";
            // 
            // tbbSeparator4
            // 
            this.tbbSeparator4.Name = "tbbSeparator4";
            this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCut
            // 
            this.tbbCut.ImageIndex = 17;
            this.tbbCut.Name = "tbbCut";
            this.tbbCut.Tag = "cut";
            // 
            // tbbCopy
            // 
            this.tbbCopy.ImageIndex = 18;
            this.tbbCopy.Name = "tbbCopy";
            this.tbbCopy.Tag = "copy";
            // 
            // tbbPaste
            // 
            this.tbbPaste.ImageIndex = 19;
            this.tbbPaste.Name = "tbbPaste";
            this.tbbPaste.Tag = "paste";
            // 
            // tbbStamp
            // 
            this.tbbStamp.ImageIndex = 8;
            this.tbbStamp.Name = "tbbStamp";
            this.tbbStamp.Tag = "edit stamp";
            // 
            // tbbBullet
            // 
            this.tbbBullet.ImageIndex = 21;
            this.tbbBullet.Name = "tbbBullet";
            this.tbbBullet.Tag = "bullet";
            // 
            // tbbZoom
            // 
            this.tbbZoom.ImageIndex = 23;
            this.tbbZoom.Name = "tbbZoom";
            this.tbbZoom.Tag = "zoom";
            this.tbbZoom.Visible = false;
            // 
            // tbbShrink
            // 
            this.tbbShrink.ImageIndex = 24;
            this.tbbShrink.Name = "tbbShrink";
            this.tbbShrink.Tag = "shrink";
            this.tbbShrink.Visible = false;
            // 
            // tbbImage
            // 
            this.tbbImage.ImageIndex = 16;
            this.tbbImage.Name = "tbbImage";
            this.tbbImage.Tag = "image";
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "");
            this.imgList1.Images.SetKeyName(1, "");
            this.imgList1.Images.SetKeyName(2, "");
            this.imgList1.Images.SetKeyName(3, "");
            this.imgList1.Images.SetKeyName(4, "");
            this.imgList1.Images.SetKeyName(5, "");
            this.imgList1.Images.SetKeyName(6, "");
            this.imgList1.Images.SetKeyName(7, "");
            this.imgList1.Images.SetKeyName(8, "");
            this.imgList1.Images.SetKeyName(9, "");
            this.imgList1.Images.SetKeyName(10, "");
            this.imgList1.Images.SetKeyName(11, "");
            this.imgList1.Images.SetKeyName(12, "");
            this.imgList1.Images.SetKeyName(13, "");
            this.imgList1.Images.SetKeyName(14, "");
            this.imgList1.Images.SetKeyName(15, "");
            this.imgList1.Images.SetKeyName(16, "");
            this.imgList1.Images.SetKeyName(17, "");
            this.imgList1.Images.SetKeyName(18, "");
            this.imgList1.Images.SetKeyName(19, "");
            this.imgList1.Images.SetKeyName(20, "");
            this.imgList1.Images.SetKeyName(21, "");
            this.imgList1.Images.SetKeyName(22, "");
            this.imgList1.Images.SetKeyName(23, "");
            // 
            // cmFontSizes
            // 
            this.cmFontSizes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi8,
            this.mi9,
            this.mi10,
            this.mi11,
            this.mi12,
            this.mi14,
            this.mi16,
            this.mi18,
            this.mi20,
            this.mi22,
            this.mi24,
            this.mi26,
            this.mi28,
            this.mi36,
            this.mi48,
            this.mi72});
            // 
            // mi8
            // 
            this.mi8.Index = 0;
            this.mi8.Text = "8";
            this.mi8.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi9
            // 
            this.mi9.Index = 1;
            this.mi9.Text = "9";
            this.mi9.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi10
            // 
            this.mi10.Index = 2;
            this.mi10.Text = "10";
            this.mi10.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi11
            // 
            this.mi11.Index = 3;
            this.mi11.Text = "11";
            this.mi11.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi12
            // 
            this.mi12.Index = 4;
            this.mi12.Text = "12";
            this.mi12.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi14
            // 
            this.mi14.Index = 5;
            this.mi14.Text = "14";
            this.mi14.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi16
            // 
            this.mi16.Index = 6;
            this.mi16.Text = "16";
            this.mi16.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi18
            // 
            this.mi18.Index = 7;
            this.mi18.Text = "18";
            this.mi18.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi20
            // 
            this.mi20.Index = 8;
            this.mi20.Text = "20";
            this.mi20.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi22
            // 
            this.mi22.Index = 9;
            this.mi22.Text = "22";
            this.mi22.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi24
            // 
            this.mi24.Index = 10;
            this.mi24.Text = "24";
            this.mi24.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi26
            // 
            this.mi26.Index = 11;
            this.mi26.Text = "26";
            this.mi26.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi28
            // 
            this.mi28.Index = 12;
            this.mi28.Text = "28";
            this.mi28.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi36
            // 
            this.mi36.Index = 13;
            this.mi36.Text = "36";
            this.mi36.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi48
            // 
            this.mi48.Index = 14;
            this.mi48.Text = "48";
            this.mi48.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi72
            // 
            this.mi72.Index = 15;
            this.mi72.Text = "72";
            this.mi72.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // cmFonts
            // 
            this.cmFonts.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miArial,
            this.miCourierNew,
            this.miGaramond,
            this.miMicrosoftSansSerif,
            this.miTahoma,
            this.miTimesNewRoman,
            this.miVerdana,
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6});
            // 
            // miArial
            // 
            this.miArial.Checked = true;
            this.miArial.Index = 0;
            this.miArial.Text = "Arial";
            this.miArial.Click += new System.EventHandler(this.Font_Click);
            // 
            // miCourierNew
            // 
            this.miCourierNew.Index = 1;
            this.miCourierNew.Text = "Courier New";
            this.miCourierNew.Click += new System.EventHandler(this.Font_Click);
            // 
            // miGaramond
            // 
            this.miGaramond.Index = 2;
            this.miGaramond.Text = "Garamond";
            this.miGaramond.Click += new System.EventHandler(this.Font_Click);
            // 
            // miMicrosoftSansSerif
            // 
            this.miMicrosoftSansSerif.Index = 3;
            this.miMicrosoftSansSerif.Text = "Microsoft Sans Serif";
            this.miMicrosoftSansSerif.Click += new System.EventHandler(this.Font_Click);
            // 
            // miTahoma
            // 
            this.miTahoma.Index = 4;
            this.miTahoma.Text = "Tahoma";
            this.miTahoma.Click += new System.EventHandler(this.Font_Click);
            // 
            // miTimesNewRoman
            // 
            this.miTimesNewRoman.Index = 5;
            this.miTimesNewRoman.Text = "Times New Roman";
            this.miTimesNewRoman.Click += new System.EventHandler(this.Font_Click);
            // 
            // miVerdana
            // 
            this.miVerdana.Index = 6;
            this.miVerdana.Text = "Verdana";
            this.miVerdana.Click += new System.EventHandler(this.Font_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 7;
            this.menuItem1.Text = "宋体";
            this.menuItem1.Click += new System.EventHandler(this.Font_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 8;
            this.menuItem2.Text = "黑体";
            this.menuItem2.Click += new System.EventHandler(this.Font_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 9;
            this.menuItem3.Text = "楷体";
            this.menuItem3.Click += new System.EventHandler(this.Font_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 10;
            this.menuItem4.Text = "仿宋";
            this.menuItem4.Click += new System.EventHandler(this.Font_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 11;
            this.menuItem5.Text = "隶书";
            this.menuItem5.Click += new System.EventHandler(this.Font_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 12;
            this.menuItem6.Text = "幼圆";
            this.menuItem6.Click += new System.EventHandler(this.Font_Click);
            // 
            // cmColors
            // 
            this.cmColors.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.miBlack,
            this.miBlue,
            this.miRed,
            this.miGreen,
            this.miWhite,
            this.miYellow,
            this.miGray});
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "[荧光笔选择]";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "-";
            // 
            // miBlack
            // 
            this.miBlack.Index = 2;
            this.miBlack.Text = "黑色";
            this.miBlack.Click += new System.EventHandler(this.Color_Click);
            // 
            // miBlue
            // 
            this.miBlue.Index = 3;
            this.miBlue.Text = "蓝色";
            this.miBlue.Click += new System.EventHandler(this.Color_Click);
            // 
            // miRed
            // 
            this.miRed.Index = 4;
            this.miRed.Text = "红色";
            this.miRed.Click += new System.EventHandler(this.Color_Click);
            // 
            // miGreen
            // 
            this.miGreen.Index = 5;
            this.miGreen.Text = "绿色";
            this.miGreen.Click += new System.EventHandler(this.Color_Click);
            // 
            // miWhite
            // 
            this.miWhite.Index = 6;
            this.miWhite.Text = "白色";
            this.miWhite.Click += new System.EventHandler(this.Color_Click);
            // 
            // miYellow
            // 
            this.miYellow.Index = 7;
            this.miYellow.Text = "黄色";
            this.miYellow.Click += new System.EventHandler(this.Color_Click);
            // 
            // miGray
            // 
            this.miGray.Index = 8;
            this.miGray.Text = "灰色";
            this.miGray.Click += new System.EventHandler(this.Color_Click);
            // 
            // rtb1
            // 
            this.rtb1.AcceptsTab = true;
            this.rtb1.AutoWordSelection = true;
            this.rtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb1.ContextMenu = this.cmColors;
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtb1.Location = new System.Drawing.Point(0, 26);
            this.rtb1.Name = "rtb1";
            this.rtb1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtb1.Size = new System.Drawing.Size(502, 196);
            this.rtb1.TabIndex = 1;
            this.rtb1.Text = "";
            this.rtb1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb1_LinkClicked);
            this.rtb1.SelectionChanged += new System.EventHandler(this.rtb1_SelectionChanged);
            // 
            // ofd1
            // 
            this.ofd1.DefaultExt = "rtf";
            this.ofd1.Filter = "Rich Text Files|*.rtf|Plain Text File|*.txt";
            this.ofd1.Title = "Open File";
            // 
            // sfd1
            // 
            this.sfd1.DefaultExt = "rtf";
            this.sfd1.Filter = "Rich Text File|*.rtf|Plain Text File|*.txt";
            this.sfd1.Title = "Save As";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // RichTextBoxExtended
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.tb1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "RichTextBoxExtended";
            this.Size = new System.Drawing.Size(502, 222);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Selection Change event	
		[Description("Occurs when the selection is changed"),
		Category("Behavior")]
		// Raised in tb1 SelectionChanged event so that user can do useful things
		public event System.EventHandler SelChanged;
		#endregion

		#region Stamp Event Stuff
		[Description("Occurs when the stamp button is clicked"), 
		 Category("Behavior")]
		public event System.EventHandler Stamp;
        
		/// <summary>
		/// OnStamp event
		/// </summary>
		protected virtual void OnStamp(EventArgs e)
		{
			if(Stamp != null)
				Stamp(this, e);

			switch(StampAction)
			{
				case StampActions.EditedBy:
				{
					StringBuilder stamp = new StringBuilder(""); //holds our stamp text
					if(rtb1.Text.Length > 0) stamp.Append("\r\n\r\n"); //add two lines for space
					stamp.Append("作者： "); 
					//use the CurrentPrincipal name if one exsist else use windows logon username
					if(Thread.CurrentPrincipal == null || Thread.CurrentPrincipal.Identity == null || Thread.CurrentPrincipal.Identity.Name.Length <= 0)
						stamp.Append(Environment.UserName);
					else
						stamp.Append(Thread.CurrentPrincipal.Identity.Name);
					stamp.Append(" 日期： " + DateTime.Now.ToLongDateString() + "\r\n");
			
					rtb1.SelectionLength = 0; //unselect everything basicly
					rtb1.SelectionStart = rtb1.Text.Length; //start new selection at the end of the text
					rtb1.SelectionColor = this.StampColor; //make the selection blue
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, FontStyle.Bold); //set the selection font and style
					rtb1.AppendText(stamp.ToString()); //add the stamp to the richtextbox
					rtb1.Focus(); //set focus back on the richtextbox
				} break; //end edited by stamp
				case StampActions.DateTime:
				{
					StringBuilder stamp = new StringBuilder(""); //holds our stamp text
					if(rtb1.Text.Length > 0) stamp.Append("\r\n\r\n"); //add two lines for space
					stamp.Append(DateTime.Now.ToLongDateString() + "\r\n");
					rtb1.SelectionLength = 0; //unselect everything basicly
					rtb1.SelectionStart = rtb1.Text.Length; //start new selection at the end of the text
					rtb1.SelectionColor = this.StampColor; //make the selection blue
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, FontStyle.Bold); //set the selection font and style
					rtb1.AppendText(stamp.ToString()); //add the stamp to the richtextbox
					rtb1.Focus(); //set focus back on the richtextbox
				} break;
			} //end select
		}
		#endregion

		#region Toolbar button click
		/// <summary>
		///     Handler for the toolbar button click event
		/// </summary>
		private void tb1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//Switch based on the tooltip of the button pressed
			// true if style to be added
			// false to remove style
			bool add = e.Button.Pushed;	
					
			switch(e.Button.Tag.ToString().ToLower())
			{
				case "bold": 
					ChangeFontStyle(FontStyle.Bold,add);
					
					break;
				case "italic": 
					ChangeFontStyle(FontStyle.Italic,add);
					break;
				case "underline":
					ChangeFontStyle(FontStyle.Underline,add);
					break;
				case "strikeout":
					ChangeFontStyle(FontStyle.Strikeout,add);
					break;
				case "left":
					//change horizontal alignment to left
					rtb1.SelectionAlignment = HorizontalAlignment.Left;
					tbbCenter.Pushed = false;
					tbbRight.Pushed = false;
                    rtb1.SelectionIndent = 0;
					break;
				case "center":
					//change horizontal alignment to center
					tbbLeft.Pushed = false;
					rtb1.SelectionAlignment = HorizontalAlignment.Center;
					tbbRight.Pushed = false;
					break;
				case "right":
					//change horizontal alignment to right
					tbbLeft.Pushed = false;
					tbbCenter.Pushed = false;
					rtb1.SelectionAlignment = HorizontalAlignment.Right;
					break;
				case "edit stamp":
                    OnStamp(new EventArgs()); //send stamp event
					break;
				case "color":
					//rtb1.SelectionColor = Color.Black;
					
					this.dlgColor.ShowDialog(this);
					
					rtb1.SelectionColor=this.dlgColor.Color;
					break;
				case "font":
					this.dlgFont.ShowDialog(this);
					rtb1.SelectionFont=this.dlgFont.Font;
					break;
				case "bullet":
					rtb1.SelectionBullet=!this.rtb1.SelectionBullet;
					break;
				case "zoom":
					//rtb1.ZoomFactor=rtb1.ZoomFactor++;
					break;
				case "shrink":
					//rtb1.ZoomFactor =rtb1.ZoomFactor--;
					break;
				case "undo":
					rtb1.Undo();
					break;
				case "redo":
					rtb1.Redo();
					break;
				case "open":
					try
					{
						if (ofd1.ShowDialog() == DialogResult.OK && ofd1.FileName.Length > 0)
							if(System.IO.Path.GetExtension(ofd1.FileName).ToLower().Equals(".rtf")) 
								rtb1.LoadFile(ofd1.FileName, RichTextBoxStreamType.RichText);
							else
								rtb1.LoadFile(ofd1.FileName, RichTextBoxStreamType.PlainText);
					}
					catch (ArgumentException ae)
					{
						if(ae.Message == "无效文件格式.")
							MessageBox.Show("加载文件错误: " + ofd1.FileName);				
					}
					break;
				case "save":
					if(sfd1.ShowDialog() == DialogResult.OK && sfd1.FileName.Length > 0)
						if(System.IO.Path.GetExtension(sfd1.FileName).ToLower().Equals(".rtf"))
							rtb1.SaveFile(sfd1.FileName);
						else
							rtb1.SaveFile(sfd1.FileName, RichTextBoxStreamType.PlainText);
					break;
				case "cut":
				{
					if(rtb1.SelectedText.Length <= 0) break;
					rtb1.Cut();
					break;
				}
				case "copy":
				{
					if(rtb1.SelectedText.Length <= 0) break;
					rtb1.Copy();
					break;
				}
				case "paste":
				{
					try
					{
						rtb1.Paste();
					}
					catch
					{
						MessageBox.Show("Paste Failed");
					}
					break;
				}

            case "image":
                {
                    OpenFileDialog1.Title = "插入图像";
                    OpenFileDialog1.DefaultExt = "rtf";
                    OpenFileDialog1.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif";
                    OpenFileDialog1.FilterIndex = 1;
                    OpenFileDialog1.FileName = "*.*";

                    OpenFileDialog1.ShowDialog();

                    if ((OpenFileDialog1.FileName == ""))
                    {
                        return;
                    }

                    try
                    {
                        string strImagePath = OpenFileDialog1.FileName;
                        Image img;
                        img = Image.FromFile(strImagePath);
                        Clipboard.SetDataObject(img);
                        DataFormats.Format df;
                        df = DataFormats.GetFormat(DataFormats.Bitmap);
                        if (this.rtb1.CanPaste(df))
                        {
                            this.rtb1.Paste(df);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("无法识别的图形格式.", "插入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }

			} //end select
		}
		#endregion

		#region Update Toolbar
		/// <summary>
		///     Update the toolbar button statuses
		/// </summary>
		public void UpdateToolbar()
		{
			// Get the font, fontsize and style to apply to the toolbar buttons
			Font fnt = GetFontDetails();
			// Set font style buttons to the styles applying to the entire selection
			FontStyle style = fnt.Style;
			
			//Set all the style buttons using the gathered style
			tbbBold.Pushed		= fnt.Bold; //bold button
			tbbItalic.Pushed	= fnt.Italic; //italic button
			tbbUnderline.Pushed	= fnt.Underline; //underline button
			tbbStrikeout.Pushed	= fnt.Strikeout; //strikeout button
			tbbLeft.Pushed		= (rtb1.SelectionAlignment == HorizontalAlignment.Left); //justify left
			tbbCenter.Pushed	= (rtb1.SelectionAlignment == HorizontalAlignment.Center); //justify center
			tbbRight.Pushed		= (rtb1.SelectionAlignment == HorizontalAlignment.Right); //justify right
	
			//Check the correct color
			foreach(MenuItem mi in cmColors.MenuItems)
				mi.Checked = (rtb1.SelectionColor == Color.FromName(mi.Text));
			
			//Check the correct font
			foreach(MenuItem mi in cmFonts.MenuItems)
				mi.Checked = (fnt.FontFamily.Name == mi.Text);

			//Check the correct font size
			foreach(MenuItem mi in cmFontSizes.MenuItems)
				mi.Checked = ((int)fnt.SizeInPoints == float.Parse(mi.Text));
					
		}
		#endregion

		#region Update Toolbar Seperators
		private void UpdateToolbarSeperators()
		{
			//Save & Open
			if(!tbbSave.Visible && !tbbOpen.Visible) 
				tbbSeparator3.Visible = false;
			else
				tbbSeparator3.Visible = true;

			//Font & Font Size
			if(!tbbFont.Visible  && !tbbColor.Visible) 
				tbbSeparator5.Visible = false;
			else
				tbbSeparator5.Visible = true;

			//Bold, Italic, Underline, & Strikeout
			if(!tbbBold.Visible && !tbbItalic.Visible && !tbbUnderline.Visible && !tbbStrikeout.Visible)
				tbbSeparator1.Visible = false;
			else
				tbbSeparator1.Visible = true;

			//Left, Center, & Right
			if(!tbbLeft.Visible && !tbbCenter.Visible && !tbbRight.Visible)
				tbbSeparator2.Visible = false;
			else
				tbbSeparator2.Visible = true;

			//Undo & Redo
			if(!tbbUndo.Visible && !tbbRedo.Visible) 
				tbbSeparator4.Visible = false;
			else
				tbbSeparator4.Visible = true;
		}
#endregion

		#region RichTextBox Selection Change
		/// <summary>
		///		Change the toolbar buttons when new text is selected
		///		and raise event SelChanged
		/// </summary>
		private void rtb1_SelectionChanged(object sender, System.EventArgs e)
		{
			//Update the toolbar buttons
			UpdateToolbar();
			
			//Send the SelChangedEvent
			if (SelChanged != null)
				SelChanged(this, e);
		}
#endregion

		#region Color Click
		/// <summary>
		///     Change the richtextbox color
		/// </summary>
		private void Color_Click(object sender, System.EventArgs e)
		{
			//set the richtextbox color based on the name of the menu item
			string mc;
            string mf;

            //MessageBox.Show(this,((MenuItem)sender).Text );

			switch(((MenuItem)sender).Text)
			{
				case "黑色":
					mc="Black";
                    mf = "White";
					break;
				case "红色":
					mc="Red";
                    mf = "White";
					break;
				case "蓝色":
					mc="Blue";
                    mf = "White";
					break;
				case "绿色":
					mc="Green";
                    mf = "White";
					break;
                case "白色":
                    mc = "White";
                    mf = "Black";
                    break;
                case "黄色":
                    mc = "Yellow";
                    mf = "Black";
                    break;
                case "灰色":
                    mc = "LightGray";
                    mf = "Black";
                    break;
				default:
					mc =" ";
                    mf = " ";
					break;
			}

			ChangeFontColor(Color.FromName(mf),Color.FromName(mc));

		}
		#endregion

		#region Font Click
		/// <summary>
		///     Change the richtextbox font
		/// </summary>
		private void Font_Click(object sender, System.EventArgs e)
		{
			// Set the font for the entire selection
			MessageBox.Show(this,((MenuItem)sender).Text);
			ChangeFont(((MenuItem)sender).Text);
		}
		#endregion

		#region Font Size Click
		/// <summary>
		///     Change the richtextbox font size
		/// </summary>
		private void FontSize_Click(object sender, System.EventArgs e)
		{
			//set the richtextbox font size based on the name of the menu item
			ChangeFontSize(float.Parse(((MenuItem)sender).Text));
		}
		#endregion

		#region Link Clicked
		/// <summary>
		/// Starts the default browser if a link is clicked
		/// </summary>
		private void rtb1_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		#endregion

		#region Public Properties
		/// <summary>
		///     The toolbar that is contained with-in the RichTextBoxExtened control
		/// </summary>
		[Description("The internal toolbar control"),
		Category("Internal Controls")]
		public ToolBar Toolbar
		{
			get { return tb1; }
		}

		/// <summary>
		///     The RichTextBox that is contained with-in the RichTextBoxExtened control
		/// </summary>
		[Description("The internal richtextbox control"),
		Category("Internal Controls")]
		public RichTextBox RichTextBox
		{
			get	{ return rtb1; }
		}

		/// <summary>
		///     Show the save button or not
		/// </summary>
		[Description("Show the save button or not"),
		Category("Appearance")]
		public bool ShowSave
		{
			get { return tbbSave.Visible; }
			set { tbbSave.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///    Show the open button or not 
		/// </summary>
		[Description("Show the open button or not"),
		Category("Appearance")]
		public bool ShowOpen
		{
			get { return tbbOpen.Visible; }
			set	{ tbbOpen.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the stamp button or not
		/// </summary>
		[Description("Show the stamp button or not"),
		 Category("Appearance")]
		public bool ShowStamp
		{
			get { return tbbStamp.Visible; }
			set { tbbStamp.Visible = value; }
		}
		
		/// <summary>
		///     Show the color button or not
		/// </summary>
		[Description("Show the color button or not"),
		Category("Appearance")]
		public bool ShowColors
		{
			get { return tbbColor.Visible; }
			set { tbbColor.Visible = value; }
		}

		/// <summary>
		///     Show the undo button or not
		/// </summary>
		[Description("Show the undo button or not"),
		Category("Appearance")]
		public bool ShowUndo
		{
			get { return tbbUndo.Visible; }
			set { tbbUndo.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the redo button or not
		/// </summary>
		[Description("Show the redo button or not"),
		Category("Appearance")]
		public bool ShowRedo
		{
			get { return tbbRedo.Visible; }
			set { tbbRedo.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the bold button or not
		/// </summary>
		[Description("Show the bold button or not"),
		Category("Appearance")]
		public bool ShowBold
		{
			get { return tbbBold.Visible; }
			set { tbbBold.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the italic button or not
		/// </summary>
		[Description("Show the italic button or not"),
		Category("Appearance")]
		public bool ShowItalic
		{
			get { return tbbItalic.Visible; }
			set { tbbItalic.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the underline button or not
		/// </summary>
		[Description("Show the underline button or not"),
		Category("Appearance")]
		public bool ShowUnderline
		{
			get { return tbbUnderline.Visible; }
			set { tbbUnderline.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the strikeout button or not
		/// </summary>
		[Description("Show the strikeout button or not"),
		Category("Appearance")]
		public bool ShowStrikeout
		{
			get { return tbbStrikeout.Visible; }
			set { tbbStrikeout.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the left justify button or not
		/// </summary>
		[Description("Show the left justify button or not"),
		Category("Appearance")]
		public bool ShowLeftJustify
		{
			get { return tbbLeft.Visible; }
			set { tbbLeft.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the right justify button or not
		/// </summary>
		[Description("Show the right justify button or not"),
		Category("Appearance")]
		public bool ShowRightJustify
		{
			get { return tbbRight.Visible; }
			set { tbbRight.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the center justify button or not
		/// </summary>
		[Description("Show the center justify button or not"),
		Category("Appearance")]
		public bool ShowCenterJustify
		{
			get { return tbbCenter.Visible; }
			set { tbbCenter.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Determines how the stamp button will respond
		/// </summary>
		StampActions m_StampAction = StampActions.EditedBy;
		[Description("Determines how the stamp button will respond"),
		Category("Behavior")]
		public StampActions StampAction
		{
			get { return m_StampAction; }
			set { m_StampAction = value; }
		}
		
		/// <summary>
		///     Color of the stamp text
		/// </summary>
		Color m_StampColor = Color.Blue;

		[Description("Color of the stamp text"),
		Category("Appearance")]
		public Color StampColor
		{
			get { return m_StampColor; }
			set { m_StampColor = value; }
		}
			
		/// <summary>
		///     Show the font button or not
		/// </summary>
		[Description("Show the font button or not"),
		Category("Appearance")]
		public bool ShowFont
		{
			get { return tbbFont.Visible; }
			set { tbbFont.Visible = value; }
		}

		/// <summary>
		///     Show the font size button or not
		/// </summary>
		[Description("Show the font size button or not"),
		Category("Appearance")]
		public bool ShowBullet
		{
			get { return tbbBullet.Visible; }
			set { tbbBullet.Visible = value; }
		}

		/// <summary>
		///     Show the font size button or not
		/// </summary>
		[Description("Show the font size button or not"),
		Category("Appearance")]
		public bool ShowZoom
		{
			get { return tbbZoom.Visible; }
			set { tbbZoom.Visible = value; }
		}

		/// <summary>
		///     Show the font size button or not
		/// </summary>
		[Description("Show the font size button or not"),
		Category("Appearance")]
		public bool ShowShrink
		{
			get { return tbbShrink.Visible; }
			set { tbbShrink.Visible = value; }
		}
		/// <summary>
		///     Show the cut button or not
		/// </summary>
		[Description("Show the cut button or not"),
		Category("Appearance")]
		public bool ShowCut
		{
			get { return tbbCut.Visible; }
			set { tbbCut.Visible = value; }
		}

		/// <summary>
		///     Show the copy button or not
		/// </summary>
		[Description("Show the copy button or not"),
		Category("Appearance")]
		public bool ShowCopy
		{
			get { return tbbCopy.Visible; }
			set { tbbCopy.Visible = value; }
		}

		/// <summary>
		///     Show the paste button or not
		/// </summary>
		[Description("Show the paste button or not"),
		Category("Appearance")]
		public bool ShowPaste
		{
			get { return tbbPaste.Visible; }
			set { tbbPaste.Visible = value; }
		}

		/// <summary>
		///     Detect URLs with-in the richtextbox
		/// </summary>
		[Description("Detect URLs with-in the richtextbox"),
		Category("Behavior")]
		public bool DetectURLs
		{
			get { return rtb1.DetectUrls; }
			set { rtb1.DetectUrls = value; }
		}

		/// <summary>
		/// Determines if the TAB key moves to the next control or enters a TAB character in the richtextbox
		/// </summary>
		[Description("Determines if the TAB key moves to the next control or enters a TAB character in the richtextbox"),
		Category("Behavior")]
		public bool AcceptsTab
		{
			get { return rtb1.AcceptsTab; }
			set { rtb1.AcceptsTab = value; }
		}

		/// <summary>
		/// Determines if auto word selection is enabled
		/// </summary>
		[Description("Determines if auto word selection is enabled"),
		Category("Behavior")]
		public bool AutoWordSelection
		{
			get { return rtb1.AutoWordSelection; }
			set { rtb1.AutoWordSelection = value; }
		}
		#endregion

		#region Change font
		/// <summary>
		///     Change the richtextbox font for the current selection
		/// </summary>
		public void ChangeFont(string fontFamily)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			// fontFamily - the font to be applied, eg "Courier New"

			// Reason: The reason this method and the others exist is because
			// setting these items via the selection font doen't work because
			// a null selection font is returned for a selection with more 
			// than one font!
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;						

			// If len <= 1 and there is a selection font, amend and return
			if (len <= 1 && rtb1.SelectionFont != null)
			{
				rtb1.SelectionFont =
					new Font(fontFamily, rtb1.SelectionFont.Size, rtb1.SelectionFont.Style);
				return;
			}

			// Step through the selected text one char at a time
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 
				rtbTemp.SelectionFont = new Font(fontFamily, rtbTemp.SelectionFont.Size, rtbTemp.SelectionFont.Style);
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Change font style
		/// <summary>
		///     Change the richtextbox style for the current selection
		/// </summary>
		public void ChangeFontStyle(FontStyle style, bool add)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			//	style - eg FontStyle.Bold
			//	add - IF true then add else remove
			
			// throw error if style isn't: bold, italic, strikeout or underline
			if (   style != FontStyle.Bold
				&& style != FontStyle.Italic
				&& style != FontStyle.Strikeout
				&& style != FontStyle.Underline)
					throw new  System.InvalidProgramException("Invalid style parameter to ChangeFontStyle");
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;			
			
			//if len <= 1 and there is a selection font then just handle and return
			if(len <= 1 && rtb1.SelectionFont != null)
			{
				//add or remove style 
				if (add)
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style | style);
				else
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style & ~style);
				
				return;
			}
			
			// Step through the selected text one char at a time	
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 

				//add or remove style 
				if (add)
					rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont, rtbTemp.SelectionFont.Style | style);
				else
					rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont, rtbTemp.SelectionFont.Style & ~style);
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Change font size
		/// <summary>
		///     Change the richtextbox font size for the current selection
		/// </summary>
		public void ChangeFontSize(float fontSize)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			// fontSize - the fontsize to be applied, eg 33.5
			
			if (fontSize <= 0.0)
				throw new System.InvalidProgramException("Invalid font size parameter to ChangeFontSize");
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;

			// If len <= 1 and there is a selection font, amend and return
			if (len <= 1 && rtb1.SelectionFont != null)
			{
				rtb1.SelectionFont =
					new Font(rtb1.SelectionFont.FontFamily, fontSize, rtb1.SelectionFont.Style);
				return;
			}
			
			// Step through the selected text one char at a time
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 
				rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont.FontFamily, fontSize, rtbTemp.SelectionFont.Style);
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Change font color
		/// <summary>
		///     Change the richtextbox font color for the current selection
		/// </summary>
		public void ChangeFontColor(Color newFontColor,Color newColor)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			//	newColor - eg Color.Red

            

			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;			
			
			//if len <= 1 and there is a selection font then just handle and return
			if(len <= 1 && rtb1.SelectionFont != null)
			{

				rtb1.SelectionColor = newFontColor;
                rtb1.SelectionBackColor = newColor;
				return;
			}
			
			// Step through the selected text one char at a time	
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 

				//change color
				rtbTemp.SelectionColor = newFontColor ;
                rtbTemp.SelectionBackColor = newColor;
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Get Font Details
		/// <summary>
		///     Returns a Font with:
		///     1) The font applying to the entire selection, if none is the default font. 
		///     2) The font size applying to the entire selection, if none is the size of the default font.
		///     3) A style containing the attributes that are common to the entire selection, default regular.
		/// </summary>		
		/// 
		public Font GetFontDetails()
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;

			if (len <= 1)						
			{
				// Return the selection or default font
				if (rtb1.SelectionFont != null)
					return rtb1.SelectionFont;
				else
					return rtb1.Font;
			}

			// Step through the selected text one char at a time	
			// after setting defaults from first char
			rtbTemp.Rtf = rtb1.SelectedRtf;
		
			//Turn everything on so we can turn it off one by one
			FontStyle replystyle =			
				FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline;
			
			// Set reply font, size and style to that of first char in selection.
			rtbTemp.Select(rtbTempStart, 1);
			string replyfont = rtbTemp.SelectionFont.Name;
			float replyfontsize = rtbTemp.SelectionFont.Size;
			replystyle = replystyle & rtbTemp.SelectionFont.Style;
			
			// Search the rest of the selection
			for(int i = 1; i < len; ++i)				
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 
				
				// Check reply for different style

				if(rtbTemp.SelectionFont != null)
				{
					replystyle = replystyle & rtbTemp.SelectionFont.Style;
				
					// Check font
					if (replyfont != rtbTemp.SelectionFont.FontFamily.Name)
						replyfont = "";

					// Check font size
					if (replyfontsize != rtbTemp.SelectionFont.Size)
						replyfontsize = (float)0.0;
				}
			}

			// Now set font and size if more than one font or font size was selected
			if (replyfont == "")
				replyfont = rtbTemp.Font.FontFamily.Name;

			if (replyfontsize == 0.0)
				replyfontsize = rtbTemp.Font.Size;

			// generate reply font
			Font reply 
				= new Font(replyfont, replyfontsize, replystyle);
			
			return reply;
		}
		#endregion



	} //end class
} //end namespace

