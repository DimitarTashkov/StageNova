using System.Drawing;
using System.Windows.Forms;

namespace StageNova.Utilities
{
    public static class MenuHelper
    {
        private static readonly Color MenuBackColor = Color.FromArgb(30, 15, 30);
        private static readonly Color MenuForeColor = Color.FromArgb(225, 200, 160);

        public static void ApplyMenuLabels(
            ToolStripMenuItem home,
            ToolStripMenuItem vehicles,
            ToolStripMenuItem store,
            ToolStripMenuItem myReservations,
            ToolStripMenuItem users,
            ToolStripMenuItem management,
            ToolStripMenuItem manageProducts,
            ToolStripMenuItem manageVehicles)
        {
            home.Text = "Home";
            vehicles.Text = "Repertoire";
            store.Text = "Merchandise";
            myReservations.Text = "My Bookings";
            users.Text = "Users";
            management.Text = "Management";
            manageProducts.Text = "Merchandise";
            manageVehicles.Text = "Plays";

            var menuStrip = home.Owner as MenuStrip;
            if (menuStrip != null)
            {
                menuStrip.BackColor = MenuBackColor;
                menuStrip.ForeColor = MenuForeColor;
                menuStrip.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }

            foreach (var item in new[] { home, vehicles, store, myReservations, users, management })
            {
                item.ForeColor = MenuForeColor;
                item.BackColor = Color.Transparent;
            }

            manageProducts.ForeColor = MenuForeColor;
            manageProducts.BackColor = MenuBackColor;
            manageVehicles.ForeColor = MenuForeColor;
            manageVehicles.BackColor = MenuBackColor;
        }
    }
}
