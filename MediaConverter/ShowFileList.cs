using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaConverter
{
    public partial class ShowFileList : Form
    {

        public ShowFileList()
        {
            InitializeComponent();
        }

        public int Add(int Id = 0, string Name = "", Boolean BatchType = false,
            String Status = "Waiting", Boolean Dummy = false, Boolean IsDeleted = false)
        {
            Name = System.IO.Path.GetFileNameWithoutExtension(Name);

            AllDataGridView.Rows.Add(Id, Name, BatchType, Status, Dummy, IsDeleted);
            AllDataGridView.Update();

            return 0;
        }

        public void Update(ControlFiles controlFiles)
        {
            UpdateAllListData(controlFiles);
            UpdateDeletedData(controlFiles);
        }

        public void UpdateAllListData(ControlFiles controlFiles)
        {
            List<FilesForCovert> lp;
            lp = controlFiles.GetMatchList(p => true);

            AllDataGridView.Rows.Clear();

            foreach (var v in lp)
            {
                AllDataGridView.Rows.Add(v.Id, v.GetBasename(),
                    v.Status, v.IsDeleted, v.IsDummy, v.IsDeleted);
            }

            AllDataGridView.Update();
        }

        public int UpdateDeletedData(ControlFiles controlFiles)
        {
            List<FilesForCovert> lp;
            lp = controlFiles.GetMatchList(p => p.IsDeleted == true);

            DeleteDataGridView.Rows.Clear();

            foreach (var v in lp) {
                DeleteDataGridView.Rows.Add(v.Id, v.GetBasename(), v.Status, v.IsDeleted,v.IsDummy);
            }

            DeleteDataGridView.Update();

            return 0;
        }
    }
}
