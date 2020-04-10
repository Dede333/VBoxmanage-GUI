namespace VBoxManage_Gui
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reglages = new System.Windows.Forms.TabPage();
            this.Btn_AfficheVersion = new System.Windows.Forms.Button();
            this.Lbl_PathToVBoxManage = new System.Windows.Forms.Label();
            this.TxtBox_StrPathToVBoxManage = new System.Windows.Forms.TextBox();
            this.Btn_FixePathToVBoxManage = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.TabPage();
            this.Btn_AfficheInfosHote = new System.Windows.Forms.Button();
            this.Btn_AfficheOSType = new System.Windows.Forms.Button();
            this.Btn_AfficheMachineEnCoursFonctionnement = new System.Windows.Forms.Button();
            this.Btn_ListeMachinesVirtuelles = new System.Windows.Forms.Button();
            this.showvminfo = new System.Windows.Forms.TabPage();
            this.ChkBox_ShowVmInfoMachineReadable = new System.Windows.Forms.CheckBox();
            this.ChkBoxShowVmInfoDetails = new System.Windows.Forms.CheckBox();
            this.Btn_ShowIdxLog = new System.Windows.Forms.Button();
            this.TxtBox_ShowIdxLog = new System.Windows.Forms.TextBox();
            this.Lbl_ShowIdxLog = new System.Windows.Forms.Label();
            this.Btn_showvminfo_AfficheInfos = new System.Windows.Forms.Button();
            this.TxtBox_Showvminfo_UUIDorName = new System.Windows.Forms.TextBox();
            this.Lbl_showUUIDorName = new System.Windows.Forms.Label();
            this.registervm_unregistervm = new System.Windows.Forms.TabPage();
            this.createvm = new System.Windows.Forms.TabPage();
            this.CmbBox_CreateVmOSType = new System.Windows.Forms.ComboBox();
            this.ChkBox_CreateVmRegister = new System.Windows.Forms.CheckBox();
            this.ChkBox_CreateVmDefault = new System.Windows.Forms.CheckBox();
            this.ChkBox_CreateVmUUID = new System.Windows.Forms.CheckBox();
            this.ChkBox_CreateBaseFolder = new System.Windows.Forms.CheckBox();
            this.ChkBox_CreateVmOSType = new System.Windows.Forms.CheckBox();
            this.ChkBox_CreateVmGroups = new System.Windows.Forms.CheckBox();
            this.Lbl_CreateVmUUID = new System.Windows.Forms.Label();
            this.Lbl_CreateVmFolder = new System.Windows.Forms.Label();
            this.TxtBox_CreateVmUUID = new System.Windows.Forms.TextBox();
            this.TxtBox_CreateVmDossierDest = new System.Windows.Forms.TextBox();
            this.Lbl_CreateVmTypeOS = new System.Windows.Forms.Label();
            this.Lbl_CreateVmGroup = new System.Windows.Forms.Label();
            this.TxtBox_CreateVmGroup = new System.Windows.Forms.TextBox();
            this.Btn_CreateVmCreer = new System.Windows.Forms.Button();
            this.Lbl_CreateVmName = new System.Windows.Forms.Label();
            this.TxtBox_CreateVmName = new System.Windows.Forms.TextBox();
            this.modifyvm = new System.Windows.Forms.TabPage();
            this.movevm = new System.Windows.Forms.TabPage();
            this.import_export = new System.Windows.Forms.TabPage();
            this.startvm = new System.Windows.Forms.TabPage();
            this.Btn_StartVM = new System.Windows.Forms.Button();
            this.TxtBox_StartVmName = new System.Windows.Forms.TextBox();
            this.Lbl_StartvmName = new System.Windows.Forms.Label();
            this.controlvm = new System.Windows.Forms.TabPage();
            this.discardstate_adoptstate = new System.Windows.Forms.TabPage();
            this.TxtBox_OutputConsole = new System.Windows.Forms.TextBox();
            this.Lbl_VBoxOutputConsole = new System.Windows.Forms.Label();
            this.backgroundWorkerVboxManageCommand = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Reglages.SuspendLayout();
            this.list.SuspendLayout();
            this.showvminfo.SuspendLayout();
            this.createvm.SuspendLayout();
            this.startvm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reglages);
            this.tabControl1.Controls.Add(this.list);
            this.tabControl1.Controls.Add(this.showvminfo);
            this.tabControl1.Controls.Add(this.registervm_unregistervm);
            this.tabControl1.Controls.Add(this.createvm);
            this.tabControl1.Controls.Add(this.modifyvm);
            this.tabControl1.Controls.Add(this.movevm);
            this.tabControl1.Controls.Add(this.import_export);
            this.tabControl1.Controls.Add(this.startvm);
            this.tabControl1.Controls.Add(this.controlvm);
            this.tabControl1.Controls.Add(this.discardstate_adoptstate);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 223);
            this.tabControl1.TabIndex = 0;
            // 
            // Reglages
            // 
            this.Reglages.Controls.Add(this.Btn_AfficheVersion);
            this.Reglages.Controls.Add(this.Lbl_PathToVBoxManage);
            this.Reglages.Controls.Add(this.TxtBox_StrPathToVBoxManage);
            this.Reglages.Controls.Add(this.Btn_FixePathToVBoxManage);
            this.Reglages.Location = new System.Drawing.Point(4, 22);
            this.Reglages.Name = "Reglages";
            this.Reglages.Padding = new System.Windows.Forms.Padding(3);
            this.Reglages.Size = new System.Drawing.Size(735, 197);
            this.Reglages.TabIndex = 0;
            this.Reglages.Text = "Réglages Paramètres";
            this.Reglages.UseVisualStyleBackColor = true;
            // 
            // Btn_AfficheVersion
            // 
            this.Btn_AfficheVersion.Location = new System.Drawing.Point(481, 103);
            this.Btn_AfficheVersion.Name = "Btn_AfficheVersion";
            this.Btn_AfficheVersion.Size = new System.Drawing.Size(145, 20);
            this.Btn_AfficheVersion.TabIndex = 6;
            this.Btn_AfficheVersion.Text = "Version de VirtualBox";
            this.Btn_AfficheVersion.UseVisualStyleBackColor = true;
            this.Btn_AfficheVersion.Click += new System.EventHandler(this.Btn_AfficheVersion_Click);
            // 
            // Lbl_PathToVBoxManage
            // 
            this.Lbl_PathToVBoxManage.AutoSize = true;
            this.Lbl_PathToVBoxManage.Location = new System.Drawing.Point(8, 38);
            this.Lbl_PathToVBoxManage.Name = "Lbl_PathToVBoxManage";
            this.Lbl_PathToVBoxManage.Size = new System.Drawing.Size(135, 13);
            this.Lbl_PathToVBoxManage.TabIndex = 5;
            this.Lbl_PathToVBoxManage.Text = "Chemin vers VBoxManage:";
            // 
            // TxtBox_StrPathToVBoxManage
            // 
            this.TxtBox_StrPathToVBoxManage.Location = new System.Drawing.Point(149, 35);
            this.TxtBox_StrPathToVBoxManage.Name = "TxtBox_StrPathToVBoxManage";
            this.TxtBox_StrPathToVBoxManage.Size = new System.Drawing.Size(326, 20);
            this.TxtBox_StrPathToVBoxManage.TabIndex = 4;
            // 
            // Btn_FixePathToVBoxManage
            // 
            this.Btn_FixePathToVBoxManage.Location = new System.Drawing.Point(481, 35);
            this.Btn_FixePathToVBoxManage.Name = "Btn_FixePathToVBoxManage";
            this.Btn_FixePathToVBoxManage.Size = new System.Drawing.Size(145, 20);
            this.Btn_FixePathToVBoxManage.TabIndex = 3;
            this.Btn_FixePathToVBoxManage.Text = "Chemin Vers VBoxManage";
            this.Btn_FixePathToVBoxManage.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Controls.Add(this.Btn_AfficheInfosHote);
            this.list.Controls.Add(this.Btn_AfficheOSType);
            this.list.Controls.Add(this.Btn_AfficheMachineEnCoursFonctionnement);
            this.list.Controls.Add(this.Btn_ListeMachinesVirtuelles);
            this.list.Location = new System.Drawing.Point(4, 22);
            this.list.Name = "list";
            this.list.Padding = new System.Windows.Forms.Padding(3);
            this.list.Size = new System.Drawing.Size(735, 197);
            this.list.TabIndex = 1;
            this.list.Text = "list";
            this.list.UseVisualStyleBackColor = true;
            // 
            // Btn_AfficheInfosHote
            // 
            this.Btn_AfficheInfosHote.Location = new System.Drawing.Point(8, 95);
            this.Btn_AfficheInfosHote.Name = "Btn_AfficheInfosHote";
            this.Btn_AfficheInfosHote.Size = new System.Drawing.Size(566, 23);
            this.Btn_AfficheInfosHote.TabIndex = 3;
            this.Btn_AfficheInfosHote.Text = "Affiche les informations de l\'hôte";
            this.Btn_AfficheInfosHote.UseVisualStyleBackColor = true;
            this.Btn_AfficheInfosHote.Click += new System.EventHandler(this.Btn_AfficheInfosHote_Click);
            // 
            // Btn_AfficheOSType
            // 
            this.Btn_AfficheOSType.Location = new System.Drawing.Point(8, 66);
            this.Btn_AfficheOSType.Name = "Btn_AfficheOSType";
            this.Btn_AfficheOSType.Size = new System.Drawing.Size(566, 23);
            this.Btn_AfficheOSType.TabIndex = 2;
            this.Btn_AfficheOSType.Text = "Affiche la liste des type OS pris en charge dans l\'environnement VirtualBox";
            this.Btn_AfficheOSType.UseVisualStyleBackColor = true;
            this.Btn_AfficheOSType.Click += new System.EventHandler(this.Btn_AfficheOSType_Click);
            // 
            // Btn_AfficheMachineEnCoursFonctionnement
            // 
            this.Btn_AfficheMachineEnCoursFonctionnement.Location = new System.Drawing.Point(8, 37);
            this.Btn_AfficheMachineEnCoursFonctionnement.Name = "Btn_AfficheMachineEnCoursFonctionnement";
            this.Btn_AfficheMachineEnCoursFonctionnement.Size = new System.Drawing.Size(566, 23);
            this.Btn_AfficheMachineEnCoursFonctionnement.TabIndex = 1;
            this.Btn_AfficheMachineEnCoursFonctionnement.Text = "Affiche toutes les machine(s) virtuelle(s) en cours de fonctionnement dans l\'envi" +
    "ronnement VirtualBox";
            this.Btn_AfficheMachineEnCoursFonctionnement.UseVisualStyleBackColor = true;
            this.Btn_AfficheMachineEnCoursFonctionnement.Click += new System.EventHandler(this.Btn_AfficheMachineEnCoursFonctionnement_Click);
            // 
            // Btn_ListeMachinesVirtuelles
            // 
            this.Btn_ListeMachinesVirtuelles.Location = new System.Drawing.Point(8, 8);
            this.Btn_ListeMachinesVirtuelles.Name = "Btn_ListeMachinesVirtuelles";
            this.Btn_ListeMachinesVirtuelles.Size = new System.Drawing.Size(566, 23);
            this.Btn_ListeMachinesVirtuelles.TabIndex = 0;
            this.Btn_ListeMachinesVirtuelles.Text = "Affiche toutes les machine(s) virtuelle(s) présentes dans l\'environnement Virtual" +
    "Box";
            this.Btn_ListeMachinesVirtuelles.UseVisualStyleBackColor = true;
            this.Btn_ListeMachinesVirtuelles.Click += new System.EventHandler(this.Btn_ListeMachinesVirtuelles_Click);
            // 
            // showvminfo
            // 
            this.showvminfo.Controls.Add(this.ChkBox_ShowVmInfoMachineReadable);
            this.showvminfo.Controls.Add(this.ChkBoxShowVmInfoDetails);
            this.showvminfo.Controls.Add(this.Btn_ShowIdxLog);
            this.showvminfo.Controls.Add(this.TxtBox_ShowIdxLog);
            this.showvminfo.Controls.Add(this.Lbl_ShowIdxLog);
            this.showvminfo.Controls.Add(this.Btn_showvminfo_AfficheInfos);
            this.showvminfo.Controls.Add(this.TxtBox_Showvminfo_UUIDorName);
            this.showvminfo.Controls.Add(this.Lbl_showUUIDorName);
            this.showvminfo.Location = new System.Drawing.Point(4, 22);
            this.showvminfo.Name = "showvminfo";
            this.showvminfo.Size = new System.Drawing.Size(735, 197);
            this.showvminfo.TabIndex = 2;
            this.showvminfo.Text = "showvminfo";
            this.showvminfo.UseVisualStyleBackColor = true;
            // 
            // ChkBox_ShowVmInfoMachineReadable
            // 
            this.ChkBox_ShowVmInfoMachineReadable.AutoSize = true;
            this.ChkBox_ShowVmInfoMachineReadable.Location = new System.Drawing.Point(346, 34);
            this.ChkBox_ShowVmInfoMachineReadable.Name = "ChkBox_ShowVmInfoMachineReadable";
            this.ChkBox_ShowVmInfoMachineReadable.Size = new System.Drawing.Size(113, 17);
            this.ChkBox_ShowVmInfoMachineReadable.TabIndex = 7;
            this.ChkBox_ShowVmInfoMachineReadable.Text = "--machinereadable";
            this.ChkBox_ShowVmInfoMachineReadable.UseVisualStyleBackColor = true;
            // 
            // ChkBoxShowVmInfoDetails
            // 
            this.ChkBoxShowVmInfoDetails.AutoSize = true;
            this.ChkBoxShowVmInfoDetails.Location = new System.Drawing.Point(243, 34);
            this.ChkBoxShowVmInfoDetails.Name = "ChkBoxShowVmInfoDetails";
            this.ChkBoxShowVmInfoDetails.Size = new System.Drawing.Size(62, 17);
            this.ChkBoxShowVmInfoDetails.TabIndex = 6;
            this.ChkBoxShowVmInfoDetails.Text = "--details";
            this.ChkBoxShowVmInfoDetails.UseVisualStyleBackColor = true;
            // 
            // Btn_ShowIdxLog
            // 
            this.Btn_ShowIdxLog.Location = new System.Drawing.Point(474, 83);
            this.Btn_ShowIdxLog.Name = "Btn_ShowIdxLog";
            this.Btn_ShowIdxLog.Size = new System.Drawing.Size(75, 23);
            this.Btn_ShowIdxLog.TabIndex = 5;
            this.Btn_ShowIdxLog.Text = "Affiche Log";
            this.Btn_ShowIdxLog.UseVisualStyleBackColor = true;
            this.Btn_ShowIdxLog.Click += new System.EventHandler(this.Btn_ShowIdxLog_Click);
            // 
            // TxtBox_ShowIdxLog
            // 
            this.TxtBox_ShowIdxLog.Location = new System.Drawing.Point(171, 83);
            this.TxtBox_ShowIdxLog.Name = "TxtBox_ShowIdxLog";
            this.TxtBox_ShowIdxLog.Size = new System.Drawing.Size(48, 20);
            this.TxtBox_ShowIdxLog.TabIndex = 4;
            // 
            // Lbl_ShowIdxLog
            // 
            this.Lbl_ShowIdxLog.AutoSize = true;
            this.Lbl_ShowIdxLog.Location = new System.Drawing.Point(112, 83);
            this.Lbl_ShowIdxLog.Name = "Lbl_ShowIdxLog";
            this.Lbl_ShowIdxLog.Size = new System.Drawing.Size(53, 13);
            this.Lbl_ShowIdxLog.TabIndex = 3;
            this.Lbl_ShowIdxLog.Text = "Index log:";
            // 
            // Btn_showvminfo_AfficheInfos
            // 
            this.Btn_showvminfo_AfficheInfos.Location = new System.Drawing.Point(474, 8);
            this.Btn_showvminfo_AfficheInfos.Name = "Btn_showvminfo_AfficheInfos";
            this.Btn_showvminfo_AfficheInfos.Size = new System.Drawing.Size(75, 23);
            this.Btn_showvminfo_AfficheInfos.TabIndex = 2;
            this.Btn_showvminfo_AfficheInfos.Text = "Affiche Infos";
            this.Btn_showvminfo_AfficheInfos.UseVisualStyleBackColor = true;
            this.Btn_showvminfo_AfficheInfos.Click += new System.EventHandler(this.Btn_showvminfo_AfficheInfos_Click);
            // 
            // TxtBox_Showvminfo_UUIDorName
            // 
            this.TxtBox_Showvminfo_UUIDorName.Location = new System.Drawing.Point(171, 8);
            this.TxtBox_Showvminfo_UUIDorName.Name = "TxtBox_Showvminfo_UUIDorName";
            this.TxtBox_Showvminfo_UUIDorName.Size = new System.Drawing.Size(288, 20);
            this.TxtBox_Showvminfo_UUIDorName.TabIndex = 1;
            // 
            // Lbl_showUUIDorName
            // 
            this.Lbl_showUUIDorName.AutoSize = true;
            this.Lbl_showUUIDorName.Location = new System.Drawing.Point(12, 11);
            this.Lbl_showUUIDorName.Name = "Lbl_showUUIDorName";
            this.Lbl_showUUIDorName.Size = new System.Drawing.Size(153, 13);
            this.Lbl_showUUIDorName.TabIndex = 0;
            this.Lbl_showUUIDorName.Text = "Virtual Machine UUID ou Nom:";
            // 
            // registervm_unregistervm
            // 
            this.registervm_unregistervm.Location = new System.Drawing.Point(4, 22);
            this.registervm_unregistervm.Name = "registervm_unregistervm";
            this.registervm_unregistervm.Size = new System.Drawing.Size(735, 197);
            this.registervm_unregistervm.TabIndex = 3;
            this.registervm_unregistervm.Text = "registervm / unregistervm";
            this.registervm_unregistervm.UseVisualStyleBackColor = true;
            // 
            // createvm
            // 
            this.createvm.Controls.Add(this.CmbBox_CreateVmOSType);
            this.createvm.Controls.Add(this.ChkBox_CreateVmRegister);
            this.createvm.Controls.Add(this.ChkBox_CreateVmDefault);
            this.createvm.Controls.Add(this.ChkBox_CreateVmUUID);
            this.createvm.Controls.Add(this.ChkBox_CreateBaseFolder);
            this.createvm.Controls.Add(this.ChkBox_CreateVmOSType);
            this.createvm.Controls.Add(this.ChkBox_CreateVmGroups);
            this.createvm.Controls.Add(this.Lbl_CreateVmUUID);
            this.createvm.Controls.Add(this.Lbl_CreateVmFolder);
            this.createvm.Controls.Add(this.TxtBox_CreateVmUUID);
            this.createvm.Controls.Add(this.TxtBox_CreateVmDossierDest);
            this.createvm.Controls.Add(this.Lbl_CreateVmTypeOS);
            this.createvm.Controls.Add(this.Lbl_CreateVmGroup);
            this.createvm.Controls.Add(this.TxtBox_CreateVmGroup);
            this.createvm.Controls.Add(this.Btn_CreateVmCreer);
            this.createvm.Controls.Add(this.Lbl_CreateVmName);
            this.createvm.Controls.Add(this.TxtBox_CreateVmName);
            this.createvm.Location = new System.Drawing.Point(4, 22);
            this.createvm.Name = "createvm";
            this.createvm.Size = new System.Drawing.Size(735, 197);
            this.createvm.TabIndex = 4;
            this.createvm.Text = "createvm";
            this.createvm.UseVisualStyleBackColor = true;
            // 
            // CmbBox_CreateVmOSType
            // 
            this.CmbBox_CreateVmOSType.FormattingEnabled = true;
            this.CmbBox_CreateVmOSType.Items.AddRange(new object[] {
            "Other",
            "Other_64",
            "Windows31",
            "Windows95",
            "Windows98",
            "WindowsMe",
            "WindowsNT3x",
            "WindowsNT4",
            "Windows2000",
            "WindowsXP",
            "WindowsXP_64",
            "Windows2003",
            "Windows2003_64",
            "WindowsVista",
            "WindowsVista64",
            "Windows2008",
            "Windows2008_64",
            "Windows7",
            "WIndows7_64",
            "Windows8",
            "Windows8_64",
            "Windows81",
            "Windows81_64",
            "Windows2012_64",
            "Windows10",
            "Windows10_64",
            "Windows2016_64",
            "Windows2019_64",
            "WindowsNT",
            "WindowsNT_64",
            "Linux22",
            "Linux24",
            "Linux24_64",
            "Linux26",
            "Linux26_64",
            "ArchLinux",
            "ArchLinux_64",
            "Debian",
            "Debian_64",
            "Fedora",
            "Fedora_64",
            "Gentoo",
            "Gentoo_64",
            "Mandriva",
            "Mandriva_64",
            "Oracle",
            "Oracle_64",
            "RedHat",
            "RedHat_64",
            "OpenSUSE",
            "OpenSUSE_64",
            "Turbolinux",
            "Turbolinux_64",
            "Ubuntu",
            "Ubuntu_64",
            "Xandros",
            "Xandros_64",
            "Linux",
            "Linux_64",
            "Solaris",
            "Solaris_64",
            "OpenSolaris",
            "OpenSolaris_64",
            "Solaris11_64",
            "FreeBSD",
            "FreeBSD_64",
            "OpenBSD",
            "OpenBSD_64",
            "NetBSD",
            "NetBSD_64",
            "OS2Warp3",
            "OS2Warp4",
            "OS2Warp45",
            "OS2eCS",
            "OS21x",
            "OS2",
            "MacOS",
            "MacOS_64",
            "MacOS106",
            "MacOS106_64",
            "MacOS107_64",
            "MacOS108_64",
            "MacOS109_64",
            "MacOS1010_64",
            "MacOS1011_64",
            "MacOS1012_64",
            "MacOS1013_64",
            "DOS",
            "Netware",
            "L4",
            "QNX",
            "JRockitVE",
            "VBoxBS_64"});
            this.CmbBox_CreateVmOSType.Location = new System.Drawing.Point(227, 70);
            this.CmbBox_CreateVmOSType.Name = "CmbBox_CreateVmOSType";
            this.CmbBox_CreateVmOSType.Size = new System.Drawing.Size(298, 21);
            this.CmbBox_CreateVmOSType.TabIndex = 20;
            // 
            // ChkBox_CreateVmRegister
            // 
            this.ChkBox_CreateVmRegister.AutoSize = true;
            this.ChkBox_CreateVmRegister.Location = new System.Drawing.Point(26, 92);
            this.ChkBox_CreateVmRegister.Name = "ChkBox_CreateVmRegister";
            this.ChkBox_CreateVmRegister.Size = new System.Drawing.Size(66, 17);
            this.ChkBox_CreateVmRegister.TabIndex = 19;
            this.ChkBox_CreateVmRegister.Text = "--register";
            this.ChkBox_CreateVmRegister.UseVisualStyleBackColor = true;
            // 
            // ChkBox_CreateVmDefault
            // 
            this.ChkBox_CreateVmDefault.AutoSize = true;
            this.ChkBox_CreateVmDefault.Location = new System.Drawing.Point(26, 184);
            this.ChkBox_CreateVmDefault.Name = "ChkBox_CreateVmDefault";
            this.ChkBox_CreateVmDefault.Size = new System.Drawing.Size(64, 17);
            this.ChkBox_CreateVmDefault.TabIndex = 18;
            this.ChkBox_CreateVmDefault.Text = "--default";
            this.ChkBox_CreateVmDefault.UseVisualStyleBackColor = true;
            // 
            // ChkBox_CreateVmUUID
            // 
            this.ChkBox_CreateVmUUID.AutoSize = true;
            this.ChkBox_CreateVmUUID.Location = new System.Drawing.Point(26, 151);
            this.ChkBox_CreateVmUUID.Name = "ChkBox_CreateVmUUID";
            this.ChkBox_CreateVmUUID.Size = new System.Drawing.Size(52, 17);
            this.ChkBox_CreateVmUUID.TabIndex = 17;
            this.ChkBox_CreateVmUUID.Text = "--uuid";
            this.ChkBox_CreateVmUUID.UseVisualStyleBackColor = true;
            // 
            // ChkBox_CreateBaseFolder
            // 
            this.ChkBox_CreateBaseFolder.AutoSize = true;
            this.ChkBox_CreateBaseFolder.Location = new System.Drawing.Point(26, 125);
            this.ChkBox_CreateBaseFolder.Name = "ChkBox_CreateBaseFolder";
            this.ChkBox_CreateBaseFolder.Size = new System.Drawing.Size(81, 17);
            this.ChkBox_CreateBaseFolder.TabIndex = 16;
            this.ChkBox_CreateBaseFolder.Text = "--basefolder";
            this.ChkBox_CreateBaseFolder.UseVisualStyleBackColor = true;
            // 
            // ChkBox_CreateVmOSType
            // 
            this.ChkBox_CreateVmOSType.AutoSize = true;
            this.ChkBox_CreateVmOSType.Location = new System.Drawing.Point(26, 69);
            this.ChkBox_CreateVmOSType.Name = "ChkBox_CreateVmOSType";
            this.ChkBox_CreateVmOSType.Size = new System.Drawing.Size(63, 17);
            this.ChkBox_CreateVmOSType.TabIndex = 15;
            this.ChkBox_CreateVmOSType.Text = "--ostype";
            this.ChkBox_CreateVmOSType.UseVisualStyleBackColor = true;
            // 
            // ChkBox_CreateVmGroups
            // 
            this.ChkBox_CreateVmGroups.AutoSize = true;
            this.ChkBox_CreateVmGroups.Location = new System.Drawing.Point(26, 44);
            this.ChkBox_CreateVmGroups.Name = "ChkBox_CreateVmGroups";
            this.ChkBox_CreateVmGroups.Size = new System.Drawing.Size(64, 17);
            this.ChkBox_CreateVmGroups.TabIndex = 14;
            this.ChkBox_CreateVmGroups.Text = "--groups";
            this.ChkBox_CreateVmGroups.UseVisualStyleBackColor = true;
            // 
            // Lbl_CreateVmUUID
            // 
            this.Lbl_CreateVmUUID.AutoSize = true;
            this.Lbl_CreateVmUUID.Location = new System.Drawing.Point(113, 151);
            this.Lbl_CreateVmUUID.Name = "Lbl_CreateVmUUID";
            this.Lbl_CreateVmUUID.Size = new System.Drawing.Size(70, 13);
            this.Lbl_CreateVmUUID.TabIndex = 13;
            this.Lbl_CreateVmUUID.Text = "Valeur UUID:";
            // 
            // Lbl_CreateVmFolder
            // 
            this.Lbl_CreateVmFolder.AutoSize = true;
            this.Lbl_CreateVmFolder.Location = new System.Drawing.Point(113, 125);
            this.Lbl_CreateVmFolder.Name = "Lbl_CreateVmFolder";
            this.Lbl_CreateVmFolder.Size = new System.Drawing.Size(113, 13);
            this.Lbl_CreateVmFolder.TabIndex = 12;
            this.Lbl_CreateVmFolder.Text = "Répertoire destination:";
            // 
            // TxtBox_CreateVmUUID
            // 
            this.TxtBox_CreateVmUUID.Location = new System.Drawing.Point(227, 146);
            this.TxtBox_CreateVmUUID.Name = "TxtBox_CreateVmUUID";
            this.TxtBox_CreateVmUUID.Size = new System.Drawing.Size(298, 20);
            this.TxtBox_CreateVmUUID.TabIndex = 11;
            // 
            // TxtBox_CreateVmDossierDest
            // 
            this.TxtBox_CreateVmDossierDest.Location = new System.Drawing.Point(227, 120);
            this.TxtBox_CreateVmDossierDest.Name = "TxtBox_CreateVmDossierDest";
            this.TxtBox_CreateVmDossierDest.Size = new System.Drawing.Size(298, 20);
            this.TxtBox_CreateVmDossierDest.TabIndex = 10;
            // 
            // Lbl_CreateVmTypeOS
            // 
            this.Lbl_CreateVmTypeOS.AutoSize = true;
            this.Lbl_CreateVmTypeOS.Location = new System.Drawing.Point(113, 70);
            this.Lbl_CreateVmTypeOS.Name = "Lbl_CreateVmTypeOS";
            this.Lbl_CreateVmTypeOS.Size = new System.Drawing.Size(90, 13);
            this.Lbl_CreateVmTypeOS.TabIndex = 9;
            this.Lbl_CreateVmTypeOS.Text = "Type de système:";
            // 
            // Lbl_CreateVmGroup
            // 
            this.Lbl_CreateVmGroup.AutoSize = true;
            this.Lbl_CreateVmGroup.Location = new System.Drawing.Point(113, 45);
            this.Lbl_CreateVmGroup.Name = "Lbl_CreateVmGroup";
            this.Lbl_CreateVmGroup.Size = new System.Drawing.Size(83, 13);
            this.Lbl_CreateVmGroup.TabIndex = 8;
            this.Lbl_CreateVmGroup.Text = "Nom du groupe:";
            // 
            // TxtBox_CreateVmGroup
            // 
            this.TxtBox_CreateVmGroup.Location = new System.Drawing.Point(227, 44);
            this.TxtBox_CreateVmGroup.Name = "TxtBox_CreateVmGroup";
            this.TxtBox_CreateVmGroup.Size = new System.Drawing.Size(298, 20);
            this.TxtBox_CreateVmGroup.TabIndex = 6;
            // 
            // Btn_CreateVmCreer
            // 
            this.Btn_CreateVmCreer.Location = new System.Drawing.Point(544, 13);
            this.Btn_CreateVmCreer.Name = "Btn_CreateVmCreer";
            this.Btn_CreateVmCreer.Size = new System.Drawing.Size(75, 23);
            this.Btn_CreateVmCreer.TabIndex = 5;
            this.Btn_CreateVmCreer.Text = "Créer";
            this.Btn_CreateVmCreer.UseVisualStyleBackColor = true;
            this.Btn_CreateVmCreer.Click += new System.EventHandler(this.Btn_CreateVmCreer_Click);
            // 
            // Lbl_CreateVmName
            // 
            this.Lbl_CreateVmName.AutoSize = true;
            this.Lbl_CreateVmName.Location = new System.Drawing.Point(23, 16);
            this.Lbl_CreateVmName.Name = "Lbl_CreateVmName";
            this.Lbl_CreateVmName.Size = new System.Drawing.Size(137, 13);
            this.Lbl_CreateVmName.TabIndex = 3;
            this.Lbl_CreateVmName.Text = "Nom de la machine à créer:";
            // 
            // TxtBox_CreateVmName
            // 
            this.TxtBox_CreateVmName.Location = new System.Drawing.Point(166, 13);
            this.TxtBox_CreateVmName.Name = "TxtBox_CreateVmName";
            this.TxtBox_CreateVmName.Size = new System.Drawing.Size(298, 20);
            this.TxtBox_CreateVmName.TabIndex = 4;
            // 
            // modifyvm
            // 
            this.modifyvm.Location = new System.Drawing.Point(4, 22);
            this.modifyvm.Name = "modifyvm";
            this.modifyvm.Size = new System.Drawing.Size(735, 197);
            this.modifyvm.TabIndex = 5;
            this.modifyvm.Text = "modifyvm";
            this.modifyvm.UseVisualStyleBackColor = true;
            // 
            // movevm
            // 
            this.movevm.Location = new System.Drawing.Point(4, 22);
            this.movevm.Name = "movevm";
            this.movevm.Size = new System.Drawing.Size(735, 197);
            this.movevm.TabIndex = 6;
            this.movevm.Text = "movevm";
            this.movevm.UseVisualStyleBackColor = true;
            // 
            // import_export
            // 
            this.import_export.Location = new System.Drawing.Point(4, 22);
            this.import_export.Name = "import_export";
            this.import_export.Size = new System.Drawing.Size(735, 197);
            this.import_export.TabIndex = 7;
            this.import_export.Text = "import / export";
            this.import_export.UseVisualStyleBackColor = true;
            // 
            // startvm
            // 
            this.startvm.Controls.Add(this.Btn_StartVM);
            this.startvm.Controls.Add(this.TxtBox_StartVmName);
            this.startvm.Controls.Add(this.Lbl_StartvmName);
            this.startvm.Location = new System.Drawing.Point(4, 22);
            this.startvm.Name = "startvm";
            this.startvm.Size = new System.Drawing.Size(735, 197);
            this.startvm.TabIndex = 8;
            this.startvm.Text = "startvm";
            this.startvm.UseVisualStyleBackColor = true;
            // 
            // Btn_StartVM
            // 
            this.Btn_StartVM.Location = new System.Drawing.Point(518, 22);
            this.Btn_StartVM.Name = "Btn_StartVM";
            this.Btn_StartVM.Size = new System.Drawing.Size(75, 23);
            this.Btn_StartVM.TabIndex = 5;
            this.Btn_StartVM.Text = "Démarre VM";
            this.Btn_StartVM.UseVisualStyleBackColor = true;
            this.Btn_StartVM.Click += new System.EventHandler(this.Btn_StartVM_Click);
            // 
            // TxtBox_StartVmName
            // 
            this.TxtBox_StartVmName.Location = new System.Drawing.Point(215, 22);
            this.TxtBox_StartVmName.Name = "TxtBox_StartVmName";
            this.TxtBox_StartVmName.Size = new System.Drawing.Size(288, 20);
            this.TxtBox_StartVmName.TabIndex = 4;
            // 
            // Lbl_StartvmName
            // 
            this.Lbl_StartvmName.AutoSize = true;
            this.Lbl_StartvmName.Location = new System.Drawing.Point(56, 25);
            this.Lbl_StartvmName.Name = "Lbl_StartvmName";
            this.Lbl_StartvmName.Size = new System.Drawing.Size(153, 13);
            this.Lbl_StartvmName.TabIndex = 3;
            this.Lbl_StartvmName.Text = "Virtual Machine UUID ou Nom:";
            // 
            // controlvm
            // 
            this.controlvm.Location = new System.Drawing.Point(4, 22);
            this.controlvm.Name = "controlvm";
            this.controlvm.Size = new System.Drawing.Size(735, 197);
            this.controlvm.TabIndex = 9;
            this.controlvm.Text = "controlvm";
            this.controlvm.UseVisualStyleBackColor = true;
            // 
            // discardstate_adoptstate
            // 
            this.discardstate_adoptstate.Location = new System.Drawing.Point(4, 22);
            this.discardstate_adoptstate.Name = "discardstate_adoptstate";
            this.discardstate_adoptstate.Size = new System.Drawing.Size(735, 197);
            this.discardstate_adoptstate.TabIndex = 10;
            this.discardstate_adoptstate.Text = "discardstate / adoptstate";
            this.discardstate_adoptstate.UseVisualStyleBackColor = true;
            // 
            // TxtBox_OutputConsole
            // 
            this.TxtBox_OutputConsole.Location = new System.Drawing.Point(4, 242);
            this.TxtBox_OutputConsole.Multiline = true;
            this.TxtBox_OutputConsole.Name = "TxtBox_OutputConsole";
            this.TxtBox_OutputConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBox_OutputConsole.Size = new System.Drawing.Size(735, 295);
            this.TxtBox_OutputConsole.TabIndex = 1;
            // 
            // Lbl_VBoxOutputConsole
            // 
            this.Lbl_VBoxOutputConsole.AutoSize = true;
            this.Lbl_VBoxOutputConsole.Location = new System.Drawing.Point(1, 226);
            this.Lbl_VBoxOutputConsole.Name = "Lbl_VBoxOutputConsole";
            this.Lbl_VBoxOutputConsole.Size = new System.Drawing.Size(150, 13);
            this.Lbl_VBoxOutputConsole.TabIndex = 2;
            this.Lbl_VBoxOutputConsole.Text = "VBoxManage Output Console:";
            // 
            // backgroundWorkerVboxManageCommand
            // 
            this.backgroundWorkerVboxManageCommand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerVboxManageCommand_DoWork);
            this.backgroundWorkerVboxManageCommand.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerVboxManageCommand_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.Lbl_VBoxOutputConsole);
            this.Controls.Add(this.TxtBox_OutputConsole);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Reglages.ResumeLayout(false);
            this.Reglages.PerformLayout();
            this.list.ResumeLayout(false);
            this.showvminfo.ResumeLayout(false);
            this.showvminfo.PerformLayout();
            this.createvm.ResumeLayout(false);
            this.createvm.PerformLayout();
            this.startvm.ResumeLayout(false);
            this.startvm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Reglages;
        private System.Windows.Forms.TabPage list;
        private System.Windows.Forms.TabPage registervm_unregistervm;
        private System.Windows.Forms.TabPage createvm;
        private System.Windows.Forms.TextBox TxtBox_OutputConsole;
        private System.Windows.Forms.Label Lbl_VBoxOutputConsole;
        private System.Windows.Forms.Label Lbl_PathToVBoxManage;
        private System.Windows.Forms.TextBox TxtBox_StrPathToVBoxManage;
        private System.Windows.Forms.Button Btn_FixePathToVBoxManage;
        private System.ComponentModel.BackgroundWorker backgroundWorkerVboxManageCommand;
        private System.Windows.Forms.Button Btn_ListeMachinesVirtuelles;
        private System.Windows.Forms.Button Btn_AfficheMachineEnCoursFonctionnement;
        private System.Windows.Forms.Button Btn_AfficheOSType;
        private System.Windows.Forms.Button Btn_AfficheInfosHote;
        private System.Windows.Forms.Button Btn_AfficheVersion;
        private System.Windows.Forms.TabPage showvminfo;
        private System.Windows.Forms.Button Btn_ShowIdxLog;
        private System.Windows.Forms.TextBox TxtBox_ShowIdxLog;
        private System.Windows.Forms.Label Lbl_ShowIdxLog;
        private System.Windows.Forms.Button Btn_showvminfo_AfficheInfos;
        private System.Windows.Forms.TextBox TxtBox_Showvminfo_UUIDorName;
        private System.Windows.Forms.Label Lbl_showUUIDorName;
        private System.Windows.Forms.CheckBox ChkBox_ShowVmInfoMachineReadable;
        private System.Windows.Forms.CheckBox ChkBoxShowVmInfoDetails;
        private System.Windows.Forms.TabPage modifyvm;
        private System.Windows.Forms.TabPage movevm;
        private System.Windows.Forms.TabPage import_export;
        private System.Windows.Forms.TabPage startvm;
        private System.Windows.Forms.TabPage controlvm;
        private System.Windows.Forms.TabPage discardstate_adoptstate;
        private System.Windows.Forms.Button Btn_StartVM;
        private System.Windows.Forms.TextBox TxtBox_StartVmName;
        private System.Windows.Forms.Label Lbl_StartvmName;
        private System.Windows.Forms.Label Lbl_CreateVmGroup;
        private System.Windows.Forms.TextBox TxtBox_CreateVmGroup;
        private System.Windows.Forms.Button Btn_CreateVmCreer;
        private System.Windows.Forms.Label Lbl_CreateVmName;
        private System.Windows.Forms.TextBox TxtBox_CreateVmName;
        private System.Windows.Forms.Label Lbl_CreateVmTypeOS;
        private System.Windows.Forms.Label Lbl_CreateVmUUID;
        private System.Windows.Forms.Label Lbl_CreateVmFolder;
        private System.Windows.Forms.TextBox TxtBox_CreateVmUUID;
        private System.Windows.Forms.TextBox TxtBox_CreateVmDossierDest;
        private System.Windows.Forms.CheckBox ChkBox_CreateVmRegister;
        private System.Windows.Forms.CheckBox ChkBox_CreateVmDefault;
        private System.Windows.Forms.CheckBox ChkBox_CreateVmUUID;
        private System.Windows.Forms.CheckBox ChkBox_CreateBaseFolder;
        private System.Windows.Forms.CheckBox ChkBox_CreateVmOSType;
        private System.Windows.Forms.CheckBox ChkBox_CreateVmGroups;
        private System.Windows.Forms.ComboBox CmbBox_CreateVmOSType;
    }
}

