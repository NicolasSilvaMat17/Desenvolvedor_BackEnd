async Task Principal()
{
    Console.WriteLine("Pedido Anotado");
    await Task.WhenAll(PrepararHamburger(), PrepararBatata(), PrepararMilkShake());
    Console.WriteLine("Peido entregue! ");

}

async Task PrepararHamburger()
{
    Console.WriteLine("Preparando Hambúrguer...");
    await Task.Delay(3000);
    Console.WriteLine("Hamburguer pronto!");

}
async Task PrepararBatata()
{
    Console.WriteLine("Preparando Batata..");
    await Task.Delay(2500);
    Console.WriteLine("Batata pronta!");
}

async Task PrepararMilkShake()
{
    Console.WriteLine("Preparando Milk Shake...");
    await Task.Delay(4000);
    Console.WriteLine("Milk Shake pronto!");
}

await Principal();
// Task é usada para representar uma operação assíncrona que pode ser aguardada. Ela permite que você execute tarefas em segundo plano sem bloquear o thread principal, tornando o aplicativo mais responsivo.
// await é usado para aguardar a conclusão de uma operação assíncrona. Ele permite que você escreva código assíncrono de forma mais legível, evitando o uso de callbacks e tornando o fluxo de execução mais linear.