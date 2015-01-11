using System;

    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.Write("Company name: ");
            var temp0 = Console.ReadLine();
            string companyName = String.IsNullOrWhiteSpace(temp0) ? "no company name" : temp0;

            Console.Write("Company address: ");
            var temp1 = Console.ReadLine();
            string companyAddress = String.IsNullOrWhiteSpace(temp1) ? "no company address" : temp1;

            Console.Write("Phone number: ");
            var temp2 = Console.ReadLine();
            string phoneNumber = String.IsNullOrWhiteSpace(temp2) ? "no phone" : temp2;

            Console.Write("Fax number: ");
            var temp3 = Console.ReadLine();
            string faxNumber = String.IsNullOrWhiteSpace(temp3) ? "no fax" : temp3;

            Console.Write("Web site: ");
            var temp4 = Console.ReadLine();
            string webSite = String.IsNullOrWhiteSpace(temp4) ? "no web site" : temp4;

            Console.Write("Manager first name: ");
            var temp5 = Console.ReadLine();
            string managerFirstname = String.IsNullOrWhiteSpace(temp5) ? "no manager first name" : temp5;

            Console.Write("Manager last name: ");
            var temp6 = Console.ReadLine();
            string managerLastname = String.IsNullOrWhiteSpace(temp6) ? "no manager last name" : temp6;

            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());

            Console.Write("Manager phone: ");
            var temp8 = Console.ReadLine();
            string managerPhone = String.IsNullOrWhiteSpace(temp8) ? "no manager phone" : temp8;

            Console.WriteLine("\n---\nCompany Information: ");
            Console.WriteLine("\n{0}" +
                              "\nAddress: {1}" +
                              "\nTel. {2}" +
                              "\nFax: {3}" +
                              "\nWeb site: {4}" +
                              "\nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstname, managerLastname, managerAge, managerPhone
                              );
        }
    }

