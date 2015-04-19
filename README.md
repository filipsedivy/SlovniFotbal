# Slovní fotbal #

Program pro automatické klikání slov dle slovníku.

Vytvořeno pro [Slovní fotbal - Hry.cz](http://www.hry.cz/slovni-fotbal)

----------

:no_entry_sign: Dle pravidel je možné **blokovat celý** účet. Jedná se totiž o výhodu ve hře. 
:baby: *Časem bude doplněna API dokumentace*

----------

## Vývoj programu ve Visual Studiu ##
Pokud chcete podpořit vývoj můžete pomocí tohož že si vytvoříte *fork* tohoto repositáře a ve složce *src/* soubor *SlovniFotbal.sln*.
Pro dotažení základních knihoven z NuGetu je nutné prvně kompilovat program přes **Run** nebo po inicializaci NuGet Console obnovit knihovny přes žlutou lištu a tlačítkem **Restore**
V případě že žlutá lišta zde není je možné napsat do konzole příkaz:
> nuget install packages.config

Nebo

> nuget restore SlovniFotbal.sln

![NuGet Console](http://i.imgur.com/vJ27mvp.jpg)

*Pozn.:* Pro aktualizaci knihoven můžete použít v NuGet Console příkaz
> Update-Package 

## Spuštění programu bez Visual Studia ##
1. Stáhněte si celý repositář pomocí *Download ZIP* tlačítka
2. Extrahujte pomocí [Windows ZIP](http://windows.microsoft.com/cs-cz/windows-8/zip-unzip-files "Windows ZIP")
3. Přejděte do složky *build/*
4. A spusťte program *Compilator.bat*
5. Po dokončení kompilace bude otevřena složka spolu se soubory
6. Následně můžete spustit aktuální verzi aplikace *SlovniFotbal.exe*

## Mapa vývoje ##
- [ ] Odchycení hlaviček z hry 
- [ ] Online slovník
- [ ] Offline slovník
- [x] Převedení tříd do angličtiny <small>(1.0.1)</small>
- [x] Ověření existence knihoven při startu
- [x] Práce s registry

## Vývojové diagramy ##

### Rozhodovací diagram pro automatické klikání ###
![Rozhodovací diagram pro automatické klikání](http://i.imgur.com/ztPhQR2.png)