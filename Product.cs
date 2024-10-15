using System.ComponentModel;
using System.Data.Common;

public class Product
{

    public int id;
    public string name;

    public decimal price;

    public Product(int id, string name, decimal price)
    {
        // this keyword'ü bu sınıfa ait demektir.
        // aşağıdaki ctor atamalarında, genelde ctora parametre olarak gelen değerler ile
        // sınıf içerisindeki değişkenlerin isimleri birbirine karıştırılabilir
        // bu karışıklığı önlemek adına, class'in değişkenlerini farklı isimlendirebilirsiniz
        // yada this keyword'ü kullanarak değişkenlerin bu sınıfın üyesi olduğunu yani ctor parametresi 
        // olmadığını söyleyebilirsiniz
        this.id = id;
        this.name=name;
        this.price = price;
    }
}