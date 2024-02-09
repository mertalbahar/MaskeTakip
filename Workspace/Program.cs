using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Engin";

Person person2 = new Person();
person2.FirstName = "Murat";

Person person3 = new Person();
person3.FirstName = "Mertal";
person3.LastName = "Bahar";
person3.DateOfBirthYear = 1987;
person3.NationalIdentity = 21321321321;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person3);

PharmacyManager pharmacyManager = new PharmacyManager(new PersonManager());
pharmacyManager.GiveMask(person2);