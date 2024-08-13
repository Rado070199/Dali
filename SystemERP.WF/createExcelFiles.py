import pandas as pd

# Definicja danych
num_job = 20
p = [10, 10, 13, 4, 9, 4, 8, 15, 7, 1, 9, 3, 15, 9, 11, 6, 5, 14, 18, 3]
d = [50, 38, 49, 12, 20, 105, 73, 45, 6, 64, 15, 6, 92, 43, 78, 21, 15, 50, 150, 99]
w = [10, 5, 1, 5, 10, 1, 5, 10, 5, 1, 5, 10, 10, 5, 1, 10, 5, 5, 1, 5]

# Tworzenie DataFrame
data = {
    'Zadanie': list(range(1, num_job + 1)),
    'Czas trwania': p,
    'Termin': d,
    'Waga': w
}

df = pd.DataFrame(data)

# Zapis do pliku Excel
excel_filename = 'algorithmForOnePosition.xlsx'
df.to_excel(excel_filename, index=False)

print(f'Plik Excel zapisany jako {excel_filename}')
