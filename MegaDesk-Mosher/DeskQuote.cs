﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

//using System.Text.Json;
//using System.Text.Json.Serialization;


namespace MegaDesk_Mosher
{
    class DeskQuote
    {
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string submitDate { get; set; }
        public double quoteTotal { get; set; }

        public string deskMaterial { get; set; }

        // Create an empty list to hold all of the DeskQuotes
        public static List<DeskQuote> listOfQuotes = new List <DeskQuote> ();

        // Create an empty desk object to be used
        public Desk userDesk;

        public DeskQuote()
        {

        }

        public DeskQuote(string quoteFirstName, string quoteLastName, string quoteDate, double deskQuoteTotal, Desk quoteDesk)
        {
            clientFirstName = quoteFirstName;
            clientLastName = quoteLastName;
            submitDate = quoteDate;
            quoteTotal = deskQuoteTotal;
            userDesk = quoteDesk;
            deskMaterial = quoteDesk.surfaceMaterial;
        }

        // This 
        public void convertToJson()
        {

            // TODO: Add logic so if the file exists, do this.  If it does not exist, create it and write the data
            // Read the current file first
            if (File.Exists("savedQuotes.txt"))
            {
                using (StreamReader r = new StreamReader("savedQuotes.txt"))
                {
                    string quotesFromFile = r.ReadToEnd();
                    List<DeskQuote> quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotesFromFile);
                    quotes.Add(this);
                }
            } 

            // First serialize the object
            string deskObject = JsonConvert.SerializeObject(this, Formatting.Indented);

            // Specify a text file to write the data to
            string quoteTextFile = "savedQuotes.txt";

            // Write the objects to a file.  This will append to the file
            using (StreamWriter textFile = new StreamWriter(quoteTextFile, true))
            {
                textFile.WriteLine(deskObject);
            }
        }

        public void convertListToJson()
        {
            var output = JsonConvert.SerializeObject(listOfQuotes, Formatting.Indented);

            // Specify a text file to write the data to
            string quoteTextFile = "savedQuotes.txt";

            // Write the objects to a file.  This will append to the file
            using (StreamWriter textFile = new StreamWriter(quoteTextFile, true))
            {
                textFile.WriteLine(output);
            }
        }


        //Get Rush Order
        //TODO: figure out file
        public int[,] GetRushOrder()
        {
            try
            {
                //string path = @"c:..\..\rushOrderPrices.txt";
            string path = "rushorderPrices.txt";
            string[] orderPrices = File.ReadAllLines(path);
            int[,] rushOrderGrid = new int[3, 3];

            //outer loop for rows, inner for columns
            int x = 0;
            int i;
            int j = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    int output = int.Parse(orderPrices[x]);
                    rushOrderGrid[i, j] = output;
                    //MessageBox.Show("Test:" + i + ", " + j + " " + rushOrderGrid[i,j]);
                    x++;
                }
                
            }
             return rushOrderGrid;
            }

            catch (Exception)
            {

                throw;
            }

        }

    }
    
    
    
}
