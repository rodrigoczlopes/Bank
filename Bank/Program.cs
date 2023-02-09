using Bank;

//ContaCorrente contaRodrigo = new ContaCorrente();
//contaRodrigo.titular = "Rodrigo";
//contaRodrigo.numeroagencia = 17;
//contaRodrigo.conta = "1785-X";
//contaRodrigo.saldo = 500;

//Console.WriteLine("Conta do Rodrigo possui esse saldo R$" + contaRodrigo.saldo);

//ContaCorrente accountJuliete = new ContaCorrente();
//contaJuliete.titular = "Juliete";
//contaJuliete.numeroagencia = 13;
//contaJuliete.conta = "1785-X";
//contaJuliete.saldo = 800;

//Console.WriteLine("Conta da Juliete possui esse saldo R$" + contaJuliete.saldo);

Cliente client = new Cliente();
client.nome = "Rodrigo Lopes";
client.cpf = "89565874565";
client.profissao = "Desenvolvedor";

ContaCorrente conta = new ContaCorrente();
conta.titular = client;
conta.conta = "1010-X";
conta.numeroagencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("Cpf = " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("Nº da conta = " + conta.conta);
Console.WriteLine("Nº da agência = " + conta.numeroagencia);
Console.WriteLine("Saldo = " + conta.saldo);


