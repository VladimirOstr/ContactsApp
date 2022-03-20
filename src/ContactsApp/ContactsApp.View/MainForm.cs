using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            FileContextMenuStrip.Items.Clear();
            FileContextMenuStrip.Items.Add("Exit");

            FileContextMenuStrip.Show(FileButton, new Point(0, FileButton.Height));
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SurnameTextBox.Text = "Иван";
            NameTextBox.Text = "Иванов";
            BirthdayTimePicker.Value = new DateTime(2001,3,7);
            PhoneTextBox.Text = "+79185634152";
            EmailTextBox.Text = "ivan.ivanov@mail.ru";
            VkTextBox.Text = "id203534";
            InfoGroupBox.Visible = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContextMenuStrip.Items.Clear();
            EditContextMenuStrip.Items.Add("Add Contact");
            EditContextMenuStrip.Items.Add("Edit Contact");
            EditContextMenuStrip.Items.Add("Remove Contact");

            EditContextMenuStrip.Show(EditButton, new Point(0, EditButton.Height));
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpContextMenuStrip.Items.Clear();
            HelpContextMenuStrip.Items.Add("About");

            HelpContextMenuStrip.Show(HelpButton, new Point(0, HelpButton.Height));
        }

    }
}
