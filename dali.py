import tkinter as tk
from tkinter import colorchooser, filedialog, messagebox
from PIL import Image, ImageDraw

class DaliApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Aplikacja do Rysowania")

        # Utworzenie płótna
        self.canvas = tk.Canvas(self.root, bg='white', width=600, height=400)
        self.canvas.pack(pady=20)

        # Utworzenie obrazu do zapisywania
        self.image = Image.new("RGB", (600, 400), "white")
        self.draw = ImageDraw.Draw(self.image)

        # Przycisk do wyboru koloru
        self.color_button = tk.Button(self.root, text="Wybierz kolor", command=self.choose_color)
        self.color_button.pack(side=tk.LEFT, padx=10)

        # Etykieta i suwak do rozmiaru pędzla
        self.brush_size_label = tk.Label(self.root, text="Rozmiar pędzla:")
        self.brush_size_label.pack(side=tk.LEFT, padx=5)

        self.brush_size = tk.IntVar(value=5)
        self.brush_size_scale = tk.Scale(self.root, from_=1, to=20, variable=self.brush_size, orient=tk.HORIZONTAL)
        self.brush_size_scale.pack(side=tk.LEFT)

        # Przycisk do zapisu obrazu
        save_button = tk.Button(self.root, text="Zapisz obraz", command=self.save_image)
        save_button.pack(side=tk.LEFT, padx=10)

        # Przycisk do gumki
        eraser_button = tk.Button(self.root, text="Gumka", command=self.use_eraser)
        eraser_button.pack(side=tk.LEFT, padx=10)

        # Przycisk do czyszczenia
        clear_button = tk.Button(self.root, text="Wyczyść", command=self.clear_canvas)
        clear_button.pack(side=tk.LEFT, padx=10)

        # Bindowanie zdarzeń do rysowania
        self.canvas.bind("<B1-Motion>", self.paint)  # Rysowanie podczas przytrzymywania lewego przycisku myszy
        self.canvas.bind("<ButtonRelease-1>", self.reset)  # Resetowanie pędzla po zwolnieniu przycisku

        self.current_color = "black"  # Domyślny kolor pędzla
        self.is_eraser = False  # Flaga, która wskazuje, czy jest używana gumka

    def choose_color(self):
        # Wybieranie koloru
        color = colorchooser.askcolor()[1]
        if color:
            self.current_color = color
            self.is_eraser = False  # Ustawienie gumki na false, jeśli wybierany jest nowy kolor

    def use_eraser(self):
        # Ustawienie gumki
        self.is_eraser = True
        self.current_color = "white"  # Ustawienie koloru gumki na biały

    def paint(self, event):
        # Rysowanie na płótnie
        x1 = event.x - self.brush_size.get()
        y1 = event.y - self.brush_size.get()
        x2 = event.x + self.brush_size.get()
        y2 = event.y + self.brush_size.get()

        # Rysowanie na Canvas
        self.canvas.create_oval(x1, y1, x2, y2, fill=self.current_color, outline=self.current_color)

        # Rysowanie na obrazie
        self.draw.ellipse([x1, y1, x2, y2], fill=self.current_color, outline=self.current_color)

    def reset(self, event):
        # Resetowanie pędzla (nie jest konieczne, ale można to wykorzystać)
        pass

    def clear_canvas(self):
        # Czyszczenie płótna
        self.canvas.delete("all")
        self.image = Image.new("RGB", (600, 400), "white")  # Resetowanie obrazu
        self.draw = ImageDraw.Draw(self.image)  # Nowe rysowanie na czystym obrazie

    def save_image(self):
        # Zapis obrazu do pliku
        file_path = filedialog.asksaveasfilename(defaultextension=".png",
                                                   filetypes=[("PNG files", "*.png"), ("JPEG files", "*.jpg"), ("All files", "*.*")])
        if file_path:
            self.image.save(file_path)
            messagebox.showinfo("Zapisano", f"Obraz został zapisany jako {file_path}")

# Uruchomienie aplikacji
if __name__ == "__main__":
    root = tk.Tk()
    app = DaliApp(root)
    root.mainloop()
