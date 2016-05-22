using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Filesplit
{
    public partial class frmMain : Form
    {
        private Work currentIns = null;

        public frmMain()
        {
            InitializeComponent();
            currentIns = new Work();
            currentIns.ProgressChanged += CurrentWork_ProgressChanged;
            currentIns.CurrentProgressChanged += CurrentWork_CurrentProgressChanged;
            currentIns.IsReady += CurrentIns_IsReady;
        }

        private void CurrentIns_IsReady()
        {
            this.setState(true);
        }

        private void setState(bool state)
        {
            this.grp2.Invoke(new Action(() => { this.grp2.Enabled = state; }));
            this.grpSplit.Invoke(new Action(() => { this.grpSplit.Enabled = state; }));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
                    
        }

        private void CurrentWork_CurrentProgressChanged(double prg)
        {
            this.prgCurrent.Invoke(new Action(() => {
                this.prgCurrent.Value = Convert.ToInt32(prg * 100.0);
            }));
        }

        private void CurrentWork_ProgressChanged(double prg)
        {
            this.prgFinal.Invoke(new Action(() => {
                this.prgFinal.Value = Convert.ToInt32(prg * 100.0);
            }));
        }

        private void btnPutFileTogether_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, Title = "Choose all files!" })
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Title = "Choose the target file" })
                {
                    if (sfd.ShowDialog(this) == DialogResult.OK && ofd.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            this.setState(false);
                            currentIns.DoWork(Work.Action.PutTogheter, ofd.FileNames, sfd.FileName);
                        }
                        catch (Exception ef)
                        {
                            MessageBox.Show(this, "There is problem occured: " + ef.Message, "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void btnSplt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                using (FolderBrowserDialog fld = new FolderBrowserDialog())
                {
                    if (ofd.ShowDialog(this) == DialogResult.OK && fld.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            this.setState(false);
                            currentIns.DoWork(Work.Action.Split, null, ofd.FileName, fld.SelectedPath, (long)numFileSize.Value * 1024L * 1024L);
                        }
                        catch (Exception ef)
                        {
                            MessageBox.Show(this, "There is problem occured: " + ef.Message, "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

    }
}
