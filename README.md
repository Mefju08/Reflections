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