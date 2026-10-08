using EFLab.Models.DataLayer;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EFLab
{
    public partial class Form1 : Form
    {

        private MMABooksContext _context;
        private Customer _customer;
   

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new MMABooksContext();
            _customer = _context.Customers.Find(2);
            lstInvoices.Items.Add(_customer.GetCustomerText(" , "));

            // Step 1: Get the datasource from the database _context using EF core
            List<Invoice> invoices = _context.Invoices.ToList();
            invoices.ForEach(x => lstInvoices.Items.Add(x.GetInvoiceText(",")));

            //Step 2: Define the query using LINQ expressions syntax
            var selectedInvoices = from inv in invoices
                                   where inv.ProductTotal > 100
                                   select inv; 
            //Step 3: Execute and loop to display the records inside the lstFiltered1 listbox
            foreach( var inv in selectedInvoices)
            {
                lstFiltered1.Items.Add(inv.GetInvoiceText(","));
            }
            // Another approach with the method based query syntax
            //Step 2: Define the query using the method based query syntax
            var selectedInvoices2 = invoices.Where(inv => inv.ProductTotal > 100)
                                             .OrderBy(inv => inv.InvoiceDate)
                                             .ThenByDescending(invoices => invoices.ProductTotal)
                                             .Select(inv => new {inv.InvoiceDate, inv.ProductTotal });
            //Step 3: Execute the query and display the results in the selectedFiltered2 listbox

            foreach (var inv in selectedInvoices2)
            {
                lstFiltered2.Items.Add($"{inv.InvoiceDate.ToString()} , {inv.ProductTotal.ToString()}");
            }

        }


    }
}
