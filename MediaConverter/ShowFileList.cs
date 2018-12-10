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

        public int Update(int Id = 0, string Name = "", Boolean BatchType = false,
            String Status = "Waiting", Boolean Dummy = false)
        {
            dataGridView1.Rows.Add(Id, Name, BatchType, Status, Dummy);
            dataGridView1.Update();

            return 0;
        }
    }
}
