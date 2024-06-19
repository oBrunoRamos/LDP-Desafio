Autor a1 = new Autor("Bruno", "Brasileiro");
a1.mostrarInfo();
Livro l1 = new Livro("Primeiro Livro", a1 , 2500.50);
l1.mostrarInfo();
l1.aplicarDesconto(2.5);
l1.mostrarInfo();
l1.aplicarDesconto(2000);
l1.mostrarInfo();