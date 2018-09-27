namespace XamarinFormsAcordeonListView
{
    public class AcordeonListViewViewModel 
    {
        public Customer[] Customers { get; set; }

        public AcordeonListViewViewModel()
        {
            Customers = new Customer[]
            {
                new Customer{ Name= "Yas" , LastName = "Moradi" , CustomerNumber = 1 , PhoneNumber = 44889511, Address = "Tehran, 32Street,1Allay,Number3 "},
                new Customer{ Name= "Mary" , LastName = "Sangtarash" , CustomerNumber = 2 , PhoneNumber = 55781266, Address = "Tehran, 42Street,2Allay,Number2 "},
                new Customer{ Name= "Nima" , LastName = "Hakim" , CustomerNumber = 3 , PhoneNumber = 55221146, Address = "Tehran, 84Street,6Allay,Number3 "},
                new Customer{ Name= "Roya" , LastName = "Moheb" , CustomerNumber = 4 , PhoneNumber = 45612352, Address = "Tehran, 84Street,6Allay,Number5 "},
                new Customer{ Name= "Neda" , LastName = "Davodi" , CustomerNumber = 5 , PhoneNumber = 52525365, Address = "Tehran, 94Street,8Allay,Number3 "},
            };
        }
    }

    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }

        public int CustomerNumber { get; set; }
    }
}
