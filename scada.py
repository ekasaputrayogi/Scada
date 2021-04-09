import serial
import sys
import socket
import paho.mqtt.client as mqttclient
import time
import threading

Connected = False
broker_adress = "151.106.113.229"
port1= 1883
user = "greekindo"
password = "@greekindo123"
li = []
ReceiveData = ""


host = '172.26.0.1'  # Standard loopback interface address (localhost)
port = 65432   
datarecv_pi = ""
data = datarecv_pi
s = ""
conn = ""
data_command = ""




def setupServer():  # ------ OPENING SERVER PORT
    global s
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    print("Socket Berhasil dibuat")
    try:
        s.bind((host, port))
    except socket.error as msg:
        print(msg)
    print("Socket bind complete")
    return s

def setupConnection():  # ------ CLIENT LISTENER
    s.listen(1)  # Allow one connection at a time
    conn, address = s.accept()
    print("Connected to:" + address[0] + ":" + str(address[1]))
    return conn

"""def dataTransfer(conn):  # ----- RECEIVE DATA
    # A big loop that send/receives data untill told not to
    global datarecv_pi, li
    #reply = ""
    while True:
        # Receive the data
        #print("oiii")
        pass
        #data = conn.recv(65536)  # receive the data
        #data = data.decode("utf-8")"""
        
                
def send(conn, text):  # ----- SEND DATA TO CLIENT
    conn.sendall(str.encode(text))

def BackgroundComm():  # ---- START CONNECTION
    global conn
    while True:
        try:
            conn = setupConnection()
            dataTransfer(conn)
            
        except:
            print("Connection Lost")

def on_connect(client, usedata,flags,rc):
    if rc==0:
        print("Client is connected")
        global Connected
        Connected = True
        client.subscribe("TEST")
    else:
        print("Connection Failed")
def on_message(client, userdata, msg):
    global ReceiveData
    print(str(msg.payload))
    ReceiveData = msg.payload
    ser.write(ReceiveData)


client = mqttclient.Client()
client.username_pw_set(user,password=password)
client.on_message = on_message
client.on_connect=on_connect
client.connect(broker_adress,port=port1)
client.loop_start()
time.sleep(1)



def Serial():
    global ReceiveData, li
    print("SERIAL IN")
    while True:
        if(ser.in_waiting > 0):
            linedat = ser.readline()
            data = linedat.decode(encoding='UTF-8',errors='ignore')
            try:
                Convert(data)
                client.publish("IOTBOX",data)
                sensor = float(li[2]) * (100/4095)
                print(li)
                send(conn, str(li))
                #print ("Data Setelah ADC = ",li[2],"   Data Setelah Akuisisi = %.2f" % sensor)
                #time.sleep(1)
            except:
                pass



def Convert(string):
    global li
    li = list(string.split(","))
    #print(li[1])
    return li 

try:
    ser = serial.Serial(port='COM1', baudrate=115200,
                    parity=serial.PARITY_NONE,
                    stopbits=serial.STOPBITS_ONE,
                    bytesize=serial.EIGHTBITS,
                    timeout=0.5)
except:
    try:
        ser = serial.Serial(port='COM2', baudrate=115200,
        parity=serial.PARITY_NONE,
        stopbits=serial.STOPBITS_ONE,
        bytesize=serial.EIGHTBITS,
        timeout=0.5)
    except:
        try:
            ser = serial.Serial(port='COM3', baudrate=115200,
            parity=serial.PARITY_NONE,
            stopbits=serial.STOPBITS_ONE,
            bytesize=serial.EIGHTBITS,
            timeout=0.5)
        except:
            try:
                ser = serial.Serial(port='COM4', baudrate=115200,
                parity=serial.PARITY_NONE,
                stopbits=serial.STOPBITS_ONE,
                bytesize=serial.EIGHTBITS,
                timeout=0.5)
            except:
                    ser = serial.Serial(port='COM5', baudrate=115200,
                    parity=serial.PARITY_NONE,
                    stopbits=serial.STOPBITS_ONE,
                    bytesize=serial.EIGHTBITS,
                    timeout=0.5)
def running():
    p1 = threading.Thread(target=BackgroundComm)
    p3 = threading.Thread(target=Serial)
    try:
        p1.start()
        p3.start()
        p1.join()
        p3.join()
    except Exception as e:
        print("Thread error!!!! :" + str(e))

#homing()
s = setupServer()
running()