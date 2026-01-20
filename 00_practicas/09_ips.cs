List<string> ips = ["192.168.1.1", "10.0.0.5", "172.16.0.10"] ;
 ips.Add("185.20.1.5") ;
 var total = ips.Count ;
string sospechosa = ips[total - 3] ;
Console.WriteLine ($"La cantidad de ips son {total}. La sospechosa es {sospechosa}.") ;