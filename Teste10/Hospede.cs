namespace Course{
    class Hospede{
        public string Name { get; set; } 
        public string Email { get; set; }
        public int Quarto { get; set; }
        
        public Hospede(string name, string email, int quarto){
            Name = name;
            Email = email;
            Quarto = quarto;
        }

    }
}