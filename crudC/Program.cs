
using crudC.conn;
using crudC.models;

// User user=new User();
// Conn conn= new Conn();
// String sql="select * from public.usuarios u ";
// conn.runSqlDataTable(sql);
// // var status=conn.openConn();
// // var statusC=conn.closeConn();

// Coche coche=new Coche(){Modelo="Sail"};
// coche.getInformation();
// coche.acelerar();

// Console.WriteLine("Final app");
// // Console.WriteLine(user);


// Acount acount=new Acount(){Titular="Jorge Luis Ortiz",NumeroCuenta=22048788};
// acount.depositar(1200);
// acount.retirar(-1200);

// Console.WriteLine("d");
// Console.WriteLine("d");
// Acount acount= new Acount{};

// AcountAhorro acountAhorro=new AcountAhorro(){Titular="Jorg Ortiz"};

// Console.WriteLine("d");


AcountAhorro acountAhorro = new AcountAhorro();
        
        // Mostrar saldo inicial
        Console.WriteLine("Saldo inicial: " + acountAhorro.saldo);
        Console.WriteLine("Interes: " + acountAhorro.Interes);


        // Realizar pago
        acountAhorro.pagar(100);  // Aumenta el saldo en 100
        
        // Mostrar saldo después del pago
        Console.WriteLine("Saldo después del pago: " + acountAhorro.saldo);

