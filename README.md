# Labo 1 - Classes
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
> Tip1: Denk aan de [naming conventions](https://github.com/PXL-Digital/PXL_Coding_Conventions/blob/main/CSharp/csharp_conventions.md#conventies)!

> [!TIP] 
> Tip2: Gebruik de code-snippet "propfull" om snel een variabele met property aan te maken

- Maak een readonly property aan met de naam ```Age``` die de leeftijd van een werknemer retourneert
- Maak een default constructor aan voor de klasse
- Maak een constructor aan waarbij *firstName* en *lastName* als parameter kunnen worden meegegeven

> [!TIP] 
> Tip3: Gebruik de code-snippet "ctor" om snel een constructor aan te maken
- Maak een methode ```IncreaseSalary``` die een integer met de naam ```percentage``` als parameter heeft. De methode moet het huidige salaris procentueel verhogen

> [!CAUTION] 
> Tip4: Een vermenigvuldiging of een deling van een decimal door een integer resulteert altijd in een integer
- Voeg onderstaande functie toe aan de *Employee* klasse. *Deze functie zorgt ervoor dat wanneer een werknemer als tekst (string) wordt weergegeven, de voornaam en achternaam worden getoond*
	```
	public override string ToString()
	{
		return $"{this.FirstName} {this.LastName}";
	}
	```
- **Open het code-behind bestand *MainWindow.xaml.cs* en implementeer de nieuwe klasse!** (zie TODO's)

- Maak een nieuwe klasse ```Address``` aan met 4 eigenschappen:
	- ```string street``` 
	- ```string number``` 
	- ```string zipcode``` 
	- ```string city``` 
- Maak een extra eigenschap aan in de *Employee* klasse van het type *Address*
- Zorg dat je voor elke nieuwe werknemer ook het adres kan ingeven, voeg hiervoor onderstaande XAML code toe net boven de "Toevoegen"-knop:
```
<Grid x:Name="addressGrid">
    <Grid.RowDefinitions>
        <RowDefinition/>
        <RowDefinition/>
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition/>
        <ColumnDefinition/>
        <ColumnDefinition/>
    </Grid.ColumnDefinitions>
    <TextBox x:Name="streetTextBox" Margin="10,0,10,10" Padding="5" Grid.ColumnSpan="2"/>
    <TextBox x:Name="numberTextBox" Margin="10,0,10,10" Padding="5" Grid.Column="2"/>
    <TextBox x:Name="zipcodeTextBox" Margin="10,0,10,10" Padding="5" Grid.Row="1"/>
    <TextBox x:Name="cityTextBox" Margin="10,0,10,10" Padding="5" Grid.Row="1" Grid.Column="1" Grid.ColumnSpan="2"/>
</Grid>
```

#### Extra
##### Ontslag
- Voeg een extra knop toe aan de detail-sectie waarmee een werknemer uit de lijst verwijderd kan worden

##### Documentatie
- Voeg documentatie toe aan de properties en functies van de *Employee* klasse
- Ga terug naar het *MainWindow.xaml.cs* bestand en bekijk het resultaat wanneer je de *Employee* klasse gebruikt

### Deel 2
- Maak een nieuw project aan in de bestaande solution en noem dit HrApp.Shared, gebruik hiervoor de template *Class Library*
- Verwijder het bestaande *Class1.cs* bestand 
- Verplaats de bestaande klasses ```Employee``` en ```Address``` naar het nieuwe project, pas de namespace aan naar ```HrApp.Shared```
- Zorg ervoor dat de nieuwe klasse kan gebruikt worden in het HrApp.UI project
- Maak een default constructor in de *Employee* klasse waarin de *address* variabele geïnitialiseerd wordt
- "Chain" de default constructor aan de constructor met *firstName* en *lastName* als parameter
- Maak een Class Diagram ```EmployeeDiagram``` in het *HrApp.Shared* project, voeg zowel de *Employee* als de *Address* klasse toe aan dit diagram