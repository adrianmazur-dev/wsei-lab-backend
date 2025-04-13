## STATE (techniki do zarządzania stanem)
- cookies (ciasteczka) - słownik klucz-wartość przechowywany w HTTP. 
- cache - przechowywanie w pamięci podręcznej danych, które są często pobierane z bazy danych w celu optymalizacji doświadczeń użytkownika

Przy użyciu REST API stanem zarządza klient. 
Najczęściej korzysta się z **nagłówków** oraz **query string**.
API REST nie powinno wspierać utrzymywania sesji.

## DEFINICJA JWT (Json Web Token)
JSON Web Token - otwarty standard przemysłowy, definuje sposób wymiany danych. Składa się z nagłówka, ładunek (payload) oraz sygnatury.

### Jak działa:
Klientem w naszym przykładzie może być strona internetowa, przeglądarka, aplikacja mobilna, linia poleceń w Windows. Logowanie odbywa się tradycyjnie loginem i hasłem lub za pośrednictwem kluczy asymetrycznych (prywatne, publiczne). System zwraca nam JWT (token). Przy każdym kolejnym requeście czy logowaniu, nie musimy się ponownie logować, a możemy użyć zwróconego JWT przez określony czas przez, który token jest ważny. Token jest wygenerowany tylko dla poświadczeń których użyliśmy.

