using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservations
{
    public partial class frmReservations : Form
    {

        //passenger and seat objects

        //list of all seats (used to display the seats in the list box)
        private List<Seat> seatList = new List<Seat>();
        public frmReservations()
        {
            InitializeComponent();
        }

        private void frmReservations_Load(object sender, EventArgs e)
        {
            using (AirlineEntities context = new AirlineEntities())
            {
                context.Passengers.ToList();
                context.Seats.ToList();

                this.passengerBindingSource.DataSource = context.Passengers.Local.ToBindingList();
                this.seatBindingSource.DataSource = context.Seats.Local.ToBindingList();

                PopulateAirplane();
                PopulateSeatRows();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Passenger passanger = new Passenger();
            Seat seat = new Seat();
            //list of all seats (used to display the seats in the list box)
            
            //see what seat column was selected(A, B, C, or D)

            //validate input. Valid name, seat row and selection of seat column is required

            //check if plane is full. If it is, place passenger on waiting list

            //check if seat is taken. If it is, exit so the user can select a different seat

            //if everything is OK add passenger and seat to database along with the assigned seat
        
        }

        private void btnShowPassengers_Click(object sender, EventArgs e)
        {
            //Get all passenger information from all 3 tables (will use Inner Join)

            //place the results into DataTable and display the result in Lookups form.

            //when focus is back, repopulate the list box with updated records
        }

        private void btnSearchPassenger_Click(object sender, EventArgs e)
        {
            //make sure a search string was entered in the text box

            //Get all all the passengers that atch the search string. Get all the information from all 3 tables.

            //Place the results in a DataTable and then display it in Lookups form
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Display the seats in the list box
        private void PopulateAirplane()
        {
            //clear previous listbox and list of Seats
            lstOutput.Items.Clear();
            seatList.Clear();
            
            //Select * seats from Seats table. Read results and create a Seat object with
            //ID, Row, Column and IsTaken property from the reader
            //Add the Seat object to the list
            //Loop through the list and display the content in the list box
            using (AirlineEntities context = new AirlineEntities())
            {
                var seats = context.Seats.OrderBy(s => s.SeatRow).ThenBy(s => s.SeatColumn).ToList();
                foreach (var seat in seats)
                {
                    var s = new Seat
                    {
                        SeatID = seat.SeatID,
                        SeatRow = seat.SeatRow,
                        SeatColumn = seat.SeatColumn,
                        IsTaken = seat.IsTaken
                    };
                    seatList.Add(s);
                }

                var msg = "";
                var counter = 0;
                for (int i = 0; i < seatList.Count; i++)
                {
                    counter++;
                    var seat = seatList[i];
                    bool available = seatList[i].IsSeatTaken(seat.SeatID);
                    if (available == true)
                    {
                        msg += "   " + seatList[i].SeatRow + seatList[i].SeatColumn + "   ";
                    }
                    else
                    {
                        msg += "   XX            ";
                    }
                    if (counter % 4 == 0)
                    {
                        lstOutput.Items.Add(msg);
                        msg = "";
                    }
                    else if (counter % 2 == 0)
                    {
                        msg += "  ";
                    }
                }
            }
        }

        //populate drop down with seat rows
        private void PopulateSeatRows()
        {
            using (AirlineEntities context = new AirlineEntities())
            {
                var seatRows = context.Seats.OrderBy(s => s.SeatRow).ThenBy(s => s.SeatColumn).Select(s => s.SeatRow).Distinct().ToList();

                foreach (var row in seatRows)
                {
                    cboSeatRow.Items.Add(row);
                }
            }
        }
    }
}
