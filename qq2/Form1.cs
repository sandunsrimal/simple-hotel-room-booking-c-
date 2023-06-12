using System.Windows.Forms.VisualStyles;

namespace qq2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb_extra.SelectedItem = "No";
            cmb_room.SelectedItem = "Single";

        }
        double total;
        double totalnew = 0;
        int Single = 0;
        int Double = 0;
        int Family = 0;
        int Suite = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRooms.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtdays.Text = string.Empty;
            cmb_extra.SelectedIndex = 0;
            cmb_room.SelectedIndex = 0;

        }

        private void btn_price_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtAddress.Text == "" || txtdays.Text == "" || txtRooms.Text == "")
            {
                MessageBox.Show("Please Fill all details", "Error");
            }

            int NumOfrooms = int.Parse(txtRooms.Text);
            int NumOfdays = int.Parse(txtdays.Text);

            switch (cmb_room.SelectedItem)
            {
                case "Single":
                    Single = Single + NumOfrooms;
                    if (Single > 11)
                    {
                        Single = Single - NumOfrooms;
                        int canAdd = 10 - Single;
                        DialogResult dialogResult = MessageBox.Show("You can't Book " + NumOfrooms + " Rooms. Only " + canAdd + " Rooms Can Book. Do you like?", "Sure", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            total= NumOfdays * canAdd * 5000.00 + totalnew;
                            Single = Single + canAdd;
                        }else if(dialogResult == DialogResult.No)
                        {
                            break;
                        }
                    }
                    else
                    {
                        total = NumOfdays * NumOfrooms * 5000.00 + totalnew;
                       
                    }
                   
                   
                    break;
                case "Double":
                    Double = Double + NumOfrooms;
                    if (Double > 8)
                    {
                        Double = Double - NumOfrooms;
                        int canAdd = 7 - Double;
                        DialogResult dialogResult = MessageBox.Show("You can't Book " + NumOfrooms + " Rooms. Only " + canAdd + " Rooms Can Book. Do you like?", "Sure", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (NumOfdays > 5)
                            {
                                total = NumOfdays * canAdd * 7500.00 * 0.05 + totalnew;
                                Double = Double + canAdd;
                                lableDis.Text = "5% disount added";
                            }
                            else
                            {
                                total = NumOfdays * canAdd * 7500.00 + totalnew;
                                Double = Double + canAdd;

                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (NumOfdays > 5)
                        {
                            total = NumOfdays * NumOfrooms * 7500.00 * 0.05 + totalnew;
                            
                            lableDis.Text = "5% disount added";
                        }
                        else
                        {
                            total = NumOfdays * NumOfrooms * 7500.00 + totalnew;
                            

                        }
                    }
                    

                    break;

                case "Family":
                    Family = Family + NumOfrooms;
                    if (Family > 5)
                    {
                        Family = Family - NumOfrooms;
                        int canAdd = 4 - Family;
                        DialogResult dialogResult = MessageBox.Show("You can't Book " + NumOfrooms + " Rooms. Only " + canAdd + " Rooms Can Book. Do you like?", "Sure", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            total = NumOfdays * canAdd * 5000.00 + totalnew;
                            Family = Family + canAdd;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            break;
                        }
                    }
                    else
                    {
                        total = NumOfdays * NumOfrooms * 8000.00 + totalnew;
                    }
                    
                   

                    break;

                case "Suite":
                    Suite = Suite + NumOfrooms;
                    if (Suite > 3)
                    {
                        Suite = Suite - NumOfrooms;
                        int canAdd = 2 - Suite;
                        DialogResult dialogResult = MessageBox.Show("You can't Book " + NumOfrooms + " Rooms. Only " + canAdd + " Rooms Can Book. Do you like?", "Sure", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (NumOfdays > 5)
                            {
                                total = NumOfdays * canAdd * 12500.00 * 0.12 + totalnew;
                                Suite = Suite + canAdd;
                                lableDis.Text = "12% disount added";
                            }
                            else
                            {
                                total = NumOfdays * canAdd * 7500.00 + totalnew;
                                Suite = Suite + canAdd;

                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (NumOfdays > 5)
                        {
                            total = NumOfdays * NumOfrooms * 12500.00 * 0.12 + totalnew;
                            Suite = Suite + NumOfrooms;
                            lableDis.Text = "12% disount added";
                        }
                        else
                        {
                            total = NumOfdays * NumOfrooms * 12500.00 + totalnew;


                        }
                    }
                   

                    break;

            }
            txtTotal.Text = total.ToString();
            if (cmb_extra.Text == "Yes")
            {
                txtRooms.Text = string.Empty;
                txtdays.Text = string.Empty;

                totalnew = total;


            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            total = 0;
            totalnew = 0;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRooms.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtdays.Text = string.Empty;
            cmb_extra.SelectedIndex = 0;
            cmb_room.SelectedIndex = 0;

            Single = 0;
            Double = 0;
            Family = 0;
            Suite = 0;
        }
    }
}
