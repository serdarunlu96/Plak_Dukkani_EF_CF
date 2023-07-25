using Microsoft.VisualBasic.ApplicationServices;
using Plak_Dukkani.Context;
using Plak_Dukkani.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Plak_Dukkani

{

    public partial class AlbumManagement : Form

    {
        private readonly Admin admin;
        PlakDukkaniDbContext db = new PlakDukkaniDbContext();

        public AlbumManagement(Admin admin)
        {

            InitializeComponent();
            this.admin = admin;
            ListAlbums();
        }

        private void ListAlbums()
        {

            dgvAlbumList.DataSource = null;

            dgvAlbumList.DataSource = db.Albums.ToList();

            dgvAlbumList.Columns[7].Visible = false;

            dgvAlbumList.Refresh();

            LoadAlbums();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Album album = new Album();

                if (txtName.Text == "")
                {
                    MessageBox.Show("Album Name cannot be empty!");
                }
                else
                {
                    album.AlbumName = txtName.Text;
                }

                if (txtSinger.Text == "")
                {
                    MessageBox.Show("Singer Name cannot be empty!");
                }
                else
                {
                    album.Singer = txtSinger.Text;
                }

                if (txtPrice.Text == "")
                {
                    
                    MessageBox.Show("Price cannot be empty!");
                }
                else
                {
                    album.Price = Convert.ToDouble(txtPrice.Text);
                }

                if (txtDiscount.Text == "")
                {
                   
                    MessageBox.Show("Discount cannot be empty!");
                }
                else
                {
                    album.Discount = Convert.ToDouble(txtDiscount.Text);
                }

                if (cmbStatus.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Please Select Status!");
                }
                else
                {
                    album.Status = cmbStatus.SelectedItem.ToString();
                }

                album.Date = dtpDate.Value;

                db.Albums.Add(album);

                db.SaveChanges();

                ListAlbums();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please provide all necessary informations! " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            } 

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (dgvAlbumList.SelectedRows.Count > 0)
            {
                int selectedAlbumId = Convert.ToInt32(dgvAlbumList.SelectedRows[0].Cells["Id"].Value);

                var album = db.Albums.Find(selectedAlbumId);

                if (album != null)
                {
                    db.Albums.Remove(album);
                    db.SaveChanges();
                    ListAlbums();
                }
            }
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            if (dgvAlbumList.SelectedRows.Count > 0)
            {
                int selectedAlbumId = Convert.ToInt32(dgvAlbumList.SelectedRows[0].Cells["Id"].Value);

                var album = db.Albums.Find(selectedAlbumId);

                if (album != null)
                {
                    album.AlbumName = txtName.Text;
                    album.Singer = txtSinger.Text;
                    album.Price = Convert.ToDouble(txtPrice.Text);
                    album.Discount = Convert.ToDouble(txtDiscount.Text.ToString());
                    album.Date = dtpDate.Value;
                    album.Status = cmbStatus.SelectedItem.ToString();

                    db.SaveChanges();
                    ListAlbums();
                }
            }
        }

        private void LoadAlbums()
        {
            var albums = db.Albums.ToList();

            dgvOutofSaleAlbums.DataSource = albums.Where(x => x.Status == "No").Select(a => new { a.AlbumName, a.Singer }).ToList();

            dgvOngoingAlbums.DataSource = albums.Where(a => a.Status == "Yes").Select(a => new { a.AlbumName, a.Singer }).ToList();

            dgvTopTenAlbums.DataSource = albums.OrderByDescending(a => a.Id).Take(10).Select(a => new { a.AlbumName, a.Singer }).ToList();

            dgvDiscountAlbums.DataSource = albums.Where(a => a.Discount > 0).OrderByDescending(a => a.Discount).Select(a => new { a.AlbumName, a.Singer }).ToList();
        }
    }
}
