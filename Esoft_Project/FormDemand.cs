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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowAgents();
            ShowClients();
            ShowDemandSet();
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewApartment.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                textBoxMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMaxFloor.Visible = true;

                listViewLand.Visible = false;
                listViewHouse.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewHouse.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                listViewApartment.Visible = false;
                listViewLand.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
            else
            {
                listViewLand.Visible = true;
                labelRealEstate.Visible = true;
                comboBoxType.Visible = true;
                labelMinArea.Visible = true;
                textBoxMinArea.Visible = true;
                labelMaxArea.Visible = true;
                textBoxMaxArea.Visible = true;

                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                listViewApartment.Visible = false;
                listViewHouse.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.wftDb.AgentsSet)
            {
                string[] item = { agentsSet.Id.ToString() + ".", agentsSet.FirstName, agentsSet.MiddleName, agentsSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
           try     
           {
                if (comboBoxAgents.SelectedItem != null && comboBoxClient != null && comboBoxType != null)
                {
                    DemandSet demand = new DemandSet();
                    if (comboBoxAgents != null) { demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]); }
                    if (comboBoxClient != null) { demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]); }
                    if (textBoxMinPrice.Text != "") { demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text); }
                    if (textBoxMaxPrice.Text != "") { demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text); }
                    if (comboBoxType.SelectedIndex == 0)
                    { 
                            demand.Type = 0;
                            if (textBoxMinArea.Text != "") { demand.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                            if (textBoxMaxArea.Text != "") { demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                            if (textBoxMinFloor.Text != "") { demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text); }
                            if (textBoxMaxFloor.Text != "") { demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text); }
                            if (textBoxMinRooms.Text != "") { demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                            if (textBoxMaxRooms.Text != "") { demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                    }
                        else if (comboBoxType.SelectedIndex == 1)
                        {
                            demand.Type = 1;
                            if (textBoxMinArea.Text != "") { demand.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                            if (textBoxMaxArea.Text != "") { demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                            if (textBoxMinFloors.Text != "") { demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                            if (textBoxMaxFloors.Text != "") { demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                        }
                        else
                        {
                            demand.Type = 2;
                            if (textBoxMinArea.Text != "") { demand.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                            if (textBoxMaxArea.Text != "") { demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                        }
                        Program.wftDb.DemandSet.Add(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                }
                else MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
                catch
                { MessageBox.Show("Не верно выбраны данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        void ShowDemandSet()
        {
            listViewApartment.Items.Clear();
            listViewHouse.Items.Clear();
            listViewLand.Items.Clear();
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    demand.IdAgent.ToString(),
                    demand.AgentsSet.LastName+" "+ demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                    demand.IdClient.ToString(),
                    demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MiddleName,
                    demand.Type.ToString(),
                    "квартира",
                    demand.MinPrice.ToString(),
                    demand.MaxPrice.ToString(),
                    demand.MinRooms.ToString(),
                    demand.MaxRooms.ToString(),
                    demand.MinArea.ToString(),
                    demand.MaxArea.ToString(),
                    demand.MinFloor.ToString(),
                    demand.MaxFloor.ToString()
                }); ;
                    item.Tag = demand;
                    listViewApartment.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    demand.IdAgent.ToString(),
                    demand.AgentsSet.LastName+" "+ demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                    demand.IdClient.ToString(),
                    demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MiddleName,
                    demand.Type.ToString(),
                    "дом",
                    demand.MinPrice.ToString(),
                    demand.MaxPrice.ToString(),
                    demand.MinArea.ToString(),
                    demand.MaxArea.ToString(),
                    demand.MinFloors.ToString(),
                    demand.MaxFloors.ToString()
                });
                    item.Tag = demand;
                    listViewHouse.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                        demand.IdAgent.ToString(),
                    demand.AgentsSet.LastName+" "+ demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                    demand.IdClient.ToString(),
                    demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MiddleName,
                    demand.Type.ToString(),
                    "земля",
                    demand.MinPrice.ToString(),
                    demand.MaxPrice.ToString(),
                    demand.MinArea.ToString(),
                    demand.MaxArea.ToString(),
                        });
                    item.Tag = demand;
                    listViewLand.Items.Add(item);
                }
            }
            listViewApartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewApartment.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxAgents.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewHouse.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewHouse.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxAgents.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else
                {
                    if (listViewLand.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewLand.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxAgents.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listViewApartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApartment.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinFloor.Text = demand.MinFloor.ToString();
                textBoxMaxFloor.Text = demand.MaxFloor.ToString();
                textBoxMinRooms.Text = demand.MinRooms.ToString();
                textBoxMaxRooms.Text = demand.MaxRooms.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
            }
        }
        private void listViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLand.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewLand.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }

        private void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewHouse.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinFloors.Text = demand.MinFloors.ToString();
                textBoxMaxFloors.Text = demand.MaxFloors.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAgents.SelectedItem != null && comboBoxClient != null && comboBoxType != null)
                {
                    if (comboBoxType.SelectedIndex == 0)
                    {
                        if (listViewApartment.SelectedItems.Count == 1)
                        {
                            DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                            if (comboBoxAgents != null) { demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]); }
                            if (comboBoxClient != null) { demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]); }
                            if (textBoxMinPrice.Text != "") { demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text); }
                            if (textBoxMaxPrice.Text != "") { demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text); }
                            if (textBoxMinArea.Text != "") { demand.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                            if (textBoxMaxArea.Text != "") { demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                            if (textBoxMinFloor.Text != "") { demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text); }
                            if (textBoxMaxFloor.Text != "") { demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text); }
                            if (textBoxMinRooms.Text != "") { demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                            if (textBoxMaxRooms.Text != "") { demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                            Program.wftDb.SaveChanges();
                            ShowDemandSet();
                        }
                    }
                    else if (comboBoxType.SelectedIndex == 1)
                    {
                        if (listViewHouse.SelectedItems.Count == 1)
                        {
                            DemandSet demand = listViewHouse.SelectedItems[0].Tag as DemandSet;
                            if (comboBoxAgents != null) { demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]); }
                            if (comboBoxClient != null) { demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]); }
                            if (textBoxMinPrice.Text != "") { demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text); }
                            if (textBoxMaxPrice.Text != "") { demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text); }
                            if (textBoxMinArea.Text != "") { demand.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                            if (textBoxMaxArea.Text != "") { demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                            if (textBoxMinFloors.Text != "") { demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                            if (textBoxMaxFloors.Text != "") { demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                            Program.wftDb.SaveChanges();
                            ShowDemandSet();

                        }
                    }
                    else
                    {
                        if (listViewLand.SelectedItems.Count == 1)
                        {
                            DemandSet demand = listViewLand.SelectedItems[0].Tag as DemandSet;
                            if (comboBoxAgents != null) demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                            if (comboBoxClient!=null) demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                            if (textBoxMinPrice.Text != "") { demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text); }
                            if (textBoxMaxPrice.Text != "") { demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text); }
                            if (textBoxMinArea.Text != "") { demand.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                            if (textBoxMaxArea.Text != "") { demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                            Program.wftDb.SaveChanges();
                            ShowDemandSet();
                        }
                    }
                }
                else
                { MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch
            { MessageBox.Show("Невереные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
    }
}
