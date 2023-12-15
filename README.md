# RailHackaton2023
RailHackaton2023 startup omgeving

## IMX Hackathon – Opdracht Integregen van alignementen
Wat leuk dat jullie mee doen aan de hackathon! Jullie opdracht vandaag gaat over het integreren van alignementen. Het doel is om gezamenlijk op een manier te komen hoe we automatisch alignementen kunnen integreren. Dit kan een proces of stroomschema zijn waar de ontwerper zich aan moet houden maar kan ook een stuk code zijn waarin dit proces (deels) is geïmplementeerd.
Voordat de opdracht uitgebreid wordt uitgelegd is het eerst belangrijk wat terminologie vast te leggen:
-	Init1: dit is de initiële situatie waarop je je ontwerp hebt gebasseerd;
-	New1: dit is jouw ontwerp; 
-	Init2: de situatie die je dient te integreren met jouw ontwerp. Dus de nieuwe situatie waarop je jouw ontwerp moet baseren;
-	New2: dit is het eindresultaat van de integratie met zowel de wijzigingen van init1 naar init2 en de wijzigingen van init1 naar new1.

De opdracht van vandaag is gebasseerd op een situatie die voorkwam bij EHL. In deze situatie hadden wij een wissel verwijderd, maar op datzelfde stuk spoor was een alignements correctie doorgevoerd door ProRail. Wanneer wij onze situatie (new1) zouden blijven handhaven, misten we de wijzigingen van het alignement (init2) en vice versa. Uiteindelijk hebben we eieren voor ons geld gekozen en deze automatisering handmatig doorgevoerd.
Het doel van vandaag is om met een methode te komen zodat dit in het vervolg niet handmatig zou hoeven. Er komen een hoop verschillende aspecten kijken bij het integreren van alignementen, daarom hebben we dit opgesplitst in vier verschillende (sub)casussen. Voor elke casus is een init1, init2, en new1 bestand gemaakt wat jullie als input kunnen gebruiken. Daarnaast heeft elke casus een new2 bestand. Dit kunnen jullie gebruiken om jullie uitkomst te testen.
## Casussen
De eerste casus hebben we opgesplitst in drie subcasussen (A, B, C) waarbij er telkens een element bij komt. In alle drie de casussen is het geval dat init1 een recht stuk spoor is met daarop drie wissels. Jij hebt het middelste wissel verwijderd. ProRail heeft echter iets gewijzigd aan het stuk spoor tussen wissel 2 en wissel 3. Nu aan jou de taak om de wijzigingen met elkaar te integreren zodanig dat je beide wijzigingen in new2 hebt. In Figuur 1 is een weergave van init1 te zien voor de casussen 1A en 1B.
 ![image](https://github.com/Sweco-NL/RailHackaton2023/assets/65706549/8013be2c-64fa-48cb-99da-9f82736729fc)

Figuur 1- Weergave van init 1 voor casus 1A en 1B
### Casus 1A
Bij casus 1A wordt alleen de z-ligging van het spoor gewijzigd. Hierbij hoeft er dus nog geen rekening gehouden te worden met de x,y-ligging of objecten naast het spoor. Alle overige aspecten dienen wel mee te worden genomen. Deze casus is schematisch weergegeven in Figuur 1.

 ![image](https://github.com/Sweco-NL/RailHackaton2023/assets/65706549/e0d07621-785e-4892-994f-5e61a13606fa)

Figuur 2- Casus 1-A,B: schematische weergave van input en output bestanden.
### Casus 1B
Het verschil tussen casus 1A en 1B is dat bij 1B niet alleen de z-ligging is gewijzigd maar ook de x,y-ligging. Zorg dat je alle drie de richtingen correct meenemeent naar new2. De schematische weergave is weergegeven in Figuur 1.
### Casus 1C
Tot nu toe hebben hoefde er alleen maar gekeken worden naar de spoorligging. Echter, liggen er buiten allemaal objecten naast het spoor. Deze moeten ook worden meegenomen bij een integratie. Als de spoortak van richting verandert zul je mogelijk aanpassingen moeten doen. In dat geval moet de railconnectioninfo worden aangepast, zoals de AtMeasure en de Direction.
 
![image](https://github.com/Sweco-NL/RailHackaton2023/assets/65706549/939e1b90-fbd0-402c-a997-c3bfeb5910b7)

Figuur 3 – Casus 1c

### Casus 2
Casus 2 lijkt in veel gevallen op casus 1C, maar nu is door een ander project ook een wissel toegevoegd tussen onze wissels 9083 en 9089. We beschouwen in dit geval dat andere project als Init2. De objecten langs het spoor moeten worden geprojecteerd op de nieuwe spoorassen, denk na over de richtingen van spoortakken, en atmeasures van objecten.
 ![image](https://github.com/Sweco-NL/RailHackaton2023/assets/65706549/0d7e0a23-d96d-4d41-8cfc-56aec843ad49)

Figuur 4 - Casus 2


