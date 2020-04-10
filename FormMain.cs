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
            String StrArguments = e.Argument.ToString();
            StrVBoxManageExitCode = "";
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
            TxtBox_OutputConsole.Text = StrOutput;              // mise à jour du résultat de la commande
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
            StrVBoxManageArguments = "startvm " + "\"" + TxtBox_StartVmName.Text + "\"";  // démarre la vm spécifiée
            backgroundWorkerVboxManageCommand.RunWorkerAsync(StrVBoxManageArguments);
            MaFormeProgress.ShowDialog();         // affiche la forme MaFormeProgress pour patienter
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
    }
}

