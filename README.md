# HrApp# Labo 1 - Classes
## HrApp
In dit labo gaan we een bestaande HR applicatie uitbreiden door middel van classes

### Deel 1
- Maak een nieuwe klasse aan met de naam ```Employee```
- Maak 4 variabelen aan met telkens een bijhorende property:
	- ```string firstName```
	- ```string lastName```
	- ```DateTime birthDate```
	- ```decimal salary```
> [!TIP] 
> Tip: Denk aan de [naming conventions](https://github.com/PXL-Digital/PXL_Coding_Conventions/blob/main/CSharp/csharp_conventions.md#conventies)!
- Maak een readonly property aan met de naam ```Age``` die de leeftijd van een werknemer retourneert
- Maak een default constructor aan voor de klasse
- Maak een constructor aan waarbij *firstName* en *lastName* als parameter kunnen worden meegegeven
- Maak een methode ```IncreaseSalary``` die een integer met de naam ```percentage``` als parameter heeft. De methode moet het huidige salaris procentueel verhogen