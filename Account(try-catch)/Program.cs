using AccountTryCatch;

var login = "dimonkk";
var password = "123456789";
var account = new Account(login, password, password);
Console.WriteLine(account.CorrectAccount);
