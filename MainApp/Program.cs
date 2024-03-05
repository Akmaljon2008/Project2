using Domain.Models;
using Infrastracture.Services;

var cs = new CustomerService();
var tr = new TranzactionService();
var t = new Tranzaction();
t.SenderId = 3;
t.TakerId = 4;
t.Sum = 150;
tr.MakeTranzaction(t);