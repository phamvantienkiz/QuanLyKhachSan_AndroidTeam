using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_AndroidTeam
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            uC_Reservations1.Visible = false;
            uC_ServiceDetail1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Employees1.Visible = false;
            uC_Rooms1.Visible = false;
            uC_Service1.Visible = false;
            uC_PayBills1.Visible = false;
            btnReservations.PerformClick();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomers.Left + 25;
            uC_Customers1.Visible = true;
            uC_Customers1.BringToFront();
        }

        private void btnEmlyees_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnEmlyees.Left + 26;
            uC_Employees1.Visible = true;
            uC_Employees1.BringToFront();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnRooms.Left + 28;
            uC_Rooms1.Visible = true;
            uC_Rooms1.BringToFront();
        }

        private void btnPayBills_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnPayBills.Left + 26;
            uC_PayBills1.Visible = true;
            uC_PayBills1.BringToFront();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnReservations.Left + 20;
            uC_Reservations1.Visible = true;
            uC_Reservations1.BringToFront();
        }

        private void btnServiceDetail_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnServiceDetail.Left + 26;
            uC_ServiceDetail1.Visible = true;
            uC_ServiceDetail1.BringToFront();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnService.Left + 26;
            uC_Service1.Visible = true;
            uC_Service1.BringToFront();
        }


    }
}
