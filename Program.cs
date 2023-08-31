using MVP;

View view = new View();

Cliente cliente1 = new Cliente("Albert", "Esponey", "Reus", "4986533J", "23/03/2001");
Cliente cliente2 = new Cliente("Raul", "Aasd", "Reus", "1212233J", "4/01/1999");
Cliente cliente3 = new Cliente("Paco", "Fff", "Montbrio", "493434K", "5/03/1990");
Cliente cliente4 = new Cliente("Trump", "Gomez", "Tgn", "4986533L", "12/08/2005");
Cliente cliente5 = new Cliente("Marta", "Gonzalez", "bcn", "4986533M", "17/05/2004");
Cliente cliente6 = new Cliente("Maria", "askj", "Reus", "4986533N", "30/11/1995");
Cliente cliente7 = new Cliente("Joan", "Esdasda", "Tgn", "4986533P", "22/12/1890");

List<Cliente> clientes = new List<Cliente>();
clientes.Add(cliente1);
clientes.Add(cliente2);
clientes.Add(cliente3);
clientes.Add(cliente4);
clientes.Add(cliente5);
clientes.Add(cliente6);
clientes.Add(cliente7);

Controller controller = new Controller(clientes, view);
controller.Ejecutar();