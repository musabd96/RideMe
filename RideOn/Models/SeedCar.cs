using RideOn.Data;

namespace RideOn.Models
{
    public class SeedCar
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

            // Check if database is already seeded
            if (context.Car.Any())
            {
                return; // Database is already seeded
            }

            // Create an array of Car objects
            var cars = new[]
            {
                new Car
                {
                    Image = "https://file.kelleybluebookimages.com/kbb/base/evox/CP/14732/2021-Toyota-Camry-front_14732_032_2400x1800_040.png",
                    Make = "Volvo",
                    Model = "Camry",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://freepngimg.com/thumb/volvo/29270-7-volvo-xc90-transparent-image.png",
                    Make = "Volvo",
                    Model = "XC90",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://www.volvocarretail.se/remote/fbinhouse/2480x/2021-12/xc60Core.png?rnd=0&crop=0,0,0,0&cropmode=percentage&center=&width=866&height=372&mode=crop&upscale=True&format=webp",
                    Make = "Volvo",
                    Model = "XC60",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://static.fbinhouse.se/480x/2019-11/S60_sedan_750x422.png",
                    Make = "Volvo",
                    Model = "S90",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://carsguide-res.cloudinary.com/image/upload/f_auto,fl_lossy,q_auto,t_default/v1/editorial/volvo-v60-my20-index-1.png",
                    Make = "Volvo",
                    Model = "V60",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 45.0m,
                    Available = true
                },

                new Car
                {

                    Image = "https://www.motortrend.com/uploads/sites/10/2019/09/2020-volvo-v90-r-design-awd-t5-wagon-angular-front.png",
                    Make = "Volvo",
                    Model = "V90",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 50.0m,
                    Available = true
                },

                // Lexus    
                new Car
                {
                    Image = "https://i.pinimg.com/originals/6d/6f/b0/6d6fb037a44c48cd1a01cb73838e0bf5.png",
                    Make = "Lexus",
                    Model = "RX",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://dealerinspire-image-library-prod.s3.us-east-1.amazonaws.com/images/8Ts6W9wKHCMQy8AAc9dMEq7yjj8PxDuqzUFiN99i.png",
                    Make = "Lexus",
                    Model = "ES",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://oomdo.com/landingPageTool/Content/ADCB/2021/Buick/Encore_GX/21-Buick-Encore-GX-Select-ChiliRed.png",
                    Make = "Lexus",
                    Model = "GX",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://toyotaassets.scene7.com/is/image/toyota/Lexus-LS-BASE-500-visualizer-styles-750x471-LEX-LSG-MY21-0001-02?wid=750&hei=471&fmt=png-alpha",
                    Make = "Lexus",
                    Model = "LS",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 45.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://file.kelleybluebookimages.com/kbb/base/evox/CP/14663/2021-Lexus-LX-front_14663_032_2400x1800_8X5_nologo.png",
                    Make = "Lexus",
                    Model = "LX",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 50.0m,
                    Available = true
                },

                // Porsche
                new Car
                {
                    Image = "https://www.motortrend.com/uploads/sites/10/2021/06/2022-porsche-911-carrera-s-coupe-angular-front.png",
                    Make = "Porsche",
                    Model = "911",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://www.pngmart.com/files/22/Porsche-Panamera-PNG-Free-Download.png",
                    Make = "Porsche",
                    Model = "Panamera",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://purepng.com/public/uploads/large/purepng.com-red-porsche-macan-gts-carcarvehicletransportporsche-961524653732vwswi.png",
                    Make = "Porsche",
                    Model = "Macan",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://www.pngplay.com/wp-content/uploads/13/Porsche-Cayenne-Coupe-Transparent-Images.png",
                    Make = "Porsche",
                    Model = "Cayenne",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 45.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://unifleet.se/wp-content/uploads/2022/02/Porsche-taycan-sport-turismo-gentian-blue-mettalic.png",
                    Make = "Porsche",
                    Model = "Taycan",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 50.0m,
                    Available = true
                },

                // Jeep
                new Car
                {
                    Image = "https://medias.fcacanada.ca/jellies/renditions/2021/800x510/CC21_JLJL72_2TB_PGG_APA_XXX_XXX_XXX.9aa68d061966dad74a091ef668b10e71.png",
                    Make = "Jeep",
                    Model = "Wrangler",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://medias.fcacanada.ca/jellies/renditions/2021/800x510/CC21_WKJP74_2TH_PHR_APA_XXX_XXX_XXX.1faa77ba769975f58efbb221e46b1508.png",
                    Make = "Jeep",
                    Model = "Grand Cherokee",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://s3.us-east-2.amazonaws.com/dealer-inspire-vps-vehicle-images/stock-images/thumbnails/large/chrome/7ef3fe1682c400cb3a95bdaa409a3375.png",
                    Make = "Jeep",
                    Model = "Compass",
                   Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://cka-dash.s3.amazonaws.com/097-0820-CC159/model1.png",
                    Make = "Jeep",
                    Model = "Renegade",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 45.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://medias.fcacanada.ca/jellies/renditions/2022/800x510/CC22_JTJL98_2TT_PX8_APA_XXX_XXX_XXX.38098310f98fd893d0fd212ced4da624.png",
                    Make = "Jeep",
                    Model = "Gladiator",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 50.0m,
                    Available = true
                },

                // Mercedes-Benz
                new Car
                {
                    Image = "https://s3.us-east-2.amazonaws.com/dealer-inspire-vps-vehicle-images/stock-images/chrome/622b82190d0898ae41b0854155407296.png",
                    Make = "Mercedes-Benz",
                    Model = "C-Class",
                   Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://www.mercedes-benz.se/passengercars/mercedes-benz-cars/models/e-class/saloon-w213-fl/_jcr_content/image.MQ6.2.2x.20220118092341.png",
                    Make = "Mercedes-Benz",
                    Model = "E-Class",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://s3.us-east-2.amazonaws.com/dealer-inspire-vps-vehicle-images/stock-images/chrome/de3f0e09094934633849d1e9ed0d24aa.png",
                    Make = "Mercedes-Benz",
                    Model = "S-Class",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://images.carprices.com/pricebooks_data/usa/colorized/2022/Mercedes-Benz/View2/GLC/AMG_GLC_43/GLC43W4_297.png",
                    Make = "Mercedes-Benz",
                    Model = "GLC",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 45.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://www.pngmart.com/files/22/Mercedes-Benz-G-Class-PNG-Isolated-Photos.png",
                    Make = "Mercedes-Benz",
                    Model = "G-Class",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 50.0m,
                    Available = true
                },
                
                // Audi
                new Car
                {
                    Image = "https://file.kelleybluebookimages.com/kbb/base/evox/CP/50245/2023-Audi-A3-front_50245_032_2400x1800_2Y2Y.png",
                    Make = "Audi",
                    Model = "A3",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://platform.cstatic-images.com/xlarge/in/v2/stock_photos/0ec4ca7b-51ca-4911-9915-67dc18aedbd6/78afd191-7f78-49a0-884d-d625abffed6f.png",
                    Make = "Audi",
                    Model = "A4",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://inv.assets.sincrod.com/ChromeColorMatch/us/TRANSPARENT_cc_2022AUC020026_01_1280_L5L5.png",
                    Make = "Audi",
                    Model = "A6",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://static.tcimg.net/vehicles/primary/947e1de185d69753/2022-Audi-Q3-blue-full_color-driver_side_front_quarter.png",
                    Make = "Audi",
                    Model = "Q3",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 45.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://carsguide-res.cloudinary.com/image/upload/f_auto,fl_lossy,q_auto,t_default/v1/editorial/vhs/Audi-SQ5_0.png",
                    Make = "Audi",
                    Model = "Q5",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 50.0m,
                    Available = true
                },

                // BMW
                new Car
                {
                    Image = "https://d2ivfcfbdvj3sm.cloudfront.net/7fc965ab77efe6e0fa62e4ca1ea7673bb25f43520e1e3d8e88cb/stills_0640_png/MY2022/15235/15235_st0640_116.png",
                    Make = "BMW",
                    Model = "3 Series",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://img.sm360.ca/ir/w640h390c/images/newcar/ca/2022/bmw/serie-3-phev/330e/sedan/exteriorColors/13800_cc0640_032_b39.png",
                    Make = "BMW",
                    Model = "5 Series",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://www.cars.com/i/large/in/v2/stock_photos/5c918baa-eafd-4442-9cb4-3251f4bae9fb/8c1ed99e-aab0-4306-9677-300ff36c7499.png",
                    Make = "BMW",
                    Model = "7 Series",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://images.carprices.com/pricebooks_data/usa/colorized/2022/BMW/View2/X3/xDrive30i/22XD_C3Z.png",
                    Make = "BMW",
                    Model = "X3",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 45.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://file.kelleybluebookimages.com/kbb/base/evox/CP/44114/2022-BMW-X5%20M-front_44114_032_2400x1800_C3G_nologo.png",
                    Make = "BMW",
                    Model = "X5",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Manual shifted",
                    DailyRate = 50.0m,
                    Available = true
                },

                // Tesla
                new Car
                {
                    Image = "https://file.kelleybluebookimages.com/kbb/base/evox/CP/50747/2022-Tesla-Model%20S-front_50747_032_2400x1800_PPSW.png",
                    Make = "Tesla",
                    Model = "Model S",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 30.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://platform.cstatic-images.com/xlarge/in/v2/stock_photos/ecbc4cd8-5926-4f8e-b320-56d6e4e14665/c367339b-1dd0-41a0-b2d8-21811fa73fe4.png",
                    Make = "Tesla",
                    Model = "Model 3",
                   Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 35.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://platform.cstatic-images.com/xlarge/in/v2/stock_photos/df07b1bd-b61c-4018-adc4-ff5ebceda4a1/69a1ecee-0c43-4c9a-ae0f-ab5dcf523d96.png",
                    Make = "Tesla",
                    Model = "Model X",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 40.0m,
                    Available = true
                },

                new Car
                {
                    Image = "https://www.pngmart.com/files/22/Tesla-Model-Y-PNG-Photo.png",
                    Make = "Tesla",
                    Model = "Model Y",
                    Seat = 5,
                    Doors = 5,
                    Shift = "Automatic transmission",
                    DailyRate = 45.0m,
                    Available = true
                },

            };

            // Add the Car objects to the context
            context.Car.AddRange(cars);

            // Save the changes to the database
            context.SaveChanges();
        }
    }
}
