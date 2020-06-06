using System.Collections.Generic;

namespace ImageProcessingApp
{
    partial class MainForm
    {
        //private System.Windows.Forms.PictureBox picture;
        //private System.Windows.Forms.Button load;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        //private System.Windows.Forms.Button process;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemOpn = new System.Windows.Forms.MenuItem();
            this.Zapisz = new System.Windows.Forms.MenuItem();
            this.menuItemHisto = new System.Windows.Forms.MenuItem();
            this.menuItemTools = new System.Windows.Forms.MenuItem();
            this.menuItemOperPunktJedno = new System.Windows.Forms.MenuItem();
            this.Negacja = new System.Windows.Forms.MenuItem();
            this.Progowanie = new System.Windows.Forms.MenuItem();
            this.menuItemOperPunktDwu = new System.Windows.Forms.MenuItem();
            this.XOR = new System.Windows.Forms.MenuItem();
            this.OR = new System.Windows.Forms.MenuItem();
            this.AND = new System.Windows.Forms.MenuItem();
            this.Mieszanie = new System.Windows.Forms.MenuItem();
            this.OperacjeSasiedztwa = new System.Windows.Forms.MenuItem();
            this.Blur = new System.Windows.Forms.MenuItem();
            this.GaussianBlur = new System.Windows.Forms.MenuItem();
            this.Sobel = new System.Windows.Forms.MenuItem();
            this.Laplacian = new System.Windows.Forms.MenuItem();
            this.Canny = new System.Windows.Forms.MenuItem();
            this.Prewitt = new System.Windows.Forms.MenuItem();
            this.WyostrzanieLiniowe = new System.Windows.Forms.MenuItem();
            this.WLiniowePreset1 = new System.Windows.Forms.MenuItem();
            this.WLiniowePreset2 = new System.Windows.Forms.MenuItem();
            this.WLiniowePreset3 = new System.Windows.Forms.MenuItem();
            this.Filtracje = new System.Windows.Forms.MenuItem();
            this.FiltracjaJedno = new System.Windows.Forms.MenuItem();
            this.FiltracjaJednoIsolated = new System.Windows.Forms.MenuItem();
            this.FiltracjaJednoReflect = new System.Windows.Forms.MenuItem();
            this.FiltracjaJednoReplicate = new System.Windows.Forms.MenuItem();
            this.FiltracjaDwu = new System.Windows.Forms.MenuItem();
            this.FiltracjaDwuIsolated = new System.Windows.Forms.MenuItem();
            this.FiltracjaDwuReflect = new System.Windows.Forms.MenuItem();
            this.FiltracjaDwuReplicate = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.UniOperLiniowa = new System.Windows.Forms.MenuItem();
            this.Morfologia = new System.Windows.Forms.MenuItem();
            this.ElementCross = new System.Windows.Forms.MenuItem();
            this.Erozja = new System.Windows.Forms.MenuItem();
            this.ErozjaIsolated = new System.Windows.Forms.MenuItem();
            this.ErozjaReflect = new System.Windows.Forms.MenuItem();
            this.ErozjaReplicate = new System.Windows.Forms.MenuItem();
            this.Dylatacja = new System.Windows.Forms.MenuItem();
            this.DylatacjaIsolated = new System.Windows.Forms.MenuItem();
            this.DylatacjaReflect = new System.Windows.Forms.MenuItem();
            this.DylatacjaReplicate = new System.Windows.Forms.MenuItem();
            this.Otwarcie = new System.Windows.Forms.MenuItem();
            this.OtwarcieIsolated = new System.Windows.Forms.MenuItem();
            this.OtwarcieReflect = new System.Windows.Forms.MenuItem();
            this.OtwarcieReplicate = new System.Windows.Forms.MenuItem();
            this.Zamkniecie = new System.Windows.Forms.MenuItem();
            this.ZamkniecieIsolated = new System.Windows.Forms.MenuItem();
            this.ZamkniecieReflect = new System.Windows.Forms.MenuItem();
            this.ZamkniecieReplicate = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.ErozjaKwadrat = new System.Windows.Forms.MenuItem();
            this.ErozjaIsolatedKwadrat = new System.Windows.Forms.MenuItem();
            this.ErozjaReflectKwadrat = new System.Windows.Forms.MenuItem();
            this.ErozjaReplicateKwadrat = new System.Windows.Forms.MenuItem();
            this.DylatacjaKwadrat = new System.Windows.Forms.MenuItem();
            this.DylatacjaIsolatedKwadrat = new System.Windows.Forms.MenuItem();
            this.DylatacjaReflectKwadrat = new System.Windows.Forms.MenuItem();
            this.DylatacjaReplicateKwadrat = new System.Windows.Forms.MenuItem();
            this.OtwarcieKwadrat = new System.Windows.Forms.MenuItem();
            this.OtwarcieIsolatedKwadrat = new System.Windows.Forms.MenuItem();
            this.OtwarcieReflectKwadrat = new System.Windows.Forms.MenuItem();
            this.OtwarcieReplicateKwadrat = new System.Windows.Forms.MenuItem();
            this.ZamkniecieKwadrat = new System.Windows.Forms.MenuItem();
            this.ZamkniecieIsolatedKwadrat = new System.Windows.Forms.MenuItem();
            this.ZamkniecieReflectKwadrat = new System.Windows.Forms.MenuItem();
            this.ZamkniecieReplicateKwadrat = new System.Windows.Forms.MenuItem();
            this.Szkieletyzacja = new System.Windows.Forms.MenuItem();
            this.Segmentacja = new System.Windows.Forms.MenuItem();
            this.ProgAdaptacyjne = new System.Windows.Forms.MenuItem();
            this.ProgOtsu = new System.Windows.Forms.MenuItem();
            this.Wododzialowa = new System.Windows.Forms.MenuItem();
            this.AnalizaObrazu = new System.Windows.Forms.MenuItem();
            this.WyznaczanieSklad = new System.Windows.Forms.MenuItem();
            this.Momenty = new System.Windows.Forms.MenuItem();
            this.PowerzchniaObwod = new System.Windows.Forms.MenuItem();
            this.RysujKontury = new System.Windows.Forms.MenuItem();
            this.WspolKsztaltu = new System.Windows.Forms.MenuItem();
            this.Info = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemHistogram = new System.Windows.Forms.MenuItem();
            this.ButtonCloseTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(13, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 587);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.CloseButtonEventAdd);
            this.tabControl1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.CloseButtonEventRemove);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemHisto,
            this.menuItemTools,
            this.OperacjeSasiedztwa,
            this.Morfologia,
            this.Segmentacja,
            this.AnalizaObrazu,
            this.Info});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOpn,
            this.Zapisz});
            this.menuItemFile.Text = "Plik";
            // 
            // menuItemOpn
            // 
            this.menuItemOpn.Index = 0;
            this.menuItemOpn.Text = "Otwórz";
            this.menuItemOpn.Click += new System.EventHandler(this.menuItemOpn_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Enabled = false;
            this.Zapisz.Index = 1;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // menuItemHisto
            // 
            this.menuItemHisto.Enabled = false;
            this.menuItemHisto.Index = 1;
            this.menuItemHisto.Text = "Histogram";
            this.menuItemHisto.Click += new System.EventHandler(this.menuItemHisto_Click);
            // 
            // menuItemTools
            // 
            this.menuItemTools.Enabled = false;
            this.menuItemTools.Index = 2;
            this.menuItemTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOperPunktJedno,
            this.menuItemOperPunktDwu});
            this.menuItemTools.Text = "Operacje punktowe";
            // 
            // menuItemOperPunktJedno
            // 
            this.menuItemOperPunktJedno.Index = 0;
            this.menuItemOperPunktJedno.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Negacja,
            this.Progowanie});
            this.menuItemOperPunktJedno.Text = "Operacje punktowe jedonargumentowe";
            // 
            // Negacja
            // 
            this.Negacja.Index = 0;
            this.Negacja.Text = "Negacja";
            this.Negacja.Click += new System.EventHandler(this.Negacja_Click);
            // 
            // Progowanie
            // 
            this.Progowanie.Index = 1;
            this.Progowanie.Text = "Progowanie";
            this.Progowanie.Click += new System.EventHandler(this.Progowanie_Click);
            // 
            // menuItemOperPunktDwu
            // 
            this.menuItemOperPunktDwu.Index = 1;
            this.menuItemOperPunktDwu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.XOR,
            this.OR,
            this.AND,
            this.Mieszanie});
            this.menuItemOperPunktDwu.Text = "Operacje punktowe dwuargumentowe";
            // 
            // XOR
            // 
            this.XOR.Index = 0;
            this.XOR.Text = "XOR";
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // OR
            // 
            this.OR.Index = 1;
            this.OR.Text = "OR";
            this.OR.Click += new System.EventHandler(this.OR_Click);
            // 
            // AND
            // 
            this.AND.Index = 2;
            this.AND.Text = "AND";
            this.AND.Click += new System.EventHandler(this.AND_Click);
            // 
            // Mieszanie
            // 
            this.Mieszanie.Index = 3;
            this.Mieszanie.Text = "Mieszanie (blending)";
            this.Mieszanie.Click += new System.EventHandler(this.Mieszanie_Click);
            // 
            // OperacjeSasiedztwa
            // 
            this.OperacjeSasiedztwa.Enabled = false;
            this.OperacjeSasiedztwa.Index = 3;
            this.OperacjeSasiedztwa.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Blur,
            this.GaussianBlur,
            this.Sobel,
            this.Laplacian,
            this.Canny,
            this.Prewitt,
            this.WyostrzanieLiniowe,
            this.Filtracje,
            this.menuItem1,
            this.UniOperLiniowa});
            this.OperacjeSasiedztwa.Text = "Operacje sąsiedztwa";
            // 
            // Blur
            // 
            this.Blur.Index = 0;
            this.Blur.Text = "Blur";
            this.Blur.Click += new System.EventHandler(this.Blur_Click);
            // 
            // GaussianBlur
            // 
            this.GaussianBlur.Index = 1;
            this.GaussianBlur.Text = "\r\nRozmycie gaussowskie";
            this.GaussianBlur.Click += new System.EventHandler(this.GaussianBlur_Click);
            // 
            // Sobel
            // 
            this.Sobel.Index = 2;
            this.Sobel.Text = "Sobel";
            this.Sobel.Click += new System.EventHandler(this.Sobel_Click);
            // 
            // Laplacian
            // 
            this.Laplacian.Index = 3;
            this.Laplacian.Text = "Laplacian";
            this.Laplacian.Click += new System.EventHandler(this.Laplacian_Click);
            // 
            // Canny
            // 
            this.Canny.Index = 4;
            this.Canny.Text = "Canny";
            this.Canny.Click += new System.EventHandler(this.Canny_Click);
            // 
            // Prewitt
            // 
            this.Prewitt.Index = 5;
            this.Prewitt.Text = "Prewitt";
            this.Prewitt.Click += new System.EventHandler(this.Prewitt_Click);
            // 
            // WyostrzanieLiniowe
            // 
            this.WyostrzanieLiniowe.Index = 6;
            this.WyostrzanieLiniowe.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WLiniowePreset1,
            this.WLiniowePreset2,
            this.WLiniowePreset3});
            this.WyostrzanieLiniowe.Text = "Wyostrzanie liniowe";
            // 
            // WLiniowePreset1
            // 
            this.WLiniowePreset1.Index = 0;
            this.WLiniowePreset1.Text = "Preset 1";
            this.WLiniowePreset1.Click += new System.EventHandler(this.WLiniowePreset1_Click);
            // 
            // WLiniowePreset2
            // 
            this.WLiniowePreset2.Index = 1;
            this.WLiniowePreset2.Text = "Preset 2";
            this.WLiniowePreset2.Click += new System.EventHandler(this.WLiniowePreset2_Click);
            // 
            // WLiniowePreset3
            // 
            this.WLiniowePreset3.Index = 2;
            this.WLiniowePreset3.Text = "Preset 3";
            this.WLiniowePreset3.Click += new System.EventHandler(this.WLiniowePreset3_Click);
            // 
            // Filtracje
            // 
            this.Filtracje.Index = 7;
            this.Filtracje.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FiltracjaJedno,
            this.FiltracjaDwu});
            this.Filtracje.Text = "Filtracje";
            // 
            // FiltracjaJedno
            // 
            this.FiltracjaJedno.Index = 0;
            this.FiltracjaJedno.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FiltracjaJednoIsolated,
            this.FiltracjaJednoReflect,
            this.FiltracjaJednoReplicate});
            this.FiltracjaJedno.Text = "Filtracja jednoetapowa (5x5)";
            // 
            // FiltracjaJednoIsolated
            // 
            this.FiltracjaJednoIsolated.Index = 0;
            this.FiltracjaJednoIsolated.Text = "Isolated";
            this.FiltracjaJednoIsolated.Click += new System.EventHandler(this.FiltracjaJednoIsolated_Click);
            // 
            // FiltracjaJednoReflect
            // 
            this.FiltracjaJednoReflect.Index = 1;
            this.FiltracjaJednoReflect.Text = "Reflect";
            this.FiltracjaJednoReflect.Click += new System.EventHandler(this.FiltracjaJednoReflect_Click);
            // 
            // FiltracjaJednoReplicate
            // 
            this.FiltracjaJednoReplicate.Index = 2;
            this.FiltracjaJednoReplicate.Text = "Replicate";
            this.FiltracjaJednoReplicate.Click += new System.EventHandler(this.FiltracjaJednoReplicate_Click);
            // 
            // FiltracjaDwu
            // 
            this.FiltracjaDwu.Index = 1;
            this.FiltracjaDwu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FiltracjaDwuIsolated,
            this.FiltracjaDwuReflect,
            this.FiltracjaDwuReplicate});
            this.FiltracjaDwu.Text = "Filtracja dwuetapowa - maski (3x3)";
            // 
            // FiltracjaDwuIsolated
            // 
            this.FiltracjaDwuIsolated.Index = 0;
            this.FiltracjaDwuIsolated.Text = "Isolated";
            this.FiltracjaDwuIsolated.Click += new System.EventHandler(this.FiltracjaDwuIsolated_Click);
            // 
            // FiltracjaDwuReflect
            // 
            this.FiltracjaDwuReflect.Index = 1;
            this.FiltracjaDwuReflect.Text = "Reflect";
            this.FiltracjaDwuReflect.Click += new System.EventHandler(this.FiltracjaDwuReflect_Click);
            // 
            // FiltracjaDwuReplicate
            // 
            this.FiltracjaDwuReplicate.Index = 2;
            this.FiltracjaDwuReplicate.Text = "Replicate";
            this.FiltracjaDwuReplicate.Click += new System.EventHandler(this.FiltracjaDwuReplicate_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 8;
            this.menuItem1.Text = "Operacje medianowe";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // UniOperLiniowa
            // 
            this.UniOperLiniowa.Index = 9;
            this.UniOperLiniowa.Text = "Uniwersalna operacja lniowa";
            this.UniOperLiniowa.Click += new System.EventHandler(this.UniOperLiniowa_Click);
            // 
            // Morfologia
            // 
            this.Morfologia.Enabled = false;
            this.Morfologia.Index = 4;
            this.Morfologia.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ElementCross,
            this.menuItem2,
            this.Szkieletyzacja});
            this.Morfologia.Text = "Morfologia";
            // 
            // ElementCross
            // 
            this.ElementCross.Index = 0;
            this.ElementCross.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Erozja,
            this.Dylatacja,
            this.Otwarcie,
            this.Zamkniecie});
            this.ElementCross.Text = "Element strukturalny (krzyż)";
            // 
            // Erozja
            // 
            this.Erozja.Index = 0;
            this.Erozja.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ErozjaIsolated,
            this.ErozjaReflect,
            this.ErozjaReplicate});
            this.Erozja.Text = "Erozja";
            // 
            // ErozjaIsolated
            // 
            this.ErozjaIsolated.Index = 0;
            this.ErozjaIsolated.Text = "Isolated";
            this.ErozjaIsolated.Click += new System.EventHandler(this.ErozjaIsolated_Click);
            // 
            // ErozjaReflect
            // 
            this.ErozjaReflect.Index = 1;
            this.ErozjaReflect.Text = "Reflect";
            this.ErozjaReflect.Click += new System.EventHandler(this.ErozjaReflect_Click);
            // 
            // ErozjaReplicate
            // 
            this.ErozjaReplicate.Index = 2;
            this.ErozjaReplicate.Text = "Replicate";
            this.ErozjaReplicate.Click += new System.EventHandler(this.ErozjaReplicate_Click);
            // 
            // Dylatacja
            // 
            this.Dylatacja.Index = 1;
            this.Dylatacja.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DylatacjaIsolated,
            this.DylatacjaReflect,
            this.DylatacjaReplicate});
            this.Dylatacja.Text = "Dylatacja";
            // 
            // DylatacjaIsolated
            // 
            this.DylatacjaIsolated.Index = 0;
            this.DylatacjaIsolated.Text = "Isolated";
            this.DylatacjaIsolated.Click += new System.EventHandler(this.DylatacjaIsolated_Click);
            // 
            // DylatacjaReflect
            // 
            this.DylatacjaReflect.Index = 1;
            this.DylatacjaReflect.Text = "Reflect";
            this.DylatacjaReflect.Click += new System.EventHandler(this.DylatacjaReflect_Click);
            // 
            // DylatacjaReplicate
            // 
            this.DylatacjaReplicate.Index = 2;
            this.DylatacjaReplicate.Text = "Replicate";
            this.DylatacjaReplicate.Click += new System.EventHandler(this.DylatacjaReplicate_Click);
            // 
            // Otwarcie
            // 
            this.Otwarcie.Index = 2;
            this.Otwarcie.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OtwarcieIsolated,
            this.OtwarcieReflect,
            this.OtwarcieReplicate});
            this.Otwarcie.Text = "Otwarcie";
            // 
            // OtwarcieIsolated
            // 
            this.OtwarcieIsolated.Index = 0;
            this.OtwarcieIsolated.Text = "Isolated";
            this.OtwarcieIsolated.Click += new System.EventHandler(this.OtwarcieIsolated_Click);
            // 
            // OtwarcieReflect
            // 
            this.OtwarcieReflect.Index = 1;
            this.OtwarcieReflect.Text = "Reflect";
            this.OtwarcieReflect.Click += new System.EventHandler(this.OtwarcieReflect_Click);
            // 
            // OtwarcieReplicate
            // 
            this.OtwarcieReplicate.Index = 2;
            this.OtwarcieReplicate.Text = "Replicate";
            this.OtwarcieReplicate.Click += new System.EventHandler(this.OtwarcieReplicate_Click);
            // 
            // Zamkniecie
            // 
            this.Zamkniecie.Index = 3;
            this.Zamkniecie.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ZamkniecieIsolated,
            this.ZamkniecieReflect,
            this.ZamkniecieReplicate});
            this.Zamkniecie.Text = "Zamknięcie";
            // 
            // ZamkniecieIsolated
            // 
            this.ZamkniecieIsolated.Index = 0;
            this.ZamkniecieIsolated.Text = "Isolated";
            this.ZamkniecieIsolated.Click += new System.EventHandler(this.ZamkniecieIsolated_Click);
            // 
            // ZamkniecieReflect
            // 
            this.ZamkniecieReflect.Index = 1;
            this.ZamkniecieReflect.Text = "Reflect";
            this.ZamkniecieReflect.Click += new System.EventHandler(this.ZamkniecieReflect_Click);
            // 
            // ZamkniecieReplicate
            // 
            this.ZamkniecieReplicate.Index = 2;
            this.ZamkniecieReplicate.Text = "Replicate";
            this.ZamkniecieReplicate.Click += new System.EventHandler(this.ZamkniecieReplicate_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ErozjaKwadrat,
            this.DylatacjaKwadrat,
            this.OtwarcieKwadrat,
            this.ZamkniecieKwadrat});
            this.menuItem2.Text = "Element strukturalny (kwadrat)";
            // 
            // ErozjaKwadrat
            // 
            this.ErozjaKwadrat.Index = 0;
            this.ErozjaKwadrat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ErozjaIsolatedKwadrat,
            this.ErozjaReflectKwadrat,
            this.ErozjaReplicateKwadrat});
            this.ErozjaKwadrat.Text = "Erozja";
            // 
            // ErozjaIsolatedKwadrat
            // 
            this.ErozjaIsolatedKwadrat.Index = 0;
            this.ErozjaIsolatedKwadrat.Text = "Isolated";
            this.ErozjaIsolatedKwadrat.Click += new System.EventHandler(this.ErozjaIsolatedKwadrat_Click);
            // 
            // ErozjaReflectKwadrat
            // 
            this.ErozjaReflectKwadrat.Index = 1;
            this.ErozjaReflectKwadrat.Text = "Reflect";
            this.ErozjaReflectKwadrat.Click += new System.EventHandler(this.ErozjaReflectKwadrat_Click);
            // 
            // ErozjaReplicateKwadrat
            // 
            this.ErozjaReplicateKwadrat.Index = 2;
            this.ErozjaReplicateKwadrat.Text = "Replicate";
            this.ErozjaReplicateKwadrat.Click += new System.EventHandler(this.ErozjaReplicateKwadrat_Click);
            // 
            // DylatacjaKwadrat
            // 
            this.DylatacjaKwadrat.Index = 1;
            this.DylatacjaKwadrat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DylatacjaIsolatedKwadrat,
            this.DylatacjaReflectKwadrat,
            this.DylatacjaReplicateKwadrat});
            this.DylatacjaKwadrat.Text = "Dylatacja";
            // 
            // DylatacjaIsolatedKwadrat
            // 
            this.DylatacjaIsolatedKwadrat.Index = 0;
            this.DylatacjaIsolatedKwadrat.Text = "Isolated";
            this.DylatacjaIsolatedKwadrat.Click += new System.EventHandler(this.DylatacjaIsolatedKwadrat_Click);
            // 
            // DylatacjaReflectKwadrat
            // 
            this.DylatacjaReflectKwadrat.Index = 1;
            this.DylatacjaReflectKwadrat.Text = "Reflect";
            this.DylatacjaReflectKwadrat.Click += new System.EventHandler(this.DylatacjaReflectKwadrat_Click);
            // 
            // DylatacjaReplicateKwadrat
            // 
            this.DylatacjaReplicateKwadrat.Index = 2;
            this.DylatacjaReplicateKwadrat.Text = "Replicate";
            this.DylatacjaReplicateKwadrat.Click += new System.EventHandler(this.DylatacjaReplicateKwadrat_Click);
            // 
            // OtwarcieKwadrat
            // 
            this.OtwarcieKwadrat.Index = 2;
            this.OtwarcieKwadrat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OtwarcieIsolatedKwadrat,
            this.OtwarcieReflectKwadrat,
            this.OtwarcieReplicateKwadrat});
            this.OtwarcieKwadrat.Text = "Otwarcie";
            // 
            // OtwarcieIsolatedKwadrat
            // 
            this.OtwarcieIsolatedKwadrat.Index = 0;
            this.OtwarcieIsolatedKwadrat.Text = "Isolated";
            this.OtwarcieIsolatedKwadrat.Click += new System.EventHandler(this.OtwarcieIsolatedKwadrat_Click);
            // 
            // OtwarcieReflectKwadrat
            // 
            this.OtwarcieReflectKwadrat.Index = 1;
            this.OtwarcieReflectKwadrat.Text = "Reflect";
            this.OtwarcieReflectKwadrat.Click += new System.EventHandler(this.OtwarcieReflectKwadrat_Click);
            // 
            // OtwarcieReplicateKwadrat
            // 
            this.OtwarcieReplicateKwadrat.Index = 2;
            this.OtwarcieReplicateKwadrat.Text = "Replicate";
            this.OtwarcieReplicateKwadrat.Click += new System.EventHandler(this.OtwarcieReplicateKwadrat_Click);
            // 
            // ZamkniecieKwadrat
            // 
            this.ZamkniecieKwadrat.Index = 3;
            this.ZamkniecieKwadrat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ZamkniecieIsolatedKwadrat,
            this.ZamkniecieReflectKwadrat,
            this.ZamkniecieReplicateKwadrat});
            this.ZamkniecieKwadrat.Text = "Zamknięcie";
            // 
            // ZamkniecieIsolatedKwadrat
            // 
            this.ZamkniecieIsolatedKwadrat.Index = 0;
            this.ZamkniecieIsolatedKwadrat.Text = "Isolated";
            this.ZamkniecieIsolatedKwadrat.Click += new System.EventHandler(this.ZamkniecieIsolatedKwadrat_Click);
            // 
            // ZamkniecieReflectKwadrat
            // 
            this.ZamkniecieReflectKwadrat.Index = 1;
            this.ZamkniecieReflectKwadrat.Text = "Reflect";
            this.ZamkniecieReflectKwadrat.Click += new System.EventHandler(this.ZamkniecieReflectKwadrat_Click);
            // 
            // ZamkniecieReplicateKwadrat
            // 
            this.ZamkniecieReplicateKwadrat.Index = 2;
            this.ZamkniecieReplicateKwadrat.Text = "Replicate";
            this.ZamkniecieReplicateKwadrat.Click += new System.EventHandler(this.ZamkniecieReplicateKwadrat_Click);
            // 
            // Szkieletyzacja
            // 
            this.Szkieletyzacja.Index = 2;
            this.Szkieletyzacja.Text = "Szkieletyzacja";
            this.Szkieletyzacja.Click += new System.EventHandler(this.Szkieletyzacja_Click);
            // 
            // Segmentacja
            // 
            this.Segmentacja.Enabled = false;
            this.Segmentacja.Index = 5;
            this.Segmentacja.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ProgAdaptacyjne,
            this.ProgOtsu,
            this.Wododzialowa});
            this.Segmentacja.Text = "Segmentacja";
            // 
            // ProgAdaptacyjne
            // 
            this.ProgAdaptacyjne.Index = 0;
            this.ProgAdaptacyjne.Text = "Progowanie adaptacyjne";
            this.ProgAdaptacyjne.Click += new System.EventHandler(this.ProgAdaptacyjne_Click);
            // 
            // ProgOtsu
            // 
            this.ProgOtsu.Index = 1;
            this.ProgOtsu.Text = "Progowanie Otsu";
            this.ProgOtsu.Click += new System.EventHandler(this.ProgOtsu_Click);
            // 
            // Wododzialowa
            // 
            this.Wododzialowa.Index = 2;
            this.Wododzialowa.Text = "Metoda wododziałowa";
            this.Wododzialowa.Click += new System.EventHandler(this.Wododzialowa_Click);
            // 
            // AnalizaObrazu
            // 
            this.AnalizaObrazu.Enabled = false;
            this.AnalizaObrazu.Index = 6;
            this.AnalizaObrazu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WyznaczanieSklad,
            this.RysujKontury,
            this.WspolKsztaltu});
            this.AnalizaObrazu.Text = "Analiza obrazu";
            // 
            // WyznaczanieSklad
            // 
            this.WyznaczanieSklad.Index = 0;
            this.WyznaczanieSklad.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Momenty,
            this.PowerzchniaObwod});
            this.WyznaczanieSklad.Text = "Wyznaczanie składowych";
            // 
            // Momenty
            // 
            this.Momenty.Index = 0;
            this.Momenty.Text = "Momenty";
            this.Momenty.Click += new System.EventHandler(this.Momenty_Click);
            // 
            // PowerzchniaObwod
            // 
            this.PowerzchniaObwod.Index = 1;
            this.PowerzchniaObwod.Text = "Powierzchnia i obwód";
            this.PowerzchniaObwod.Click += new System.EventHandler(this.PowerzchniaObwod_Click);
            // 
            // RysujKontury
            // 
            this.RysujKontury.Index = 1;
            this.RysujKontury.Text = "Rysuj kontury";
            this.RysujKontury.Click += new System.EventHandler(this.RysujKontury_Click);
            // 
            // WspolKsztaltu
            // 
            this.WspolKsztaltu.Index = 2;
            this.WspolKsztaltu.Text = "Współczynniki kształtu";
            this.WspolKsztaltu.Click += new System.EventHandler(this.WspolKsztaltu_Click);
            // 
            // Info
            // 
            this.Info.Index = 7;
            this.Info.Text = "Informacje o programie";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = -1;
            this.menuItemOpen.Text = "";
            // 
            // menuItemHistogram
            // 
            this.menuItemHistogram.Enabled = false;
            this.menuItemHistogram.Index = -1;
            this.menuItemHistogram.Text = "";
            // 
            // ButtonCloseTab
            // 
            this.ButtonCloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseTab.Enabled = false;
            this.ButtonCloseTab.Location = new System.Drawing.Point(1121, 1);
            this.ButtonCloseTab.Name = "ButtonCloseTab";
            this.ButtonCloseTab.Size = new System.Drawing.Size(20, 20);
            this.ButtonCloseTab.TabIndex = 1;
            this.ButtonCloseTab.Text = "X";
            this.ButtonCloseTab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCloseTab.UseVisualStyleBackColor = true;
            this.ButtonCloseTab.Click += new System.EventHandler(this.ButtonCloseTab_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1153, 626);
            this.Controls.Add(this.ButtonCloseTab);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Text = "Image Processing Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leaving);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemTools;
        private System.Windows.Forms.MenuItem menuItemHistogram;
        private System.Windows.Forms.MenuItem menuItemOpn;
        private System.Windows.Forms.MenuItem menuItemHisto;
        private System.Windows.Forms.MenuItem menuItemOperPunktJedno;
        private System.Windows.Forms.MenuItem Negacja;
        private System.Windows.Forms.MenuItem Progowanie;
        private System.Windows.Forms.MenuItem menuItemOperPunktDwu;
        private System.Windows.Forms.MenuItem XOR;
        private System.Windows.Forms.MenuItem OR;
        private System.Windows.Forms.MenuItem AND;
        private System.Windows.Forms.MenuItem OperacjeSasiedztwa;
        private System.Windows.Forms.MenuItem Blur;
        private System.Windows.Forms.MenuItem GaussianBlur;
        private System.Windows.Forms.MenuItem Sobel;
        private System.Windows.Forms.MenuItem Laplacian;
        private System.Windows.Forms.MenuItem Canny;
        private System.Windows.Forms.MenuItem WyostrzanieLiniowe;
        private System.Windows.Forms.MenuItem WLiniowePreset1;
        private System.Windows.Forms.MenuItem WLiniowePreset2;
        private System.Windows.Forms.MenuItem WLiniowePreset3;
        private System.Windows.Forms.MenuItem Prewitt;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem Morfologia;
        private System.Windows.Forms.MenuItem ElementCross;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem Erozja;
        private System.Windows.Forms.MenuItem ErozjaIsolated;
        private System.Windows.Forms.MenuItem ErozjaReflect;
        private System.Windows.Forms.MenuItem ErozjaReplicate;
        private System.Windows.Forms.MenuItem Dylatacja;
        private System.Windows.Forms.MenuItem DylatacjaIsolated;
        private System.Windows.Forms.MenuItem DylatacjaReflect;
        private System.Windows.Forms.MenuItem DylatacjaReplicate;
        private System.Windows.Forms.MenuItem Otwarcie;
        private System.Windows.Forms.MenuItem OtwarcieIsolated;
        private System.Windows.Forms.MenuItem OtwarcieReflect;
        private System.Windows.Forms.MenuItem OtwarcieReplicate;
        private System.Windows.Forms.MenuItem Zamkniecie;
        private System.Windows.Forms.MenuItem ZamkniecieIsolated;
        private System.Windows.Forms.MenuItem ZamkniecieReflect;
        private System.Windows.Forms.MenuItem ZamkniecieReplicate;
        private System.Windows.Forms.MenuItem ErozjaKwadrat;
        private System.Windows.Forms.MenuItem ErozjaIsolatedKwadrat;
        private System.Windows.Forms.MenuItem ErozjaReflectKwadrat;
        private System.Windows.Forms.MenuItem ErozjaReplicateKwadrat;
        private System.Windows.Forms.MenuItem DylatacjaKwadrat;
        private System.Windows.Forms.MenuItem DylatacjaIsolatedKwadrat;
        private System.Windows.Forms.MenuItem DylatacjaReflectKwadrat;
        private System.Windows.Forms.MenuItem DylatacjaReplicateKwadrat;
        private System.Windows.Forms.MenuItem OtwarcieKwadrat;
        private System.Windows.Forms.MenuItem OtwarcieIsolatedKwadrat;
        private System.Windows.Forms.MenuItem OtwarcieReflectKwadrat;
        private System.Windows.Forms.MenuItem OtwarcieReplicateKwadrat;
        private System.Windows.Forms.MenuItem ZamkniecieKwadrat;
        private System.Windows.Forms.MenuItem ZamkniecieIsolatedKwadrat;
        private System.Windows.Forms.MenuItem ZamkniecieReflectKwadrat;
        private System.Windows.Forms.MenuItem ZamkniecieReplicateKwadrat;
        private System.Windows.Forms.MenuItem Szkieletyzacja;
        private System.Windows.Forms.MenuItem FiltracjaJedno;
        private System.Windows.Forms.MenuItem FiltracjaDwu;
        private System.Windows.Forms.MenuItem FiltracjaDwuIsolated;
        private System.Windows.Forms.MenuItem FiltracjaDwuReflect;
        private System.Windows.Forms.MenuItem FiltracjaDwuReplicate;
        private System.Windows.Forms.MenuItem Filtracje;
        private System.Windows.Forms.MenuItem FiltracjaJednoIsolated;
        private System.Windows.Forms.MenuItem FiltracjaJednoReflect;
        private System.Windows.Forms.MenuItem FiltracjaJednoReplicate;
        private System.Windows.Forms.MenuItem Segmentacja;
        private System.Windows.Forms.MenuItem ProgAdaptacyjne;
        private System.Windows.Forms.MenuItem ProgOtsu;
        private System.Windows.Forms.MenuItem Mieszanie;
        private System.Windows.Forms.MenuItem AnalizaObrazu;
        private System.Windows.Forms.MenuItem WyznaczanieSklad;
        private System.Windows.Forms.MenuItem Momenty;
        private System.Windows.Forms.MenuItem PowerzchniaObwod;
        private System.Windows.Forms.MenuItem RysujKontury;
        internal System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem UniOperLiniowa;
        private System.Windows.Forms.Button ButtonCloseTab;
        private System.Windows.Forms.MenuItem WspolKsztaltu;
        private System.Windows.Forms.MenuItem Wododzialowa;
        private System.Windows.Forms.MenuItem Info;
        private System.Windows.Forms.MenuItem Zapisz;
        //public static List<System.Windows.Forms.PictureBox> PictureList = new List<System.Windows.Forms.PictureBox>();
        //public System.Windows.Forms.PictureBox Pictureee;

    }
}

