using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormAgents : Form
    {
        public FormAgents()
        {
            InitializeComponent();
            ShowAgent();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentsSet agentsSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                    agentsSet.FirstName = textBoxFirstName.Text;
                    agentsSet.MiddleName = textBoxMiddleName.Text;
                    agentsSet.LastName = textBoxLastName.Text;
                    if (textBoxDealShare.Text != "") { agentsSet.DealShare = Convert.ToInt32(textBoxDealShare.Text); }
                    if ((agentsSet.DealShare < 0) || (agentsSet.DealShare > 100))
                    {
                        throw new Exception("Доля должна находиться в диапазоне от 0 до 100");
                    }
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }
            }
            catch (Exception expection)
            {
                MessageBox.Show(expection.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentsSet agentsSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                textBoxFirstName.Text= agentsSet.FirstName ;
                textBoxMiddleName.Text=agentsSet.MiddleName ;
                textBoxLastName.Text= agentsSet.LastName ;
                if (textBoxDealShare.Text!= "") { agentsSet.DealShare = Convert.ToInt32(textBoxDealShare.Text); }
                textBoxDealShare.Text = agentsSet.DealShare.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
        }
        void ShowAgent()
        {
            //предварительно очищаем lastView
            listViewAgent.Items.Clear();
            //проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (AgentsSet agentsSet in Program.wftDb.AgentsSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentsSet.Id.ToString(), agentsSet.FirstName, agentsSet.MiddleName,
                   agentsSet.LastName, agentsSet.DealShare.ToString()
                }) ;
                //указываем по какому тегу будем брать элементы
                item.Tag = agentsSet;
                //добавляем элементы в listView для отображения
                listViewAgent.Items.Add(item);
            }
            //выравниваем колонки 
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AgentsSet agentsSet = new AgentsSet();
                //делаем ссылку на объект, который хранится в textBox-ax
                agentsSet.FirstName = textBoxFirstName.Text;
                agentsSet.MiddleName = textBoxMiddleName.Text;
                agentsSet.LastName = textBoxLastName.Text;
                if (textBoxDealShare.Text != "") { agentsSet.DealShare = Convert.ToInt32(textBoxDealShare.Text); }
                if ((agentsSet.DealShare < 0) || (agentsSet.DealShare > 100))
                {
                    throw new Exception("Доля должна находиться в диапазоне от 0 до 100");
                }
                Program.wftDb.AgentsSet.Add(agentsSet);
                //сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                ShowAgent();
            }
            catch (Exception expection)
            {
                MessageBox.Show(expection.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentsSet agentsSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                    Program.wftDb.AgentsSet.Remove(agentsSet);
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDealShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
