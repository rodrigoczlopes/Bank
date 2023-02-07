using Bank;

CurrentAccount contRodrigo = new CurrentAccount();
contRodrigo.holder = "Rodrigo";
contRodrigo.agnumber = 17;
contRodrigo.cont = "1785-X";
contRodrigo.balance = 500;

Console.WriteLine("Conta do Rodrigo possui esse saldo R$" + contRodrigo.balance);

CurrentAccount contJuliete = new CurrentAccount();
contJuliete.holder = "Juliete";
contJuliete.agnumber = 13;
contJuliete.cont = "1785-X";
contJuliete.balance = 800;

Console.WriteLine("Conta da Juliete possui esse saldo R$" + contJuliete.balance);




