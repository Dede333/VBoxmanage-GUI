using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;   // nécessaire pour fonction Process()

namespace VBoxManage_Gui
{
    public partial class FormMain : Form
    {
        String StrPathToVBoxManage= "C:\\Program Files\\Oracle\\VirtualBox\\"; // mémorise chemin vers VBoxManage
        String StrVBoxManageArguments; // arguments passés en ligne de commande
        String StrVBoxManageExitCode;  // code d'erreur retour de fonction
        String StrOutput="";              // sortie de la console

        FormProgress MaFormeProgress = new FormProgress(); // pour instancier la forme progress


        public FormMain()
        {
            InitializeComponent();
            TxtBox_StrPathToVBoxManage.Text = StrPathToVBoxManage; // Initialisation par défaut
        }

        // Permet d'éxécuter une commande VBoxMange
        // Les arguments sont passés à la fonction
        // Révision: 05042020
        //
        private void backgroundWorkerVboxManageCommand_DoWork(object sender, DoWorkEventArgs e)
        {
            String StrArguments = e.Argument.ToString();  // récupère les arguments passés à la fonction
            StrVBoxManageExitCode = "";                   // pour le code de retour de la fonction
            Process VBoxManage = new Process();
            VBoxManage.StartInfo.RedirectStandardOutput = true; // redirection sortie standard
            VBoxManage.StartInfo.RedirectStandardError = true;  // idem pour la sortie erreurs
            VBoxManage.StartInfo.UseShellExecute = false;       // pas de shell
            VBoxManage.StartInfo.CreateNoWindow = true;         // pas de fenêtre
            VBoxManage.StartInfo.FileName = StrPathToVBoxManage + "VBoxManage.exe";    // fichier VBoxManage à éxécuter
            VBoxManage.StartInfo.Arguments = StrArguments;      // arguments passés à la fonction
            StrOutput = "Exécution de la ligne de commande: VBoxManage.exe " + VBoxManage.StartInfo.Arguments + "\r\n\r\n"; // visualise la commande complète
            VBoxManage.Start();                                 // exécution de la commande
            StrOutput = StrOutput + VBoxManage.StandardOutput.ReadToEnd(); // affiche tous les caractères jusqu'a fin de commande
            VBoxManage.WaitForExit();                           // Attends la fin d'éxécution
            StrVBoxManageExitCode = VBoxManage.ExitCode.ToString();  // code de retour de la fonction
            TxtBox_OutputConsole.Text = TxtBox_OutputConsole.Text + StrOutput;              // mise à jour du résultat de la commande
        }

        // Permet d'afficher toutes les machine(s) virtuelle(s) présentes dans l'environnement
        // Révision: 05042020
        //
        private void Btn_ListeMachinesVirtuelles_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            StrVBoxManageArguments = "list vms";  // affiche l'ensemble des vms
            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
            // TxtBox_OutputConsole.Text = StrOutput; // prob asynchrone affichage...
        }

