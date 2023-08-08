namespace Employe;

public class Emploee
{
    int Id;
    string FirstName;
    string LastName;
    int Salary;
    public Emploee(int id, string firstName, string lastName,int salary)
    {
      Id=id;
      FirstName=firstName;
      LastName=lastName;
      Salary=salary;

    }
    public int GetId(){
        return Id;
    }
    public string GetFirstName(){
        return FirstName;
    }
    public string GetLastName(){
        return LastName;
    }
    public int GetSalary(){
        return Salary;
    }
    public void SetSalary(int salary){
        Salary=salary;
    }
    public int GetAnualSalary(){
      return Salary*12;
    }
    public int RaiseSalary(int persent){
    return Salary+((Salary*persent)/100);

    }
    public string ToString(){
    return $"Emploee [Id={Id},Name= {FirstName} , Lastname= {LastName} , Salary={Salary}] " ;
    }


}
