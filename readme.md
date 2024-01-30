# Lern-Periode 3

Szymon Rybicki

9.1.2024 bis 30.1.2024 (☃️ Sportferien)

## Grob-Planung

Meine Note sind sehr gut. Mein beste Note war von Modul 162, da ich anhand Rückmeldung eine sehr gute Portfolio geschrieben habe. Und ich denke, dass diese Modul wichtig war, da anhand Wissen aus denen werden wir noch zwei Module bearbeiten. Ich bin aber nicht so weit mit Aufträgen aus Modul 177, und es ist auch ein wichtiger und komplizierter Modul.

Am ende von LP2 habe ich mir vorgenommen, dass wenn ich ein Problem habe, soll ich  dieses mit ein Muster lösen. Öfters habe ich Probleme mit Erfahrung versucht zu lösen,  was nicht immer der Fall war. Mit Mein Muster erkläre ich mein Problem, vermute warum es entstanden ist, erinnere ich mich nach Hauptziel und versuche eine Lösung zu stellen. 

Benutztung von Muster kann ich gut üben, wenn der Zugang zu Muster leicht ist und  wenn oft ein Problem während meiner Arbeit vorkommt.

Ich möchte an meinen alten Projekt, nähmlich Tic Tac Toe wiederarbeiten. Mit dieses Projekt habe ich plötzlich aufgehört, was aber mein erstes fertig-gestellte Spiel Projekt sein kann. Ich möchte bis jetzt gelernte Methoden anwenden aber natürlich nicht ganz von Anfang beginnen, sondern Wissen und Code aus damals nutzten.

## 9.1.2024

Heute habe ich mich erinnert, wie kann ich besser Arbeiten anhand Erfahrung aus Lernperiode 2. Anhand meiner Entscheidung, dass ich wieder an meinem alten Projekt arbeiten werde, erstellte ich Grobplanung. Dazu habe ich noch die ersten vier Arbeitspaketen erstellt, die präzis sind. Ich habe heute konzentriert gearbeitet und bin zufrieden, dass alles jetzt geplannt ist. (55)

## 16.1.2024

- [x] ein kopierbares Muster als Txt erstellen, der die 4 fragen stellt
- [x] Titel und Menu erstellen. Das menu hat blintzende Hintergrundfarbe.
- [x] beginnt das Spiel, wird das Tic Tac Toe board gezeigt
- [x] Feld anhand Eingabe von Benutzer mit Symbol bedecken

| estfall-Nummer | Ausgangslage (Given)                  | Eingabe (When)          | Ausgabe (Then)                                              | Erfüllt? |
| -------------- | ------------------------------------- | ----------------------- | ----------------------------------------------------------- | -------- |
| 1              | Muster txt File kopiert               | Muster geöffnet         | Problem: Warum: Ziel: Lösung:                               | Ja       |
| 2              | Einführung für app wurde programmiert | Programm wird gestartet | Tic Tac Toe als Titel, Menu mit "Choose Symbol" und "Close" | Ja       |
| 2.1            | Programm wurde gestartet              | s                       | "Choose Symbol" text blintzelt schnell 3 mal                | Ja       |
| 3              | Programm gestartet, Symbol gewählt    | -                       | Board zu Spiel wird gezeigt                                 | Ja       |
| 4              | ...symbol gewählt, Spiel gestartet    | 1                       | Feld 1 wird mit Symbol bedeckt                              | Ja       |

✍️ Heute am 16.1 habe ich mit den Erstellung von Muster angefangen. Ich habe es "Problem2Solution" bennant und in Order getan, wo ich dazu schnellen Zugriff habe. Danach habe ich mit den Projekt richtig angefangen. Ich habe Menu erstellt und mit den blintzenden Effekt mich beschäftigt, was schlussendlich sehr toll aussieht. In Plannung habe ich vergessen, dass ich noch ein Menu für Symbole erstellen muss. Das hat mich überrascht, war aber kein Problem, den das war ähnlich wie Menu früher. Gegenende habe ich Brett eingebaut, und eine gute Lösung für Zahl Eingabe gefunden, statt mit switch – case zu arbeiten. (99)

## 23.1.2024