        // Permet d'afficher toutes les machine(s) virtuelle(s) en cours de fonctionnement
        // dans l'environnement VirtualBox
        // Révision: 05042020
        //
        private void Btn_AfficheMachineEnCoursFonctionnement_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            StrVBoxManageArguments = "list runningvms";  // liste machine en cours de fonctionnement
            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
        }

        // Permet d'afficher la liste des type d'OS pris en charge dans l'environnement
        // VirtualBox
        // Révision: 05042020
        //
        private void Btn_AfficheOSType_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            StrVBoxManageArguments = "list ostypes";  // liste des OS pris en charge
            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
        }

        // Permet d'afficher les informations de l'hôte
        // VirtualBox
        // Révision: 05042020
        //
        private void Btn_AfficheInfosHote_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            StrVBoxManageArguments = "list hostinfo";  // Information sur l'hôte
            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
        }

        // Permet d'afficher les caractéristiques d'une VM
        // Révision: 05042020
        //
        private void Btn_showvminfo_AfficheInfos_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            if (TxtBox_Showvminfo_UUIDorName.Text != "")
            {
                StrVBoxManageArguments = "showvminfo " + "\"" + TxtBox_Showvminfo_UUIDorName.Text + "\"";  // Information sur l'hôte
                if (ChkBoxShowVmInfoDetails.Checked == true) StrVBoxManageArguments = StrVBoxManageArguments + " --details";
                if (ChkBox_ShowVmInfoMachineReadable.Checked == true) StrVBoxManageArguments = StrVBoxManageArguments + " --machinereadable";
                backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
                MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
            }
        }
        
        // Permet d'afficher les informations sur l'hôte
        // Révision: 05042020
        //
        private void Btn_ShowIdxLog_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            if (TxtBox_Showvminfo_UUIDorName.Text != "")
            {
                StrVBoxManageArguments = "showvminfo " + "\"" + TxtBox_Showvminfo_UUIDorName.Text + "\"" + " --log " + TxtBox_ShowIdxLog.Text;  // Information sur l'hôte
                backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
                MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter            
            }
        }

        // Actions après la fin de l'éxécution d'une commande VBoxManage
        // Révision: 05042020
        //
        private void backgroundWorkerVboxManageCommand_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MaFormeProgress.Close();  // ferme la forme MaFormeProgress
        }

        // Affiche la version installé de VirtualBox
        // Révision: 05042020
        //
        private void Btn_AfficheVersion_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            StrVBoxManageArguments = "--version";  // Information sur l'hôte
            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
        }

        // Démarre la machine virtuelle spécifiée
        // Révision: 05042020
        //
        private void Btn_StartVM_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            if (TxtBox_StartVmName.Text != "")
            {
                StrVBoxManageArguments = "startvm " + "\"" + TxtBox_StartVmName.Text + "\"";  // démarre la vm spécifiée
                if (ChkBox_StartVmType.Checked == true)
                    StrVBoxManageArguments = StrVBoxManageArguments + " --type " + CmbBox_StartVmType.SelectedItem.ToString();
                //MessageBox.Show(StrVBoxManageArguments);
                backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
                MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
            }
            
        }

        // Permet de créer une machine virtuelle
        // Révision: 05042020
        //
        private void Btn_CreateVmCreer_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            StrVBoxManageArguments = "createvm --name " + "\"" + TxtBox_CreateVmName.Text + "\"";  // création d'une vm
            
            if (ChkBox_CreateVmGroups.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + " --groups " + "\"" + TxtBox_CreateVmGroup.Text + "\"";
            if (ChkBox_CreateVmOSType.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + " --ostype " + "\"" + CmbBox_CreateVmOSType.SelectedItem.ToString() + "\"";
            if (ChkBox_CreateVmRegister.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + " --register ";
            if (ChkBox_CreateBaseFolder.Checked ==true)
                StrVBoxManageArguments = StrVBoxManageArguments + " --basefolder " + "\"" + TxtBox_CreateVmDossierDest.Text + "\"";
            if (ChkBox_CreateVmUUID.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + " --uuid " + "\"" + TxtBox_CreateVmUUID.Text + "\"";
            if (ChkBox_CreateVmDefault.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + " --default ";

            // MessageBox.Show(StrVBoxManageArguments);  // afin de vérifier la commande

            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
        }

        // Permet de modifier la variable StrPathToVBoxManage par défaut
        // Dans le cas ou il y aurait des changements...
        // Le chemin par défaut est : C:\Program Files\Oracle\VirtualBox\
        // L'utilisateur peut ainsi le modifier éventuellement
        // Révision 12/04/2020
        //
        private void Btn_FixePathToVBoxManage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dossier = new FolderBrowserDialog();
            if (Dossier.ShowDialog() == DialogResult.OK)
            {
                StrPathToVBoxManage = Dossier.SelectedPath + "\\";  // mémorise le chemin
                TxtBox_StrPathToVBoxManage.Text = StrPathToVBoxManage; // mise à jour contrôle associé
            }
                
        }
        // Permet de sélectionner un fichier vbox à enregistrer dans l'environnement virtualbox
        // Révision: 12/04/2020
        // 
        private void Btn_RegisterVmChoixFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog MonFileDialogue = new OpenFileDialog();
            MonFileDialogue.InitialDirectory = "c:";  // répertoire c: par défaut
            MonFileDialogue.Title = "Choisir un fichier d'extension vbox:";
            MonFileDialogue.Filter = ("Fichier vbox (*.vbox) | *.vbox"); // extension de fichier vbox
            if (MonFileDialogue.ShowDialog() == DialogResult.OK)
            {
                TxtBox_RegisterVmFilename.Text = MonFileDialogue.FileName; // Maj contrôle associé
            }
        }

        // Permet d'enregistrer la machine virtuelle dans l'environnement VirtualBox
        // le fichier VirtualBox.XML du dossier cacher .VirtualBox de l'utilisateur courant
        // sera mis à jour
        // Révision: 12/04/2020
        //
        private void Btn_RegisterVm_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            if (TxtBox_RegisterVmFilename.Text != "")
            {
                StrVBoxManageArguments = "registervm " + "\"" + TxtBox_RegisterVmFilename.Text + "\"";  // enregistre la vm
                //MessageBox.Show(StrVBoxManageArguments);
                backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
                MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
            }
        }

        // Permet de désenregistrer la machine virtuelle dans l'environnement VirtualBox
        //  Attention: l'option --delete ne fonctionne que si la machine est bien enregistrée
        // le fichier VirtualBox.XML du dossier cacher .VirtualBox de l'utilisateur courant
        // sera mis à jour
        // Révision: 12/04/2020
        //
        private void Btn_UnregisterVm_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            if (TxtBox_UnregisterVmUUIDorFilename.Text != "")
            {
                StrVBoxManageArguments = "unregistervm " + "\"" + TxtBox_UnregisterVmUUIDorFilename.Text + "\"";  // enregistre la vm
                if (ChkBox_UnregisterVmDelete.Checked == true)
                    StrVBoxManageArguments = StrVBoxManageArguments + " --delete";
                //MessageBox.Show(StrVBoxManageArguments);
                backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
                MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
            }
        }

        // Permet de choisir le dossier cible où la machine sera déplacée
        // Révision: 12/04/2020
        //
        private void Btn_MoveVmChoixDossierCible_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dossier = new FolderBrowserDialog();
            if (Dossier.ShowDialog() == DialogResult.OK)
                TxtBox_MoveVmDossierCible.Text = Dossier.SelectedPath; // mise à jour contrôle associé
        }

        // permet de déplacer une machine virtuelle d'un dossier vers un autre
        // le fichier VirtualBox.XML du dossier cacher .VirtualBox de l'utilisateur courant
        // sera mis à jour
        // Révision: 12/04/2020
        //
        private void Btn_DeplaceVm_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            if (TxtBox_MoveVmDossierCible.Text != "")
            {
                StrVBoxManageArguments = "movevm " + "\"" + TxtBox_MoveVmUUIDorName.Text + "\"" + " --folder ";
                StrVBoxManageArguments = StrVBoxManageArguments + "\"" + TxtBox_MoveVmDossierCible.Text + "\"";
                if (ChkBox_MoveVmType.Checked == true)
                    StrVBoxManageArguments = StrVBoxManageArguments + " --type basic";
                //MessageBox.Show(StrVBoxManageArguments);
                backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
                MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
            }
        }

        // permet d'afficher les informations concernant un type de media
        // Révision: 13/04/2020
        //
        private void Btn_ShowMediumInfo_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";
            if (CmbBox_ShowMediumInfoType.Text == "" || TxtBox_ShowMediumInfoUUIDorName.Text == "")
            {
                MessageBox.Show("Vous devez renseigner l'ensemble des champs avant de lancer la commande !");
            }
            else
            {
                StrVBoxManageArguments = "showmediuminfo " + CmbBox_ShowMediumInfoType.SelectedItem.ToString() + " ";
                StrVBoxManageArguments = StrVBoxManageArguments + "\"" + TxtBox_ShowMediumInfoUUIDorName.Text + "\"";
                //MessageBox.Show(StrVBoxManageArguments);
                backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
                MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
            }
        }

        // Permet de sélectionne un nom de fichier média
        // attention à la conception du filtre bien mettre le pipe '|' coller sans espace
        // sinon le filtre ne fonctionnera pas correctement !!
        // Révision: 12/04/2020
        //
        private void Btn_ShowMediumInfoChoix_Click(object sender, EventArgs e)
        {
            OpenFileDialog MonFileDialogue = new OpenFileDialog();
            MonFileDialogue.InitialDirectory = "c:";  // répertoire c: par défaut
            MonFileDialogue.Title = "Choisir un fichier média:";
            MonFileDialogue.Filter = ("Fichier (*.vdi)|*.vdi|Fichier (*.vmdk)|*.vmdk|Fichier (*.vhd)|*.vhd|Fichier (*.*)|*.*"); // extension de fichier vbox
            if (MonFileDialogue.ShowDialog() == DialogResult.OK)
            {
                TxtBox_ShowMediumInfoUUIDorName.Text = MonFileDialogue.FileName; // Maj contrôle associé
            }
        }

        // Permet de choisir le dossier qui va recevoir la nouvelle machine crée
        // Révision: 13/04/2020
        //

        private void Btn_CreateVmDossierCible_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dossier = new FolderBrowserDialog();
            if (Dossier.ShowDialog() == DialogResult.OK)
                TxtBox_CreateVmDossierDest.Text = Dossier.SelectedPath; // mise à jour contrôle associé
        }

        // Permet de créer un média
        // Révision: 13/04/2020
        //
        private void Btn_CreateMediumCreerMedia_Click(object sender, EventArgs e)
        {
            TxtBox_OutputConsole.Text = "";

            StrVBoxManageArguments = "createmedium " + CmbBox_CreateMediumType.SelectedItem.ToString() + " ";
            StrVBoxManageArguments = StrVBoxManageArguments + "--filename " + "\"" + TxtBox_CreateMediumNomFichier.Text + "\" ";
            if (ChkBox_CreateMediumSizeMega.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + "--size " + TxtBox_CreateMediumSizeMegaByte.Text + " ";
            if (ChkBox_CreateMediumSizeByte.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + "--sizebyte " + TxtBox_CreateMediumSizeByte.Text + " ";
            if (ChkBox_CreateMediumDiffParent.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + "--diffparent " + TxtBox_CreateMediumUUIDorFileName.Text + " ";
            if (ChkBox_CreateMediumFormat.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + "--format " + CmbBox_CreateMediumFormat.SelectedItem.ToString() + " ";
            if (ChkBox_CreateMediumVariant.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + "--variant " + CmbBox_CreateMediumVariant.SelectedItem.ToString() + " ";
            if (ChkBox_CreateMediumProperty.Checked == true)
                StrVBoxManageArguments = StrVBoxManageArguments + "--property " + TxtBox_CreateMediumProperty.Text;

            //MessageBox.Show(StrVBoxManageArguments);
            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
        }
    }
}

