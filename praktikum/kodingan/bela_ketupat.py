# nama : Muhammad Faqih Wirahadi Wijaya Kusuma
# nim : 201511039
# mata kuliah : pemrograman visual
# kelas: R4/TI 20 D
# tugas : praktikum

from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W


class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("390x290")
        self.parent.title(title)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10 )
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label

        Label(mainFrame, text='masukan panjang diagonal 1:',border=0, width=30, font=30).grid(row=1, column=0, sticky=W, padx=20, pady=5)
        Label(mainFrame, text="masukan panjang diagonal 2:", border=0, width=30, font=30).grid(row=3, column=0, sticky=W, padx=20, pady=5)
        Label(mainFrame, text="Luas bela ketupat adalah:", border=0, width=30, font=30).grid(row=6, column=0, sticky=W, padx=20, pady=5)


        # pasang textbox
        self.txtdiagonal1 = Entry(mainFrame, border=0, width=30, font=30)
        self.txtdiagonal1.grid(row=2, column=0, padx=20, pady=5) 
        self.txtdiagonal2 = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtdiagonal2.grid(row=4, column=0, padx=20, pady=5) 
        self.txtLuas = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtLuas.grid(row=37, column=0, padx=20, pady=5)  
        
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung,  border=0, width=15, font=20, background="#CCD5AE" )
        self.btnHitung.grid(row=5, column=0, padx=20, pady=5)
    
    # fungsi untuk menghitung luas bela ketupat
    def onHitung(self):
        # perhitungan dengan metode Pemrograman  Terstruktur 
        diagonal1 = int(self.txtdiagonal1.get())
        diagonal2 = int(self.txtdiagonal2.get())

        luas = self.LuasDiagonal(diagonal1, diagonal2)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        
    
    def LuasDiagonal(self, diagonal1, diagonal2):
        luas = 0.5 * diagonal1 * diagonal2
        return luas
        
    
if __name__ == '__main__':  
    root = Tk() 
    aplikasi = FrmPersegi(root, "Program Luas Bela ketupat")
    root.mainloop()
    