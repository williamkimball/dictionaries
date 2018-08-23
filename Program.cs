using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, string> stocks = new Dictionary<string, string> ();
            stocks.Add ("GE", "General Electric");
            stocks.Add ("CAT", "Caterpillar");
            stocks.Add ("TSLA", "Tesla");
            stocks.Add ("APPL", "Apple");

            // Add a few more of your favorite stocks

            // string GM = stocks["GM"];
            // Console.WriteLine(GM);

            List < (string ticker, int shares, double price) > purchases = new List < (string, int, double) > ();

            purchases.Add ((ticker: "GE", shares : 150, price : 23.21));
            purchases.Add ((ticker: "GE", shares : 32, price : 17.87));
            purchases.Add ((ticker: "GE", shares : 80, price : 19.02));

            purchases.Add ((ticker: "TSLA", shares : 1, price : 298.21));
            purchases.Add ((ticker: "TSLA", shares : 5, price : 292.35));
            purchases.Add ((ticker: "TSLA", shares : 4, price : 308.43));

            purchases.Add ((ticker: "APPL", shares : 450, price : 23.21));
            purchases.Add ((ticker: "APPL", shares : 32, price : 17.87));
            purchases.Add ((ticker: "APPL", shares : 20, price : 19.02));

            purchases.Add ((ticker: "CAT", shares : 1760, price : 23.21));
            purchases.Add ((ticker: "CAT", shares : 32, price : 17.87));
            purchases.Add ((ticker: "CAT", shares : 80, price : 19.02));

            /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the valuation of each stock (price*amount)

    {
        "General Electric": 35900,
        "AAPL": 8445,
        ...
    }
*/

            Dictionary<string, double> purchaseInfo = new Dictionary<string, double> ();

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases) {
                // Does the company name key already exist in the report dictionary?
                if (purchaseInfo.ContainsKey (stocks[purchase.ticker])) {
                    purchaseInfo[stocks[purchase.ticker]] +=  purchase.shares * purchase.price;
                }
                // If it does, update the total valuation
                else { purchaseInfo.Add (stocks[purchase.ticker], (purchase.shares * purchase.price)); }
                // If not, add the new key and set its value
            } 
            foreach (KeyValuePair<string, double> item in purchaseInfo) {
                Console.WriteLine($"{item.Key}: {item.Value.ToString("C")}");
            }

            

        }
    }
}