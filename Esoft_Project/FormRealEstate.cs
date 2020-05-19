using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstateSet();
        }

        private void FormRealEstate_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                listViewRealEstateSet_Land.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";

            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";

            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewRealEstateSet_Land.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";

            }

        }
        void ShowRealEstateSet()
        {
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            foreach (RealEstateSet realEstate in Program.wftDb.RealEstateSet)
            {
                if (realEstate.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(), realEstate.Coordinate_longitude.ToString(),
                        realEstate.TotalArea.ToString(),realEstate.Rooms.ToString(), realEstate.Floor.ToString()
                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                else if (realEstate.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(), realEstate.Coordinate_longitude.ToString(),
                        realEstate.TotalArea.ToString(), realEstate.TotalFloors.ToString()

                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(), realEstate.Coordinate_longitude.ToString(),
                        realEstate.TotalArea.ToString()
                });
                    item.Tag = realEstate;
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                textBoxFloor.Text = realEstate.Floor.ToString();
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
        }
        private void listViewRealEstateSet_Land_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void listViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_House.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxTotalFloors.Text = realEstate.TotalFloors.ToString();
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxTotalArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_House_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void textBoxAddress_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCoordinate_latitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number !=45)
            {
                e.Handled = true;
            }
        }

        private void textBoxCoordinate_longitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textBoxTotalArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxRooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxTotalFloors_KeyPress(object sender, KeyPressEventArgs e)
        {
           char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                RealEstateSet realEstate = new RealEstateSet();
                if (textBoxAddress_City.Text != "") { realEstate.Address_City = textBoxAddress_City.Text; }
                if (textBoxAddress_House.Text != "") { realEstate.Address_House = textBoxAddress_House.Text; }
                if (textBoxAddress_Street.Text != "") { realEstate.Address_Street = textBoxAddress_Street.Text; }
                if (textBoxAddress_Number.Text != "") { realEstate.Address_Number = textBoxAddress_Number.Text; }
                if (textBoxCoordinate_latitude.Text != "") { realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text); }
                if (textBoxCoordinate_longitude.Text != "") { realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text); }
                if (textBoxTotalArea.Text != "") { realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text); }
                if (comboBoxType.SelectedIndex == 0)
                {
                    realEstate.Type = 0;
                    if (textBoxRooms.Text != "") { realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text); }
                    if (textBoxFloor.Text != "") { realEstate.Floor = Convert.ToInt32(textBoxFloor.Text); }
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    realEstate.Type = 1;
                    if (textBoxTotalFloors.Text != "") { realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text); }
                }
                else
                {
                    realEstate.Type = 2;
                }
                if (textBoxCoordinate_latitude.Text != "") { realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text); }
                if ((realEstate.Coordinate_latitude < -90) || (realEstate.Coordinate_latitude > 90))
                {
                    throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");

                }
                if (textBoxCoordinate_longitude.Text != "") { realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text); }
                if ((realEstate.Coordinate_longitude < -90) || (realEstate.Coordinate_longitude > 90))
                {
                    throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");
                }
                Program.wftDb.RealEstateSet.Add(realEstate);
                Program.wftDb.SaveChanges();
                ShowRealEstateSet();
            }
            catch (Exception expection)
            { MessageBox.Show(expection.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        if (textBoxAddress_City.Text != "") { realEstate.Address_City = textBoxAddress_City.Text; }
                        if (textBoxAddress_House.Text != "") realEstate.Address_House = textBoxAddress_House.Text;
                        if (textBoxAddress_Street.Text != "") realEstate.Address_Street = textBoxAddress_Street.Text;
                        if (textBoxAddress_Number.Text != "") realEstate.Address_Number = textBoxAddress_Number.Text;
                        if (textBoxCoordinate_latitude.Text != "") realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                        if (textBoxCoordinate_longitude.Text != "") realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                        if (textBoxTotalArea.Text != "") realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                        if (textBoxRooms.Text != "") realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                        if (textBoxFloor.Text != "") realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                        if (textBoxCoordinate_latitude.Text != "") { realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text); }
                        if ((realEstate.Coordinate_latitude < -90) || (realEstate.Coordinate_latitude > 90))
                        {
                            throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");

                        }
                        if (textBoxCoordinate_longitude.Text != "") { realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text); }
                        if ((realEstate.Coordinate_longitude < -90) || (realEstate.Coordinate_longitude > 90))
                        {
                            throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");
                        }
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        if (textBoxAddress_City.Text != "") { realEstate.Address_City = textBoxAddress_City.Text; }
                        if (textBoxAddress_House.Text != "") realEstate.Address_House = textBoxAddress_House.Text;
                        if (textBoxAddress_Street.Text != "") realEstate.Address_Street = textBoxAddress_Street.Text;
                        if (textBoxAddress_Number.Text != "") realEstate.Address_Number = textBoxAddress_Number.Text;
                        if (textBoxCoordinate_latitude.Text != "") realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                        if (textBoxCoordinate_longitude.Text != "") realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                        if (textBoxTotalArea.Text != "") realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                        if (textBoxTotalFloors.Text != "") realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);
                        if (textBoxCoordinate_latitude.Text != "") { realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text); }
                        if ((realEstate.Coordinate_latitude < -90) || (realEstate.Coordinate_latitude > 90))
                        {
                            throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");

                        }
                        if (textBoxCoordinate_longitude.Text != "") { realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text); }
                        if ((realEstate.Coordinate_longitude < -90) || (realEstate.Coordinate_longitude > 90))
                        {
                            throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");
                        }
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();

                    }
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        if (textBoxAddress_City.Text != "") { realEstate.Address_City = textBoxAddress_City.Text; }
                        if (textBoxAddress_House.Text != "") realEstate.Address_House = textBoxAddress_House.Text;
                        if (textBoxAddress_Street.Text != "") realEstate.Address_Street = textBoxAddress_Street.Text;
                        if (textBoxAddress_Number.Text != "") realEstate.Address_Number = textBoxAddress_Number.Text;
                        if (textBoxCoordinate_latitude.Text != "") realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                        if (textBoxCoordinate_longitude.Text != "") realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                        if (textBoxTotalArea.Text != "") realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                        if (textBoxCoordinate_latitude.Text != "") { realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text); }
                        if ((realEstate.Coordinate_latitude < -90) || (realEstate.Coordinate_latitude > 90))
                        {
                            throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");

                        }
                        if (textBoxCoordinate_longitude.Text != "") { realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text); }
                        if ((realEstate.Coordinate_longitude < -90) || (realEstate.Coordinate_longitude > 90))
                        {
                            throw new Exception("Диапазон широты от -90 до 90" + "\n" + "Диапазон долготы от - 180 до 180");
                        }
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                }
            }
            catch (Exception expection)
            { MessageBox.Show(expection.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxRooms.Text = "";
                    textBoxFloor.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxTotalFloors.Text = "";
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
