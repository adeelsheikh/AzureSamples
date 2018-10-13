using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AzureSamples.Tables
{
    public class ProductEntity : TableEntity
    {
        public ProductEntity(string category, string sku)
        {
            PartitionKey = Category = category;
            RowKey = Sku = sku;
        }

        // The following constructor is required for retrieve operation.
        public ProductEntity()
        {
        }

        public string Category { get; set; }

        public string Color { get; set; }

        public string Name { get; set; }

        public string Size { get; set; }

        public string Sku { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Products
    {
        public static List<ProductEntity> AllProducts => new List<ProductEntity>
        {
                 new ProductEntity("Mountain Bikes", "BK-M82S-38")
            {
                Name = "Mountain-100 Silver, 38",
                Color = "Silver",
                Size = "38"
            },
       new ProductEntity("Mountain Bikes", "BK-M82S-42")
        {
            Name = "Mountain-100 Silver, 42",
          Color = "Silver",
          Size = "42"
       },
       new ProductEntity("Mountain Bikes", "BK-M82S-44")
        {
            Name = "Mountain-100 Silver, 44",
          Color = "Silver",
          Size = "44"
       },
       new ProductEntity("Mountain Bikes", "BK-M82S-48")
        {
            Name = "Mountain-100 Silver, 48",
          Color = "Silver",
          Size = "48"
       },
       new ProductEntity("Mountain Bikes", "BK-M82B-38")
        {
            Name = "Mountain-100 Black, 38",
          Color = "Black",
          Size = "38"
       },
       new ProductEntity("Mountain Bikes", "BK-M82B-42")
        {
            Name = "Mountain-100 Black, 42",
          Color = "Black",
          Size = "42"
       },
       new ProductEntity("Mountain Bikes", "BK-M82B-44")
        {
            Name = "Mountain-100 Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Mountain Bikes", "BK-M82B-48")
        {
            Name = "Mountain-100 Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Mountain Bikes", "BK-M68S-38")
        {
            Name = "Mountain-200 Silver, 38",
          Color = "Silver",
          Size = "38"
       },
       new ProductEntity("Mountain Bikes", "BK-M68S-42")
        {
            Name = "Mountain-200 Silver, 42",
          Color = "Silver",
          Size = "42"
       },
       new ProductEntity("Mountain Bikes", "BK-M68S-46")
        {
            Name = "Mountain-200 Silver, 46",
          Color = "Silver",
          Size = "46"
       },
       new ProductEntity("Mountain Bikes", "BK-M68B-38")
        {
            Name = "Mountain-200 Black, 38",
          Color = "Black",
          Size = "38"
       },
       new ProductEntity("Mountain Bikes", "BK-M68B-42")
        {
            Name = "Mountain-200 Black, 42",
          Color = "Black",
          Size = "42"
       },
       new ProductEntity("Mountain Bikes", "BK-M68B-46")
        {
            Name = "Mountain-200 Black, 46",
          Color = "Black",
          Size = "46"
       },
       new ProductEntity("Mountain Bikes", "BK-M47B-38")
        {
            Name = "Mountain-300 Black, 38",
          Color = "Black",
          Size = "38"
       },
       new ProductEntity("Mountain Bikes", "BK-M47B-40")
        {
            Name = "Mountain-300 Black, 40",
          Color = "Black",
          Size = "40"
       },
       new ProductEntity("Mountain Bikes", "BK-M47B-44")
        {
            Name = "Mountain-300 Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Mountain Bikes", "BK-M47B-48")
        {
            Name = "Mountain-300 Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Mountain Bikes", "BK-M38S-38")
        {
            Name = "Mountain-400-W Silver, 38",
          Color = "Silver",
          Size = "38"
       },
       new ProductEntity("Mountain Bikes", "BK-M38S-40")
        {
            Name = "Mountain-400-W Silver, 40",
          Color = "Silver",
          Size = "40"
       },
       new ProductEntity("Mountain Bikes", "BK-M38S-42")
        {
            Name = "Mountain-400-W Silver, 42",
          Color = "Silver",
          Size = "42"
       },
       new ProductEntity("Mountain Bikes", "BK-M38S-46")
        {
            Name = "Mountain-400-W Silver, 46",
          Color = "Silver",
          Size = "46"
       },
       new ProductEntity("Mountain Bikes", "BK-M18S-40")
        {
            Name = "Mountain-500 Silver, 40",
          Color = "Silver",
          Size = "40"
       },
       new ProductEntity("Mountain Bikes", "BK-M18S-42")
        {
            Name = "Mountain-500 Silver, 42",
          Color = "Silver",
          Size = "42"
       },
       new ProductEntity("Mountain Bikes", "BK-M18S-44")
        {
            Name = "Mountain-500 Silver, 44",
          Color = "Silver",
          Size = "44"
       },
       new ProductEntity("Mountain Bikes", "BK-M18S-48")
        {
            Name = "Mountain-500 Silver, 48",
          Color = "Silver",
          Size = "48"
       },
       new ProductEntity("Mountain Bikes", "BK-M18S-52")
        {
            Name = "Mountain-500 Silver, 52",
          Color = "Silver",
          Size = "52"
       },
       new ProductEntity("Mountain Bikes", "BK-M18B-40")
        {
            Name = "Mountain-500 Black, 40",
          Color = "Black",
          Size = "40"
       },
       new ProductEntity("Mountain Bikes", "BK-M18B-42")
        {
            Name = "Mountain-500 Black, 42",
          Color = "Black",
          Size = "42"
       },
       new ProductEntity("Mountain Bikes", "BK-M18B-44")
        {
            Name = "Mountain-500 Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Mountain Bikes", "BK-M18B-48")
        {
            Name = "Mountain-500 Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Mountain Bikes", "BK-M18B-52")
        {
            Name = "Mountain-500 Black, 52",
          Color = "Black",
          Size = "52"
       },
       new ProductEntity("Road Bikes", "BK-R79Y-40")
        {
            Name = "Road-350-W Yellow, 40",
          Color = "Yellow",
          Size = "40"
       },
       new ProductEntity("Road Bikes", "BK-R79Y-42")
        {
            Name = "Road-350-W Yellow, 42",
          Color = "Yellow",
          Size = "42"
       },
       new ProductEntity("Road Bikes", "BK-R79Y-44")
        {
            Name = "Road-350-W Yellow, 44",
          Color = "Yellow",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R79Y-48")
        {
            Name = "Road-350-W Yellow, 48",
          Color = "Yellow",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R19B-58")
        {
            Name = "Road-750 Black, 58",
          Color = "Black",
          Size = "58"
       },
       new ProductEntity("Road Bikes", "BK-R19B-44")
        {
            Name = "Road-750 Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R19B-48")
        {
            Name = "Road-750 Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R19B-52")
        {
            Name = "Road-750 Black, 52",
          Color = "Black",
          Size = "52"
       },
       new ProductEntity("Road Bikes", "BK-R89R-44")
        {
            Name = "Road-250 Red, 44",
          Color = "Red",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R89R-48")
        {
            Name = "Road-250 Red, 48",
          Color = "Red",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R89R-52")
        {
            Name = "Road-250 Red, 52",
          Color = "Red",
          Size = "52"
       },
       new ProductEntity("Road Bikes", "BK-R89R-58")
        {
            Name = "Road-250 Red, 58",
          Color = "Red",
          Size = "58"
       },
       new ProductEntity("Road Bikes", "BK-R89B-44")
        {
            Name = "Road-250 Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R89B-48")
        {
            Name = "Road-250 Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R89B-52")
        {
            Name = "Road-250 Black, 52",
          Color = "Black",
          Size = "52"
       },
       new ProductEntity("Road Bikes", "BK-R89B-58")
        {
            Name = "Road-250 Black, 58",
          Color = "Black",
          Size = "58"
       },
       new ProductEntity("Road Bikes", "BK-R64Y-38")
        {
            Name = "Road-550-W Yellow, 38",
          Color = "Yellow",
          Size = "38"
       },
       new ProductEntity("Road Bikes", "BK-R64Y-40")
        {
            Name = "Road-550-W Yellow, 40",
          Color = "Yellow",
          Size = "40"
       },
       new ProductEntity("Road Bikes", "BK-R64Y-42")
        {
            Name = "Road-550-W Yellow, 42",
          Color = "Yellow",
          Size = "42"
       },
       new ProductEntity("Road Bikes", "BK-R64Y-44")
        {
            Name = "Road-550-W Yellow, 44",
          Color = "Yellow",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R64Y-48")
        {
            Name = "Road-550-W Yellow, 48",
          Color = "Yellow",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R93R-62")
        {
            Name = "Road-150 Red, 62",
          Color = "Red",
          Size = "62"
       },
       new ProductEntity("Road Bikes", "BK-R93R-44")
        {
            Name = "Road-150 Red, 44",
          Color = "Red",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R93R-48")
        {
            Name = "Road-150 Red, 48",
          Color = "Red",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R93R-52")
        {
            Name = "Road-150 Red, 52",
          Color = "Red",
          Size = "52"
       },
       new ProductEntity("Road Bikes", "BK-R93R-56")
        {
            Name = "Road-150 Red, 56",
          Color = "Red",
          Size = "56"
       },
       new ProductEntity("Road Bikes", "BK-R68R-58")
        {
            Name = "Road-450 Red, 58",
          Color = "Red",
          Size = "58"
       },
       new ProductEntity("Road Bikes", "BK-R68R-60")
        {
            Name = "Road-450 Red, 60",
          Color = "Red",
          Size = "60"
       },
       new ProductEntity("Road Bikes", "BK-R68R-44")
        {
            Name = "Road-450 Red, 44",
          Color = "Red",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R68R-48")
        {
            Name = "Road-450 Red, 48",
          Color = "Red",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R68R-52")
        {
            Name = "Road-450 Red, 52",
          Color = "Red",
          Size = "52"
       },
       new ProductEntity("Road Bikes", "BK-R50R-58")
        {
            Name = "Road-650 Red, 58",
          Color = "Red",
          Size = "58"
       },
       new ProductEntity("Road Bikes", "BK-R50R-60")
        {
            Name = "Road-650 Red, 60",
          Color = "Red",
          Size = "60"
       },
       new ProductEntity("Road Bikes", "BK-R50R-62")
        {
            Name = "Road-650 Red, 62",
          Color = "Red",
          Size = "62"
       },
       new ProductEntity("Road Bikes", "BK-R50R-44")
        {
            Name = "Road-650 Red, 44",
          Color = "Red",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R50R-48")
        {
            Name = "Road-650 Red, 48",
          Color = "Red",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R50R-52")
        {
            Name = "Road-650 Red, 52",
          Color = "Red",
          Size = "52"
       },
       new ProductEntity("Road Bikes", "BK-R50B-58")
        {
            Name = "Road-650 Black, 58",
          Color = "Black",
          Size = "58"
       },
       new ProductEntity("Road Bikes", "BK-R50B-60")
        {
            Name = "Road-650 Black, 60",
          Color = "Black",
          Size = "60"
       },
       new ProductEntity("Road Bikes", "BK-R50B-62")
        {
            Name = "Road-650 Black, 62",
          Color = "Black",
          Size = "62"
       },
       new ProductEntity("Road Bikes", "BK-R50B-44")
        {
            Name = "Road-650 Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Road Bikes", "BK-R50B-48")
        {
            Name = "Road-650 Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Road Bikes", "BK-R50B-52")
        {
            Name = "Road-650 Black, 52",
          Color = "Black",
          Size = "52"
       },
       new ProductEntity("Touring Bikes", "BK-T18U-44")
        {
            Name = "Touring-3000 Blue, 44",
          Color = "Blue",
          Size = "44"
       },
       new ProductEntity("Touring Bikes", "BK-T18U-50")
        {
            Name = "Touring-3000 Blue, 50",
          Color = "Blue",
          Size = "50"
       },
       new ProductEntity("Touring Bikes", "BK-T44U-60")
        {
            Name = "Touring-2000 Blue, 60",
          Color = "Blue",
          Size = "60"
       },
       new ProductEntity("Touring Bikes", "BK-T79Y-46")
        {
            Name = "Touring-1000 Yellow, 46",
          Color = "Yellow",
          Size = "46"
       },
       new ProductEntity("Touring Bikes", "BK-T79Y-50")
        {
            Name = "Touring-1000 Yellow, 50",
          Color = "Yellow",
          Size = "50"
       },
       new ProductEntity("Touring Bikes", "BK-T79Y-54")
        {
            Name = "Touring-1000 Yellow, 54",
          Color = "Yellow",
          Size = "54"
       },
       new ProductEntity("Touring Bikes", "BK-T79Y-60")
        {
            Name = "Touring-1000 Yellow, 60",
          Color = "Yellow",
          Size = "60"
       },
       new ProductEntity("Touring Bikes", "BK-T18U-54")
        {
            Name = "Touring-3000 Blue, 54",
          Color = "Blue",
          Size = "54"
       },
       new ProductEntity("Touring Bikes", "BK-T18U-58")
        {
            Name = "Touring-3000 Blue, 58",
          Color = "Blue",
          Size = "58"
       },
       new ProductEntity("Touring Bikes", "BK-T18U-62")
        {
            Name = "Touring-3000 Blue, 62",
          Color = "Blue",
          Size = "62"
       },
       new ProductEntity("Touring Bikes", "BK-T18Y-44")
        {
            Name = "Touring-3000 Yellow, 44",
          Color = "Yellow",
          Size = "44"
       },
       new ProductEntity("Touring Bikes", "BK-T18Y-50")
        {
            Name = "Touring-3000 Yellow, 50",
          Color = "Yellow",
          Size = "50"
       },
       new ProductEntity("Touring Bikes", "BK-T18Y-54")
        {
            Name = "Touring-3000 Yellow, 54",
          Color = "Yellow",
          Size = "54"
       },
       new ProductEntity("Touring Bikes", "BK-T18Y-58")
        {
            Name = "Touring-3000 Yellow, 58",
          Color = "Yellow",
          Size = "58"
       },
       new ProductEntity("Touring Bikes", "BK-T18Y-62")
        {
            Name = "Touring-3000 Yellow, 62",
          Color = "Yellow",
          Size = "62"
       },
       new ProductEntity("Touring Bikes", "BK-T79U-46")
        {
            Name = "Touring-1000 Blue, 46",
          Color = "Blue",
          Size = "46"
       },
       new ProductEntity("Touring Bikes", "BK-T79U-50")
        {
            Name = "Touring-1000 Blue, 50",
          Color = "Blue",
          Size = "50"
       },
       new ProductEntity("Touring Bikes", "BK-T79U-54")
        {
            Name = "Touring-1000 Blue, 54",
          Color = "Blue",
          Size = "54"
       },
       new ProductEntity("Touring Bikes", "BK-T79U-60")
        {
            Name = "Touring-1000 Blue, 60",
          Color = "Blue",
          Size = "60"
       },
       new ProductEntity("Touring Bikes", "BK-T44U-46")
        {
            Name = "Touring-2000 Blue, 46",
          Color = "Blue",
          Size = "46"
       },
       new ProductEntity("Touring Bikes", "BK-T44U-50")
        {
            Name = "Touring-2000 Blue, 50",
          Color = "Blue",
          Size = "50"
       },
       new ProductEntity("Touring Bikes", "BK-T44U-54")
        {
            Name = "Touring-2000 Blue, 54",
          Color = "Blue",
          Size = "54"
       },
       new ProductEntity("Handlebars", "HB-T721")
        {
            Name = "LL Touring Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Handlebars", "HB-T928")
        {
            Name = "HL Touring Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Handlebars", "HB-M243")
        {
            Name = "LL Mountain Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Handlebars", "HB-M763")
        {
            Name = "ML Mountain Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Handlebars", "HB-M918")
        {
            Name = "HL Mountain Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Handlebars", "HB-R504")
        {
            Name = "LL Road Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Handlebars", "HB-R720")
        {
            Name = "ML Road Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Handlebars", "HB-R956")
        {
            Name = "HL Road Handlebars",
          Color = "",
          Size = ""
       },
       new ProductEntity("Bottom Brackets", "BB-7421")
        {
            Name = "LL Bottom Bracket",
          Color = "",
          Size = ""
       },
       new ProductEntity("Bottom Brackets", "BB-8107")
        {
            Name = "ML Bottom Bracket",
          Color = "",
          Size = ""
       },
       new ProductEntity("Bottom Brackets", "BB-9108")
        {
            Name = "HL Bottom Bracket",
          Color = "",
          Size = ""
       },
       new ProductEntity("Brakes", "FB-9873")
        {
            Name = "Front Brakes",
          Color = "Silver",
          Size = ""
       },
       new ProductEntity("Brakes", "RB-9231")
        {
            Name = "Rear Brakes",
          Color = "Silver",
          Size = ""
       },
       new ProductEntity("Chains", "CH-0234")
        {
            Name = "Chain",
          Color = "Silver",
          Size = ""
       },
       new ProductEntity("Cranksets", "CS-4759")
        {
            Name = "LL Crankset",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Cranksets", "CS-6583")
        {
            Name = "ML Crankset",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Cranksets", "CS-9183")
        {
            Name = "HL Crankset",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Derailleurs", "FD-2342")
        {
            Name = "Front Derailleur",
          Color = "Silver",
          Size = ""
       },
       new ProductEntity("Derailleurs", "RD-2308")
        {
            Name = "Rear Derailleur",
          Color = "Silver",
          Size = ""
       },
       new ProductEntity("Forks", "FK-1639")
        {
            Name = "LL Fork",
          Color = "",
          Size = ""
       },
       new ProductEntity("Forks", "FK-5136")
        {
            Name = "ML Fork",
          Color = "",
          Size = ""
       },
       new ProductEntity("Forks", "FK-9939")
        {
            Name = "HL Fork",
          Color = "",
          Size = ""
       },
       new ProductEntity("Headsets", "HS-0296")
        {
            Name = "LL Headset",
          Color = "",
          Size = ""
       },
       new ProductEntity("Headsets", "HS-2451")
        {
            Name = "ML Headset",
          Color = "",
          Size = ""
       },
       new ProductEntity("Headsets", "HS-3479")
        {
            Name = "HL Headset",
          Color = "",
          Size = ""
       },
       new ProductEntity("Mountain Frames", "FR-M94S-42")
        {
            Name = "HL Mountain Frame - Silver, 42",
          Color = "Silver",
          Size = "42"
       },
       new ProductEntity("Mountain Frames", "FR-M94S-44")
        {
            Name = "HL Mountain Frame - Silver, 44",
          Color = "Silver",
          Size = "44"
       },
       new ProductEntity("Mountain Frames", "FR-M94S-52")
        {
            Name = "HL Mountain Frame - Silver, 48",
          Color = "Silver",
          Size = "48"
       },
       new ProductEntity("Mountain Frames", "FR-M94S-46")
        {
            Name = "HL Mountain Frame - Silver, 46",
          Color = "Silver",
          Size = "46"
       },
       new ProductEntity("Mountain Frames", "FR-M94B-42")
        {
            Name = "HL Mountain Frame - Black, 42",
          Color = "Black",
          Size = "42"
       },
       new ProductEntity("Mountain Frames", "FR-M94B-44")
        {
            Name = "HL Mountain Frame - Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Mountain Frames", "FR-M94B-48")
        {
            Name = "HL Mountain Frame - Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Mountain Frames", "FR-M94B-46")
        {
            Name = "HL Mountain Frame - Black, 46",
          Color = "Black",
          Size = "46"
       },
       new ProductEntity("Mountain Frames", "FR-M94B-38")
        {
            Name = "HL Mountain Frame - Black, 38",
          Color = "Black",
          Size = "38"
       },
       new ProductEntity("Mountain Frames", "FR-M94S-38")
        {
            Name = "HL Mountain Frame - Silver, 38",
          Color = "Silver",
          Size = "38"
       },
       new ProductEntity("Mountain Frames", "FR-M63B-38")
        {
            Name = "ML Mountain Frame - Black, 38",
          Color = "Black",
          Size = "38"
       },
       new ProductEntity("Mountain Frames", "FR-M63B-40")
        {
            Name = "ML Mountain Frame - Black, 40",
          Color = "Black",
          Size = "40"
       },
       new ProductEntity("Mountain Frames", "FR-M63B-44")
        {
            Name = "ML Mountain Frame - Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Mountain Frames", "FR-M63B-48")
        {
            Name = "ML Mountain Frame - Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Mountain Frames", "FR-M21B-42")
        {
            Name = "LL Mountain Frame - Black, 42",
          Color = "Black",
          Size = "42"
       },
       new ProductEntity("Mountain Frames", "FR-M21B-44")
        {
            Name = "LL Mountain Frame - Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Mountain Frames", "FR-M21B-48")
        {
            Name = "LL Mountain Frame - Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Mountain Frames", "FR-M21B-52")
        {
            Name = "LL Mountain Frame - Black, 52",
          Color = "Black",
          Size = "52"
       },
       new ProductEntity("Mountain Frames", "FR-M21S-42")
        {
            Name = "LL Mountain Frame - Silver, 42",
          Color = "Silver",
          Size = "42"
       },
       new ProductEntity("Mountain Frames", "FR-M21S-44")
        {
            Name = "LL Mountain Frame - Silver, 44",
          Color = "Silver",
          Size = "44"
       },
       new ProductEntity("Mountain Frames", "FR-M21S-48")
        {
            Name = "LL Mountain Frame - Silver, 48",
          Color = "Silver",
          Size = "48"
       },
       new ProductEntity("Mountain Frames", "FR-M21S-52")
        {
            Name = "LL Mountain Frame - Silver, 52",
          Color = "Silver",
          Size = "52"
       },
       new ProductEntity("Mountain Frames", "FR-M63S-40")
        {
            Name = "ML Mountain Frame-W - Silver, 40",
          Color = "Silver",
          Size = "40"
       },
       new ProductEntity("Mountain Frames", "FR-M63S-42")
        {
            Name = "ML Mountain Frame-W - Silver, 42",
          Color = "Silver",
          Size = "42"
       },
       new ProductEntity("Mountain Frames", "FR-M63S-46")
        {
            Name = "ML Mountain Frame-W - Silver, 46",
          Color = "Silver",
          Size = "46"
       },
       new ProductEntity("Mountain Frames", "FR-M63S-38")
        {
            Name = "ML Mountain Frame-W - Silver, 38",
          Color = "Silver",
          Size = "38"
       },
       new ProductEntity("Mountain Frames", "FR-M21B-40")
        {
            Name = "LL Mountain Frame - Black, 40",
          Color = "Black",
          Size = "40"
       },
       new ProductEntity("Mountain Frames", "FR-M21S-40")
        {
            Name = "LL Mountain Frame - Silver, 40",
          Color = "Silver",
          Size = "40"
       },
       new ProductEntity("Pedals", "PD-M282")
        {
            Name = "LL Mountain Pedal",
          Color = "Silver/Black",
          Size = ""
       },
       new ProductEntity("Pedals", "PD-M340")
        {
            Name = "ML Mountain Pedal",
          Color = "Silver/Black",
          Size = ""
       },
       new ProductEntity("Pedals", "PD-M562")
        {
            Name = "HL Mountain Pedal",
          Color = "Silver/Black",
          Size = ""
       },
       new ProductEntity("Pedals", "PD-R347")
        {
            Name = "LL Road Pedal",
          Color = "Silver/Black",
          Size = ""
       },
       new ProductEntity("Pedals", "PD-R563")
        {
            Name = "ML Road Pedal",
          Color = "Silver/Black",
          Size = ""
       },
       new ProductEntity("Pedals", "PD-R853")
        {
            Name = "HL Road Pedal",
          Color = "Silver/Black",
          Size = ""
       },
       new ProductEntity("Pedals", "PD-T852")
        {
            Name = "Touring Pedal",
          Color = "Silver/Black",
          Size = ""
       },
       new ProductEntity("Road Frames", "FR-R72Y-40")
        {
            Name = "ML Road Frame-W - Yellow, 40",
          Color = "Yellow",
          Size = "40"
       },
       new ProductEntity("Road Frames", "FR-R72Y-42")
        {
            Name = "ML Road Frame-W - Yellow, 42",
          Color = "Yellow",
          Size = "42"
       },
       new ProductEntity("Road Frames", "FR-R72Y-44")
        {
            Name = "ML Road Frame-W - Yellow, 44",
          Color = "Yellow",
          Size = "44"
       },
       new ProductEntity("Road Frames", "FR-R72Y-48")
        {
            Name = "ML Road Frame-W - Yellow, 48",
          Color = "Yellow",
          Size = "48"
       },
       new ProductEntity("Road Frames", "FR-R92B-62")
        {
            Name = "HL Road Frame - Black, 62",
          Color = "Black",
          Size = "62"
       },
       new ProductEntity("Road Frames", "FR-R92B-44")
        {
            Name = "HL Road Frame - Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Road Frames", "FR-R92B-48")
        {
            Name = "HL Road Frame - Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Road Frames", "FR-R92B-52")
        {
            Name = "HL Road Frame - Black, 52",
          Color = "Black",
          Size = "52"
       },
       new ProductEntity("Road Frames", "FR-R72Y-38")
        {
            Name = "ML Road Frame-W - Yellow, 38",
          Color = "Yellow",
          Size = "38"
       },
       new ProductEntity("Road Frames", "FR-R92B-58")
        {
            Name = "HL Road Frame - Black, 58",
          Color = "Black",
          Size = "58"
       },
       new ProductEntity("Road Frames", "FR-R92R-58")
        {
            Name = "HL Road Frame - Red, 58",
          Color = "Red",
          Size = "58"
       },
       new ProductEntity("Road Frames", "FR-R92R-62")
        {
            Name = "HL Road Frame - Red, 62",
          Color = "Red",
          Size = "62"
       },
       new ProductEntity("Road Frames", "FR-R92R-44")
        {
            Name = "HL Road Frame - Red, 44",
          Color = "Red",
          Size = "44"
       },
       new ProductEntity("Road Frames", "FR-R92R-48")
        {
            Name = "HL Road Frame - Red, 48",
          Color = "Red",
          Size = "48"
       },
       new ProductEntity("Road Frames", "FR-R92R-52")
        {
            Name = "HL Road Frame - Red, 52",
          Color = "Red",
          Size = "52"
       },
       new ProductEntity("Road Frames", "FR-R92R-56")
        {
            Name = "HL Road Frame - Red, 56",
          Color = "Red",
          Size = "56"
       },
       new ProductEntity("Road Frames", "FR-R38B-58")
        {
            Name = "LL Road Frame - Black, 58",
          Color = "Black",
          Size = "58"
       },
       new ProductEntity("Road Frames", "FR-R38B-60")
        {
            Name = "LL Road Frame - Black, 60",
          Color = "Black",
          Size = "60"
       },
       new ProductEntity("Road Frames", "FR-R38B-62")
        {
            Name = "LL Road Frame - Black, 62",
          Color = "Black",
          Size = "62"
       },
       new ProductEntity("Road Frames", "FR-R38R-44")
        {
            Name = "LL Road Frame - Red, 44",
          Color = "Red",
          Size = "44"
       },
       new ProductEntity("Road Frames", "FR-R38R-48")
        {
            Name = "LL Road Frame - Red, 48",
          Color = "Red",
          Size = "48"
       },
       new ProductEntity("Road Frames", "FR-R38R-52")
        {
            Name = "LL Road Frame - Red, 52",
          Color = "Red",
          Size = "52"
       },
       new ProductEntity("Road Frames", "FR-R38R-58")
        {
            Name = "LL Road Frame - Red, 58",
          Color = "Red",
          Size = "58"
       },
       new ProductEntity("Road Frames", "FR-R38R-60")
        {
            Name = "LL Road Frame - Red, 60",
          Color = "Red",
          Size = "60"
       },
       new ProductEntity("Road Frames", "FR-R38R-62")
        {
            Name = "LL Road Frame - Red, 62",
          Color = "Red",
          Size = "62"
       },
       new ProductEntity("Road Frames", "FR-R72R-44")
        {
            Name = "ML Road Frame - Red, 44",
          Color = "Red",
          Size = "44"
       },
       new ProductEntity("Road Frames", "FR-R72R-48")
        {
            Name = "ML Road Frame - Red, 48",
          Color = "Red",
          Size = "48"
       },
       new ProductEntity("Road Frames", "FR-R72R-52")
        {
            Name = "ML Road Frame - Red, 52",
          Color = "Red",
          Size = "52"
       },
       new ProductEntity("Road Frames", "FR-R72R-58")
        {
            Name = "ML Road Frame - Red, 58",
          Color = "Red",
          Size = "58"
       },
       new ProductEntity("Road Frames", "FR-R72R-60")
        {
            Name = "ML Road Frame - Red, 60",
          Color = "Red",
          Size = "60"
       },
       new ProductEntity("Road Frames", "FR-R38B-44")
        {
            Name = "LL Road Frame - Black, 44",
          Color = "Black",
          Size = "44"
       },
       new ProductEntity("Road Frames", "FR-R38B-48")
        {
            Name = "LL Road Frame - Black, 48",
          Color = "Black",
          Size = "48"
       },
       new ProductEntity("Road Frames", "FR-R38B-52")
        {
            Name = "LL Road Frame - Black, 52",
          Color = "Black",
          Size = "52"
       },
       new ProductEntity("Saddles", "SE-M236")
        {
            Name = "LL Mountain Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-M798")
        {
            Name = "ML Mountain Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-M940")
        {
            Name = "HL Mountain Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-R581")
        {
            Name = "LL Road Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-R908")
        {
            Name = "ML Road Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-R995")
        {
            Name = "HL Road Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-T312")
        {
            Name = "LL Touring Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-T762")
        {
            Name = "ML Touring Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Saddles", "SE-T924")
        {
            Name = "HL Touring Seat/Saddle",
          Color = "",
          Size = ""
       },
       new ProductEntity("Touring Frames", "FR-T67U-50")
        {
            Name = "LL Touring Frame - Blue, 50",
          Color = "Blue",
          Size = "50"
       },
       new ProductEntity("Touring Frames", "FR-T67U-54")
        {
            Name = "LL Touring Frame - Blue, 54",
          Color = "Blue",
          Size = "54"
       },
       new ProductEntity("Touring Frames", "FR-T67U-58")
        {
            Name = "LL Touring Frame - Blue, 58",
          Color = "Blue",
          Size = "58"
       },
       new ProductEntity("Touring Frames", "FR-T67U-62")
        {
            Name = "LL Touring Frame - Blue, 62",
          Color = "Blue",
          Size = "62"
       },
       new ProductEntity("Touring Frames", "FR-T67Y-44")
        {
            Name = "LL Touring Frame - Yellow, 44",
          Color = "Yellow",
          Size = "44"
       },
       new ProductEntity("Touring Frames", "FR-T67Y-50")
        {
            Name = "LL Touring Frame - Yellow, 50",
          Color = "Yellow",
          Size = "50"
       },
       new ProductEntity("Touring Frames", "FR-T67Y-54")
        {
            Name = "LL Touring Frame - Yellow, 54",
          Color = "Yellow",
          Size = "54"
       },
       new ProductEntity("Touring Frames", "FR-T67Y-58")
        {
            Name = "LL Touring Frame - Yellow, 58",
          Color = "Yellow",
          Size = "58"
       },
       new ProductEntity("Touring Frames", "FR-T67U-44")
        {
            Name = "LL Touring Frame - Blue, 44",
          Color = "Blue",
          Size = "44"
       },
       new ProductEntity("Touring Frames", "FR-T98Y-60")
        {
            Name = "HL Touring Frame - Yellow, 60",
          Color = "Yellow",
          Size = "60"
       },
       new ProductEntity("Touring Frames", "FR-T67Y-62")
        {
            Name = "LL Touring Frame - Yellow, 62",
          Color = "Yellow",
          Size = "62"
       },
       new ProductEntity("Touring Frames", "FR-T98Y-46")
        {
            Name = "HL Touring Frame - Yellow, 46",
          Color = "Yellow",
          Size = "46"
       },
       new ProductEntity("Touring Frames", "FR-T98Y-50")
        {
            Name = "HL Touring Frame - Yellow, 50",
          Color = "Yellow",
          Size = "50"
       },
       new ProductEntity("Touring Frames", "FR-T98Y-54")
        {
            Name = "HL Touring Frame - Yellow, 54",
          Color = "Yellow",
          Size = "54"
       },
       new ProductEntity("Touring Frames", "FR-T98U-46")
        {
            Name = "HL Touring Frame - Blue, 46",
          Color = "Blue",
          Size = "46"
       },
       new ProductEntity("Touring Frames", "FR-T98U-50")
        {
            Name = "HL Touring Frame - Blue, 50",
          Color = "Blue",
          Size = "50"
       },
       new ProductEntity("Touring Frames", "FR-T98U-54")
        {
            Name = "HL Touring Frame - Blue, 54",
          Color = "Blue",
          Size = "54"
       },
       new ProductEntity("Touring Frames", "FR-T98U-60")
        {
            Name = "HL Touring Frame - Blue, 60",
          Color = "Blue",
          Size = "60"
       },
       new ProductEntity("Wheels", "RW-M423")
        {
            Name = "LL Mountain Rear Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "RW-M762")
        {
            Name = "ML Mountain Rear Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "RW-M928")
        {
            Name = "HL Mountain Rear Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "RW-R623")
        {
            Name = "LL Road Rear Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "RW-R762")
        {
            Name = "ML Road Rear Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "RW-R820")
        {
            Name = "HL Road Rear Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "RW-T905")
        {
            Name = "Touring Rear Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "FW-M423")
        {
            Name = "LL Mountain Front Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "FW-M762")
        {
            Name = "ML Mountain Front Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "FW-M928")
        {
            Name = "HL Mountain Front Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "FW-R623")
        {
            Name = "LL Road Front Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "FW-R762")
        {
            Name = "ML Road Front Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "FW-R820")
        {
            Name = "HL Road Front Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Wheels", "FW-T905")
        {
            Name = "Touring Front Wheel",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Bib-Shorts", "SB-M891-S")
        {
            Name = "Men's Bib-Shorts, S",
          Color = "Multi",
          Size = "S"
       },
       new ProductEntity("Bib-Shorts", "SB-M891-M")
        {
            Name = "Men's Bib-Shorts, M",
          Color = "Multi",
          Size = "M"
       },
       new ProductEntity("Bib-Shorts", "SB-M891-L")
        {
            Name = "Men's Bib-Shorts, L",
          Color = "Multi",
          Size = "L"
       },
       new ProductEntity("Caps", "CA-1098")
        {
            Name = "AWC Logo Cap",
          Color = "Multi",
          Size = ""
       },
       new ProductEntity("Gloves", "GL-H102-S")
        {
            Name = "Half-Finger Gloves, S",
          Color = "Black",
          Size = "S"
       },
       new ProductEntity("Gloves", "GL-H102-M")
        {
            Name = "Half-Finger Gloves, M",
          Color = "Black",
          Size = "M"
       },
       new ProductEntity("Gloves", "GL-H102-L")
        {
            Name = "Half-Finger Gloves, L",
          Color = "Black",
          Size = "L"
       },
       new ProductEntity("Gloves", "GL-F110-S")
        {
            Name = "Full-Finger Gloves, S",
          Color = "Black",
          Size = "S"
       },
       new ProductEntity("Gloves", "GL-F110-M")
        {
            Name = "Full-Finger Gloves, M",
          Color = "Black",
          Size = "M"
       },
       new ProductEntity("Gloves", "GL-F110-L")
        {
            Name = "Full-Finger Gloves, L",
          Color = "Black",
          Size = "L"
       },
       new ProductEntity("Jerseys", "LJ-0192-S")
        {
            Name = "Long-Sleeve Logo Jersey, S",
          Color = "Multi",
          Size = "S"
       },
       new ProductEntity("Jerseys", "LJ-0192-M")
        {
            Name = "Long-Sleeve Logo Jersey, M",
          Color = "Multi",
          Size = "M"
       },
       new ProductEntity("Jerseys", "LJ-0192-L")
        {
            Name = "Long-Sleeve Logo Jersey, L",
          Color = "Multi",
          Size = "L"
       },
       new ProductEntity("Jerseys", "LJ-0192-X")
        {
            Name = "Long-Sleeve Logo Jersey, XL",
          Color = "Multi",
          Size = "XL"
       },
       new ProductEntity("Jerseys", "SJ-0194-S")
        {
            Name = "Short-Sleeve Classic Jersey, S",
          Color = "Yellow",
          Size = "S"
       },
       new ProductEntity("Jerseys", "SJ-0194-M")
        {
            Name = "Short-Sleeve Classic Jersey, M",
          Color = "Yellow",
          Size = "M"
       },
       new ProductEntity("Jerseys", "SJ-0194-L")
        {
            Name = "Short-Sleeve Classic Jersey, L",
          Color = "Yellow",
          Size = "L"
       },
       new ProductEntity("Jerseys", "SJ-0194-X")
        {
            Name = "Short-Sleeve Classic Jersey, XL",
          Color = "Yellow",
          Size = "XL"
       },
       new ProductEntity("Shorts", "SH-W890-S")
        {
            Name = "Women's Mountain Shorts, S",
          Color = "Black",
          Size = "S"
       },
       new ProductEntity("Shorts", "SH-W890-M")
        {
            Name = "Women's Mountain Shorts, M",
          Color = "Black",
          Size = "M"
       },
       new ProductEntity("Shorts", "SH-W890-L")
        {
            Name = "Women's Mountain Shorts, L",
          Color = "Black",
          Size = "L"
       },
       new ProductEntity("Shorts", "SH-M897-S")
        {
            Name = "Men's Sports Shorts, S",
          Color = "Black",
          Size = "S"
       },
       new ProductEntity("Shorts", "SH-M897-M")
        {
            Name = "Men's Sports Shorts, M",
          Color = "Black",
          Size = "M"
       },
       new ProductEntity("Shorts", "SH-M897-L")
        {
            Name = "Men's Sports Shorts, L",
          Color = "Black",
          Size = "L"
       },
       new ProductEntity("Shorts", "SH-M897-X")
        {
            Name = "Men's Sports Shorts, XL",
          Color = "Black",
          Size = "XL"
       },
       new ProductEntity("Socks", "SO-B909-M")
        {
            Name = "Mountain Bike Socks, M",
          Color = "White",
          Size = "M"
       },
       new ProductEntity("Socks", "SO-B909-L")
        {
            Name = "Mountain Bike Socks, L",
          Color = "White",
          Size = "L"
       },
       new ProductEntity("Socks", "SO-R809-M")
        {
            Name = "Racing Socks, M",
          Color = "White",
          Size = "M"
       },
       new ProductEntity("Socks", "SO-R809-L")
        {
            Name = "Racing Socks, L",
          Color = "White",
          Size = "L"
       },
       new ProductEntity("Tights", "TG-W091-S")
        {
            Name = "Women's Tights, S",
          Color = "Black",
          Size = "S"
       },
       new ProductEntity("Tights", "TG-W091-M")
        {
            Name = "Women's Tights, M",
          Color = "Black",
          Size = "M"
       },
       new ProductEntity("Tights", "TG-W091-L")
        {
            Name = "Women's Tights, L",
          Color = "Black",
          Size = "L"
       },
       new ProductEntity("Vests", "VE-C304-S")
        {
            Name = "Classic Vest, S",
          Color = "Blue",
          Size = "S"
       },
       new ProductEntity("Vests", "VE-C304-M")
        {
            Name = "Classic Vest, M",
          Color = "Blue",
          Size = "M"
       },
       new ProductEntity("Vests", "VE-C304-L")
        {
            Name = "Classic Vest, L",
          Color = "Blue",
          Size = "L"
       },
       new ProductEntity("Bike Racks", "RA-H123")
        {
            Name = "Hitch Rack - 4-Bike",
          Color = "",
          Size = ""
       },
       new ProductEntity("Bike Stands", "ST-1401")
        {
            Name = "All-Purpose Bike Stand",
          Color = "",
          Size = ""
       },
       new ProductEntity("Bottles and Cages", "WB-H098")
        {
            Name = "Water Bottle - 30 oz.",
          Color = "",
          Size = ""
       },
       new ProductEntity("Bottles and Cages", "BC-M005")
        {
            Name = "Mountain Bottle Cage",
          Color = "",
          Size = ""
       },
       new ProductEntity("Bottles and Cages", "BC-R205")
        {
            Name = "Road Bottle Cage",
          Color = "",
          Size = ""
       },
       new ProductEntity("Cleaners", "CL-9009")
        {
            Name = "Bike Wash - Dissolver",
          Color = "",
          Size = ""
       },
       new ProductEntity("Fenders", "FE-6654")
        {
            Name = "Fender Set - Mountain",
          Color = "",
          Size = ""
       },
       new ProductEntity("Helmets", "HL-U509-B")
        {
            Name = "Sport-100 Helmet, Blue",
          Color = "Blue",
          Size = ""
       },
       new ProductEntity("Helmets", "HL-U509-R")
        {
            Name = "Sport-100 Helmet, Red",
          Color = "Red",
          Size = ""
       },
       new ProductEntity("Helmets", "HL-U509")
        {
            Name = "Sport-100 Helmet, Black",
          Color = "Black",
          Size = ""
       },
       new ProductEntity("Hydration Packs", "HY-1023-70")
        {
            Name = "Hydration Pack - 70 oz.",
          Color = "Silver",
          Size = "70"
       },
       new ProductEntity("Lights", "LT-T990")
        {
            Name = "Taillights - Battery-Powered",
          Color = "",
          Size = ""
       },
       new ProductEntity("Lights", "LT-H902")
        {
            Name = "Headlights - Dual-Beam",
          Color = "",
          Size = ""
       },
       new ProductEntity("Lights", "LT-H903")
        {
            Name = "Headlights - Weatherproof",
          Color = "",
          Size = ""
       },
       new ProductEntity("Locks", "LO-C100")
        {
            Name = "Cable Lock",
          Color = "",
          Size = ""
       },
       new ProductEntity("Panniers", "PA-T100")
        {
            Name = "Touring-Panniers, Large",
          Color = "Grey",
          Size = ""
       },
       new ProductEntity("Pumps", "PU-0452")
        {
            Name = "Minipump",
          Color = "",
          Size = ""
       },
       new ProductEntity("Pumps", "PU-M044")
        {
            Name = "Mountain Pump",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "PK-7098")
        {
            Name = "Patch Kit/8 Patches",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TT-M928")
        {
            Name = "Mountain Tire Tube",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TT-R982")
        {
            Name = "Road Tire Tube",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TT-T092")
        {
            Name = "Touring Tire Tube",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TI-M267")
        {
            Name = "LL Mountain Tire",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TI-M602")
        {
            Name = "ML Mountain Tire",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TI-M823")
        {
            Name = "HL Mountain Tire",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TI-R092")
        {
            Name = "LL Road Tire",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TI-R628")
       {
            Name = "ML Road Tire",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TI-R982")
       {
            Name = "HL Road Tire",
          Color = "",
          Size = ""
       },
       new ProductEntity("Tires and Tubes", "TI-T723")
       {
            Name = "Touring Tire",
          Color = "",
          Size = ""
       }
        };
    }
}
