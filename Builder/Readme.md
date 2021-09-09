# **Builder (Budowniczy)**
Budowniczy jest **kreacyjnym** wzorcem projektowym, który daje możliwość tworzenia złożonych obiektów krok po kroku. Wzorzec ten pozwala produkować różne typy oraz reprezentacje obiektu używając tego samego kodu konstrukcyjnego.

## Statystyki
---
| Klucz | Wartosć |
| ------| --------|
| Typ wzorca | Wzorzec Kreacyjny |
| Popularność | 3 / 3 |
| Trudność | 1 / 3 |


## Wykorzystanie
---
Tworzenie obiektów o różnych konfiguracjach.


## Wykorzystany interface
---

```    
public interface IBuilder
{
    public void Reset();

    public Man GetMan();

    public void AddPartMoney();

    public void AddPartFame();

    public void AddPartInteligence();

    public void AddPartStamina();

    public void AddPartName();
}
```

## Moje uwagi
---

Bardzo dobrze może zastąpić klasyczne tworzenie obiektów ( Wprowadzanie danych w konstruktor )

Opcji na stworzenie tego wzorca jest naprawde bardzo dużo, w tym przypadku demonstruje wykorzystanie interface dla automatycznego tworzenie dwóch rodzajów obiektów 