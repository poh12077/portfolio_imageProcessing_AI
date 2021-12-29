
# making mosaic program

from tkinter import *
from tkinter.colorchooser import * #this line enable to use askcolor()
from functools import *

color='white'

size=7

def paint_oval(e):
    x1,y1=( e.x-size),(e.y-size)
    x2, y2=(e.x+size),(e.y+size)
    canvas.create_oval(x1,y1,x2,y2,fill=color, outline=color)

def paint_rectangle(e):
    x1,y1=(e.x-size),(e.y-size)
    x2,y2=(e.x+size),(e.y+size)
    canvas.create_rectangle(x1,y1,x2,y2,fill=color)



shape = paint_oval

def change_shape():
    global shape
    shape = paint_oval

def change_black():
    global color
    color = 'black'

def change_white():
    global color
    color = 'white'

def change_red():
    global color
    color = 'red'

def change_yellow():
    global color
    color = 'yellow'

def change_blue():
    global color
    color = 'blue'

def change_green():
    global color
    color='green'

def edit_color():
    global color
    #c=askcolor()
    #color=c[1]
    color= askcolor()[1]


tk=Tk()
menubar=Menu(tk)
cell=Menu(menubar)#,tearoff=0)
cell.add_command(label="black",command=change_black)
cell.add_command(label="whitbe",command=change_white)
cell.add_command(label="red",command=change_red)
cell.add_command(label="green",command=change_green)
cell.add_command(label="blue",command=change_blue)
cell.add_command(label="yellow",command=change_yellow)
cell.add_separator()
cell.add_command(label="edit color",command=edit_color)
menubar.add_cascade(label="color",menu=cell)

cell1=Menu(menubar)
cell1.add_command(label=" ",command=change_yellow)
menubar.add_cascade(label="NULL",menu=cell1)

tk.config(menu=menubar)

num1=StringVar()
e1=Entry(tk, textvariable=num1)
e1.grid(row=0, column=0 )#columnspan=1)
#button_oval=Button(tk,text="oval", command=change_yellow)
#button_oval.pack()

def ff(a):
    b=a.get()
    c=int(b)
    global size
    size=c


ff1=partial(ff, num1)
b1 = Button(tk, text="confirm", command=ff1).grid(row=0, column=1)

canvas=Canvas(tk,width=400,height=400)
tk.resizable(0,0)
canvas.grid()
canvas.bind("<Button-1>", paint_rectangle)
canvas.bind("<B3-Motion>", paint_oval)
#my_image=PhotoImage(file='D:\\picture1\\starry night.gif')  # you can put some image in the canvas background
#canvas.create_image(0,0,anchor=NW,image=my_image)
tk.mainloop()