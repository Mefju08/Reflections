# 🧩 Zadanie 1 – Analiza typu (Type Inspection)

## 🎯 Cel zadania

Napisz program, który:

1. Przyjmie dowolny obiekt jako parametr.
2. Wypisze:
   - pełną nazwę typu obiektu,
   - wszystkie publiczne i prywatne właściwości wraz z ich typami,
   - wszystkie pola (w tym prywatne),
   - wszystkie **normalne** metody (bez getterów i setterów), z nazwami i parametrami.

---

# 🧩 Zadanie 2 – Dynamiczne tworzenie i modyfikacja obiektu

## 🎯 Cel zadania

Napisz klasę, która:

1. Przyjmuje dowolny obiekt (np. `User`) jako wejście,
2. Tworzy **nową instancję** tego samego typu dynamicznie przez refleksję,
3. Ustawia wybrane właściwości nowej instancji na podstawie słownika (`Dictionary<string, object>`),
4. Zwraca nowy obiekt z nadpisanymi danymi.

---

# 🧩 Zadanie 3 – Dynamiczne wywoływanie metody

## 🎯 Cel zadania

Napisz klasę/metodę, która:

1. Przyjmie dowolny obiekt,
2. Odczyta listę jego publicznych metod (pomijając gettery i settery),
3. Znajdzie metodę o określonej nazwie (np. `"Greet"`),
4. Wywoła ją dynamicznie na przekazanym obiekcie,
5. (Opcjonalnie) Obsłuży sytuację, gdy metoda o podanej nazwie nie istnieje.

---

# 🧩 Zadanie 4 – Odczyt i modyfikacja pól prywatnych

## 🎯 Cel zadania

Stwórz klasę, która:

1. Przyjmuje jako argument instancję obiektu dowolnego typu,
2. Wyszukuje wszystkie prywatne pola zdefiniowane **bezpośrednio** w klasie,
3. Znajduje pole o określonej nazwie (np. `_pesel`),
4. Aktualizuje jego wartość na nową,
5. Pomija pola generowane automatycznie przez kompilator (`k__BackingField`).

---

# 🧩 Zadanie 5 – Tworzenie obiektu przez konstruktor z parametrami

## 🎯 Cel zadania

Napisz klasę, która:

1. Odszuka w klasie odpowiedni konstruktor,
2. Sprawdzi, czy przekazane argumenty pasują typami do parametrów konstruktora,
3. Utworzy nowy obiekt przy pomocy `ConstructorInfo.Invoke`.

---

# 🧩 Zadanie 6 – Wywoływanie metody z argumentami przez refleksję

## 📋 Opis

Zaimplementuj klasę, która:

1. Przyjmuje dowolny obiekt (`object`),
2. Przyjmuje nazwę metody (`string`),
3. Przyjmuje listę argumentów (`object[]`),
4. Wyszukuje metodę o danej nazwie i wywołuje ją, przekazując argumenty.

---

# 🧩 Zadanie 7 – Dynamiczny getter i setter (pola i właściwości)

## 📋 Opis

Zaimplementuj klasę, która udostępnia dwie metody:

- `object GetValue(object obj, string memberName)` – odczytuje wartość pola lub właściwości,
- `void SetValue(object obj, string memberName, object value)` – ustawia wartość pola lub właściwości.

# 🧩 Zadanie 8 – Odczytywanie atrybutów z pól i właściwości

---

## 📋 Opis

Zaimplementuj klasę, która:

1. odczytuje atrybuty przypisane do pól i właściwości obiektu,
2. wypisuje nazwę członu (pole/właściwość) oraz typ atrybutu,
3. ignoruje pola kompilatora (`k__BackingField`).

---
# 🧩 Zadanie 9 – Wyszukiwanie klas implementujących interfejs i uruchamianie metody

## 📋 Opis

Zaimplementuj klasę, która:

1. znajdie wszystki typy implementujące interfejs `IRunnable`,
2. wywoła metodę `Run()`.