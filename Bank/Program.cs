using Bank;

CurrentAccount contRodrigo = new CurrentAccount();
contRodrigo.holder = "Rodrigo";
contRodrigo.agnumber = 17;
contRodrigo.cont = "1785-X";
contRodrigo.saldo = 500;

Console.WriteLine("Conta do Rodrigo possui esse saldo R$" + contRodrigo.saldo);