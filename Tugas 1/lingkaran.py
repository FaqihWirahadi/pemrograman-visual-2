from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W


class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent 
        self.parent.geometry("500x180")
        self.parent.title(title)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label

        Label(mainFrame, text='Lingkaran:',border=0, width=10, font=30).grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:", border=0, width=10, font=30).grid(row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="keliling :", border=0, width=10, font=30).grid(row=4, column=0, sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtlingkaran = Entry(mainFrame, border=0, width=30, font=30)
        self.txtlingkaran.grid(row=0, column=1, padx=20, pady=5) 
        self.txtLuas = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtLuas.grid(row=3, column=1, padx=20, pady=5) 
        self.txtkeliling = Entry(mainFrame, border=0, width=30, font=30) 
        self.txtkeliling.grid(row=4, column=1, padx=20, pady=5) 
        
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung,  border=0, width=15, font=20, background="#CCD5AE")
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)
    
    # fungsi untuk menghitung luas dan keliling lingkaran 
    def onHitung(self):
        # perhitungan dengan metode Pemrograman  Terstruktur 
        r = int(self.txtlingkaran.get())

        lingkaran = jari_jari_lingkaran(r)
        luas = lingkaran.luas()
        keliling = lingkaran.keliling()

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        
        self.txtkeliling.delete(0, END)
        self.txtkeliling.insert(END, str(keliling))

class jari_jari_lingkaran:
    def __init__(self, r):
        self.r = r

    def luas(self):
        return 3.14 * self.r * self.r
    
    def keliling(self):
        return 2 * 3.14 * self.r
        
    
if __name__ == '__main__':  
    root = Tk() 
    aplikasi = FrmPersegi(root, "Program Luas dan keliling lingkaran")
    root.mainloop()