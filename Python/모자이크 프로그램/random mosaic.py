from tkinter import *
from random import *
tk=Tk()
tk.title("no title")
tk.resizable(0,0)

wi=600
he=600
cc=Canvas(tk,width=wi,height=he)
cc.pack()
color1='white'


for i in range(0,wi//10):
    a=0 # first y cordinate of mosaic piece
    b=0 # second y cordinate of mosaic piece
    for j in range(0,he//5):
        k=randrange(7)
        gap=randrange(8,30)
        a=b
        b=b+gap # update b

        if (k+1)%7==0:
            color= 'yellow'
            cc.create_rectangle(i*10,a,i*10+10,b,fill=color,outline=color1)

        elif (k+1)%7==1:
            color = 'gold'
            cc.create_rectangle(i * 10, a, i * 10 + 10, b, fill=color,outline=color1)

        elif (k + 1) % 7 == 2:
            color = 'orange'
            cc.create_rectangle(i * 10, a, i * 10 + 10, b, fill=color,outline=color1)
        elif (k + 1) % 7 == 3:
            color = 'cyan'
            cc.create_rectangle(i * 10, a, i * 10 + 10, b , fill=color,outline=color1)
        elif (k + 1) % 7 == 4:
            color = 'magenta'
            cc.create_rectangle(i * 10, a, i * 10 + 10,b, fill=color,outline=color1)
        elif (k + 1) % 7 == 5:
            color = 'pink'
            cc.create_rectangle(i * 10, a, i * 10 + 10, b, fill=color,outline=color1)
        else:
            color = 'violet'
            cc.create_rectangle(i * 10, a, i * 10 + 10, b, fill=color,outline=color1)
    #tk.update()


tk.mainloop()