- [x] Fehler eingaben von Benutzer fangen, und wieder nach Zahl fragen.

- [x] Nicht erlauben, dass der Benutzer schon bedeckte Ort eingeben kann

- [x] Ein Generator erstellen, der zufallig eine erlaubte Zahl auswählt

- [x] Nach jeder Runde des Benutzer kommt der Generator und bedeckt ein Feld

- [ ] (Nach Gewinn prüfen (ex. if field 1&&4&&7 ==  gleiche Symbol dann spiel beenden und "Gewinn" ausgeben)

| Testfall-Nummer | Ausgangslage (Given)                                    | Eingabe (When) | Ausgabe (Then)                                                                     | Erfüllt? |
| --------------- | ------------------------------------------------------- | -------------- | ---------------------------------------------------------------------------------- | -------- |
| 5               | ... Symbol gewählt, benutzer ist nach Koordinat gefragt | abc            | Invalid Field                                                                      | ja       |
| 6               | ... Symbol gewählt, benutzer ist nach Koordinat gefragt | 1              | Field already taken                                                                | jain     |
| 7               | Spiel gestartet                                         | -              | int BotField = random number                                                       | ja       |
| 8               | ... Benutzer gibt den Koordinat an                      | 1              | (Feld 1 ist bedeckt) (dann bedeckt der Komputer ein anderes Feld anhand Generator) | ja       |

✍️ Heute am 23.1 habe ich mich viel mit Ausnahmen beschäftigt, sodass das Spiel ordentlich bleibt. Nun kann der Benutzter nur eine Zahl eingeben. Mit dieser Änderung würde auch das zweite Anforderung gelöst. Danach habe ich mich an den Komputer Reihe gearbeitet. Ich habe gedacht, dass es gleich wie mit den Benutzer wird, war eber nicht so. Es hat mir lange gedauert, um herauszufinden, wie ich richtig Zufallzahl mit Zahl aus Spielbrett vergleiche. Während der Arbeit habe ich drei mal meine Vorlage benutzt. Das hat mir aber geholfen, auf den Problem von aussen zu schauen, und konnte direkt eine Lösung vermuten. Leider ist das Spiel nicht fertig, wie ich es möchte. (110)



## 30.1.2024

✍️ Heute am 23.1 habe ich am Anfang mein Code geputzt. Das heisst, dass nun in upload 3 gibt es Code, mit Variablen die Sinn machen. Auch Funktionen, wie InvertedSymbol, würde zu InvertSymbol, geben den Code einen mehr lesbaren Blick. Danach habe ich mein Profil auf Github gestaltet. Und noch eine Github website erstellt. Alle heutige Ziele erfüllte ich mit Hilfe von Checklisten, damit ich nicht während Arbeit vergesse. Und das ist gut gegangen. (73)

## Reflexion

Während dieser Lernperiode ist mir Paar Mal gefallen, dass ich meine Vorlage benutzte, oder dass ich mir überlegete warum habe ich gerade ein Prolem und was mein Ziel ist. Somit war ein Verbessrungsvorschlag eine tolle Idee. Die Vorlagen haben mir paar mal geholfen. Habe ich bemerkt, dass ich in ein Problem stecke, öffnete ich diese Datei und überlegte ich mir. Es braucht aber eine Übung, um zu merken, wann ich dies brauche. Manchmal bemerkte ich erst später, dass ich zu viel an einen Problem steckte.

Nun ist die dritte Lerperiode vorbei. Die war dazu, um an einen kleineren Projekt bis ende zu arbeiten. Auf einer Seite fand ich das super. Ich habe am bisschen was ausprobiert, was in Schlusseffekt dazu führte, dass mein Spiel sehr einfach und schön ist. Sie ist viel besser als die erste, weil ich Zeit hatte, um nur am Verbesserung zu denken. Aber auf der andere Seite konnte ich in einen längeren Lernperiode mehr ausprobieren. Und hatte auch Zeit gehabt, um Lernstoff nachzuholen. Deswegen komme ich auf die Meinung, dass ich nächste Arbeitszeit so aufteilen soll, dass ich gegend Ende Zeit verbringe, um das, an was ich arbeite, auf schöneres Niveau bringe. (198)
