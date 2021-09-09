# **Strategy**
Strategia to **behawioralny** wzorzec projektowy zakładający przekształcenie zestawu zachowań w obiekty, które można stosować zamiennie w pierwotnym obiekcie

## Statystyki

| Klucz | Wartosć |
| ------| --------|
| Typ wzorca | Wzorzec Behawioralny |
| Popularność | 3 / 3 |
| Trudność | 1 / 3 |


## Wykorzystanie

Zmiana funkcionalności bez konieczności roszerzania klasy
## Wykorzystany interface


```
internal interface IStrategy
{
    public string DoThing(TestClass test);
}
```

## Moje uwagi

Moim zdaniem jest to jedno z podstawowych użyć interfaców