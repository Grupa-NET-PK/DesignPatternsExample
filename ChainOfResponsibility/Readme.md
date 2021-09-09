# **Chain of Responsibility**
Łańcuch zobowiązań jest **behawioralnym** wzorcem projektowym, który pozwala przekazywać żądania wzdłuż łańcucha obiektów obsługujących. Otrzymawszy żądanie, każdy z obiektów obsługujących decyduje o przetworzeniu żądania lub przekazaniu go do kolejnego obiektu obsługującego w łańcuchu.

## Statystyki
---

| Klucz | Wartosć |
| ------| --------|
| Typ wzorca | Wzorzec Behawioralny |
| Popularność | 1 / 3 |
| Trudność | 2 / 3 |


## Wykorzystanie
---
Obsługa zapytań, obsługa komend i wszędzie tam gdzie trzeba wykonać okreslona ilość rzeczy po sobie.

## Wykorzystany interface
---

```
internal interface IChain
{
    public void SetNext(IChain chain);

    public object Execute(string test);
}
```

## Moje uwagi
---
Wzorzec ten można wykorzystać tak jak w opisie czyli albo wykonujemy i zwracamy null lub przekazujemy dalej, jest to tylko sugestia. Wzorzec można tworzyć dowolnie i tak będzie wzorcem. 