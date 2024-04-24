using UdemyIOC.Console;

BL bl = new BL(DALFactory.GetSQLDal());

bl.GetProducts().ForEach(p =>
{
    Console.WriteLine($" {p.Id} {p.Name} {p.Price} {p.Stock} ");
});
