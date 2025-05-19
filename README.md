Autor: .Adamczyli <3
Prefix: infinityrage

📖 Opis
Infinity Rage096 to prosty plugin do SCP: Secret Laboratory wykorzystujący framework EXILED, który modyfikuje zachowanie SCP-096.

Plugin sprawia, że SCP-096 nie przestaje być w stanie Rage, dopóki posiada aktywne targety, które go widziały.

⚙️ Funkcjonalność
Gdy gracz spojrzy na twarz SCP-096:

Otrzymuje powiadomienie w formie hinta: "Spojrzałeś na twarz SCP-096!"

SCP-096 dostaje informację o liczbie aktualnych celów:
"Dodano X Targetów"

Podczas próby wyjścia z trybu Rage:

Jeśli SCP-096 ma nadal aktywne cele – Rage zostaje przedłużony, a gracz kontrolujący SCP-096 otrzymuje informację:
"Rage trwa dalej, ponieważ pozostało X targetów."

Jeśli SCP-096 nie ma już celów – Rage zostaje zakończony, a gracz otrzymuje komunikat:
"Rage zakończony, ponieważ nie ma już targetów."

🧩 Wymagania
EXILED w wersji 9.5.2 lub wyższej (plugin korzysta z nowych handlerów dla SCP-096)

Działa na serwerach SCP:SL z zainstalowanym EXILED

📦 Instalacja
Skopiuj plik .dll do folderu Plugins na Twoim serwerze SCP:SL.

Zrestartuj serwer.

📁 Struktura projektu
// Główne eventy:
Scp096.AddingTarget      // Dodanie nowego celu do SCP-096
Scp096.CalmingDown       // Próba zakończenia Rage

// Główne funkcje:
OnAddingTarget()         // Obsługuje dodanie targetu
OnRagingEnded()          // Kontroluje czy Rage ma się zakończyć

🛠️ Konfiguracja
Plugin aktualnie nie posiada dodatkowej konfiguracji.

✅ Przyszłe plany
Dodanie opcji konfiguracyjnej, np. maksymalnego czasu Rage

Lepsze wsparcie dla lokalizacji i wielu języków

Obsługa logów / statystyk
