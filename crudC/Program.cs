
using crudC.conn;
using crudC.models;

User user=new User();
Conn conn= new Conn();
String sql="select * from public.usuarios u ";
conn.runSqlDataTable(sql);
// var status=conn.openConn();
// var statusC=conn.closeConn();

Console.WriteLine("Final app");
// Console.WriteLine(user);
